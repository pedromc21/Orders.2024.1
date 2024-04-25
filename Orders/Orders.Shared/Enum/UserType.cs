using System.ComponentModel;

namespace Orders.Shared.Enum
{
    public enum UserType
    {
        [Description("Administrador")]
        Admin,

        [Description("Usuario")]
        User
    }
}