import { useEffect } from "react";
import "./Modals.css";

export default function LanguageModal({ isOpen, onClose, onSelect, currentLanguage }) {
    useEffect(() => {
        const handleKey = (e) => {
            if (e.key === "Escape") onClose();
        };

        if (isOpen) {
            window.addEventListener("keydown", handleKey);
        }

        return () => {
            window.removeEventListener("keydown", handleKey);
        };
    }, [isOpen, onClose]);

    if (!isOpen) return null;

    return (
        <div
            className="overlay"
            onClick={(e) => {
                if (e.target === e.currentTarget) onClose();
            }}
        >
            <div
                className="modal"
                onClick={(e) => e.stopPropagation()}
            >
                <h2 className="title">Language</h2>

                <div className="languageList">
                    <button onClick={() => onSelect("uk")}>
                        Українська
                    </button>
                    <button onClick={() => onSelect("en")}>
                        English
                    </button>
                    <button onClick={() => onSelect("ar")}>
                        العربية
                    </button>
                </div>
                <div className="hint">
                    Press ESC or click outside to close
                </div>
            </div>
        </div>
    );
}