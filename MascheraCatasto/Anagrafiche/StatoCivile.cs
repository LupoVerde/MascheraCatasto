using System.ComponentModel;

namespace MascheraCatasto.Anagrafiche
{
    public enum StatoCivile
    {
        [Description("Indeterminato")]
        Neonati = 0,
        [Description("Sposato/a")]
        Sposato = 1,
        [Description("Celibe/Nubile")]
        Celibe_Nubile = 2,
        [Description("Impegnato")]
        Impegnato = 3,
        [Description("Vedovo/a")]
        Vedovo = 4,
        [Description("Sposato/a o Vedovo/a")]
        Sposato_Vedovo = 5,
        [Description("Sconosciuto")]
        NotGiven = 6,
        [Description("Separato/a")]
        Separato = 7,
        [Description("Sposato (1428-1429)")]
        Sposato_Nuovo = 8,
    }
}
