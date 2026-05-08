export interface Point {
    x: number;
    y: number;
}

export function project(
    ra: number,
    dec: number,
    width: number,
    height: number
): Point {
    const x = (ra / 24) * width;
    const y = height / 2 - (dec / 180) * height;

    return { x, y };
}