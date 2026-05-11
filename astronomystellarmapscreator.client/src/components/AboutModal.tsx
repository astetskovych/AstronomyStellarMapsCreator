import React, { useEffect } from "react";


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

    // 👇 THEN THIS
    if (!open) return null;

    return (
        <div style={styles.overlay} onClick={onClose}>
            <div style={styles.modal} onClick={e => e.stopPropagation()}>
                <h3 style={styles.title}>About</h3>

                <div style={styles.text}>
                    ©2026 Andrii Stetskovych
                    <br />
                    Sky Viewer Project
                    <br />
                    Built with React + Canvas
                </div>

                <div style={styles.hint}>
                    Click anywhere or press ESC to close
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
        zIndex: 100,
    },

    modal: {
        background: "black",
        border: "1px solid #00ff00",
        padding: "20px",
        minWidth: "260px",
        fontFamily: "monospace",
        color: "#00ff00",
        textAlign: "center",
    },

    title: {
        marginBottom: "10px",
    },

    text: {
        lineHeight: "1.6",
        marginBottom: "10px",
    },

    hint: {
        fontSize: "12px",
        color: "#00aa00",
    },
};