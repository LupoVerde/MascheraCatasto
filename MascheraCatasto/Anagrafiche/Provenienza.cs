using System.ComponentModel;

namespace MascheraCatasto.Anagrafiche
{
    public enum Provenienza
    {
        [Description("Firenze")]
        Firenze = 1,

        [Description("Residenza a Firenze")]
        Residenza_Firenze = 2,

        [Description("Italia (non Firenze)")]
        Italia = 3,

        [Description("Germania")]
        Germania = 4,

        [Description("Altro (No Germania o Italia)")]
        Altro = 5,

        [Description("Residenza in Italia (non Firenze)")]
        Residenza_Italia = 6,

        [Description("Residenza in Germania")]
        Residenza_Germania = 7,

        [Description("Residenza No Germania o Italia")]
        Residenza_Altro = 8,

    }
}
