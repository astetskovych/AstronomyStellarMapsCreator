export function screenToWorld(
    screenX: number,
    screenY: number,
    scale: number,
    offsetX: number,
    offsetY: number
) {
    return {
        x: (screenX - offsetX) / scale,
        y: (screenY - offsetY) / scale,
    };
}