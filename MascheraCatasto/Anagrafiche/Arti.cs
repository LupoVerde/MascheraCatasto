namespace MascheraCatasto.Anagrafiche
{
    using System;
    using System.ComponentModel;

    public enum PrefissiArti
    {

        [Description("Lavoratore")]
        Lavoratore = 1,

        [Description("Figlia o Vedova")]
        Figlia_Vedova = 2,
    }
    /// <summary>
    /// Se il codice è formato da 3 cifre: la prima cifra fa riferimento a PrefissiArti
    /// es. 105 => Pastore
    ///     205 => Figlia o vedova di un Pastore
    /// </summary>
    public enum Arti
    {
        [Description("Contadino (Proprietario)")]
        Contadino_Proprietario = 01,

        [Description("Contadino (In affitto)")]
        Contadino_InAffitto = 02,

        [Description("Mezzadro")]
        Mezzadro = 03,

        [Description("Contadino senza terra")]
        Contadino_NoTerra = 04,

        [Description("Pastore")]
        Pastore = 05,

        [Description("Pescatore")]
        Pescatore = 06,

        [Description("Ortolano, Treccone")]
        Ortolano_Treccone = 07,

        [Description("Messere (Cavaliere, Vescovo, alta carica ecclesiastica...)")]
        Messere = 08,

        [Description("Bambaciaio")]
        Bambaciaio = 09,

        [Description("Marinaio, Calafato, Copertoaio")]
        Marinaio_Calafato_Copertoaio = 10,

        [Description("Servitore Privato (Fante, Fattore)")]
        ServitorePrivato_Fante_Fattore = 11,

        [Description("Servitore del clero NON militare (es. Spedaliere)")]
        ServitoreClero_Spedaliere = 12,

        [Description("Impiegato Statali NON militare (Vigilaio, Piffero, Meziere, Corriere, Messo)")]
        Vigilaio_Piffero_Meziere_Corriere_Messo = 13,

        [Description("Soldato (qualsiasi rango)")]
        Soldato = 14,

        [Description("Impiegato di Gilda")]
        ImpiegatoDiGilda = 15,

        [Description("Cuoco")]
        Cuoco = 16,

        [Description("Becchino")]
        Becchino = 17,

        [Description("Scriba, Fattore, Attore di Puilli, Bullettaio")]
        Scriba_Fattore_AttoreDiPuilli_Bullettaio = 18,

        [Description("Varie")]
        Varie = 19,

        [Description("Vetturale, Carretaio, Portatore, Carradore, Legatore")]
        Vetturale_Carretaio_Portatore_Carradore_Legatore = 20,

        [Description("Giudice, Notaio")]
        Giudice_Notaio = 21,

        [Description("Mercatante, Calimala")]
        Mercatante_Calimala = 22,

        [Description("Cambiatore, Banchiere, Tavoliere")]
        Cambiatore_Banchiere_Tavoliere = 23,

        [Description("Lanaio, Ritagliatore, Pannellaio, Drappiere")]
        Lanaio_Ritagliatore_Pannellaio_Drappiere = 24,

        [Description("Setaiolo")]
        Setaiolo = 25,

        [Description("Medico, Speziale")]
        Medico_Speziale = 26,

        [Description("Vaiaio, Pellicciaio")]
        Vaiaio_Pellicciaio = 27,

        [Description("Beccaio, Pollaiolo, Carnaiolo")]
        Beccaio_Pollaiolo_Carnaiolo = 28,

        [Description("Calzolaio")]
        Calzolaio = 29,

        [Description("Fabbro")]
        Fabbro = 30,

        [Description("Rigattiere, Linaiuolo")]
        Rigattiere_Linaiuolo = 31,

        [Description("Maestro (Dottore in Medicina)")]
        Maestro = 32,

        [Description("Vinattiere, Mescitore di Vino")]
        Vinattiere_MescitorediVino = 33,

        [Description("Albergatore, Tavernaio, Oste")]
        Albergatore_Tavernaio_Oste = 34,

        [Description("Oliandolor, Candelaio, Sevaiolo")]
        Oliandolo_Candelaio_Sevaiolo = 35,

        [Description("Galigaio")]
        Galigaio = 36,

        [Description("Correggiaio")]
        Correggiaio = 37,

        [Description("Corazzaio")]
        Corazzaio = 38,

        [Description("Chiavaiolo, Toppaiolo")]
        Chiavaiolo_Toppaiolo = 39,

        [Description("Legnaiolo")]
        Legnaiolo = 40,

        [Description("Fornaio")]
        Fornaio = 41,

        [Description("Mugnaio")]
        Mugnaio = 42,

        [Description("Tintore, Curandaio")]
        Tintore_Curandaio = 43,

        [Description("Barbiere")]
        Barbiere = 44,

        [Description("Scardassiere")]
        Scardassiere = 45,

        [Description("Tessitore di Lana")]
        TessitoreDiLana = 46,

        [Description("Pizzicagnolo, Cacciaiuolo")]
        Pizzicagnolo_Cacciaiuolo = 47,

        [Description("Bottaio, Barattolaio, Barlettaio")]
        Bottaio_Barattolaio_Barlettaio = 48,

        [Description("Orafo, Gioielliere, Intagliatore, Orpellaio")]
        Orafo_Gioielliere_Intagliatore_Orpellaio = 49,

        [Description("Manovale")]
        Manovale = 50,

        [Description("Scodellaio, Stovigliaio, Fiascaio, Orciolaio, Bicchiere")]
        Scodellaio_Stovigliaio_Fiascaio_Orciolaio_Bicchiere = 51,

        [Description("Merciaio")]
        Merciaio = 52,

        [Description("Purgatore")]
        Purgatore = 53,

        [Description("Muratore, Lastraiolo, Scarpellatore")]
        Muratore_Lastraiolo_Scarpellatore = 54,

        [Description("Bastiere, Brigliaio, Sellaio, Speronaio, Bastaio, Guainaio")]
        Bastiere_Brigliaio_Sellaio_Speronaio_Bastaio_Guainaio = 55,

        [Description("Cartolaio, Cartaio")]
        Cartolaio_Cartaio = 56,

        [Description("Maniscalco")]
        Maniscalco = 57,

        [Description("Farsettaio")]
        Farsettaio = 58,

        [Description("Fornaciaio, Stufaiolo")]
        Fornaciaio_Stufaiolo = 59,

        [Description("Riveditore")]
        Riveditore = 60,

        [Description("Pettinatore, Carditore, Scegliatore di Lana, Apennichino")]
        Pettinatore_Carditore_ScegliatoreDiLana_Apennichino = 61,

        [Description("Cimatore")]
        Cimatore = 62,

        [Description("Borsaio")]
        Borsaio = 63,

        [Description("Tessitore di Seta e di Lino")]
        TessitoreDiSetaEDiLino = 64,

        [Description("Pianellaio")]
        Pianellaio = 65,

        [Description("Pesatore, Staderaio, Bilanciaio")]
        Pesatore_Staderaio_Bilanciaio = 66,

        [Description("Sarto")]
        Sarto = 67,

        [Description("Guarnaio")]
        Guarnaio = 68,

        [Description("Bandettaio, Banditore")]
        Bandettaio_Banditore = 69,

        [Description("Sacerdote")]
        Sacerdote = 70,

        [Description("Membro del Clero")]
        Clero = 71,

        [Description("Mendicante")]
        Mendicante = 72,

        [Description("Cuoaio")]
        Cuoaio = 73,

        [Description("Cappellaio")]
        Cappellaio = 74,

        [Description("Ottonaio, Stagnaio, Calderaio")]
        Ottonaio_Stagnaio_Calderaio = 75,

        [Description("Ferratore, Ferravecchio")]
        Ferratore_Ferravecchio = 76,

        [Description("Insegnante di Lettere o di Abaco")]
        InsegnanteLettereOAbaco = 77,

        [Description("Conciatore di Pelle, Pelacane")]
        ConciatoreDiPelle_Pelacane = 78,

        [Description("Sensale")]
        Sensale = 79,

        [Description("Stamaiolo, Filatoiaio")]
        Stamaiolo_Filatoiaio = 80,

        [Description("Pezzaio")]
        Pezzaio = 81,

        [Description("Pinzochera")]
        Pinzochera = 82,

        [Description("Cimbalaio, Buffone")]
        Cimbalaio_Buffone = 83,

        [Description("Lava Panni")]
        LavaPanni = 84,

        [Description("Coltellaio, Forbiciaio")]
        Coltellaio_Forbiciaio = 85,

        [Description("Mulattiere, Presta Ronzini, Cavallaio, Asinaio")]
        Mulattiere_PrestaRonzini_Cavallaio_Asinaio = 86,

        [Description("Rimendatore, Ricamatore, Refaiuolo, Pattiere")]
        Rimendatore_Ricamatore_Refaiuolo_Pattiere = 87,

        [Description("Employee of the Mint")]
        EmployeeOfMint = 88,

        [Description("Nobile Rurale")]
        NobileRurale = 89,

        [Description("Ebreo")]
        Ebreo = 90,

        [Description("Tiratore")]
        Tiratore = 91,

        [Description("Materassaio, Coltriciaio, Pagliaiolo")]
        Materassaio_Coltriciaio_Pagliaiolo = 92,

        [Description("Lanino")]
        Lanino = 93,

        [Description("Spadaio, Balestiere, Armaiolo, Forbelarme, Schermidore")]
        Spadaio_Balestiere_Armaiolo_Forbelarme_Schermidore = 94,

        [Description("Dipintore, Miniatore, Ceraiuolo")]
        Dipintore_Miniatore_Ceraiuolo = 95,

        [Description("Biadaiolo")]
        Biadaiolo = 96,

        [Description("Cordatore, Funaiolo, Saccaio")]
        Cordatore_Funaiolo_Saccaio = 97,

        [Description("Verghegiatore, Scamatino, Divettino")]
        Verghegiatore_Scamatino_Divettino = 98,

        [Description("Messer (Dottore in Legge)")]
        Messer = 99
    }
}
