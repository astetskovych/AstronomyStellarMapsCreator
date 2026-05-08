export interface Star {
    id: number;
    ra: number;   // 0–360 (TODO -> better do it in h)
    dec: number;  // -90–90
    mag: number;
    name?: string | null; //Proper name or catalogue ID
}