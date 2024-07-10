namespace ProyectoDeSeguridad.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int RiskLevel { get; set; }
    }
}
