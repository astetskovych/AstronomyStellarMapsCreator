import { useState } from "react";
import "./TopMenu.css";

type Props = {
    onOpenGridModal: () => void;
    onOpenAbout: () => void;
    onOpenConstellations: () => void;
    onOpenLoad: () => void;
    onOpenExit: () => void;
    onOpenHelp: () => void;
    onOpenSave: () => void;
};

export default function TopMenu({ onOpenGridModal,
                                  onOpenAbout,
                                  onOpenConstellations,
                                  onOpenLoad,
                                  onOpenSave,
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
        <div className = "wrapper">
            <div className= "bar">
                {menus.map(menu => (
                    <div
                        key={menu.label}
                        className= "menu"
                        onMouseEnter={() => setOpenMenu(menu.label)}
                        onMouseLeave={() => setOpenMenu(null)}>
                        <button className= "button">
                            {menu.label}
                        </button>
                        {openMenu === menu.label && (
                            <div className= "dropdown">
                                {menu.items.map(item => (
                                    <div
                                        key={item}
                                        className= "item"
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
                                            if (item === "Save") {
                                                onOpenSave();
                                            }
                                            if (item === "Exit") {
                                                onOpenExit();
                                            }
                                            if (item === "Help") {
                                                onOpenHelp();
                                            }
                                            console.log(menu.label, item);
                                            setOpenMenu(null);
                                        }}>
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