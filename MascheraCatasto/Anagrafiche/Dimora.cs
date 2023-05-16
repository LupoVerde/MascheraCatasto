using System.ComponentModel;

namespace MascheraCatasto.Anagrafiche
{
    public enum Dimora
    {
        [Description("Proprietario della casa in cui vive")]
        Proprietario = 1,

        [Description("Vive in affitto")]
        InAffitto = 2,

        [Description("Vive in famiglia (parenti o servi)")]
        InFamiglia = 3,
    }
}
