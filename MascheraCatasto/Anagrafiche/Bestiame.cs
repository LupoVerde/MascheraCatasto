using System.ComponentModel;

namespace MascheraCatasto.Anagrafiche
{
    public enum Bestiame
    {
        [Description("Proprietario di Bestiame")]
        Proprietario = 1,
        [Description("Locatore di Bestiame")]
        Locatore = 2,
        [Description("Proprietario e Locatore di bestiame")]
        Proprietario_Locatore = 3,
        [Description("Proprietario di piccoli animali")]
        PiccoliAnimale = 4,
        [Description("Proprietario di bestie da soma")]
        Soma = 5,
    }
}
