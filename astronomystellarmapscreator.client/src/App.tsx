import React, { useState } from "react";
import TopMenu from "./components/TopMenu";
import SkyCanvas from "./components/SkyCanvas";
import GridModal from "./components/GridModal";
import AboutModal from "./components/AboutModal";
import ConstellationsModal from "./components/ConstellationsModal";
import LoadModal from "./components/LoadModal";

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
    return <div style={{ width: "100%", aspectRatio: "2 / 1" }}>
                <TopMenu
                    onOpenGridModal={() => setGridModalOpen(true)}
                    onOpenAbout={() => setAboutOpen(true)}
                    onOpenConstellations={() => setConstModalOpen(true)}
                    onOpenLoad={() => setLoadOpen(true)}
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
                <SkyCanvas
                    gridType={gridType}
                    constellations={constellations}
                />
           </div>;
}