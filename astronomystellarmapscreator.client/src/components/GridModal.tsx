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
        <div style={styles.overlay} onClick={onClose}>
            <div style={styles.modal} onClick={e => e.stopPropagation()}>
                <h3 style={styles.title}>Select Grid</h3>

                {options.map((opt, i) => (
                    <div
                        key={opt}
                        style={{
                            ...styles.item,
                            background: i === index ? "#003300" : "black"
                        }}
                        onMouseEnter={() => setIndex(i)}
                        onClick={() => {
                            onSelect(opt);
                            onClose();
                        }}
                    >
                        {opt}
                    </div>
                ))}

                <div style={styles.hint}>
                    ↑ ↓ Navigate • Enter Select • ESC Close
                </div>
            </div>
        </div>
    );
}

const styles: Record<string, React.CSSProperties> = {
    overlay: {
        position: "absolute",
        top: 0,
        left: 0,
        width: "100%",
        height: "100%",
        background: "rgba(0,0,0,0.7)",
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        zIndex: 100
    },
    modal: {
        background: "black",
        border: "1px solid #00ff00",
        padding: "20px",
        minWidth: "250px",
        fontFamily: "monospace"
    },
    title: {
        color: "#00ff00",
        marginBottom: "10px"
    },
    item: {
        padding: "8px",
        color: "#00ff00",
        cursor: "pointer"
    },
    hint: {
        marginTop: "10px",
        fontSize: "12px",
        color: "#00aa00"
    }
};