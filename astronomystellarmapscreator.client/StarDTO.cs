namespace AstronomyStellarMapsCreator.Server.DTOs
{
    public record StarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RA { get; set; }
        public double Dec { get; set; }
        public double Mag { get; set; }
    }
}
