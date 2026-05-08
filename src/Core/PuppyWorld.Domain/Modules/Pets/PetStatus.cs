using System.ComponentModel;

namespace PuppyWorld.Domain
{
    public enum PetStatus
    {
        [Description("Activo")]
        Active,
        [Description("Inactivo")]
        Inactive
    }
}
