import { useState } from "react";

type Props = {
    onOpenGridModal: () => void;
    onOpenAbout: () => void;
    onOpenConstellations: () => void;
    onOpenLoad: () => void;
    onOpenExit: () => void;
    onOpenHelp: () => void;
};

export default function TopMenu({ onOpenGridModal,
                                  onOpenAbout,
                                  onOpenConstellations,
                                  onOpenLoad,
                                  onOpenExit,
                                  onOpenHelp }: Props) {
    const [openMenu, setOpenMenu] = useState<string | null>(null);

    const menus = [
        {
            label: "File",
            items: ["Load", "Save", "Exit"],
        },
        {
            label: "View",
            items: ["Grids", "Constellations", "Settings"],
        },
        {
            label: "Help",
            items: ["Help", "About"],
        },
    ];

    return (
        <div style={styles.wrapper}>
            <div style={styles.bar}>
                {menus.map(menu => (
                    <div
                        key={menu.label}
                        style={styles.menu}
                        onMouseEnter={() => setOpenMenu(menu.label)}
                        onMouseLeave={() => setOpenMenu(null)}
                    >
                        <button style={styles.button}>
                            {menu.label}
                        </button>

                        {openMenu === menu.label && (
                            <div style={styles.dropdown}>
                                {menu.items.map(item => (
                                    <div
                                        key={item}
                                        style={styles.item}
                                        onClick={() => {
                                            if (item === "Grids") {
                                                onOpenGridModal();
                                            }
                                            if (item === "About") {
                                                onOpenAbout();
                                            }
                                            if (item === "Constellations") {
                                                onOpenConstellations();
                                            }
                                            if (item === "Load") {
                                                onOpenLoad();
                                            }
                                            if (item === "Exit") {
                                                onOpenExit();
                                            }
                                            if (item === "Help") {
                                                onOpenHelp();
                                            }
                                            console.log(menu.label, item);
                                            setOpenMenu(null);
                                        }}
                                    >
                                        {item}
                                    </div>
                                ))}
                            </div>
                        )}
                    </div>
                ))}
            </div>
        </div>
    );
}

const styles: Record<string, React.CSSProperties> = {
    wrapper: {
        position: "absolute",
        top: 0,
        left: 0,
        width: "100%",
        display: "flex",
        justifyContent: "center", // ⭐ center on X axis
        zIndex: 10,
        pointerEvents: "none", // allows canvas interaction except buttons
    },

    bar: {
        display: "flex",
        gap: "100px",
        padding: "10px 10px",
        background: "transparent",
        pointerEvents: "auto",
        fontFamily: "monospace",
    },

    menu: {
        position: "relative",
    },

    button: {
        background: "black",
        color: "#00ff00",
        border: "1px solid #00ff00",
        padding: "6px 12px",
        cursor: "crosshair",
        fontFamily: "monospace",
    },

    dropdown: {
        position: "absolute",
        top: "100%",
        left: 0,
        background: "black",
        border: "1px solid #00ff00",
        minWidth: "160px",
    },

    item: {
        padding: "6px 10px",
        color: "#00ff00",
        cursor: "pointer",
        fontFamily: "monospace",
        whiteSpace: "nowrap",
    },
};