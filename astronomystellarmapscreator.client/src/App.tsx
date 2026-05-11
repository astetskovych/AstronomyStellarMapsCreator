import React, { useState } from "react";
import TopMenu from "./components/TopMenu";
import SkyCanvas from "./components/SkyCanvas";
import GridModal from "./components/GridModal";
import AboutModal from "./components/AboutModal";

export default function App() {
    const [gridType, setGridType] = useState<string>("Equatorial");
    const [gridModalOpen, setGridModalOpen] = useState(false);
    const [aboutOpen, setAboutOpen] = useState(false);
    return <div style={{ width: "100%", aspectRatio: "2 / 1" }}>
        <TopMenu
            onOpenGridModal={() => setGridModalOpen(true)}
            onOpenAbout={() => setAboutOpen(true)}
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
                <SkyCanvas gridType={gridType} />
           </div>;
}