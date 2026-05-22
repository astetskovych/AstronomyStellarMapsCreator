import { useEffect } from "react";
import "./Modals.css"; 

type Props = {
    open: boolean;
    onClose: () => void;
};

export default function AboutModal({ open, onClose }: Props) {
    useEffect(() => {
        if (!open) return;

        const handleKey = (e: KeyboardEvent) => {
            if (e.key === "Escape") {
                onClose();
            }
        };

        window.addEventListener("keydown", handleKey);
        return () => window.removeEventListener("keydown", handleKey);
    }, [open, onClose]);

    if (!open) return null;

    return (
        <div className = "overlay" onClick={onClose}>
            <div className = "modal" onClick={e => e.stopPropagation()}>
                <h2 className = "title">About</h2>
                <div className = "description">
                    ©2026 Andrii Stetskovych
                    <br />
                    Astronomy Stellar Maps Creator
                    <br />
                    version 1.0
                </div>
                <div className = "hint">
                    Click anywhere or press ESC to close
                </div>
            </div>
        </div>
    );
}