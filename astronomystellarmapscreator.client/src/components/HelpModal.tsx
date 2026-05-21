import { useEffect } from "react";
import "./Modals.css";

type Props = {
    open: boolean;
    onClose: () => void;
};

export default function HelpModal({ open, onClose }: Props) {
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
                <h3 className="title">Help</h3>

                <table className="helpTable">
                    <tbody>
                        <tr>
                            <td className="key">+</td>
                            <td>Zoom in</td>
                        </tr>
                        <tr>
                            <td className="key">-</td>
                            <td>Zoom out</td>
                        </tr>
                        <tr>
                            <td className="key">↑ ↓</td>
                            <td>Navigate menus</td>
                        </tr>
                        <tr>
                            <td className="key">Enter</td>
                            <td>Select</td>
                        </tr>
                        <tr>
                            <td className="key">H</td>
                            <td>Open this modal</td>
                        </tr>
                        <tr>
                            <td className="key">ESC</td>
                            <td>Close modal</td>
                        </tr>
                    </tbody>
                </table>

                <div className="hint">
                    Click anywhere or press ESC to close
                </div>
            </div>
        </div>
    );
}