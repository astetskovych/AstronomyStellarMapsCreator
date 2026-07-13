import type { Star } from "../types/Star";

export const loadStars = async (url: string,
                                setStars: React.Dispatch<React.SetStateAction<Star[]>>,
                                setLoading: React.Dispatch<React.SetStateAction<boolean>>) => {
    fetch(url)
        .then(res => {
            if (!res.ok) {
                throw new Error("BIG BANG!");
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
};