import { useState, useEffect } from "react";
import "./Modals.css";

export default function SaveModal({ isOpen, onClose, onCreate }) {
    const [mapsFormat, setMapsFormat] = useState("NONE");
    const [catalogueFormat, setCatalogueFormat] = useState("NONE");
    const [pages, setPages] = useState(1);
    const [color, setColor] = useState("black");

    const COLORS = {
        white: "#ffffff",
        black: "#000000",
        cream: "#f5f5dc",
        blue: "#0000ff",
    };

    useEffect(() => {
        const handleKey = (e) => {
            if (e.key === "Escape") onClose();
        };
        window.addEventListener("keydown", handleKey);
        return () => window.removeEventListener("keydown", handleKey);
    }, [isOpen, onClose]);

    if (!isOpen) return null;

    return (
        <div className="overlay" onClick={(e) => {
            if (e.target === e.currentTarget) {
                onClose();
            }
        }}>
            <div className="modal">
                <h2 className="title">Export Settings</h2>
                <div className="field">
                    <label>Maps format</label>
                    <select value={mapsFormat} onChange={(e) => setMapsFormat(e.target.value)}>
                        <option>NONE</option>
                        <option>png</option>
                        <option>jpeg</option>
                        <option>pdf</option>
                        <option>doc</option>
                    </select>
                </div>

                {/* Catalogue format */}
                <div className="field">
                    <label>Catalogue format</label>
                    <select value={catalogueFormat} onChange={(e) => setCatalogueFormat(e.target.value)}>
                        <option>NONE</option>
                        <option>excel</option>
                        <option>doc</option>
                        <option>csv</option>
                        <option>pdf</option>
                        <option>txt</option>
                        <option>dat</option>
                    </select>
                </div>

                {/* Pages */}
                <div className="field">
                    <label>Number of pages</label>
                    <input
                        type="number"
                        min="1"
                        value={pages}
                        onChange={(e) => setPages(Number(e.target.value))}
                    />
                </div>

                <div className="field">
                    <label>Colour schema</label>

                    <div className="colorPicker">
                        {Object.entries(COLORS).map(([name, value]) => (
                            <div
                                key={name}
                                className={`swatch ${color === value ? "active" : ""}`}
                                style={{ background: value }}
                                onClick={() => setColor(value)}
                                title={name}
                            />
                        ))}
                    </div>
                </div>

                {/* Buttons */}
                <div className="actions">
                    <button className="previewBtn">Preview</button>

                    <button
                        className="createBtn"
                        onClick={() =>
                            onCreate({ mapsFormat, catalogueFormat, pages, color })
                        }
                    >
                        Create
                    </button>
                </div>
                <div className="hint">
                    Press ESC or click outside to close
                </div>
            </div>
        </div>
    );
}