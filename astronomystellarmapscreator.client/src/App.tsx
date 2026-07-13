import { useState, useEffect } from "react";
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
import { loadStars } from "./utils/loadStars";
import type { Star } from "./types/Star";
import "./App.css";

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
    const [constellations, setConstellations] = useState({
        borders: true,
        names: true,
        figures: false
    });
    const [language, setLanguage] = useState<LanguageCode>(getInitialLanguage);
    const [stars, setStars] = useState<Star[]>([]);
    const [loading, setLoading] = useState(true);

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

    useEffect(() => {
        loadStars("/api/celestialObjects", setStars, setLoading);
    }, []);

    return (
        <div style={{ width: "100%", aspectRatio: "2 / 1" }}>
            {loading && (
                <div className="loading-overlay">
                    <h2 className="loading-text">LoAdInG mAp...</h2>
                </div>
            )}
            <div style={{ display: loading ? "none" : "block" }}>
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
            </div>
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
                stars={stars}
            />
        </div>
    );
}