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
    onOpenLanguage: () => void;
};

export default function TopMenu({ onOpenGridModal,
                                  onOpenAbout,
                                  onOpenConstellations,
                                  onOpenLoad,
                                  onOpenSave,
                                  onOpenExit,
                                  onOpenHelp,
                                  onOpenLanguage }: Props) {
    const [openMenu, setOpenMenu] = useState<string | null>(null);
    const menus = [
        {
            label: "FILE",
            items: ["Load", "Save", "Exit"],
        },
        {
            label: "VIEW",
            items: ["Grids", "Constellations", "Settings", "Language"],
        },
        {
            label: "HELP",
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
                                        className="item"
                                        onClick={() => {
                                            setOpenMenu(null);
                                            switch (item) {
                                                case "Load":
                                                    onOpenLoad();
                                                    break;
                                                case "Save":
                                                    onOpenSave();
                                                    break;
                                                case "Exit":
                                                    onOpenExit();
                                                    break;
                                                case "Grids":
                                                    onOpenGridModal();
                                                    break;
                                                case "Constellations":
                                                    onOpenConstellations();
                                                    break;
                                                case "Language":
                                                    onOpenLanguage();
                                                    break;
                                                case "Help":
                                                    onOpenHelp();
                                                    break;
                                                case "About":
                                                    onOpenAbout();
                                                    break;
                                            }
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