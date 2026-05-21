import { useEffect, useRef, useState } from "react";
import type { Star } from "../types/Star";
import { project } from "../utils/projection";
import { screenToWorld } from "../utils/coordinates";
import { findNearestStar } from "../utils/findStar";

type NavState = {
    scale: number;
    offsetX: number;
    offsetY: number;
};

type Props = {
    gridType: string;
    constellations: {
        borders: boolean;
        names: boolean;
        figures: boolean;
    };
    setHelpOpen: (open: boolean) => void;
};

export default function SkyCanvas({ gridType, constellations, setHelpOpen }: Props) {
    const canvasRef = useRef<HTMLCanvasElement | null>(null);
    const navRef = useRef<NavState>({
        scale: 1,
        offsetX: 0,
        offsetY: 0,
    });
    const selectedStarRef = useRef<Star | null>(null);
    const renderRef = useRef<() => void>(() => { });

    const [stars, setStars] = useState<Star[]>([]);
    const [loading, setLoading] = useState(true);
    const [selectedStarDetails, setSelectedStarDetails] = useState<Record<string, unknown> | null>(null);

    // fetch
    useEffect(() => {
        fetch("/api/stars")
            .then(res => {
                if (!res.ok) {
                    throw new Error("БЛЯ!");
                }
                return res.json();
            })
            .then((data: Star[]) => {
                const mapped: Star[] = data.map((s) => ({
                    id: s.id,
                    name: s.name,
                    ra: s.ra,
                    dec: s.dec,
                    mag: s.mag,
                }));

                setStars(mapped);
            })
            .catch(console.error)
            .finally(() => setLoading(false));
    }, []);

    // logic
    useEffect(() => {
        const canvas = canvasRef.current;
        if (!canvas) return;

        const ctx = canvas.getContext("2d");
        if (!ctx) return;

        function resize() {
            const canvas = canvasRef.current;
            if (!canvas) return;

            const dpr = window.devicePixelRatio || 1;

            canvas.width = canvas.clientWidth * dpr;
            canvas.height = canvas.clientHeight * dpr;

            ctx.setTransform(dpr, 0, 0, dpr, 0, 0);

            render();
        }

        window.addEventListener("resize", resize);
        resize();

        function render() {
            if (!canvas || !ctx) return;

            const { scale, offsetX, offsetY } = navRef.current;

            const dpr = window.devicePixelRatio || 1;

            ctx.clearRect(0, 0, canvas.width, canvas.height);

            ctx.save();
            ctx.setTransform(
                scale * dpr,
                0,
                0,
                scale * dpr,
                offsetX * dpr,
                offsetY * dpr
            );

            if (gridType === "Equatorial") {
                drawEquatorialGrid(
                    ctx,
                    canvas.clientWidth,
                    canvas.clientHeight
                );
                // draw labels WITHOUT transform
                //ctx.save();
                //ctx.setTransform(1, 0, 0, 1, 0, 0);
                drawEquatorialLabels(ctx, canvas.clientWidth, canvas.clientHeight);
                drawMapBorder(ctx, canvas.clientWidth, canvas.clientHeight);
                //ctx.restore();
            }

            if (constellations.borders) {
                // draw constellation borders
            }

            if (constellations.names) {
                // draw constellation names
            }

            if (constellations.figures) {
                // draw constellation lines
            }

            for (const star of stars) {
                const { x, y } = project(
                    star.ra,
                    star.dec,
                    canvas.clientWidth,
                    canvas.clientHeight
                );

                const r = Math.max(0.2, 4 - star.mag);

                // draw star
                ctx.beginPath();
                ctx.arc(x, y, r, 0, Math.PI * 2);
                ctx.fillStyle = "white";
                ctx.fill();

                // highlight
                if (selectedStarRef.current?.id === star.id) {
                    ctx.beginPath();
                    ctx.arc(x, y, r + 4, 0, Math.PI * 2);
                    ctx.strokeStyle = "#00ff00";
                    ctx.lineWidth = 1;
                    ctx.stroke();
                }
            }

            ctx.restore();
        }

        renderRef.current = render;

        // click
        function handleClick(e: MouseEvent) {
            const canvas = canvasRef.current;
            if (!canvas) return;

            const rect = canvas.getBoundingClientRect();

            const screenX = e.clientX - rect.left;
            const screenY = e.clientY - rect.top;

            const nav = navRef.current;

            const { x, y } = screenToWorld(
                screenX,
                screenY,
                nav.scale,
                nav.offsetX,
                nav.offsetY
            );

            const star = findNearestStar(
                stars,
                x,
                y,
                canvas.clientWidth,
                canvas.clientHeight,
                6 / nav.scale
            );

            selectedStarRef.current = star;
            if (!star) {
                setSelectedStarDetails(null);
            }
            if (star) {
                fetch(`/api/stars/${star.id}`)
                    .then(res => {
                        if (!res.ok) throw new Error("Failed to fetch star details");
                        return res.json() as Promise<Record<string, unknown>>;
                    })
                    .then(setSelectedStarDetails)
                    .catch(console.error);
            }

            requestAnimationFrame(render);
        }

        canvas.addEventListener("click", handleClick);

        // zoom
        function handleWheel(e: WheelEvent) {
            const canvas = canvasRef.current;
            if (!canvas) return;

            e.preventDefault();

            const zoomIntensity = 0.1;
            const nav = navRef.current;

            const rect = canvas.getBoundingClientRect();

            const mouseX = e.clientX - rect.left;
            const mouseY = e.clientY - rect.top;

            const scaleFactor = 1 - e.deltaY * zoomIntensity * 0.01;
            const newScale = nav.scale * scaleFactor;

            nav.offsetX =
                mouseX - (mouseX - nav.offsetX) * (newScale / nav.scale);
            nav.offsetY =
                mouseY - (mouseY - nav.offsetY) * (newScale / nav.scale);

            nav.scale = Math.max(0.2, Math.min(newScale, 20));

            requestAnimationFrame(render);
        }

        canvas.addEventListener("wheel", handleWheel, { passive: false });

        // pan
        let isDragging = false;
        let lastX = 0;
        let lastY = 0;

        function handleMouseDown(e: MouseEvent) {
            isDragging = true;
            lastX = e.clientX;
            lastY = e.clientY;
        }

        function handleMouseMove(e: MouseEvent) {
            if (!isDragging) return;

            const dx = e.clientX - lastX;
            const dy = e.clientY - lastY;

            const nav = navRef.current;
            nav.offsetX += dx;
            nav.offsetY += dy;

            lastX = e.clientX;
            lastY = e.clientY;

            requestAnimationFrame(render);
        }

        function handleMouseUp() {
            isDragging = false;
        }

        canvas.addEventListener("mousedown", handleMouseDown);
        window.addEventListener("mousemove", handleMouseMove);
        window.addEventListener("mouseup", handleMouseUp);

        // CLEANUP
        return () => {
            window.removeEventListener("resize", resize);
            canvas.removeEventListener("click", handleClick);
            canvas.removeEventListener("wheel", handleWheel);
            canvas.removeEventListener("mousedown", handleMouseDown);
            window.removeEventListener("mousemove", handleMouseMove);
            window.removeEventListener("mouseup", handleMouseUp);
        };
    }, [stars]);

    //zoom keyboard
    useEffect(() => {
        const handleKeyDown = (e: KeyboardEvent) => {
            const nav = navRef.current;

            if (e.key === "+" || e.key === "=") {
                nav.scale = Math.min(nav.scale * 1.2, 20);
            }
            if (e.key === "-") {
                nav.scale = Math.max(nav.scale / 1.2, 0.2);
            }

            renderRef.current();
        };

        window.addEventListener("keydown", handleKeyDown);
        return () => window.removeEventListener("keydown", handleKeyDown);
    }, []);

    // help modal
    useEffect(() => {
        const handleKey = (e: KeyboardEvent) => {
            if (e.key.toLowerCase() === "h") {
                setHelpOpen(true);
            }
        };

        window.addEventListener("keydown", handleKey);
        return () => window.removeEventListener("keydown", handleKey);
    }, []);


    // LOADING
    if (loading) {
        return (
            <div style={{ color: "yellow", background: "black" }}>
                Loading map...
            </div>
        );
    }

    return (
        <div style={{ width: "100%", height: "100%", position: "relative" }}>
            <canvas
                ref={canvasRef}
                style={{
                    width: "100%",
                    height: "100%",
                    display: "block",
                    background: "black",
                }}
            />

            {selectedStarDetails && (
                <div
                    style={{
                        position: "absolute",
                        top: 20,
                        left: 20,
                        color: "#00ff00",
                        background: "rgba(0,0,0,0.5)",
                        padding: "10px",
                        borderRadius: "8px",
                        //borderColor: "#00ff00",
                        fontSize: "14px",
                        maxWidth: "250px",
                        border: "1px solid rgb(0, 255, 0)"
                    }}
                >
                    {Object.entries(selectedStarDetails).map(([key, value]) => (
                        <div key={key}>
                            <b>{key}:</b> {String(value)}
                        </div>
                    ))}
                </div>
            )}
        </div>
    );
}

function drawEquatorialGrid(
    ctx: CanvasRenderingContext2D,
    width: number,
    height: number
) {
    ctx.strokeStyle = "rgba(0, 255, 0, 0.25)";
    ctx.lineWidth = 1;

    // RA lines (vertical)
    for (let ra = 0; ra < 360; ra += 15) {
        const x = (ra / 360) * width;

        ctx.beginPath();
        ctx.moveTo(x, 0);
        ctx.lineTo(x, height);
        ctx.stroke();
    }

    // Dec lines (horizontal)
    for (let dec = -90; dec <= 90; dec += 15) {
        const y = ((90 - dec) / 180) * height;

        ctx.beginPath();
        ctx.moveTo(0, y);
        ctx.lineTo(width, y);
        ctx.stroke();
    }
}

function drawEquatorialLabels(
    ctx: CanvasRenderingContext2D,
    width: number,
    height: number
) {
    ctx.fillStyle = "#00ff00";
    ctx.font = "12px monospace";

    // -------------------------
    // RA labels (top & bottom)
    // -------------------------
    for (let ra = 0; ra < 360; ra += 30) {
        const x = (ra / 360) * width;

        const hours = Math.floor(ra / 15); // 360° = 24h
        const label = `${hours}h`;

        // top
        ctx.fillText(label, x + 2, -10);

        // bottom
        ctx.fillText(label, x + 2, height + 15);
    }

    // -------------------------
    // Dec labels (left & right)
    // -------------------------
    for (let dec = -60; dec <= 60; dec += 30) {
        const y = ((90 - dec) / 180) * height;

        const label = `${dec > 0 ? "+" : ""}${dec}°`;

        // left
        ctx.fillText(label, -30, y - 2);

        // right
        ctx.fillText(label, width + 4, y - 2);
    }
}

function drawMapBorder(
    ctx: CanvasRenderingContext2D,
    width: number,
    height: number
) {
    ctx.strokeStyle = "#00ff00";
    ctx.lineWidth = 2;

    ctx.strokeRect(0, 0, width, height);
}