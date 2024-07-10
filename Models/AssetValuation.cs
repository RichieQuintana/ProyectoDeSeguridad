using System.Collections.Generic;
using System.Linq;

namespace ProyectoDeSeguridad.Models
{
    public class AssetValuation
    {
        public List<Asset> Assets { get; private set; } = new List<Asset>();

        public void AddAsset(Asset asset)
        {
            asset.Id = Assets.Count + 1; // Asigna un ID único
            Assets.Add(asset);
        }

        public decimal ValuateAsset(Asset asset)
        {
            // Suponiendo una fórmula simple de valoración: valor base * nivel de riesgo
            return asset.Value * asset.RiskLevel;
        }
    }
}
