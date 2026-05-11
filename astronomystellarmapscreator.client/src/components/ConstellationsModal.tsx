import { useEffect, useState } from "react";
import "./Modals.css";

type Props = {
    open: boolean;
    onClose: () => void;
    onApply: (settings: {
        borders: boolean;
        names: boolean;
        figures: boolean;
    }) => void;
};

export default function ConstellationsModal({ open, onClose, onApply }: Props) {
    const [borders, setBorders] = useState(true);
    const [names, setNames] = useState(true);
    const [figures, setFigures] = useState(false);

    useEffect(() => {
        if (!open) return;

        const handleKey = (e: KeyboardEvent) => {
            if (e.key === "Escape") onClose();
        };

        window.addEventListener("keydown", handleKey);
        return () => window.removeEventListener("keydown", handleKey);
    }, [open, onClose]);

    if (!open) return null;

    return (
        <div className="overlay" onClick={onClose}>
            <div className="modal" onClick={e => e.stopPropagation()}>
                <h3 className="title">Constellations</h3>

                <div className="text">
                    <label className="checkbox">
                        <input
                            type="checkbox"
                            checked={borders}
                            onChange={e => setBorders(e.target.checked)}
                        />
                        Constellation borders
                    </label>

                    <label className="checkbox">
                        <input
                            type="checkbox"
                            checked={names}
                            onChange={e => setNames(e.target.checked)}
                        />
                        Constellation names
                    </label>

                    <label className="checkbox">
                        <input
                            type="checkbox"
                            checked={figures}
                            onChange={e => setFigures(e.target.checked)}
                        />
                        Constellation figures
                    </label>
                </div>

                <button
                    className="applyButton"
                    onClick={() => {
                        onApply({ borders, names, figures });
                        onClose();
                    }}
                >
                    Apply
                </button>

                <div className="hint">
                    ESC to close
                </div>
            </div>
        </div>
    );
}