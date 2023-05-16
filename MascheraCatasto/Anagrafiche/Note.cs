using System.ComponentModel;

namespace MascheraCatasto.Anagrafiche
{
    public enum Note
    {
        [Description("/")]
        NoComment = 0,

        [Description("Non incluso nel conteggio delle \"bocche\" a carico")]
        NoBocca = 1,

        [Description("Neonato (1428-1429)")]
        Neonato = 2,

        [Description("Registrato fuori Firenze")]
        FuoriFirenze = 4,

        [Description("No capofamiglia")]
        NoCapoFamiglia = 5,

        [Description("Incapace fisicamente o psicologicamente")]
        Incapace = 6,

        [Description("Figlio illegittimo")]
        FiglioIllegittimo = 7,

        [Description("Cancellato per matrimonio")]
        Cancellato_Matrimonio = 8,

        [Description("Cancellato per Morte")]
        Cancellato_Morte = 9,
    }
}
