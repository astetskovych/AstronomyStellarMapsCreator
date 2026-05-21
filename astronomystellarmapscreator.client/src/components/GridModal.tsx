import { useEffect, useState } from "react";

const options = [
    "Equatorial",
    "Ecliptical",
    "Galactical",
    "Horizontal"
];

type Props = {
    open: boolean;
    onClose: () => void;
    onSelect: (value: string) => void;
};

export default function GridModal({ open, onClose, onSelect }: Props) {
    const [index, setIndex] = useState(0);

    useEffect(() => {
        if (!open) return;

        const handleKey = (e: KeyboardEvent) => {
            if (e.key === "ArrowDown") {
                setIndex(i => (i + 1) % options.length);
            }

            if (e.key === "ArrowUp") {
                setIndex(i => (i - 1 + options.length) % options.length);
            }

            if (e.key === "Enter") {
                onSelect(options[index]);
                onClose();
            }

            if (e.key === "Escape") {
                onClose();
            }
        };

        window.addEventListener("keydown", handleKey);
        return () => window.removeEventListener("keydown", handleKey);
    }, [open, index]);

    if (!open) return null;

    return (
        <div className = "overlay" onClick = { onClose } >
            <div className= "modal" onClick={e => e.stopPropagation()}>
                <h3 className= "title">Select Grid</h3>

                {options.map((opt, i) => (
                    <div
                        key={opt}
                        className={`item ${i === index ? "active" : ""}`}
                        onMouseEnter={() => setIndex(i)}
                        onClick={() => {
                            onSelect(opt);
                            onClose();
                        }}
                    >
                        {opt}
                    </div>
                ))}

                <div className= "hint">
                    ↑ ↓ Navigate • Enter Select • ESC Close
                </div>
            </div>
        </div>
    );
}