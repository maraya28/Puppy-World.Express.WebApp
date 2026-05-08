using System.ComponentModel;

namespace PuppyWorld.Domain
{
    public enum ServiceType
    {
        [Description("Lavado")]
        Washing,
        [Description("Corte")]
        Cutting,
        [Description("Corte + Lavado")]
        WashingCutting,
        [Description("Deslanado")]
        Skimming
    }
}
