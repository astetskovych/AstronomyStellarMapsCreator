import type { Star } from "../types/Star";
import { project } from "./projection";

export function findNearestStar(
    stars: Star[],
    x: number,
    y: number,
    width: number,
    height: number,
    threshold = 6
): Star | null {
    let closest: Star | null = null;
    let minDist = Infinity;

    for (const star of stars) {
        const pos = project(star.ra, star.dec, width, height);

        const dx = pos.x - x;
        const dy = pos.y - y;
        const dist = Math.sqrt(dx * dx + dy * dy);

        if (dist < threshold && dist < minDist) {
            minDist = dist;
            closest = star;
        }
    }

    return closest;
}