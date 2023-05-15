using System.ComponentModel;

namespace MascheraCatasto.Anagrafiche
{
    public enum Quartieri
    {
        #region Santo Spirito
        [Description("S. Spirito: Scala")]
        SantoSpirito_Scala = 11,

        [Description("S. Spirito: Nicchio")]
        SantoSpirito_Nicchio = 12,

        [Description("S. Spirito: Ferza")]
        SantoSpirito_Ferza = 13,

        [Description("S. Spirito: Drago")]
        SantoSpirito_Drago = 14,

        #endregion

        #region Santa Croce

        [Description("S. Croce: Carro")]
        SantaCroce_Carro = 21,

        [Description("S. Croce: Bue")]
        SantaCroce_Bue = 22,

        [Description("S. Croce: Leon Nero")]
        SantaCroce_LeonNero = 23,

        [Description("S. Croce: Ruote")]
        SantaCroce_Ruote = 24,

        #endregion

        #region Santa Maria Novella

        [Description("S. Maria Novella: Vipera")]
        SantaMariaNovella_Vipera = 31,

        [Description("S. Maria Novella: Unicorno")]
        SantaMariaNovella_Unicorno = 32,

        [Description("S. Maria Novella: Leon Rosso")]
        SantaMariaNovella_LeonRosso = 33,

        [Description("S. Maria Novella: Leon Bianco")]
        SantaMariaNovella_LeonBianco = 34,

        #endregion

        #region San Giovanni

        [Description("S. Giovanni: Leon D'Oro")]
        SanGiovanni_LeonDOro = 41,

        [Description("S. Giovanni: Drago")]
        SanGiovanni_Drago = 42,

        [Description("S. Giovanni: Chiavi")]
        SanGiovanni_Chiavi = 43,

        [Description("S. Giovanni: Vaio")]
        SanGiovanni_Vaio = 44,

        #endregion

    }
}
