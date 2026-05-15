import { useEffect } from "react";

type Props = {
    open: boolean;
    onCancel: () => void;
    onConfirm: () => void;
};

export default function ExitModal({ open, onCancel, onConfirm }: Props) {
    useEffect(() => {
        if (!open) return;

        const handleKey = (e: KeyboardEvent) => {
            if (e.key === "Escape") onCancel();
        };

        window.addEventListener("keydown", handleKey);
        return () => window.removeEventListener("keydown", handleKey);
    }, [open, onCancel]);

    if (!open) return null;

    return (
        <div className="overlay" onClick={onCancel}>
            <div className="modal" onClick={e => e.stopPropagation()}>
                <h3 className="title">Exit Application</h3>

                <div className="text">
                    Are you sure you want to exit?
                </div>

                <div style={{ display: "flex", gap: "10px", justifyContent: "center" }}>
                    <button
                        className="applyButton"
                        onClick={onConfirm}
                    >
                        OK
                    </button>

                    <button
                        className="applyButton"
                        onClick={onCancel}
                    >
                        Cancel
                    </button>
                </div>

                <div className="hint">ESC = Cancel</div>
            </div>
        </div>
    );
}