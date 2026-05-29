import { useEffect, useState } from "react";
import "./Modals.css";
import type { CatDTO } from "../types/cat";

type Props = {
    open: boolean;
    onClose: () => void;
    onLoad?: (cat: CatDTO) => void; // optional but useful
};

export default function LoadModal({ open, onClose }: Props) {
    const [cats, setCats] = useState<CatDTO[]>([]);
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState<string | null>(null);
    const [selected, setSelected] = useState<CatDTO | null>(null);

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

        fetch("/api/cats")
            .then(res => {
                if (!res.ok) throw new Error();
                return res.json();
            })
            .then(setCats)
            .catch(() => setError("Failed to load catalogues"))
            .finally(() => setLoading(false));

    }, [open]);

    if (!open) return null;

    return (
        <div className="overlay" onClick={onClose}>
            <div className="modal" onClick={e => e.stopPropagation()}>
                <h2 className="title">Load Catalogue</h2>
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