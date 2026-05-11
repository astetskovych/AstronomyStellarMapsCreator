import { useEffect } from "react";
import "./Modals.css";

type Props = {
    open: boolean;
    onClose: () => void;
};

export default function LoadModal({ open, onClose }: Props) {
    useEffect(() => {
        if (!open) return;

        const handleKey = (e: KeyboardEvent) => {
            if (e.key === "Escape") onClose();
        };

        window.addEventListener("keydown", handleKey);
        return () => window.removeEventListener("keydown", handleKey);
    }, [open, onClose]);

    if (!open) return null;

    const catalogues = Array.from({ length: 30 }, (_, i) =>
        `Catalogue ${i + 1} — Deep Sky Objects`
    );

    return (
        <div className="overlay" onClick={onClose}>
            <div className="modal" onClick={e => e.stopPropagation()}>
                <h3 className="title">Load Catalogue</h3>

                <div className="scrollArea">
                    {catalogues.map((item, index) => (
                        <div key={index} className="item">
                            {item}
                        </div>
                    ))}
                </div>

                <div className="hint">ESC to close</div>
            </div>
        </div>
    );
}