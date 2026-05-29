import React, { useState } from "react";
import TopMenu from "./components/TopMenu";
import SkyCanvas from "./components/SkyCanvas";
import GridModal from "./components/GridModal";
import AboutModal from "./components/AboutModal";
import ConstellationsModal from "./components/ConstellationsModal";
import LoadModal from "./components/LoadModal";
import ExitModal from "./components/ExitModal";
import HelpModal from "./components/HelpModal";
import SaveModal from "./components/SaveModal";
import LanguageModal from "./components/LanguageModal"; 

export type LanguageCode = "en" | "ua" | "ar"; // extend anytime

const DEFAULT_LANGUAGE: LanguageCode = "en";

const getInitialLanguage = (): LanguageCode => {
    const saved = localStorage.getItem("lang");
    if (saved === "en" || saved === "ua" || saved === "ar") {
        return saved;
    }
    return DEFAULT_LANGUAGE;
};

export default function App() {
    const [gridType, setGridType] = useState<string>("Equatorial");
    const [modals, setModals] = useState({
        grid: false,
        about: false,
        constellations: false,
        load: false,
        exit: false,
        help: false,
        save: false,
        language: false,
    });
    //const [gridModalOpen, setGridModalOpen] = useState(false);
    //const [aboutOpen, setAboutOpen] = useState(false);
    //const [constModalOpen, setConstModalOpen] = useState(false);
    const [constellations, setConstellations] = useState({
        borders: true,
        names: true,
        figures: false
    });
    //const [loadOpen, setLoadOpen] = useState(false);
    //const [exitModalOpen, setExitModalOpen] = useState(false);
    //const [helpOpen, setHelpOpen] = useState(false);
    //const [saveOpen, setSaveOpen] = useState(false);
    //const [langOpen, setLanguageOpen] = useState(false);
    const [language, setLanguage] = useState<LanguageCode>(getInitialLanguage);

    /* =========================
       🔧 Helpers
    ========================= */

    const openModal = (key: keyof typeof modals) =>
        setModals((prev) => ({ ...prev, [key]: true }));

    const closeModal = (key: keyof typeof modals) =>
        setModals((prev) => ({ ...prev, [key]: false }));

    const handleExit = () => {
        window.location.href = "about:blank";
    };

    return (
        <div style={{ width: "100%", aspectRatio: "2 / 1" }}>
            <TopMenu
                onOpenGridModal={() => openModal("grid")}
                onOpenAbout={() => openModal("about")}
                onOpenConstellations={() => openModal("constellations")}
                onOpenLoad={() => openModal("load")}
                onOpenExit={() => openModal("exit")}
                onOpenHelp={() => openModal("help")}
                onOpenSave={() => openModal("save")}
                onOpenLanguage={() => openModal("language")}
            />

            <ConstellationsModal
                open={modals.constellations}
                onClose={() => closeModal("constellations")}
                onApply={setConstellations}
            />

            <AboutModal
                open={modals.about}
                onClose={() => closeModal("about")}
            />

            <GridModal
                open={modals.grid}
                onClose={() => closeModal("grid")}
                onSelect={setGridType}
            />

            <LoadModal
                open={modals.load}
                onClose={() => closeModal("load")}
            />

            <ExitModal
                open={modals.exit}
                onCancel={() => closeModal("exit")}
                onConfirm={handleExit}
            />

            <HelpModal
                open={modals.help}
                onClose={() => closeModal("help")}
            />

            <SaveModal
                isOpen={modals.save}
                onClose={() => closeModal("save")}
                onCreate={(data) => {
                    console.log("EXPORT CONFIG:", data);
                }}
            />

            <LanguageModal
                isOpen={modals.language}
                currentLanguage={language}
                onClose={() => closeModal("language")}
                onSelect={(lang: LanguageCode) => {
                    setLanguage(lang);
                    closeModal("language");
                }}
            />

            <SkyCanvas
                gridType={gridType}
                constellations={constellations}
                setHelpOpen={() => openModal("help")}
            />
        </div>
    );
}