using System.ComponentModel;

namespace MascheraCatasto.Anagrafiche
{
    public enum Sesso
    {
        [Description("Sconosciuto")]
        Sconosciuto = 0,

        [Description("Uomo")]
        Uomo = 1,

        [Description("Donna")]
        Donna = 2,
    }
}
