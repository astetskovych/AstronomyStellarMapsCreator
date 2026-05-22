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

export default function App() {
    const [gridType, setGridType] = useState<string>("Equatorial");
    const [gridModalOpen, setGridModalOpen] = useState(false);
    const [aboutOpen, setAboutOpen] = useState(false);
    const [constModalOpen, setConstModalOpen] = useState(false);
    const [constellations, setConstellations] = useState({
        borders: true,
        names: true,
        figures: false
    });
    const [loadOpen, setLoadOpen] = useState(false);
    const [exitModalOpen, setExitModalOpen] = useState(false);
    const [helpOpen, setHelpOpen] = useState(false);
    const [saveOpen, setSaveOpen] = useState(false);

    const handleExit = () => {
        window.location.href = "about:blank";
    };
    return <div style={{ width: "100%", aspectRatio: "2 / 1" }}>
                <TopMenu
                    onOpenGridModal={() => setGridModalOpen(true)}
                    onOpenAbout={() => setAboutOpen(true)}
                    onOpenConstellations={() => setConstModalOpen(true)}
                    onOpenLoad={() => setLoadOpen(true)}
                    onOpenExit={() => setExitModalOpen(true)}
            onOpenHelp={() => setHelpOpen(true)}
            onOpenSave={() => setSaveOpen(true)}
                />
                <ConstellationsModal
                    open={constModalOpen}
                    onClose={() => setConstModalOpen(false)}
                    onApply={setConstellations}
                />
                <AboutModal
                    open={aboutOpen}
                    onClose={() => setAboutOpen(false)}
                />
                <GridModal
                    open={gridModalOpen}
                    onClose={() => setGridModalOpen(false)}
                    onSelect={setGridType}
                />
                <LoadModal
                    open={loadOpen}
                    onClose={() => setLoadOpen(false)}
                />
                <ExitModal
                    open={exitModalOpen}
                    onCancel={() => setExitModalOpen(false)}
                    onConfirm={handleExit}
                />
                <HelpModal
                    open={helpOpen}
                    onClose={() => setHelpOpen(false)}
                />
                <SaveModal
                    isOpen={saveOpen}
                    onClose={() => setSaveOpen(false)}
                    onCreate={(data) => {
                        console.log("EXPORT CONFIG:", data);
                    }}/>
                <SkyCanvas
                    gridType={gridType}
                    constellations={constellations}
                    setHelpOpen={setHelpOpen}
                />
           </div>;
}