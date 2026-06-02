import { useEffect, useState } from "react";
import "./Modals.css";
import type { CatDTO } from "../types/cat";
import type { Category } from "../types/category";

type Props = {
    open: boolean;
    onClose: () => void;
    onLoad?: (cat: CatDTO) => void;
};

export default function LoadModal({ open, onClose }: Props) {
    const [cats, setCats] = useState<CatDTO[]>([]);
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState<string | null>(null);
    const [selected, setSelected] = useState<CatDTO | null>(null);
    const [categories, setCategories] = useState<Record<number, Category>>({});

    const [name, setName] = useState("");
    const [categoryId, setCategoryId] = useState("");
    const [key, setKey] = useState("");

    const isSearchEnabled = name || categoryId || key;

    useEffect(() => {
        if (!open) return;

        const handleKey = (e: KeyboardEvent) => {
            if (e.key === "Escape") onClose();
        };

        window.addEventListener("keydown", handleKey);
        return () => window.removeEventListener("keydown", handleKey);
    }, [open, onClose]);

    useEffect(() => {
        if (!open) return;

        const fetchData = async () => {
            setLoading(true);
            setError(null);

            try {
                const [catsRes, categoriesRes] = await Promise.all([
                    fetch("/api/cats"),
                    fetch("/api/categories")
                ]);

                const catsData = await catsRes.json();
                const categoriesData = await categoriesRes.json();

                setCats(catsData);
                setCategories(categoriesData);
            } catch (err) {
                setError("Failed to load catalogues " + err);
            } finally {
                setLoading(false);
            }
        };

        fetchData();
    }, [open]);

    const handleSearch = async () => {
        try {
            setLoading(true);

            const query = new URLSearchParams({
                name,
                categoryId,
                key
            });

            const res = await fetch(`api/cats/search?${query}`);
            const data = await res.json();

            setCats(data);
        } catch (err) {
            setError("Search failed " + err);
        } finally {
            setLoading(false);
        }
    };

    if (!open) return null;

    return (
        <div className="overlay" onClick={onClose}>
            <div className="modal" onClick={e => e.stopPropagation()}>
                <h2 className="title">Load Catalogue</h2>
                <div className="searchSection">
                    <div className="inpt">
                        <select
                            value={categoryId}
                            onChange={e => setCategoryId(e.target.value)}
                        >
                            <option value="">All Categories</option>
                            {Object.entries(categories).map(([id, cat]) => (
                                <option key={id} value={id}>
                                    {cat.name}
                                </option>
                            ))}
                        </select>
                    </div>
                    <div className="inpt">
                        <input
                            type="text"
                            placeholder="Catalogue name"
                            value={name}
                            onChange={e => setName(e.target.value)}
                        />
                    </div>
                    <div className="inpt">
                        <input
                            type="text"
                            placeholder="Key"
                            value={key}
                            onChange={e => setKey(e.target.value)}
                            />
                    </div>
                    <div className="inpt">
                        <button
                            disabled={!isSearchEnabled}
                            onClick={handleSearch}
                        >
                        Search
                        </button>
                    </div>
                </div>
                <div className="scrollArea">
                    {loading && <div className="item">Loading...</div>}
                    {error && <div className="item error">{error}</div>}
                    {!loading && !error && cats.map(cat => (
                        <div
                            key={cat.id}
                            className={`item ${selected?.id === cat.id ? "selected" : ""}`}
                            onClick={() => setSelected(cat)}
                        >
                            <div><strong>{cat.name}</strong></div>
                            <div>{cat.records ?? "—"} records</div>
                            <hr />
                        </div>
                    ))}
                </div>
                <div className="hint">ESC to close</div>
            </div>
        </div>
    );
}