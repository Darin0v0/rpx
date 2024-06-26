using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace MyApp
{
    public class Program
    {
        private const string Value = "ΔΔΔ";
        class Character
        {
            #region // branie
            public string ClassName { get; set; }
            public double zdrowie { get; set; }
            public double mana { get; set; }
            public int Pancerz { get; set; }
            public int ManipulacjaCharyzmou { get; set; }
            public double Siła { get; set; }
            public int Zręczność { get; set; }
            public int Wiedza { get; set; }
            public int Wytrzymałość { get; set; }
            public int Charyzma { get; set; }
            public int Skrytobójstwo { get; set; }
            public int OdpornośćMagiczna { get; set; }
            public int Rzemiosło { get; set; }
            public int BieganieKonia { get; set; }
            public int Elastyczność { get; set; }
            public int Instynkt { get; set; }
            public int CharyzmaBojowa { get; set; }
            public int Koncentracja { get; set; }
            public int UmiejętnościPrzetrwania { get; set; }
            public int Ukrywanie { get; set; }
            public int Śledzenie { get; set; }
            public int Intuicja { get; set; }
            public int SiłaWoli { get; set; }
            public int CharyzmaLidera { get; set; }
            public int ZrozumienieIntuicji { get; set; }
            public int ElastycznośćMentalna { get; set; }
            public int Medytacja { get; set; }
            public int Negocjacje { get; set; }
            public int IntuicjaWalki { get; set; }
            public int CharyzmaZwierząt { get; set; }
            public int Nekromancja { get; set; }
            public int WrodzonaWiedza { get; set; }
            public int ZdolnośćMaskowania { get; set; }
            public int WyostrzoneZmysły { get; set; }
            public int Czujność { get; set; }
            public int Samodoskonalenie { get; set; }
            public int Akrobatyka { get; set; }
            public int WyczuciePoezji { get; set; }
            public int MyślenieAnalityczne { get; set; }
            public int Bieg { get; set; }
            public int Kopnięcie { get; set; }
            public int Refleks { get; set; }
            public int IntuicjaTechnologiczna { get; set; }
            public int PrzemierzanieTerenu { get; set; }
            public int ManipulacjaEmocjonalna { get; set; }
            public int SztukaPrzeklęta { get; set; }
            public int WizjaMistyczna { get; set; }
            public int PrzyciemnienieMentalne { get; set; }
            public int Fałszerstwo { get; set; }
            public int RzucanieCzarów { get; set; }
            public int WarzenieEliksirów { get; set; }
            public int ManipulacjaEnergią { get; set; }
            public int ManipulacjaCzasem { get; set; }
            public int WięźZeSpirytamiNatury { get; set; }
            public int MistrzostwoIluzji { get; set; }
            public int MagiaKrwi { get; set; }
            public int RozerwanieDusz { get; set; }
            public int Penetracja { get; set; }
            public int CzytanieAury { get; set; }
            public int TworzeniePortali { get; set; }
            public int MagiczneTarcze { get; set; }
            public int ModyfikacjaRzeczywistości { get; set; }
            public int PrzełamywanieGranicy { get; set; }
            public int ManipulacjaEnergiąŻyciową { get; set; }
            public int ManipulacjaPrzestrzenią { get; set; }
            public int Ziołolecznictwo { get; set; }
            public int MaskowanieMagii { get; set; }
            public int Unikanie { get; set; }
            public int WywoływanieKlątw { get; set; }
            public int PrzetrwanieWWarunkachEkstremalnych { get; set; }
            public int UdzielanieMocy { get; set; }
            public int DowodzenieArmiami { get; set; }
            public int Mędrzec { get; set; }
            public int KontrolaGrawitacji { get; set; }
            public int Archeologia { get; set; }
            public int InterpretacjaZnaków { get; set; }
            public int Improwizacja { get; set; }
            public int TworzeniePólEnergetycznych { get; set; }
            public int Telekineza { get; set; }
            public int ZmienianieKształtu { get; set; }
            public int OswojenieZwierząt { get; set; }
            public int MagiaSłowa { get; set; }
            public int Antygrawitacja { get; set; }
            public int Szczęście { get; set; }
            public int PracaNadCiałem { get; set; }
            public int HeroicznyNatarcie { get; set; }
            public int MagiaŚwiatła { get; set; }
            public int MagiaCiemności { get; set; }
            public int MagiaOgnia { get; set; }
            public int MagiaWiatru { get; set; }
            public int Precyzja { get; set; }
            public int MagiaZiemi { get; set; }
            public int MagiaPowietrza { get; set; }
            public int MagiaPustki { get; set; }
            public int Strażnik { get; set; }
            public int Sprint { get; set; }
            public int AbsorpcjaEnergii { get; set; }
            public int OdczytywanieEmocji { get; set; }
            public int WydobycieWglądu { get; set; }
            public int MagiaLodu { get; set; }
            public int Niewidzialność { get; set; }
            public int MagiaChaotyczna { get; set; }
            public int PrzewidywanieZagrożeń { get; set; }
            public int MagiaEteru { get; set; }
            public int Perswazja { get; set; }
            public int Tropienie { get; set; }
            public int Mediacja { get; set; }
            public int WiedzaMedyczna { get; set; }
            public int TargowanieSie { get; set; }
            public int Taktyka { get; set; }
            public int Plotkowanie { get; set; }
            public int Dedukcja { get; set; }
            public int WytrzymaloscPsychiczna { get; set; }
            public int SpecjalizacjaElementalistyczna { get; set; }
            public int Fizyka { get; set; }
            public int Kryptografia { get; set; }
            public int RozbrajaniePulapek { get; set; }
            public int Zwinność { get; set; }
            public int PogłębioneZrozumienieMagii { get; set; }
            public int ZnajomośćJezykowObcych { get; set; }
            public int WykorzystanieSrodowiska { get; set; }
            public int Telepatia { get; set; }
            public int SztukaWalkiBroniaBiala { get; set; }
            public int YingYang { get; set; }
            public int Poetyckosc { get; set; }
            #endregion


            public static void Main(string[] args)
            {
                        #region//początek gry
                        Console.WriteLine($"   ┌───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                        Console.WriteLine($"   │                                                                                WIAJ W GRZE RPG                                                                                            │");
                        Console.WriteLine($"   │                                                                                                                                                                                           │");
                        Console.WriteLine($"   │     NAZWIJ SWOJĄ POSTAĆ:                                                                                                                                                                  │");
                        Console.WriteLine($"   └───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                        Console.Write(">> ");
                        var Input = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"   ┌───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                        Console.WriteLine($"   │                                                                                CLASSY POSTACI RPG                                                                                         │");
                        Console.WriteLine($"   │                                              KAŻDA KLAS MA SWOJE + I - MAJĄ ROZDRYSTRYBUTOWANIE 10 PUNKTÓW UMIJETNOŚĆI POMIEDZY UMIEJETNOŚCI                                              │");
                        Console.WriteLine($"   │ common:   1-MAG        2-ŁUCZNIK    3-RYCERZ     4-BARBARZNCA   6-ZŁODZIEJ     10-PALLADYN   11-MNICH         12-KAPŁAN      25-DRWAL     27-POSZUKIWACZ PRZYGÓD  32-HERETYK              │");
                        Console.WriteLine($"   │ common:   33-WYGNANIEC 34-FANATYK   35-WŁUCZENGA 36-SKRYBA      41-WIEŚNIAK    53-NIEWOLNIK  47-TROPICIEL    56-SZUJA        58-GURNIK    54-WIEDZMA              55-DEZERTER             │");
                        Console.WriteLine($"   │ uncommon: 5-VAMPIR     7-DRUDI      8-ZIELARZ    9-MECHANIK     13-SZERMIERZ   14-STRAŻNIK   15-ŁOWCA         20-ZWIADOWCA   26-SAMURAI   42-MAG PUSTKI           57-INFORMATYK           │");
                        Console.WriteLine($"   │ rare:     16-SZAMAN    18-EGZEKUTOR 21-ZAKLINACZ 22-TEMPLARIUSZ 28-KOWAL       31-PROROK     37-ŁOWCA DEMONUW 38-ŁOWCA BESTI 49-OPIEKUN   50-KRZYRZAK             59-PRZEKLĘTY            │");
                        Console.WriteLine($"   │ epic:     17-ALCHEMIK  23-BISKUP    24-SZLACHCIC 30-GENERAŁ     19-MISTRZBRONI 30-ARCHITEKT  39-UZDROWICIEL   40-NATURYSTA   48-DUCH LASU 51-CHAMPION             61-TAMER                │");
                        Console.WriteLine($"   │ (OP)ezzy: 43-BOCHATER  44-BARD      45-NIMFA_W   46-NIMFA_O     60-UCZEŃ       52-Driada                                                                                                  │");
                        Console.WriteLine($"   └───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                        Console.Write(">> ");
                        #region//umiejki
                        string className = "";
                        int zdrowie = 0, mana = 0, pancerz = 0, Siła = 0, Zręczność = 0, Wiedza = 0, Wytrzymałość = 0, Charyzma = 0, Skrytobójstwo = 0, OdpornośćMagiczna = 0, Rzemiosło = 0, BieganieKonia = 0, Elastyczność = 0,
                        Instynkt = 0, CharyzmaBojowa = 0, Koncentracja = 0, UmiejętnościPrzetrwania = 0, Ukrywanie = 0, Śledzenie = 0, Intuicja = 0, SiłaWoli = 0, CharyzmaLidera = 0,
                        ZrozumienieIntuicji = 0, ElastycznośćMentalna = 0, Medytacja = 0, Negocjacje = 0, IntuicjaWalki = 0, CharyzmaZwierząt = 0, Nekromancja = 0, WrodzonaWiedza = 0,
                        ZdolnośćMaskowania = 0, WyostrzoneZmysły = 0, Czujność = 0, Samodoskonalenie = 0, Akrobatyka = 0, WyczuciePoezji = 0, MyślenieAnalityczne = 0, Bieg = 0,
                        Kopnięcie = 0, Refleks = 0, IntuicjaTechnologiczna = 0, PrzemierzanieTerenu = 0, ManipulacjaEmocjonalna = 0, SztukaPrzeklęta = 0, ManipulacjaCharyzmą = 0,
                        WizjaMistyczna = 0, PrzyciemnienieMentalne = 0, Fałszerstwo = 0, RzucanieCzarów = 0, WarzenieEliksirów = 0, ManipulacjaEnergią = 0, ManipulacjaCzasem = 0,
                        WięźZeSpirytamiNatury = 0, MistrzostwoIluzji = 0, MagiaKrwi = 0, RozerwanieDusz = 0, Penetracja = 0, CzytanieAury = 0, TworzeniePortali = 0, MagiczneTarcze = 0,
                        ModyfikacjaRzeczywistości = 0, PrzełamywanieGranicy = 0, ManipulacjaEnergiąŻyciową = 0, ManipulacjaPrzestrzenią = 0, Ziołolecznictwo = 0, Unikanie = 0,
                        MaskowanieMagii = 0, WywoływanieKlątw = 0, PrzetrwanieWWarunkachEkstremalnych = 0, UdzielanieMocy = 0, DowodzenieArmiami = 0, Mędrzec = 0, KontrolaGrawitacji = 0,
                        Archeologia = 0, InterpretacjaZnaków = 0, Improwizacja = 0, TworzeniePólEnergetycznych = 0, Telekineza = 0, ZmienianieKształtu = 0, OswojenieZwierząt = 0,
                        MagiaSłowa = 0, Antygrawitacja = 0, Szczęście = 0, PracaNadCiałem = 0, HeroicznyNatarcie = 0, MagiaŚwiatła = 0, MagiaCiemności = 0, MagiaOgnia = 0,
                        MagiaWiatru = 0, Precyzja = 0, MagiaZiemi = 0, MagiaPowietrza = 0, MagiaPustki = 0, Strażnik = 0, Sprint = 0, AbsorpcjaEnergii = 0, OdczytywanieEmocji = 0,
                        WydobycieWglądu = 0, MagiaLodu = 0, Niewidzialność = 0, MagiaChaotyczna = 0, PrzewidywanieZagrożeń = 0, MagiaEteru = 0, Perswazja = 0, Tropienie = 0,
                        Mediacja = 0, WiedzaMedyczna = 0, TargowanieSie = 0, Taktyka = 0, Plotkowanie = 0, Dedukcja = 0, WytrzymaloscPsychiczna = 0, SpecjalizacjaElementalistyczna = 0,
                        Fizyka = 0, Kryptografia = 0, RozbrajaniePulapek = 0, Zwinność = 0, PogłębioneZrozumienieMagii = 0, ZnajomośćJezykowObcych = 0, WykorzystanieSrodowiska = 0,
                        Telepatia = 0, SztukaWalkiBroniaBiala = 0, yingYang = 0, poetyckosc = 0;
                        #endregion
                        string inputString = Console.ReadLine();
                        int inputClass;
                        if (int.TryParse(inputString, out inputClass))
                        {
                            #region//klasy





                            switch (inputClass)
                            {
                                case 1: // mag
                                    className = "mag";
                                    zdrowie = 100;
                                    mana = 350;
                                    pancerz = 70;
                                    Siła = 1;
                                    Zręczność = 1;
                                    Wiedza = 3;
                                    WrodzonaWiedza = 2;
                                    MagiaOgnia = 2;
                                    Fizyka = 1;
                                    break;
                                case 2: // łucznik
                                    className = "łucznik";
                                    zdrowie = 150;
                                    mana = 100;
                                    pancerz = 120;
                                    Siła = 2;
                                    Zręczność = 2;
                                    WyostrzoneZmysły = 1;
                                    Penetracja = 2;
                                    UmiejętnościPrzetrwania = 1;
                                    PrzemierzanieTerenu = 1;
                                    PrzetrwanieWWarunkachEkstremalnych = 1;
                                    MagiaWiatru = 2;
                                    break;
                                case 3: // Ryczerz
                                    className = "Rycerz";
                                    zdrowie = 200;
                                    mana = 60;
                                    pancerz = 200;
                                    Siła = 5;
                                    Wytrzymałość = 3;
                                    WytrzymaloscPsychiczna = 2;
                                    SiłaWoli = 1;
                                    IntuicjaWalki = 1;
                                    SztukaWalkiBroniaBiala = 2;
                                    MagiczneTarcze = 1;
                                    break;
                                case 4: //Barbarzyńca
                                    className = "Barbarzyńca";
                                    zdrowie = 250;
                                    mana = 80;
                                    pancerz = 150;
                                    Siła = 3;
                                    Wytrzymałość = 2;
                                    OdpornośćMagiczna = 2;
                                    UmiejętnościPrzetrwania = 3;
                                    SztukaWalkiBroniaBiala = 1;
                                    Szczęście = 2;
                                    break;
                                case 5: //Vampir
                                    className = "Vampir";
                                    zdrowie = 150;
                                    mana = 150;
                                    pancerz = 100;
                                    Siła = 4;
                                    WywoływanieKlątw = 1;
                                    ZnajomośćJezykowObcych = 1;
                                    Wiedza = 2;
                                    WrodzonaWiedza = 1;
                                    MagiaKrwi = 4;
                                    WykorzystanieSrodowiska = 1;
                                    break;
                                case 6: //Złodziej
                                    className = "Złodziej";
                                    zdrowie = 90;
                                    mana = 100;
                                    pancerz = 80;
                                    Siła = 2;
                                    ZdolnośćMaskowania = 2;
                                    Niewidzialność = 1;
                                    Skrytobójstwo = 2;
                                    Kopnięcie = 2;
                                    Koncentracja = 2;
                                    Dedukcja = 1;
                                    break;
                                case 7: // Druid
                                    className = "Druid";
                                    zdrowie = 120;
                                    mana = 150;
                                    pancerz = 60;
                                    Siła = 2;
                                    OswojenieZwierząt = 1;
                                    WiedzaMedyczna = 2;
                                    MagiaZiemi = 3;
                                    PrzetrwanieWWarunkachEkstremalnych = 2;
                                    PrzemierzanieTerenu = 2;
                                    ZmienianieKształtu = 1;
                                    break;
                                case 8: //Zielarz
                                    className = "Zielarz";
                                    zdrowie = 100;
                                    mana = 100;
                                    pancerz = 50;
                                    Siła = 1;
                                    Ziołolecznictwo = 3;
                                    WykorzystanieSrodowiska = 2;
                                    Tropienie = 1;
                                    WiedzaMedyczna = 2;
                                    Zwinność = 3;
                                    break;
                                case 9://Mechanik
                                    className = "Mechanik";
                                    zdrowie = 140;
                                    mana = 140;
                                    pancerz = 80;
                                    Siła = 2;
                                    IntuicjaTechnologiczna = 3;
                                    ZnajomośćJezykowObcych = 2;
                                    Archeologia = 2;
                                    Kryptografia = 3;
                                    break;
                                case 10://Paladyn 
                                    className = "Paladyn";
                                    zdrowie = 200;
                                    mana = 150;
                                    pancerz = 100;
                                    Siła = 4;
                                    MagiaŚwiatła = 2;
                                    PogłębioneZrozumienieMagii = 3;
                                    Wytrzymałość = 1;
                                    Strażnik = 2;
                                    SztukaWalkiBroniaBiala = 2;
                                    break;
                                case 11://Mnich 
                                    className = "Mnich";
                                    zdrowie = 170;
                                    mana = 100;
                                    pancerz = 50;
                                    Siła = 6;
                                    Medytacja = 3;
                                    OdczytywanieEmocji = 2;
                                    OdpornośćMagiczna = 2;
                                    IntuicjaWalki = 2;
                                    PracaNadCiałem = 1;
                                    break;
                                case 12://Kapłan  
                                    className = "Kapłan";
                                    zdrowie = 90;
                                    mana = 300;
                                    pancerz = 90;
                                    Siła = 1;
                                    Wiedza = 4;
                                    MyślenieAnalityczne = 1;
                                    Dedukcja = 1;
                                    WizjaMistyczna = 2;
                                    MagiaŚwiatła = 2;
                                    break;
                                case 13://Szermierz 
                                    className = "Szermierz";
                                    zdrowie = 180;
                                    mana = 160;
                                    pancerz = 80;
                                    Siła = 2;
                                    IntuicjaWalki = 2;
                                    SztukaWalkiBroniaBiala = 3;
                                    PrzyciemnienieMentalne = 1;
                                    Unikanie = 2;
                                    MagiaCiemności = 1;
                                    Refleks = 1;
                                    break;
                                case 14://Strażnik 
                                    className = "Strażnik";
                                    zdrowie = 200;
                                    mana = 100;
                                    pancerz = 200;
                                    Siła = 1;
                                    MagiczneTarcze = 3;
                                    Wytrzymałość = 2;
                                    WytrzymaloscPsychiczna = 2;
                                    ManipulacjaEnergiąŻyciową = 2;
                                    Perswazja = 1;
                                    break;
                                case 15://Łowca
                                    className = "Łowca";
                                    zdrowie = 100;
                                    mana = 100;
                                    pancerz = 65;
                                    Siła = 1;
                                    Tropienie = 3;
                                    Czujność = 2;
                                    WyostrzoneZmysły = 2;
                                    ElastycznośćMentalna = 1;
                                    PrzemierzanieTerenu = 1;
                                    Bieg = 1;
                                    break;
                                case 16://Szaman
                                    className = "Szaman";
                                    zdrowie = 80;
                                    mana = 300;
                                    pancerz = 100;
                                    Siła = 1;
                                    TworzeniePólEnergetycznych = 3;
                                    ManipulacjaPrzestrzenią = 1;
                                    CharyzmaLidera = 2;
                                    ManipulacjaEnergiąŻyciową = 3;
                                    WywoływanieKlątw = 1;
                                    break;
                                case 17:// Alchemik
                                    className = "Alchemik";
                                    zdrowie = 100;
                                    mana = 50;
                                    pancerz = 80;
                                    Siła = 1;
                                    MaskowanieMagii = 2;
                                    Fałszerstwo = 4;
                                    SpecjalizacjaElementalistyczna = 2;
                                    Rzemiosło = 1;
                                    Czujność = 1;
                                    break;
                                case 18:
                                    className = "Egzekutor";
                                    zdrowie = 140;
                                    mana = 50;
                                    pancerz = 80;
                                    Siła = 4;
                                    OdczytywanieEmocji = 2;
                                    MagiaZiemi = 3;
                                    RozerwanieDusz = 3;
                                    Penetracja = 2;
                                    break;
                                case 19:
                                    className = "Mistch Broni";
                                    zdrowie = 180;
                                    mana = 100;
                                    pancerz = 100;
                                    Siła = 3;
                                    SztukaWalkiBroniaBiala = 5;
                                    Szczęście = 2;
                                    ManipulacjaPrzestrzenią = 1;
                                    Zręczność = 2;
                                    break;
                                case 20:
                                    className = "Zwiadowca";
                                    zdrowie = 140;
                                    mana = 70;
                                    pancerz = 100;
                                    Siła = 2;
                                    PrzemierzanieTerenu = 2;
                                    PrzewidywanieZagrożeń = 2;
                                    UmiejętnościPrzetrwania = 3;
                                    Unikanie = 2;
                                    Sprint = 1;
                                    break;
                                case 21:
                                    className = "Zaklinacz";
                                    zdrowie = 100;
                                    mana = 130;
                                    pancerz = 50;
                                    Siła = 1;
                                    ZrozumienieIntuicji = 2;
                                    MagiaChaotyczna = 2;
                                    MagiaEteru = 2;
                                    MagiaPowietrza = 1;
                                    IntuicjaWalki = 2;
                                    SztukaWalkiBroniaBiala = 1;
                                    break;
                                case 22:
                                    className = "Templariusz";
                                    zdrowie = 140;
                                    mana = 100;
                                    pancerz = 270;
                                    Siła = 2;
                                    TargowanieSie = 1;
                                    HeroicznyNatarcie = 1;
                                    ModyfikacjaRzeczywistości = 1;
                                    MagiaOgnia = 4;
                                    MistrzostwoIluzji = 2;
                                    Precyzja = 1;
                                    break;
                                case 23:
                                    className = "Biskup";
                                    zdrowie = 80;
                                    mana = 500;
                                    pancerz = 70;
                                    Siła = 1;
                                    PogłębioneZrozumienieMagii = 2;
                                    MagiaSłowa = 3;
                                    Kryptografia = 1;
                                    MagiaŚwiatła = 2;
                                    TargowanieSie = 1;
                                    UdzielanieMocy = 1;
                                    break;
                                case 24:
                                    className = "Szlachcic";
                                    zdrowie = 180;
                                    mana = 180;
                                    pancerz = 90;
                                    Siła = 2;
                                    Zręczność = 3;
                                    CharyzmaBojowa = 4;
                                    Perswazja = 2;
                                    TargowanieSie = 1;
                                    break;
                                case 25:
                                    className = "Drwal";
                                    zdrowie = 200;
                                    mana = 30;
                                    pancerz = 50;
                                    Siła = 3;
                                    Improwizacja = 2;
                                    Wytrzymałość = 3;
                                    WyostrzoneZmysły = 1;
                                    UmiejętnościPrzetrwania = 2;
                                    PrzetrwanieWWarunkachEkstremalnych = 1;
                                    PrzemierzanieTerenu = 1;
                                    break;
                                case 26:
                                    className = "Samurai";
                                    zdrowie = 100;
                                    mana = 99;
                                    pancerz = 200;
                                    Siła = 2;
                                    yingYang = 4;
                                    OdpornośćMagiczna = 3;
                                    BieganieKonia = 2;
                                    SiłaWoli = 1;
                                    break;
                                case 27:
                                    className = "Poszukiwacz przygód";
                                    zdrowie = 130;
                                    mana = 70;
                                    pancerz = 60;
                                    Siła = 2;
                                    Instynkt = 2;
                                    Intuicja = 3;
                                    WyczuciePoezji = 1;
                                    UmiejętnościPrzetrwania = 2;
                                    PrzemierzanieTerenu = 2;
                                    break;
                                case 28:
                                    className = "Kowal";
                                    zdrowie = 330;
                                    mana = 100;
                                    pancerz = 60;
                                    Siła = 3;
                                    Rzemiosło = 5;
                                    IntuicjaTechnologiczna = 2;
                                    Improwizacja = 3;
                                    break;
                                case 29:
                                    className = "Generał";
                                    zdrowie = 230;
                                    mana = 130;
                                    pancerz = 60;
                                    Siła = 2;
                                    Taktyka = 4;
                                    DowodzenieArmiami = 4;
                                    TargowanieSie = 2;
                                    break;
                                case 30:
                                    className = "Architekt";
                                    zdrowie = 90;
                                    mana = 230;
                                    pancerz = 30;
                                    Siła = 1;
                                    ManipulacjaCzasem = 3;
                                    TworzeniePortali = 4;
                                    MagiczneTarcze = 3;
                                    break;
                                case 31:
                                    className = "Prorok";
                                    zdrowie = 50;
                                    mana = 290;
                                    pancerz = 70;
                                    Siła = 1;
                                    WyczuciePoezji = 1;
                                    InterpretacjaZnaków = 3;
                                    PrzewidywanieZagrożeń = 3;
                                    WizjaMistyczna = 2;
                                    break;
                                case 32:
                                    className = "Heretyk";
                                    zdrowie = 130;
                                    mana = 777;
                                    pancerz = 70;
                                    Siła = 1;
                                    SztukaPrzeklęta = 6;
                                    MagiaCiemności = 2;
                                    Kryptografia = 2;
                                    break;
                                case 33:
                                    className = "Wygnaniec";
                                    zdrowie = 100;
                                    mana = 150;
                                    pancerz = 40;
                                    Siła = 3;
                                    Skrytobójstwo = 3;
                                    RozbrajaniePulapek = 2;
                                    Kopnięcie = 1;
                                    Śledzenie = 2;
                                    Elastyczność = 2;
                                    break;
                                case 34:
                                    className = "Fanatyk";
                                    zdrowie = 160;
                                    mana = 120;
                                    pancerz = 70;
                                    Siła = 1;
                                    Perswazja = 5;
                                    WywoływanieKlątw = 3;
                                    MagiaPustki = 2;
                                    break;
                                case 35:
                                    className = "Włuczęga";
                                    zdrowie = 60;
                                    mana = 120;
                                    pancerz = 70;
                                    Siła = 2;
                                    ZdolnośćMaskowania = 2;
                                    Czujność = 2;
                                    Fałszerstwo = 4;
                                    Plotkowanie = 1;
                                    break;
                                case 36:
                                    className = "Skryba";
                                    zdrowie = 80;
                                    mana = 160;
                                    pancerz = 20;
                                    Siła = 1;
                                    Kryptografia = 4;
                                    Śledzenie = 2;
                                    ZnajomośćJezykowObcych = 1;
                                    Plotkowanie = 2;
                                    Perswazja = 1;
                                    break;
                                case 37:
                                    className = "Łowca Demonów";
                                    zdrowie = 160;
                                    mana = 130;
                                    pancerz = 100;
                                    Siła = 2;
                                    MagiaŚwiatła = 2;
                                    MagiaKrwi = 3;
                                    OdpornośćMagiczna = 3;
                                    WykorzystanieSrodowiska = 2;
                                    break;
                                case 38:
                                    className = "Zabujca Besti";
                                    zdrowie = 350;
                                    mana = 180;
                                    pancerz = 60;
                                    Siła = 4;
                                    ZmienianieKształtu = 4;
                                    Wytrzymałość = 4;
                                    WydobycieWglądu = 2;
                                    break;
                                case 39:
                                    className = "Uzdrowiciel";
                                    zdrowie = 150;
                                    mana = 250;
                                    pancerz = 20;
                                    Siła = 1;
                                    Sprint = 3;
                                    WarzenieEliksirów = 1;
                                    UdzielanieMocy = 1;
                                    MagiaŚwiatła = 2;
                                    WiedzaMedyczna = 2;
                                    Medytacja = 1;
                                    break;
                                case 40:
                                    className = "Poeta";
                                    zdrowie = 120;
                                    mana = 200;
                                    pancerz = 40;
                                    Siła = 1;
                                    Sprint = 1;
                                    WyczuciePoezji = 3;
                                    WykorzystanieSrodowiska = 2;
                                    Wiedza = 4;
                                    WrodzonaWiedza = 1;
                                    break;
                                case 41:
                                    className = "Wiesniak";
                                    zdrowie = 120;
                                    mana = 200;
                                    pancerz = 40;
                                    Siła = 1;
                                    Sprint = 2;
                                    Perswazja = 2;
                                    RozbrajaniePulapek = 4;
                                    Samodoskonalenie = 1;
                                    Bieg = 1;
                                    break;
                                case 42:
                                    className = "Mag Pustki";
                                    zdrowie = 100;
                                    mana = 200;
                                    pancerz = 30;
                                    Siła = 1;
                                    MagiaPustki = 6;
                                    MagiaChaotyczna = 2;
                                    PogłębioneZrozumienieMagii = 2;
                                    break;
                                case 43:
                                    className = "Bochater";
                                    zdrowie = 400;
                                    mana = 500;
                                    pancerz = 400;
                                    Siła = 5;
                                    WytrzymaloscPsychiczna = 3;
                                    Wytrzymałość = 3;
                                    Ukrywanie = 3;
                                    OdpornośćMagiczna = 3;
                                    Czujność = 3;
                                    WizjaMistyczna = 1;
                                    ManipulacjaEnergią = 3;
                                    MagiczneTarcze = 3;
                                    Szczęście = 3;
                                    MagiaWiatru = 3;
                                    AbsorpcjaEnergii = 3;
                                    Zwinność = 3;
                                    Telepatia = 3;
                                    break;
                                case 44:
                                    className = "Bard";
                                    zdrowie = 100;
                                    mana = 300;
                                    pancerz = 100;
                                    Siła = 1;
                                    WyczuciePoezji = 3;
                                    poetyckosc = 3;
                                    UdzielanieMocy = 3;
                                    TworzeniePortali = 1;
                                    break;
                                case 45:
                                    className = "Nimfa Ognia";
                                    zdrowie = 100;
                                    mana = 1000;
                                    pancerz = 100;
                                    Siła = 1;
                                    MagiaOgnia = 4;
                                    MagiaWiatru = 4;
                                    MagiczneTarcze = 2;
                                    WrodzonaWiedza = 5;
                                    ManipulacjaCharyzmą = 6;
                                    break;
                                case 46:
                                    className = "Nimfa Wodna";
                                    zdrowie = 100;
                                    mana = 1000;
                                    pancerz = 100;
                                    Siła = 1;
                                    MagiaLodu = 4;
                                    MagiaWiatru = 4;
                                    MagiczneTarcze = 2;
                                    WrodzonaWiedza = 5;
                                    ManipulacjaCharyzmą = 6;
                                    break;
                                case 47:
                                    className = "Tropiciel";
                                    zdrowie = 160;
                                    mana = 100;
                                    pancerz = 100;
                                    Siła = 3;
                                    Tropienie = 4;
                                    ElastycznośćMentalna = 2;
                                    Elastyczność = 2;
                                    Precyzja = 2;
                                    break;
                                case 48:
                                    className = "Duch Lasu";
                                    zdrowie = 160;
                                    mana = 500;
                                    pancerz = 100;

                                    PogłębioneZrozumienieMagii = 5;
                                    RozerwanieDusz = 3;
                                    SpecjalizacjaElementalistyczna = 3;
                                    Ziołolecznictwo = 2;
                                    MagiaZiemi = 2;
                                    WięźZeSpirytamiNatury = 5;
                                    break;
                                case 49:
                                    className = "Opiekun";
                                    zdrowie = 160;
                                    mana = 500;
                                    pancerz = 100;
                                    Siła = 2;
                                    MagiczneTarcze = 5;
                                    Strażnik = 3;
                                    PrzełamywanieGranicy = 2;
                                    break;
                                case 50:
                                    className = "Krzyrzak";
                                    zdrowie = 120;
                                    mana = 100;
                                    pancerz = 120;
                                    Siła = 2;
                                    Unikanie = 1;
                                    OdpornośćMagiczna = 1;
                                    OdczytywanieEmocji = 2;
                                    WyczuciePoezji = 1;
                                    Improwizacja = 4;
                                    MagiaChaotyczna = 1;
                                    break;
                                case 51:
                                    className = "Champion";
                                    zdrowie = 170;
                                    mana = 150;
                                    pancerz = 170;
                                    Siła = 3;
                                    Precyzja = 3;
                                    PracaNadCiałem = 3;
                                    KontrolaGrawitacji = 1;
                                    CharyzmaBojowa = 2;
                                    AbsorpcjaEnergii = 1;
                                    break;
                                case 52:
                                    className = "Driada";
                                    zdrowie = 100;
                                    mana = 200;
                                    pancerz = 100;
                                    Siła = 1;
                                    WięźZeSpirytamiNatury = 5;
                                    Ziołolecznictwo = 3;
                                    ZdolnośćMaskowania = 2;
                                    break;
                                case 53:
                                    className = "Niewolnik";
                                    zdrowie = 100;
                                    mana = 100;
                                    pancerz = 100;
                                    Siła = 2;
                                    Unikanie = 3;
                                    Akrobatyka = 2;
                                    Refleks = 3;
                                    Improwizacja = 2;
                                    break;
                                case 54:
                                    className = "Wiedzma";
                                    zdrowie = 100;
                                    mana = 200;
                                    pancerz = 51;
                                    Siła = 1;
                                    PogłębioneZrozumienieMagii = 5;
                                    RzucanieCzarów = 4;
                                    WarzenieEliksirów = 1;
                                    break;
                                case 55:
                                    className = "Dezerter";
                                    zdrowie = 80;
                                    mana = 100;
                                    pancerz = 200;
                                    Siła = 2;
                                    Szczęście = 2;
                                    HeroicznyNatarcie = 2;
                                    PrzewidywanieZagrożeń = 2;
                                    SztukaWalkiBroniaBiala = 2;
                                    WytrzymaloscPsychiczna = 2;
                                    break;
                                case 56:
                                    className = "Szuja";
                                    zdrowie = 95;
                                    mana = 100;
                                    pancerz = 100;
                                    Siła = 2;
                                    Ukrywanie = 1;
                                    Śledzenie = 1;
                                    Sprint = 3;
                                    Koncentracja = 1;
                                    Penetracja = 2;
                                    Perswazja = -2;
                                    break;
                                case 57:
                                    className = "Informatyk";
                                    zdrowie = 60;
                                    mana = 100;
                                    pancerz = 40;
                                    Siła = 2;
                                    Sprint = 3;
                                    Bieg = 3;
                                    Ukrywanie = 3;
                                    PrzyciemnienieMentalne = 1;
                                    break;
                                case 58:
                                    className = "Gurnik";
                                    zdrowie = 100;
                                    mana = 100;
                                    pancerz = 40;
                                    Siła = 2;
                                    Wytrzymałość = 7;
                                    WyczuciePoezji = 2;
                                    PrzetrwanieWWarunkachEkstremalnych = 1;
                                    break;
                                case 59:
                                    className = "Przeklęty";
                                    zdrowie = 50;
                                    mana = 300;
                                    pancerz = 40;
                                    Siła = 2;
                                    MagiaKrwi = 5;
                                    SztukaPrzeklęta = 5;
                                    ZdolnośćMaskowania = 2;
                                    RozerwanieDusz = 3;
                                    break;
                                case 60:
                                    className = "Uczeń";
                                    zdrowie = 170;
                                    mana = 200;
                                    pancerz = 150;
                                    Siła = 1;
                                    SztukaWalkiBroniaBiala = 1;
                                    KontrolaGrawitacji = 1;
                                    Telekineza = 1;
                                    Antygrawitacja = 1;
                                    ManipulacjaEnergią = 1;
                                    Samodoskonalenie = 2;
                                    Nekromancja = 1;
                                    Instynkt = 1;
                                    PracaNadCiałem = 1;
                                    break;
                                case 61:
                                    className = "Tamer";
                                    zdrowie = 150;
                                    mana = 280;
                                    pancerz = 90;
                                    Siła = 2;
                                    ManipulacjaCharyzmą = 2;
                                    CharyzmaZwierząt = 3;
                                    OswojenieZwierząt = 3;
                                    Szczęście = 2;
                                    break;
                                default:

                                    break;
                            }
                            #endregion
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy format. Wprowadź liczbę całkowitą.");
                        }


                        Console.Clear();
                        Console.WriteLine($"   ┌───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                        Console.WriteLine($"   │                                                                                RASY POSTACI RPG                                                                                           │");
                        Console.WriteLine($"   │                                                                WYBIERZ KLASSE POSTACI DO CI TO -+ 5/10 DO STATYSTYK                                                                       │");
                        Console.WriteLine($"   │ 1-KRASNOLUD  4-WYSOKI ELF 7-GNOM     10-GOBLIN   13-LIZARDFOLK 16-KENKU   19-YUAN-TI 22-WARFORGER 25-GOLIAD  28-TORTLE     31-SATYR       34-CHANGELING  37-CENTAUR  40-DHAMPIR           │");
                        Console.WriteLine($"   │ 2-ELF        5-ORK        8-HALFLING 11-FAUN     14-TIEFLING   17-ONI     20-GITH    23-GENASI    26-DROW    29-SVIRFNRBIL 32-FIRRAN      35-TRITON      38-TENGU                         │");
                        Console.WriteLine($"   │ 3-MROCZY ELF 6.CZŁOWIEK   9-KOTOMRF  12-MINOTAUR 15-AARAKOCRA  18-FIRBOLG 21-KOBOLD  24-SHIFTER   27-AASIMAR 30-SYLPH      33-SVIRNEBLIN  36-TABAXI      39-WARLOCK                       │");
                        Console.WriteLine($"   └───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");

                        int InputRasy = int.Parse(Console.ReadLine());
                        #region //rasy
                        string klasa = "";
                        switch (InputRasy)
                        {
                            case 1://Krasnolud 
                                Siła -= 1;
                                pancerz += 20;
                                klasa = "Krasnal";
                                break;
                            case 2://Elf 
                                Zręczność += 5;
                                pancerz -= 10;
                                klasa = "Elf";
                                break;
                            case 3://Mroczny elf 
                                Wiedza += 5;
                                zdrowie += 10;
                                klasa = "Mroczny Elf";
                                break;
                            case 4://Wysoki elf
                                WrodzonaWiedza += 5;
                                zdrowie -= 10;
                                klasa = "Wysoli Elf";
                                break;
                            case 5://Ork 
                                Siła += 5;
                                zdrowie -= 10;
                                klasa = "Ork";
                                break;
                            case 6://Człowiek 
                                Zwinność += 1;
                                klasa = "Człowiek";
                                break;
                            case 7://Gnom 
                                Wiedza += 5;
                                mana -= 10;
                                klasa = "Gnome";
                                break;
                            case 8://Halfling 
                                Zręczność += 5;
                                mana -= 10;
                                klasa = "Halfling";
                                break;
                            case 9://Kotmorf 
                                Elastyczność += 5;
                                zdrowie -= 20;
                                klasa = "Kotmorf";
                                break;
                            case 10://Goblin 
                                pancerz -= 10;
                                mana -= 10;
                                klasa = "Goblin";
                                break;
                            case 11://Faun 
                                poetyckosc += 5;
                                pancerz += 10;
                                klasa = "Faun";
                                break;
                            case 12://Minotaur 
                                Siła += 5;
                                mana -= 10;
                                klasa = "Minotaur";
                                break;
                            case 13://Lizardfolk 
                                Wytrzymałość += 5;
                                mana -= 10;
                                klasa = "LizordFolk";
                                break;
                            case 14://Tiefling 
                                Wiedza += 5;
                                pancerz -= 10;
                                klasa = "Tiefling";
                                break;
                            case 15://Aarakocra 
                                Zwinność += 5;
                                pancerz -= 10;
                                klasa = "Aarakocra";
                                break;
                            case 16://Kenku 
                                SztukaWalkiBroniaBiala += 5;
                                pancerz -= 10;
                                klasa = "Kenku";
                                break;
                            case 17://oni
                                Siła += 5;
                                zdrowie -= 10;
                                klasa = "Oni";
                                break;
                            case 18://Firbolg 
                                Wiedza += 5;
                                pancerz -= 10;
                                klasa = "Firbolg";
                                break;
                            case 19://Yuan-ti 
                                Wiedza += 5;
                                SztukaPrzeklęta += 1;
                                pancerz -= 10;
                                klasa = "Yuan-ti";
                                break;
                            case 20://Gith 
                                Wiedza += 5;
                                Telepatia += 1;
                                zdrowie -= 10;
                                klasa = "Gith";
                                break;
                            case 21://Kobold 
                                Zwinność += 2;
                                RozbrajaniePulapek += 4;
                                klasa = "Kobold";
                                break;
                            case 22://Warforged 
                                pancerz += 20;
                                Wytrzymałość += 2;
                                Siła -= 1;
                                klasa = "WarForged";
                                break;
                            case 23://Genasi 
                                Zręczność += 3;
                                zdrowie -= 10;
                                klasa = "Genasi";
                                break;
                            case 24://Shifter 
                                Siła += 4;
                                ZmienianieKształtu += 1;
                                pancerz -= 20;
                                klasa = "Shifter";
                                break;
                            case 25://Goliath 
                                Wytrzymałość += 4;
                                SiłaWoli += 1;
                                mana -= 20;
                                klasa = "Goliad";
                                break;
                            case 26://Drow 
                                Zwinność += 4;
                                Ukrywanie += 1;
                                zdrowie -= 10;
                                klasa = "Drow";
                                break;
                            case 27://Aasimar 
                                MagiaŚwiatła += 2;
                                Wiedza += 3;
                                mana -= 20;
                                klasa = "Aasimar";
                                break;
                            case 28://Tortle 
                                Wytrzymałość += 2;
                                pancerz += 10;
                                mana -= 20;
                                klasa = "Tortle";
                                break;
                            case 29://Svirfnrbil 
                                Wiedza += 3;
                                Ziołolecznictwo += 2;
                                pancerz -= 20;
                                klasa = "Svirfnrbil";
                                break;
                            case 30://Sylph 
                                Zwinność += 4;
                                Niewidzialność += 1;
                                zdrowie -= 10;
                                klasa = "Sylph";
                                break;
                            case 31://Satyr 
                                poetyckosc += 3;
                                WyczuciePoezji += 1;
                                klasa = "Satyr";
                                break;
                            case 32://Firran 
                                Zwinność += 4;
                                klasa = "Firran";
                                break;
                            case 33://Svirfneblin 
                                Zręczność += 2;
                                Instynkt += 1;
                                klasa = "Svirfneblin";
                                break;
                            case 34://Changeling 
                                Zręczność += 2;
                                Ukrywanie += 3;
                                pancerz -= 2;
                                klasa = "ChangeLing";
                                break;
                            case 35://Triton 
                                pancerz -= 20;
                                WytrzymaloscPsychiczna = 5;
                                klasa = "Trition";
                                break;
                            case 36://Tabaxi 
                                Zwinność += 2;
                                Rzemiosło += 3;
                                pancerz -= 10;
                                klasa = "Tabaxi";
                                break;
                            case 37://Centaur 
                                Siła += 3;
                                Wytrzymałość += 1;
                                break;
                                klasa = "Centaur";
                            case 38://Tengu 
                                HeroicznyNatarcie += 1;
                                klasa = "Tengu";
                                break;
                            case 39://Warlock 
                                Wytrzymałość += 2;
                                PogłębioneZrozumienieMagii += 2;
                                zdrowie -= 10;
                                klasa = "Warlock";
                                break;
                            case 40://Dhampir 
                                MagiaCiemności += 3;
                                Wiedza += 2;
                                mana -= 10;
                                klasa = "Dhampir";
                                break;
                            default:
                                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                break;
                        }
                        #endregion
                        #region//zapyrtanie po wartośi
                        /*
                        Console.WriteLine($"Wybrałeś Klase: {className}");
                        Console.WriteLine($"Zdrowie: {zdrowie}");
                        Console.WriteLine($"Mana: {mana}");
                        Console.WriteLine($"Pancerz: {pancerz}");
                        Console.WriteLine($"Siła: {Siła}");
                        if (Zręczność != 0) Console.WriteLine($"Zręczność: {Zręczność}");
                        if (Wiedza != 0) Console.WriteLine($"Wiedza: {Wiedza}");
                        if (Wytrzymałość != 0) Console.WriteLine($"Wytrzymałość: {Wytrzymałość}");
                        if (Charyzma != 0) Console.WriteLine($"Charyzma: {Charyzma}");
                        if (Skrytobójstwo != 0) Console.WriteLine($"Skrytobójstwo: {Skrytobójstwo}");
                        if (OdpornośćMagiczna != 0) Console.WriteLine($"Odporność magiczna: {OdpornośćMagiczna}");
                        if (Rzemiosło != 0) Console.WriteLine($"Rzemiosło: {Rzemiosło}");
                        if (BieganieKonia != 0) Console.WriteLine($"Bieganie konia: {BieganieKonia}");
                        if (Elastyczność != 0) Console.WriteLine($"Elastyczność: {Elastyczność}");
                        if (Instynkt != 0) Console.WriteLine($"Instynkt: {Instynkt}");
                        if (CharyzmaBojowa != 0) Console.WriteLine($"Charyzma bojowa: {CharyzmaBojowa}");
                        if (Koncentracja != 0) Console.WriteLine($"Koncentracja: {Koncentracja}");
                        if (UmiejętnościPrzetrwania != 0) Console.WriteLine($"Umiejętności przetrwania: {UmiejętnościPrzetrwania}");
                        if (Ukrywanie != 0) Console.WriteLine($"Ukrywanie: {Ukrywanie}");
                        if (Śledzenie != 0) Console.WriteLine($"Śledzenie: {Śledzenie}");
                        if (Intuicja != 0) Console.WriteLine($"Intuicja: {Intuicja}");
                        if (SiłaWoli != 0) Console.WriteLine($"Siła woli: {SiłaWoli}");
                        if (CharyzmaLidera != 0) Console.WriteLine($"Charyzma lidera: {CharyzmaLidera}");
                        if (ZrozumienieIntuicji != 0) Console.WriteLine($"Zrozumienie intuicji: {ZrozumienieIntuicji}");
                        if (ElastycznośćMentalna != 0) Console.WriteLine($"Elastyczność mentalna: {ElastycznośćMentalna}");
                        if (Medytacja != 0) Console.WriteLine($"Medytacja: {Medytacja}");
                        if (Negocjacje != 0) Console.WriteLine($"Negocjacje: {Negocjacje}");
                        if (IntuicjaWalki != 0) Console.WriteLine($"Intuicja walki: {IntuicjaWalki}");
                        if (CharyzmaZwierząt != 0) Console.WriteLine($"Charyzma zwierząt: {CharyzmaZwierząt}");
                        if (Nekromancja != 0) Console.WriteLine($"Nekromancja: {Nekromancja}");
                        if (WrodzonaWiedza != 0) Console.WriteLine($"Wrodzona wiedza: {WrodzonaWiedza}");
                        if (ZdolnośćMaskowania != 0) Console.WriteLine($"Zdolność maskowania: {ZdolnośćMaskowania}");
                        if (WyostrzoneZmysły != 0) Console.WriteLine($"Wyostrzone zmysły: {WyostrzoneZmysły}");
                        if (Czujność != 0) Console.WriteLine($"Czujność: {Czujność}");
                        if (Samodoskonalenie != 0) Console.WriteLine($"Samodoskonalenie: {Samodoskonalenie}");
                        if (Akrobatyka != 0) Console.WriteLine($"Akrobatyka: {Akrobatyka}");
                        if (WyczuciePoezji != 0) Console.WriteLine($"Wyczucie poezji: {WyczuciePoezji}");
                        if (MyślenieAnalityczne != 0) Console.WriteLine($"Myślenie analityczne: {MyślenieAnalityczne}");
                        if (Bieg != 0) Console.WriteLine($"Bieg: {Bieg}");
                        if (Kopnięcie != 0) Console.WriteLine($"Kopnięcie: {Kopnięcie}");
                        if (Refleks != 0) Console.WriteLine($"Refleks: {Refleks}");
                        if (IntuicjaTechnologiczna != 0) Console.WriteLine($"Intuicja technologiczna: {IntuicjaTechnologiczna}");
                        if (PrzemierzanieTerenu != 0) Console.WriteLine($"Przemierzanie terenu: {PrzemierzanieTerenu}");
                        if (ManipulacjaEmocjonalna != 0) Console.WriteLine($"Manipulacja emocjonalna: {ManipulacjaEmocjonalna}");
                        if (SztukaPrzeklęta != 0) Console.WriteLine($"Sztuka przeklęta: {SztukaPrzeklęta}");
                        if (ManipulacjaCharyzmą != 0) Console.WriteLine($"Manipulacja charyzmą: {ManipulacjaCharyzmą}");
                        if (WizjaMistyczna != 0) Console.WriteLine($"Wizja mistyczna: {WizjaMistyczna}");
                        if (PrzyciemnienieMentalne != 0) Console.WriteLine($"Przyciemnienie mentalne: {PrzyciemnienieMentalne}");
                        if (Fałszerstwo != 0) Console.WriteLine($"Fałszerstwo: {Fałszerstwo}");
                        if (RzucanieCzarów != 0) Console.WriteLine($"Rzucanie czarów: {RzucanieCzarów}");
                        if (WarzenieEliksirów != 0) Console.WriteLine($"Warzenie eliksirów: {WarzenieEliksirów}");
                        if (ManipulacjaEnergią != 0) Console.WriteLine($"Manipulacja energią: {ManipulacjaEnergią}");
                        if (ManipulacjaCzasem != 0) Console.WriteLine($"Manipulacja czasem: {ManipulacjaCzasem}");
                        if (WięźZeSpirytamiNatury != 0) Console.WriteLine($"Więź ze spirytami natury: {WięźZeSpirytamiNatury}");
                        if (MistrzostwoIluzji != 0) Console.WriteLine($"Mistrzostwo iluzji: {MistrzostwoIluzji}");
                        if (MagiaKrwi != 0) Console.WriteLine($"Magia krwi: {MagiaKrwi}");
                        if (RozerwanieDusz != 0) Console.WriteLine($"Rozerwanie dusz: {RozerwanieDusz}");
                        if (Penetracja != 0) Console.WriteLine($"Penetracja: {Penetracja}");
                        if (CzytanieAury != 0) Console.WriteLine($"Czytanie aury: {CzytanieAury}");
                        if (TworzeniePortali != 0) Console.WriteLine($"Tworzenie portali: {TworzeniePortali}");
                        if (MagiczneTarcze != 0) Console.WriteLine($"Magiczne tarcze: {MagiczneTarcze}");
                        if (ModyfikacjaRzeczywistości != 0) Console.WriteLine($"Modyfikacja rzeczywistości: {ModyfikacjaRzeczywistości}");
                        if (PrzełamywanieGranicy != 0) Console.WriteLine($"Przełamywanie granicy: {PrzełamywanieGranicy}");
                        if (ManipulacjaEnergiąŻyciową != 0) Console.WriteLine($"Manipulacja energią życiową: {ManipulacjaEnergiąŻyciową}");
                        if (ManipulacjaPrzestrzenią != 0) Console.WriteLine($"Manipulacja przestrzenią: {ManipulacjaPrzestrzenią}");
                        if (Ziołolecznictwo != 0) Console.WriteLine($"Ziołolecznictwo: {Ziołolecznictwo}");
                        if (Unikanie != 0) Console.WriteLine($"Unikanie: {Unikanie}");
                        if (MaskowanieMagii != 0) Console.WriteLine($"Maskowanie magii: {MaskowanieMagii}");
                        if (WywoływanieKlątw != 0) Console.WriteLine($"Wywoływanie klątw: {WywoływanieKlątw}");
                        if (PrzetrwanieWWarunkachEkstremalnych != 0) Console.WriteLine($"Przetrwanie w warunkach ekstremalnych: {PrzetrwanieWWarunkachEkstremalnych}");
                        if (UdzielanieMocy != 0) Console.WriteLine($"Udzielanie mocy: {UdzielanieMocy}");
                        if (DowodzenieArmiami != 0) Console.WriteLine($"Dowodzenie armiami: {DowodzenieArmiami}");
                        if (Mędrzec != 0) Console.WriteLine($"Mędrzec: {Mędrzec}");
                        if (KontrolaGrawitacji != 0) Console.WriteLine($"Kontrola grawitacji: {KontrolaGrawitacji}");
                        if (Archeologia != 0) Console.WriteLine($"Archeologia: {Archeologia}");
                        if (InterpretacjaZnaków != 0) Console.WriteLine($"Interpretacja znaków: {InterpretacjaZnaków}");
                        if (Improwizacja != 0) Console.WriteLine($"Improwizacja: {Improwizacja}");
                        if (TworzeniePólEnergetycznych != 0) Console.WriteLine($"Tworzenie pól energetycznych: {TworzeniePólEnergetycznych}");
                        if (Telekineza != 0) Console.WriteLine($"Telekineza: {Telekineza}");
                        if (ZmienianieKształtu != 0) Console.WriteLine($"Zmienianie kształtu: {ZmienianieKształtu}");
                        if (OswojenieZwierząt != 0) Console.WriteLine($"Oswojenie zwierząt: {OswojenieZwierząt}");
                        if (MagiaSłowa != 0) Console.WriteLine($"Magia słowa: {MagiaSłowa}");
                        if (Antygrawitacja != 0) Console.WriteLine($"Antygrawitacja: {Antygrawitacja}");
                        if (Szczęście != 0) Console.WriteLine($"Szczęście: {Szczęście}");
                        if (PracaNadCiałem != 0) Console.WriteLine($"Praca nad ciałem: {PracaNadCiałem}");
                        if (HeroicznyNatarcie != 0) Console.WriteLine($"Heroiczny natarcie: {HeroicznyNatarcie}");
                        if (MagiaŚwiatła != 0) Console.WriteLine($"Magia światła: {MagiaŚwiatła}");
                        if (MagiaCiemności != 0) Console.WriteLine($"Magia ciemności: {MagiaCiemności}");
                        if (MagiaOgnia != 0) Console.WriteLine($"Magia ognia: {MagiaOgnia}");
                        if (MagiaWiatru != 0) Console.WriteLine($"Magia wiatru: {MagiaWiatru}");
                        if (Precyzja != 0) Console.WriteLine($"Precyzja: {Precyzja}");
                        if (MagiaZiemi != 0) Console.WriteLine($"Magia ziemi: {MagiaZiemi}");
                        if (MagiaPowietrza != 0) Console.WriteLine($"Magia powietrza: {MagiaPowietrza}");
                        if (MagiaPustki != 0) Console.WriteLine($"Magia pustki: {MagiaPustki}");
                        if (Strażnik != 0) Console.WriteLine($"Strażnik: {Strażnik}");
                        if (Sprint != 0) Console.WriteLine($"Sprint: {Sprint}");
                        if (AbsorpcjaEnergii != 0) Console.WriteLine($"Absorpcja energii: {AbsorpcjaEnergii}");
                        if (OdczytywanieEmocji != 0) Console.WriteLine($"Odczytywanie emocji: {OdczytywanieEmocji}");
                        if (WydobycieWglądu != 0) Console.WriteLine($"Wydobycie wglądu: {WydobycieWglądu}");
                        if (MagiaLodu != 0) Console.WriteLine($"Magia lodu: {MagiaLodu}");
                        if (Niewidzialność != 0) Console.WriteLine($"Niewidzialność: {Niewidzialność}");
                        if (MagiaChaotyczna != 0) Console.WriteLine($"Magia chaotyczna: {MagiaChaotyczna}");
                        if (PrzewidywanieZagrożeń != 0) Console.WriteLine($"Przewidywanie zagrożeń: {PrzewidywanieZagrożeń}");
                        if (MagiaEteru != 0) Console.WriteLine($"Magia eteru: {MagiaEteru}");
                        if (Perswazja != 0) Console.WriteLine($"Perswazja: {Perswazja}");
                        if (Tropienie != 0) Console.WriteLine($"Tropienie: {Tropienie}");
                        if (Mediacja != 0) Console.WriteLine($"Mediacja: {Mediacja}");
                        if (WiedzaMedyczna != 0) Console.WriteLine($"Wiedza medyczna: {WiedzaMedyczna}");
                        if (TargowanieSie != 0) Console.WriteLine($"Targowanie się: {TargowanieSie}");
                        if (Taktyka != 0) Console.WriteLine($"Taktyka: {Taktyka}");
                        if (Plotkowanie != 0) Console.WriteLine($"Plotkowanie: {Plotkowanie}");
                        if (Dedukcja != 0) Console.WriteLine($"Dedukcja: {Dedukcja}");
                        if (WytrzymaloscPsychiczna != 0) Console.WriteLine($"Wytrzymałość psychiczna: {WytrzymaloscPsychiczna}");
                        if (SpecjalizacjaElementalistyczna != 0) Console.WriteLine($"Specjalizacja elementalistyczna: {SpecjalizacjaElementalistyczna}");
                        if (Fizyka != 0) Console.WriteLine($"Fizyka: {Fizyka}");
                        if (Kryptografia != 0) Console.WriteLine($"Kryptografia: {Kryptografia}");
                        if (RozbrajaniePulapek != 0) Console.WriteLine($"Rozbrajanie pułapek: {RozbrajaniePulapek}");
                        if (Zwinność != 0) Console.WriteLine($"Zwinność: {Zwinność}");
                        if (PogłębioneZrozumienieMagii != 0) Console.WriteLine($"Pogłębione zrozumienie magii: {PogłębioneZrozumienieMagii}");
                        if (ZnajomośćJezykowObcych != 0) Console.WriteLine($"Znajomość języków obcych: {ZnajomośćJezykowObcych}");
                        if (WykorzystanieSrodowiska != 0) Console.WriteLine($"Wykorzystanie środowiska: {WykorzystanieSrodowiska}");
                        if (Telepatia != 0) Console.WriteLine($"Telepatia: {Telepatia}");
                        if (SztukaWalkiBroniaBiala != 0) Console.WriteLine($"Sztuka walki bronią białą: {SztukaWalkiBroniaBiala}");
                        if (yingYang != 0) Console.WriteLine($"Ying Yang: {yingYang}");
                        Console.WriteLine("Klikin jakis prtzycisk by kontynułowć");
                        Console.ReadLine();
                        */
                        #endregion
                        Console.Clear();
                        // Game loop
                        Console.Clear();
                        #region//Wybur lokalizacji
                        Console.WriteLine($"   ┌───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                        Console.WriteLine($"   │                                                                                WYBUR LOKALIZACJI STARTOWEJ                                                                                │");
                        Console.WriteLine($"   │ 1-WIOSKA NA OBRZERZACH LASU      4-OPUSZCZONY ZAMEK           7-PODZIEMIA STARORZYTNEJ ŚWIĄTYNI    10-WYSEPKA NA JEZIORZE             13-KARCZMA W PODRZĘDNYM MIEŚCIE NA SZLAKU HANDLOWYM │");
                        Console.WriteLine($"   │ 2-STARA WIERZA W LESIE           5-JASKINA NA ZBOCZU GURY     8-LEŚLNA POLANA                      11-PODWODNA JASKINIA               14-OSADA NA PUSTYMI                                 │");
                        Console.WriteLine($"   │ 3-PORTOWA DZIELICA OBOK MORZA    6-TAJEMNICZA WYSPA           9-MAGICZNY LABIRYNT                  12-GURZYSTY TEREN Z GURKAMI I DOLINAMI                                                 │");
                        Console.WriteLine($"   └───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                        Console.Write(">>");
                        int InputLokalizaja = int.Parse(Console.ReadLine());
                        #endregion
                        #region//Lokalizacje startowe

                        switch (InputLokalizaja)
                        {
                            case 1:
                                Console.WriteLine("1- Wioska na obrzeżach lasu:\nWioska ta spoczywa na pograniczu gęstych drzew i dzikiej przyrody. Zbudowane z drewnianych chat,\n które otaczają centralny plac, gdzie dzieci bawią się wesoło, a dorośli handlują lokalnymi produktami.\n Przez wioskę przepływa rwący strumień, nad którym łagodnie wygięty most umożliwia przemieszczanie się między jej dwoma brzegami.\n Spokój i harmonia są tutaj na porządku dziennym, a mieszkańy \nżyją zgodnie z naturą, szanując jej piękno i tajemnicę.");
                                WięźZeSpirytamiNatury += 1;
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("2- Stara wieża  na szczytach gór:\nWieża ta, starożytna i majestatyczna, wznosi się dumnie na najwyższym szczycie górskim,\n jak strażnik nad otaczającymi krajobrazami. Jej kamienna konstrukcja wydaje się przetrwać wieki, opowiadając historie minionych czasów.\n Z wierzchołka wieży rozpościera się zapierający dech w piersiach widok na rozległe doliny, \ngęste lasy i nieokiełznane rzeki. To miejsce, gdzie można oderwać się od zgiełku codzienności \ni zanurzyć w spokoju i pięknie natury, kontemplując majestatyczne\n góry i ich tajemnice.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("3- Portowa dzielnica miasta na brzegu morza:\nTa portowa dzielnica pulsuje życiem i działalnością od wczesnych godzin porannych do późnych nocnych godzin.\n Stare, kolorowe domki rybackie, przemalowane na pastelowe kolory, wystają spomiędzy gęstej mgły,\n unoszącej się nad morzem. Rybacy wracają z połowów, przynosząc ze sobą świeże łupy, które natychmiast trafiają na tutejsze targowiska. \nWąskie uliczki wypełnione są zapachami soli morskiej, świeżego rybnego smażenia i dźwiękami mew \nkążących w powietrzu. Portowa dzielnica emanuje energią i charakterem, \nprzyciągając zarówno mieszkańców, jak i turystów.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("4- Opuszczony zamek w głębi lasu:\nTen opuszczony zamek, zatopiony w głębi dzikiego lasu, wydaje się być zatopiony w czasie.\n Jego mury, choć pokryte mchem i porośnięte dziką roślinnością, wciąż emanują potężną aurą i tajemnicą. Wieże i krużganki,\n kiedyś majestatyczne, teraz stoją jako zwiędłe świadectwo przemijania. Wnętrze zamku jest pełne\n zapomnianych sal, w których echo dawnych czasów wciąż wydaje się płynąć.\n To miejsce wzbudza zarówno fascynację, jak i niepokój, przyciągając\n odważnych badaczy, gotowych odkrywać jego sekrety.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("5- Jaskinia na stromym zboczu góry:\nTa jaskinia, ukryta na stromym zboczu góry, jest schronieniem dla tych, którzy poszukują ciszy i spokoju. \nJej wejście otoczone jest dziką roślinnością, a wewnętrzne komory kryją w sobie bogactwo stalaktytów i stalagmitów.\n Światło słoneczne przebija się przez szczeliny w skale, oświetlając podziemne jeziora i korytarze. \nTo miejsce emanuje mistyczną energią, przyciągając \nzarówno badaczy, jak i poszukiwaczy wewnętrznego spokoju.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("6- Tajemnicza wyspa otoczona mgłą:\nTa tajemnicza wyspa, otoczona gęstą mgłą, budzi ciekawość i lęki tych, którzy próbują zbadać jej tajemnice.\n Jej brzegi są ostre i skaliste, a plaże pokryte są drobnym piaskiem i ukrytymi skarbami.\n Gęsta roślinność tropikalna przykrywa wnętrze wyspy, ukrywając w sobie starożytne ruiny i nieodkryte sekrety. \nNiezliczone opowieści krążą o tej wyspie, często pełne magii i legend, które\n przyciągają śmiałków gotowych odkryć prawdę za mgiełką.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("8- Podziemia starożytniej świątyni:\nTe podziemia, skryte pod starożytną świątynią, są labiryntem tajemnic i niebezpieczeństw. Komory i korytarze są pełne starożytnych\n artefaktów i rytuałów, które pragną zostać odkryte przez odważnych badaczy. \nŚciany są ozdobione rzeźbami i inskrypcjami, które opowiadają historie zapomnianych bogów i bohaterów. Wśród labiryntu czają\n się jednak niebezpieczeństwa, które próbują powstrzymać \nintruzów przed dotarciem do swoich tajemnic.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 8:
                                Console.WriteLine("8- Leśna polana z tajemniczymi ruinami:\nTa leśna polana, otoczona przez drzewa i dziką roślinność, kryje w sobie tajemnicze ruiny dawnych budowli.\n Ich pochodzenie i przeznaczenie pozostają enigmą, która przyciąga badaczy i poszukiwaczy przygód. \nWśród porośniętych mchem ścian i kolumn można odnaleźć starożytne artefakty i \nprzedmioty, które prowadzą do jeszcze większych zagadek i tajemnic ukrytych w głębi lasu.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 9:
                                Console.WriteLine("9- Magiczny labirynt pełen pułapek:\nTen magiczny labirynt, snujący się między drzewami i skałami, jest miejscem próby dla odważnych i sprytnych.\n Jego ścieżki zmieniają się i przemieszczają, utrudniając nawigację dla tych, którzy próbują go przemierzyć.\n Pułapki i zaklęcia czają się na każdym kroku, testując zdolności i determinację wędrowców.\n Tylko ci najbardziej przebiegli mogą ujrzeć światło na końcu\n labiryntu i odkryć jego największe tajemnice.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 10:
                                Console.WriteLine("10- Wysepka na jeziorze, dostępna tylko łodzią:\nTa wysepka, spokojna i urocza, leży na środku spokojnego jeziora, dostępnego tylko za pomocą łodzi lub kajaka.\n Jej brzegi są porośnięte gęstą roślinnością, a na środku znajduje się urokliwy domek lub kapliczka.\n To idealne miejsce dla tych, którzy pragną uciec od zgiełku świata i zanurzyć się w \nharmonii natury, słuchając szumu fal i śpiewu ptaków.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 11:
                                Console.WriteLine("11- Podwodna jaskinia w głębinach oceanu:\nTa podwodna jaskinia, schowana głęboko pod powierzchnią oceanu, jest ukrytym skarbem dla tych, którzy poszukują nieodkrytych zakątków podwodnego świata. Jej kryształowe komory są domem dla egzotycznych form życia morskiego i ukrytych skarbów, które czekają na odkrycie. Nurkowie, odważni i zafascynowani,\n próbują dotrzeć do wnętrza jaskini, gotowi stawić czoła niebezpieczeństwom i\n tajemnicom, które kryje głębiny oceanu.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 12:
                                Console.WriteLine("12- Górzysty teren z licznymi jaskiniami i dolinami:\nTen górzysty teren, porywający swym pięknem i surowością, jest domem dla licznych jaskiń i dolin, które kryją w sobie bogactwo fauny i flory. Wysokie szczyty gór i głębokie wąwozy tworzą malowniczy krajobraz, który przyciąga zarówno miłośników przyrody, jak i poszukiwaczy przygód.\n Tajemnicze jaskinie, ukryte wśród skał, czekają na\n odważnych odkrywców gotowych zgłębiać ich sekrety.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 13:
                                Console.WriteLine("13- Karczma w podrzędnym mieście na szlaku handlowym:\nTa karczma, skryta w podrzędnym mieście na ruchliwym szlaku handlowym, to miejsce spotkań podróżnych, \nkupców i poszukiwaczy przygód. Jej drewniane ściany są wypisane historiami niezliczonych podróży i wymiany handlowej. \nWnętrze karczmy jest wypełnione gwarem rozmów, śmiechem i aromatami przypraw i pieczonych potraw. Właściciel,\n doświadczony gospodarz, serwuje tutaj\n najsmaczniejsze dania i trunki, gotowy wysłuchać opowieści \nkażdego podróżnika, który przekroczy próg tego miejsca.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            case 14:
                                Console.WriteLine("14- Osada na pustyni, zdominowana przez nomadów:\nTa osada na pustyni, wznosząca się wśród fal piasków, jest domem dla nomadycznych plemion, które od wieków przemieszczają się w poszukiwaniu wody i pożywienia. Ich namioty i jurty tworzą skromne, ale funkcjonalne miasteczko, gdzie handel i wymiana kulturowa kwitną na tle surowego krajobrazu.\n Ludzie ci są twardzi i wytrwali, przywiązani do swych tradycji i zwyczajów,\n przetrwający w nieustannym wysiłku i walce z przyrodą.");
                                Console.Write(">>");
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                break;

                        }
                        #endregion
                        #endregion
                        #region//meni i ststy bochater
                        int lvlBochater = 0;
                        #region//tworzenie stat bochatera
                        #region
                        int n = 10 - (Unikanie / 5);

                        #endregion
                        #region//wiedza i magia
                        double widz = (mana + ((Wiedza * mana) * 0.5) + ((WrodzonaWiedza * mana) * 0.3));
                        #endregion
                        #region//hp
                        double zycie1 = (zdrowie + (Wytrzymałość * 20) + (ManipulacjaEnergiąŻyciową * 10));

                        #endregion
                        #region//pancerz
                        double obrona = (pancerz + (OdpornośćMagiczna * 15) + (yingYang + 30) + (WytrzymaloscPsychiczna + 10));
                        #endregion
                        #region//siła
                        double atak1 = (Siła * 3) + (Precyzja * 2) + (SztukaWalkiBroniaBiala * 4);

                        #endregion
                        #endregion
                        #region//meun
                        //271
                        while (true)
                        {

                            Console.Clear();
                            Console.WriteLine($"┌───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐   ");
                            Console.WriteLine($"│███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████   ");
                            Console.WriteLine($"│█     CLASSA:{className,-10}                             ");
                            Console.WriteLine($"│█     PODSTAWOWE INFORMACJE:                           ");
                            Console.WriteLine($"│█     ZDROWIE:{zycie1,-3}                            ");
                            Console.WriteLine($"│█     MANA:{widz,-3}                                  ");
                            Console.WriteLine($"│█     PANCERZ:{obrona,-3}                            ");
                            Console.WriteLine($"│█     SIŁA:{atak1,-3}                                   ");
                            Console.WriteLine($"│█     LV: {lvlBochater,-3}                       ");
                            Console.WriteLine($"│█     Rasa: {klasa,-3}                         ");
                            Console.WriteLine($"├─────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤ ");
                            Console.WriteLine($"│     CO CHCESZ ZROBIĆ?                           │ STATYSTYKI:  ");
                            Console.WriteLine($"│                                                 │ Sztuka przeklęta: {SztukaPrzeklęta,-3}    Precyzja: {Precyzja,-3}                  /Przetrwanie w warunkach ekstremalnych: {PrzetrwanieWWarunkachEkstremalnych,-3} ");
                            Console.WriteLine($"│      1 - SPRAWDZ MAPE                           │ Wiedza: {Wiedza,-3}              //Manipulacja charyzmą: {ManipulacjaCharyzmą,-3}       /Praca nad ciałem: {PracaNadCiałem,-3}                 ");
                            Console.WriteLine($"│                                                 │ Wytrzymałość: {Wytrzymałość,-3}        Wizja mistyczna: {WizjaMistyczna,-3}            /Heroiczny natarcie: {HeroicznyNatarcie,-3}            ");
                            Console.WriteLine($"│      2 - WYLEJ POT I KREW W WALCE               │ /Szczęście: {Szczęście,-3}           Przyciemnienie mentalne: {PrzyciemnienieMentalne,-3}    Magia światła: {MagiaŚwiatła,-3}    ");
                            Console.WriteLine($"│                                                 │ Skrytobójstwo: {Skrytobójstwo,-3}       //Fałszerstwo: {Fałszerstwo,-3}                Magia ciemności: {MagiaCiemności,-3}                  ");
                            Console.WriteLine($"│      3 - ZAPISZ GRE                             │ Rzucanie czarów: {RzucanieCzarów,-3}     Magia ognia: {MagiaOgnia,-3}                Magia wiatru: {MagiaWiatru,-3}                        ");
                            Console.WriteLine($"│                                                 │ /Rzemiosło: {Rzemiosło,-3}           /Warzenie eliksirów: {WarzenieEliksirów,-3}         /Wykorzystanie środowiska: {WykorzystanieSrodowiska,-3}");
                            Console.WriteLine($"│      4 - .................                      │ /Ujezdzanie konia: {BieganieKonia,-3}    Manipulacja energią: {ManipulacjaEnergią,-3}        Magia ziemi: {MagiaZiemi,-3}                          ");
                            Console.WriteLine($"│                                                 │ /Elastyczność: {Elastyczność,-3}        Manipulacja czasem: {ManipulacjaCzasem,-3}         Magia powietrza: {MagiaPowietrza,-3}                  ");
                            Console.WriteLine($"│                                                 │ /Instynkt: {Instynkt,-3}            /Więź ze duchami natury: {WięźZeSpirytamiNatury,-3}     Magia pustki: {MagiaPustki,-3}                        ");
                            Console.WriteLine($"│                                                 │ /Charyzma bojowa: {CharyzmaBojowa,-3}     Mistrzostwo iluzji: {MistrzostwoIluzji,-3}         /Strażnik: {Strażnik,-3}                               ");
                            Console.WriteLine($"│                                                 │ /Koncentracja: {Koncentracja,-3}        Magia krwi: {MagiaKrwi,-3}                 Absorpcja energii: {AbsorpcjaEnergii,-3}              ");
                            Console.WriteLine($"│                                                 │ Rozerwanie dusz: {RozerwanieDusz,-3}     Sztuka walki bronią białą:{SztukaWalkiBroniaBiala,-3}   /Odczytywanie emocji: {OdczytywanieEmocji,-3}          ");
                            Console.WriteLine($"│                                                 │ /Ukrywanie: {Ukrywanie,3}           /Penetracja: {Penetracja,-3}                 /Wydobycie wglądu: {WydobycieWglądu,-3}                ");
                            Console.WriteLine($"│                                                 │ /Śledzenie: {Śledzenie,3}           Czytanie aury: {CzytanieAury,-3}              Magia lodu: {MagiaLodu,-3}                            ");
                            Console.WriteLine($"│                                                 │ /Intuicja: {Intuicja,3}            Tworzenie portali: {TworzeniePortali,-3}          Niewidzialność: {Niewidzialność,-3}                   ");
                            Console.WriteLine($"│                                                 │ /Siła woli: {SiłaWoli,3}           Magiczne tarcze: {MagiczneTarcze,-3}            Manipulacja przestrzenią: {ManipulacjaPrzestrzenią,-3}");
                            Console.WriteLine($"│                                                 │ /Charyzma lidera: {CharyzmaLidera,3}     Modyfikacja rzeczywistości: {ModyfikacjaRzeczywistości,-3} Przełamywanie granicy: {PrzełamywanieGranicy,-3}                ");
                            Console.WriteLine($"│                                                 │ Magia chaotyczna: {MagiaChaotyczna,-3}    Manipulacja energią życiową:{ManipulacjaEnergiąŻyciową,-3} Odporność magiczna:{OdpornośćMagiczna,-3}                       ");
                            Console.WriteLine($"│                                                 │ /Medytacja: {Medytacja,-3}           Magia eteru: {MagiaEteru,-3}                /Charyzma zwierząt: {CharyzmaZwierząt,-3}              ");
                            Console.WriteLine($"│                                                 │ /Ziołolecznictwo: {Ziołolecznictwo,-3}     /Perswazja: {Perswazja,-3}                  /Przewidywanie zagrożeń: {PrzewidywanieZagrożeń,-3}    ");
                            Console.WriteLine($"│                                                 │ /Negocjacje: {Negocjacje,-3}          /Unikanie: {Unikanie,-3}                   /Zdolność maskowania: {ZdolnośćMaskowania,-3}          ");
                            Console.WriteLine($"│                                                 │ /Intuicja walki: {IntuicjaWalki}        /Tropienie: {Tropienie,-3}                  /Wiedza medyczna: {WiedzaMedyczna,-3}                  ");
                            Console.WriteLine($"│       0 - wyjdz                                 │ /Maskowanie magii: {MaskowanieMagii,-3}    /Mediacja: {Mediacja,-3}                   Ying Yang: {yingYang,-3}                              ");
                            Console.WriteLine($"│                                                 │ Nekromancja: {Nekromancja,-3}         Wywoływanie klątw: {WywoływanieKlątw,-3}          /Wyostrzone zmysły: {WyostrzoneZmysły,-3}              ");
                            Console.WriteLine($"│                                                 │ Wrodzona wiedza: {WrodzonaWiedza,-3}     Telepatia: {Telepatia,-3}                  Wytrzymałość psychiczna: {WytrzymaloscPsychiczna}     ");
                            Console.WriteLine($"│                                                 │ Udzielanie mocy: {UdzielanieMocy,-3}     /Targowanie się: {TargowanieSie,-3}             /Specjalizacja elementalistyczna: {SpecjalizacjaElementalistyczna} ");
                            Console.WriteLine($"│                                                 │ /Taktyka: {Taktyka,-3}             /Dowodzenie armiami: {DowodzenieArmiami,-3}        /Myślenie analityczne: {MyślenieAnalityczne,-3}        ");
                            Console.WriteLine($"│                                                 │ /Czujność: {Czujność,-3}            /Mędrzec: {Mędrzec,-3}                    Plotkowanie: {Plotkowanie,-3}                         ");
                            Console.WriteLine($"│                                                 │ /Samodoskonalenie: {Samodoskonalenie,-3}    Kontrola grawitacji: {KontrolaGrawitacji,-3}        Tworzenie pól energetycznych:{TworzeniePólEnergetycznych,-3}");
                            Console.WriteLine($"│                                                 │ /Akrobatyka: {Akrobatyka,-3}          /Archeologia: {Archeologia,-3}                /Zrozumienie intuicji: {ZrozumienieIntuicji,3}         ");
                            Console.WriteLine($"│                                                 │ /Wyczucie poezji: {WyczuciePoezji,-3}     /Interpretacja znaków: {InterpretacjaZnaków,-3}       /Rozbrajanie pułapek: {RozbrajaniePulapek,-3}          ");
                            Console.WriteLine($"│                                                 │ /Improwizacja: {Improwizacja,-3}        /Fizyka: {Fizyka}                       /Intuicja technologiczna: {IntuicjaTechnologiczna,-3}  ");
                            Console.WriteLine($"│                                                 │ /Bieg: {Bieg,-3}                /Sprint: {Sprint,-3}                     /Przemierzanie terenu: {PrzemierzanieTerenu,-3}        ");
                            Console.WriteLine($"│                                                 │ /Kopnięcie: {Kopnięcie,-3}           Telekineza: {Telekineza,-3}                 /Manipulacja emocjonalna: {ManipulacjaEmocjonalna,-3}  ");
                            Console.WriteLine($"│                                                 │ /Refleks: {Refleks,-3}             Zmienianie kształtu: {ZmienianieKształtu,-3}                 ");
                            Console.WriteLine($"│                                                 │ /Zwinność: {Zwinność,-3}            /Oswojenie zwierząt: {OswojenieZwierząt,-3}          ");
                            Console.WriteLine($"│                                                 │ Magia słowa: {MagiaSłowa,-3}         /Pogłębione zrozumienie magii: {PogłębioneZrozumienieMagii,-3}          ");
                            Console.WriteLine($"│                                                 │ Antygrawitacja: {Antygrawitacja,-3}      /Znajomość języków obcych: {ZnajomośćJezykowObcych,-3}                  ");
                            Console.WriteLine($"│                                                 │ /Kryptografia: {Kryptografia,-3}        /Elastyczność mentalna: {ElastycznośćMentalna,3}                        ");
                            Console.WriteLine($"│                                                 │ /Dedukcja: {Dedukcja,-3}            /Umiejętności przetrwania: {UmiejętnościPrzetrwania,-3}                 ");
                            Console.WriteLine($"└─────────────────────────────────────────────────┴──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");

                            Console.Write(">>");
                            string input = Console.ReadLine();
                            switch (input)
                            {
                                case "1":
                                    Eksploracja();
                                    break;
                                case "2":
                                     Walka(widz,zycie1,atak1,obrona,n,lvlBochater);
                                     break;
                               case "3":
        
                                    break;
                                case "0":
                                    Console.WriteLine("Dziękujemy za grę!");
                                    return;
                                default:
                                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                    break;
                            }
                        }
                #endregion
                #endregion
                
             }
    static void Eksploracja()
                    {
                        Console.WriteLine("Eksplorujesz mapę...");
                        Console.Clear();
                        Console.OutputEncoding = Encoding.UTF8;
                        //ΔζΓΠ¬“”¶‖≈Δη√⨼⨽㇕㇘㇗㇐| ㇄▲♠

                        //Console.WriteLine(" ─ ┌ ┐ | ┘ └ ├ ┤ ┴ ┬ ┼");
                        #region//1 linia         
                        //ᴨU //♠⁋
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√V√VV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌─┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲ΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠♠Γ♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔΔΔΔ▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶Γ♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶♠♠¶Γ♠¶¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶n|Γ¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓ|Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("UΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┤");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("””““");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("””n““““ΓΓ\"Γ”ΓΓ”ΓΓΓ”Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶”ΓΓn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//2 linia
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶♠¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ▲▲ΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUUU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶‖");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Uηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶‖Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠‖ΓΓΓ♠♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓ¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η“”“”");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("”“““”");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("”¶”");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("l");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("”\'“““”Γ\"Γ\"Γ\"Γ\"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("¶¶”Γn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//3 linia
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV√√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠♠¶♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ηΔΔ▲▲▲ΔΔ▲▲▲▲Δ▲Δ▲▲ΔΔΔΔΔ▲▲▲▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶ΓΓΓ¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠¶ΓΓ¶¶¶ΓΓ♠¶♠");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"¶Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶ΓnNN");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Uη\"Uu");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"““\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("L");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"¶““\"\"\"ΓΓΓ\"Γ\"Γ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("”Γn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        //≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈¶¶”Γn¶“≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
                        #endregion
                        #region //4 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("U");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓV");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶ΓΓ¶Γ¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VVV");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VVVV");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("V");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔ▲▲▲▲▲▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶nl");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠♠¶♠♠♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠¶¶¶¶ΓΓ¶♠");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶¶n¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Unn");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"¶\"\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲Δ▲▲▲▲▲▲ΔΔΔ▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("n\"Γ\"\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌───");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//5 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶ΓΓ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√V");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┐");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠¶¶♠♠♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲▲▲^▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"▲▲▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"▲▲▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"‖¶n‖¶¶♠¶¶¶♠n‖¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"‖¶♠Γ♠♠♠¶ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"\"n\"\"n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ▲▲▲Δ▲▲▲^▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"N");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌────┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"\"♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//6 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶ΓΓΓ¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠♠♠♠¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"nΔΔ▲▲▲▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"▲▲▲▲▲▲▲▲▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"łηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶ζ♠♠♠♠¶♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"▲▲");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"”¶♠¶Γ♠¶♠¶♠♠ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶UUΓηU¶η\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ł");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"n\"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔζ▲▲▲▲▲ΔζΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌─┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"\"\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//7 linia 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ηΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓΓ¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√V√√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠U");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ▲▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"▲▲▲▲▲▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"▲▲▲▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶”U”♠””¶♠¶♠¶””♠¶ΓΓ¶♠Γ¶ΓΓΓΓΓ♠ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶≈Γηηη¶ζ¶ΓUUnζ¶♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"\"ł");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"nn\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ▲▲▲▲ΔΔΔnΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ\"ΓΓΓ\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//8 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU¶UηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√√¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uη¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌─┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uη\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┴┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠¶♠¶¶¶η¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔΔ▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶♠¶♠♠¶¶♠Γn““♠Γ¶♠ΓΓΓ♠Γ♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"Γ\"ΓΓ♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶n\"¶¶¶ΓΓ¶Γ¶ΓΓUnłn\"\"\"u\"\"ΓΓΓ¶Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"Γ\"Γ\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"η");
                        #endregion
                        #region//9 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VVV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└───┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠♠¶η¶¶ηη");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲▲▲▲▲▲ΔΔΔ▲▲▲▲▲▲▲▲▲▲ΔΔ▲▲Δ▲ΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠¶¶♠♠¶ΓΓη¶¶¶♠♠“n♠ΓUηηUη♠Γ♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"\"\"Γ\"Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη¶ηηηΓΓηUUη\"Γ♠ζζζζ\"♠\"Γ\"\"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"Γ\"Γη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"ΓηΓ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ");
                        #endregion
                        #region//10 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUηηUηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηηη");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"♠♠¶♠¶η♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ▲▲▲▲Δ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶\"¶¶♠♠¶♠nη♠¶♠ζ♠ζη♠¶ηΓΓΓΓΓ♠ΓΓΓ““ζζζ”””Γ“”“Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη¶ηηΓΓηUUη\"Γ♠ζζζζ\"♠\"Γ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ▲Δ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"N");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη\"Γ\"\"ηΓ\"\"η¶Γ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶");
                        #endregion
                        #region//11 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηUηUηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌────┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηUΓη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠¶¶¶♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ▲Δ▲ΔΔΔΔ▲▲▲▲▲▲▲▲ΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶¶¶Γ♠¶η“”“”Γ♠ΓΓη¶Γ♠Γ“““Γ\"\"Γ\"Γ\"Γ\"Γ””Γ“”“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ¶ηU¶¶Γ¶n¶¶♠ηΓ♠η\"ł\"ΓΓ♠ΓΓ“”“”Γζ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ“”“\"“”“”ΓΓ”“Γ“");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ¶η¶Γ¶¶U");
                        #endregion
                        #region//12 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUUηη");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUη♠UηUηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶♠♠¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔnΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠n♠¶♠♠¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶♠¶¶♠♠UηηηUΓΓηηΓηΓ♠ΓΓΓΓΓΓ\"\"Γ\"ΓΓ\"\"Γ\"Γ\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶ηΓΓΓnΓ¶η\"ΓłłΓ♠♠♠Γ¶♠ΓΓ♠Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"¶U“”ηΓΓ\"Γn“”η\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"\"u\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶¶¶¶");
                        #endregion
                        #region//13 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ΓUηη");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"Ω");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√VV√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUUUηηUU\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶♠n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUn");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠nΓΓ¶♠♠“♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─────┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶♠η¶♠η¶♠ηηUUUη♠¶♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"Γ\"\"\"ΓΓΓ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ¶Γ¶η¶Γ♠ΓΓΓ¶Γη¶¶♠Γη\"η\"ł♠Γ♠Γ♠łł");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"NΔΔΔΔΔuΔΔΔΔΔΔu");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"¶U“”ηΓΓ\"Γn“”η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"Γ\"\"\"Γ\"\"\"u\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶¶¶¶");
                        #endregion
                        #region//14 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηηηηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√V");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VVVVV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶♠♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUηUηUΔΔnn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUUUηηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓ¶¶Γ¶Γ¶Γ♠Γ¶¶♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓ¶¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUuUηUUη");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ\"ΓΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶♠¶”Γ♠♠”Γ¶♠♠”Γ¶♠♠”Γ¶♠♠”Γ¶♠¶♠”Γ¶¶♠♠”");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ¶♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"Γ\"Γ\"\"t\'\'\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"Γ\"\'ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//15 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηVη");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUłłηłłUłł");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶Γ♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η¶Γ¶UUηUηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηUUU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠ηΓ¶¶Γζ♠Γ¶♠Γ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠ηn¶Γn¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUUUηUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"ΓΓ\"\"\"ΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶Γn¶ηΓUΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓΓ♠♠♠♠ΓΓ♠ΓΓ\"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",♠,");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"\'\'\'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",.,Δ,");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nη");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"~≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nη\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"n\"\"łη\"η\"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ηη\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//16 linia

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V√V");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"\'\'\'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU\"Γł\"♠♠Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUηηU¶U¶UηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηηUUU¶η¶ΓU♠¶ΓΓ♠Γ¶♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶η¶Γ♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUηUUUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶Γ¶ΓnnΓ¶¶¶ΓnU¶Γ♠♠Γ♠♠¶♠Γ♠ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($",\'\'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($".ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"Π");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"NN\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"ηη\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.Write($",\'\'");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($".ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//17 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√√VV");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η\"η\"ł\"\"łłnł\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠ηη¶¶¶♠¶nΓΓΓn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηnnł");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌──┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠ΓΓUΓΓnΓ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓU♠U¶♠n¶¶¶♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUUη");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ\"ΓΓ\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓΓ¶¶nΓΓ♠¶Uηη♠♠ΓΓ♠Γ♠ΓΓΓnn\"łΓΓ\"\"ΓΓΓΓΓζ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ,Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",ΔΔΔ▲ΔΔΔΠ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"\"η\"\'\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($",ΓΓ.ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//18 linia
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√U");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"ł\"ł\"\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"“”““┌┘”””");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶♠¶¶♠ΓΓ♠n¶♠♠U");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n¶¶U");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"nł");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"nη¶U¶η¶ηn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("♠♠ηn¶Γn¶ηηUUU♠UηUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"Γ\"\"ΓΓ\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ¶Γ¶ΓηηηΓΓΓ¶Γ¶¶¶nΓ♠♠♠♠♠♠♠ΓΓ♠Γ♠ΓΓΓnn\"łΓΓ\"\"ΓΓ♠ΓΓΓζ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"ΓΓΔ\"\"n\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"ηηηηη\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//19 linia         
                        //ᴨU //♠⁋
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√V√VV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌─┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲ΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠♠Γ♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔΔΔΔ▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶Γ♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶♠♠¶Γ♠¶¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶n|Γ¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓ|Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("UΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┤");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("””““");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("””n““““ΓΓ\"Γ”ΓΓ”ΓΓΓ”Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶”ΓΓn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//20 linia
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶♠¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ▲▲ΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUUU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶‖");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Uηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶‖Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠‖ΓΓΓ♠♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓ¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η“”“”");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("”“““”");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("”¶”");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("l");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("”\'“““”Γ\"Γ\"Γ\"Γ\"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("¶¶”Γn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//21 linia
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV√√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠♠¶♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ηΔΔ▲▲▲ΔΔ▲▲▲▲Δ▲Δ▲▲ΔΔΔΔΔ▲▲▲▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶ΓΓΓ¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠¶ΓΓ¶¶¶ΓΓ♠¶♠");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"¶Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶ΓnNN");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Uη\"Uu");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"““\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("L");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"¶““\"\"\"ΓΓΓ\"Γ\"Γ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("”Γn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        //≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈¶¶”Γn¶“≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
                        #endregion
                        #region //22 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("U");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓV");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶ΓΓ¶Γ¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VVV");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VVVV");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("V");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔ▲▲▲▲▲▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶nl");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠♠¶♠♠♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠¶¶¶¶ΓΓ¶♠");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶¶n¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Unn");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"¶\"\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲Δ▲▲▲▲▲▲ΔΔΔ▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("n\"Γ\"\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌───");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//23 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶ΓΓ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√V");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┐");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠¶¶♠♠♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲▲▲^▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"▲▲▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"▲▲▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"‖¶n‖¶¶♠¶¶¶♠n‖¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"‖¶♠Γ♠♠♠¶ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"\"n\"\"n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ▲▲▲Δ▲▲▲^▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"N");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌────┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"\"♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//24 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶ΓΓΓ¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠♠♠♠¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"nΔΔ▲▲▲▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"▲▲▲▲▲▲▲▲▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"łηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶ζ♠♠♠♠¶♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"▲▲");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"”¶♠¶Γ♠¶♠¶♠♠ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶UUΓηU¶η\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ł");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"n\"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔζ▲▲▲▲▲ΔζΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌─┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"\"\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//25 linia 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ηΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓΓ¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√V√√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠U");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ▲▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"▲▲▲▲▲▲▲▲▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"▲▲▲▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶”U”♠””¶♠¶♠¶””♠¶ΓΓ¶♠Γ¶ΓΓΓΓΓ♠ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶≈Γηηη¶ζ¶ΓUUnζ¶♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"\"ł");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"nn\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ▲▲▲▲ΔΔΔnΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ\"ΓΓΓ\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//26 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU¶UηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√√¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uη¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌─┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uη\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┴┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠¶♠¶¶¶η¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔΔ▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶♠¶♠♠¶¶♠Γn““♠Γ¶♠ΓΓΓ♠Γ♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"Γ\"ΓΓ♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶n\"¶¶¶ΓΓ¶¶¶¶¶¶¶¶¶¶Γ¶ΓΓUnłn\"\"\"u\"\"ΓΓΓ¶Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"Γ\"Γ\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"η");
                        #endregion
                        #region//27 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VVV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└───┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠♠¶η¶¶ηη");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲▲▲▲▲▲ΔΔΔ▲▲▲▲▲▲▲▲▲▲ΔΔ▲▲Δ▲ΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠¶¶♠♠¶ΓΓη¶¶¶♠♠“n♠ΓUηηUη♠Γ♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"\"\"Γ\"Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη¶ηηηΓΓηUUη\"Γ♠ζζζζ\"♠\"Γ\"\"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"Γ\"Γη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"ΓηΓ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ");
                        #endregion
                        #region//28 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUηηUηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηηη");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"♠♠¶♠¶η♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ▲▲▲▲Δ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶\"¶¶♠♠¶♠nη♠¶♠ζ♠ζη♠¶ηΓΓΓΓΓ♠ΓΓΓ““ζζζ”””Γ“”“Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη¶ηηΓΓηUUη\"Γ♠ζζζζ\"♠\"Γ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ▲Δ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"N");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη\"Γ\"\"ηΓ\"\"η¶Γ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶");
                        #endregion
                        #region//29 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηUηUηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌────┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηUΓη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠¶¶¶♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ▲Δ▲ΔΔΔΔ▲▲▲▲▲▲▲▲ΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶¶¶Γ♠¶η“”“”Γ♠ΓΓη¶Γ♠Γ“““Γ\"\"Γ\"Γ\"Γ\"Γ””Γ“”“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ¶ηU¶¶Γ¶n¶¶♠ηΓ♠η\"ł\"ΓΓ♠ΓΓ“”“”Γζ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ“”“\"“”“”ΓΓ”“Γ“");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ¶η¶Γ¶¶U");
                        #endregion
                        #region//30 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUUηη");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUη♠UηUηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶♠♠¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔnΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠n♠¶♠♠¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶♠¶¶♠♠UηηηUΓΓηηΓηΓ♠ΓΓΓΓΓΓ\"\"Γ\"ΓΓ\"\"Γ\"Γ\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶ηΓΓΓnΓ¶η\"ΓłłΓ♠♠♠Γ¶♠ΓΓ♠Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"¶U“”ηΓΓ\"Γn“”η\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"\"u\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶¶¶¶");
                        #endregion
                        #region//31 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ΓUηη");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"Ω");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√VV√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUUUηηUU\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶♠n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUn");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠nΓΓ¶♠♠“♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─────┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶♠η¶♠η¶♠ηηUUUη♠¶♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"Γ\"\"\"ΓΓΓ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ¶Γ¶η¶Γ♠ΓΓΓ¶Γη¶¶♠Γη\"η\"ł♠Γ♠Γ♠łł");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"NΔΔΔΔΔuΔΔΔΔΔΔu");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"¶U“”ηΓΓ\"Γn“”η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"Γ\"\"\"Γ\"\"\"u\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶¶¶¶");
                        #endregion
                        #region//32 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηηηηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√V");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VVVVV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶♠♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUηUηUΔΔnn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUUUηηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓ¶¶Γ¶Γ¶Γ♠Γ¶¶♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓ¶¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUuUηUUη");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ\"ΓΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶♠¶”Γ♠♠”Γ¶♠♠”Γ¶♠♠”Γ¶♠♠”Γ¶♠¶♠”Γ¶¶♠♠”");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ¶♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"Γ\"Γ\"\"t\'\'\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"Γ\"\'ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//34 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηVη");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUłłηłłUłł");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶Γ♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η¶Γ¶UUηUηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηUUU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠ηΓ¶¶Γζ♠Γ¶♠Γ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠ηn¶Γn¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUUUηUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"ΓΓ\"\"\"ΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶Γn¶ηΓUΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓΓ♠♠♠♠ΓΓ♠ΓΓ\"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",♠,");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"\'\'\'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",.,Δ,");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nη");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"~≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nη\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"n\"\"łη\"η\"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ηη\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//35 linia

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V√V");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"\'\'\'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU\"Γł\"♠♠Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUηηU¶U¶UηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηηUUU¶η¶ΓU♠¶ΓΓ♠Γ¶♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶η¶Γ♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUηUUUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶Γ¶ΓnnΓ¶¶¶ΓnU¶Γ♠♠Γ♠♠¶♠Γ♠ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($",\'\'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($".ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"Π");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"NN\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"ηη\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.Write($",\'\'");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($".ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//36 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√√VV");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η\"η\"ł\"\"łłnł\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠ηη¶¶¶♠¶nΓΓΓn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηnnł");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌──┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠ΓΓUΓΓnΓ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓU♠U¶♠n¶¶¶♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUUη");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ\"ΓΓ\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓΓ¶¶nΓΓ♠¶Uηη♠♠ΓΓ♠Γ♠ΓΓΓnn\"łΓΓ\"\"ΓΓΓΓΓζ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ,Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",ΔΔΔ▲ΔΔΔΠ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"\"η\"\'\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($",ΓΓ.ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//37 linia
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√U");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"ł\"ł\"\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"“”““┌┘”””");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶♠¶¶♠ΓΓ♠n¶♠♠U");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n¶¶U");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"nł");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"nη¶U¶η¶ηn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("♠♠ηn¶Γn¶ηηUUU♠UηUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"Γ\"\"ΓΓ\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ¶Γ¶ΓηηηΓΓΓ¶Γ¶¶¶nΓ♠♠♠♠♠♠♠ΓΓ♠Γ♠ΓΓΓnn\"łΓΓ\"\"ΓΓ♠ΓΓΓζ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"ΓΓΔ\"\"n\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"ηηηηη\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//38 linia
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("V√√nn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"ł\"ł\"\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("\"\"\"┌┘\"\"\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("");
                        #endregion
                        #region//26 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU¶UηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√√¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uη¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌─┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Uη\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┴┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠¶♠¶¶¶η¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔΔ▲▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶♠¶♠♠¶¶♠Γn““♠Γ¶♠ΓΓΓ♠Γ♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"Γ\"ΓΓ♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶n\"¶¶¶ΓΓ¶Γ¶ΓΓUnłn\"\"\"u\"\"ΓΓΓ¶Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"Γ\"Γ\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"η");
                        #endregion
                        #region//27 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VVV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└───┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠♠¶η¶¶ηη");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲▲▲▲▲▲ΔΔΔ▲▲▲▲▲▲▲▲▲▲ΔΔ▲▲Δ▲ΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠¶¶♠♠¶ΓΓη¶¶¶♠♠“n♠ΓUηηUη♠Γ♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"\"\"Γ\"Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη¶ηηηΓΓηUUη\"Γ♠ζζζζ\"♠\"Γ\"\"\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"Γ\"Γη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"ΓηΓ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ");
                        #endregion
                        #region//28 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUηηUηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηηη");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"♠♠¶♠¶η♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ▲▲▲▲Δ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶\"¶¶♠♠¶♠nη♠¶♠ζ♠ζη♠¶ηΓΓΓΓΓ♠ΓΓΓ““ζζζ”””Γ“”“Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη¶ηηΓΓηUUη\"Γ♠ζζζζ\"♠\"Γ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ▲Δ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"N");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γη\"Γ\"\"ηΓ\"\"η¶Γ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"ΓΓ\"ΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶");
                        #endregion
                        #region//29 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηUηUηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌────┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηUΓη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠¶¶¶♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ▲Δ▲ΔΔΔΔ▲▲▲▲▲▲▲▲ΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶¶¶Γ♠¶η“”“”Γ♠ΓΓη¶Γ♠Γ“““Γ\"\"Γ\"Γ\"Γ\"Γ””Γ“”“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ¶ηU¶¶Γ¶n¶¶♠ηΓ♠η\"ł\"ΓΓ♠ΓΓ“”“”Γζ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ“”“\"“”“”ΓΓ”“Γ“");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ¶η¶Γ¶¶U");
                        #endregion
                        #region//30 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUUηη");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUη♠UηUηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶♠♠¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔnΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠n♠¶♠♠¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶♠¶¶♠♠UηηηUΓΓηηΓηΓ♠ΓΓΓΓΓΓ\"\"Γ\"ΓΓ\"\"Γ\"Γ\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶ηΓΓΓnΓ¶η\"ΓłłΓ♠♠♠Γ¶♠ΓΓ♠Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"¶U“”ηΓΓ\"Γn“”η\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"\"u\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶¶¶¶");
                        #endregion
                        #region//31 linia
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ΓUηη");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"Ω");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√VV√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUUUηηUU\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~~");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶♠n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUn");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠nΓΓ¶♠♠“♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─────┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶♠η¶♠η¶♠ηηUUUη♠¶♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"Γ\"\"\"ΓΓΓ\"Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ¶Γ¶η¶Γ♠ΓΓΓ¶Γη¶¶♠Γη\"η\"ł♠Γ♠Γ♠łł");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"NΔΔΔΔΔuΔΔΔΔΔΔu");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"¶U“”ηΓΓ\"Γn“”η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ\"Γ\"\"\"Γ\"\"\"u\"\"\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"¶¶¶¶¶¶¶");
                        #endregion
                        #region//32 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηηηηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√V");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VVVVV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶♠♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUηUηUΔΔnn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUUUηηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓ¶¶Γ¶Γ¶Γ♠Γ¶¶♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓ¶¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUuUηUUη");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ\"ΓΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶♠¶”Γ♠♠”Γ¶♠♠”Γ¶♠♠”Γ¶♠♠”Γ¶♠¶♠”Γ¶¶♠♠”");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ¶♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"Γ\"Γ\"\"t\'\'\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"Γ\"\'ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//34 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηVη");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUłłηłłUłł");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶Γ♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η¶Γ¶UUηUηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηUUU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠ηΓ¶¶Γζ♠Γ¶♠Γ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠ηn¶Γn¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUUUηUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"ΓΓ\"\"\"ΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶Γn¶ηΓUΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓΓ♠♠♠♠ΓΓ♠ΓΓ\"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",♠,");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"\'\'\'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",.,Δ,");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nη");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"~≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nη\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"n\"\"łη\"η\"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ηη\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//35 linia

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V√V");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"\'\'\'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU\"Γł\"♠♠Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUηηU¶U¶UηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηηUUU¶η¶ΓU♠¶ΓΓ♠Γ¶♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶η¶Γ♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUηUUUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶Γ¶ΓnnΓ¶¶¶ΓnU¶Γ♠♠Γ♠♠¶♠Γ♠ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($",\'\'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($".ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"Π");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"NN\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"ηη\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.Write($",\'\'");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($".ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//36 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√√VV");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η\"η\"ł\"\"łłnł\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠ηη¶¶¶♠¶nΓΓΓn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηnnł");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌──┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠ΓΓUΓΓnΓ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓU♠U¶♠n¶¶¶♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUUη");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ\"ΓΓ\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓΓ¶¶nΓΓ♠¶Uηη♠♠ΓΓ♠Γ♠ΓΓΓnn\"łΓΓ\"\"ΓΓΓΓΓζ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ,Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",ΔΔΔ▲ΔΔΔΠ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"\"η\"\'\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($",ΓΓ.ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//37 linia
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√U");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\"ł\"ł\"\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"“”““┌┘”””");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶♠¶¶♠ΓΓ♠n¶♠♠U");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"n¶¶U");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"nł");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"nη¶U¶η¶ηn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("♠♠ηn¶Γn¶ηηUUU♠UηUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"Γ\"\"ΓΓ\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶Γ¶Γ¶ΓηηηΓΓΓ¶Γ¶¶¶nΓ♠♠♠♠♠♠♠ΓΓ♠Γ♠ΓΓΓnn\"łΓΓ\"\"ΓΓ♠ΓΓΓζ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"ΓΓΔ\"\"n\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔ▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"ηηηηη\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion

                        #region//19 linia         
                        //ᴨU //♠⁋
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"U");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√V√VV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌─┘");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲ΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶♠♠Γ♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔΔΔΔ▲▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶¶Γ♠¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶♠♠¶Γ♠¶¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ≈≈¶¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶n|Γ¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓ|Γ\"Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("UΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┤");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("””““");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("””n““““ΓΓ\"Γ”ΓΓ”ΓΓΓ”Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶”ΓΓn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//20 linia
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶♠¶¶¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ▲▲ΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUUU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶‖");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠¶¶¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Uηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶‖Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠‖ΓΓΓ♠♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠Γ\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓ¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η“”“”");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("”“““”");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("”¶”");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("l");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("”\'“““”Γ\"Γ\"Γ\"Γ\"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("¶¶”Γn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//21 linia
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUUU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√V");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VV√√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηηU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠♠¶♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ηΔΔ▲▲▲ΔΔ▲▲▲▲Δ▲Δ▲▲ΔΔΔΔΔ▲▲▲▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("UUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶ΓΓΓ¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠¶ΓΓ¶¶¶ΓΓ♠¶♠");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"¶Γ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶ΓnNN");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Uη\"Uu");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"““\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲▲ΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("L");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"¶““\"\"\"ΓΓΓ\"Γ\"Γ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("”Γn¶“");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        //≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈¶¶”Γn¶“≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
                        #endregion
                        #region //22 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("U");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ΓV");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶ΓΓ¶Γ¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("√√V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VVV");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("VVVV");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠¶¶");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("V");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲ΔΔ▲▲▲▲▲▲▲▲▲ΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶nl");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("♠♠¶♠♠♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ηηη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶♠¶¶¶¶ΓΓ¶♠");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¶");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶¶¶n¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Unn");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("¶\"\"\"¶\"\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("ΔΔΔ▲Δ▲▲▲▲▲▲ΔΔΔ▲▲▲▲");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("n\"Γ\"\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("┌───");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//32 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠Γ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηηηηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√V");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VVVVV");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηU\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"~");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠¶¶♠♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUηUηUΔΔnn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUUUηηUη");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓ¶¶Γ¶Γ¶Γ♠Γ¶¶♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓ¶¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUuUηUUη");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ\"ΓΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶♠¶”Γ♠♠”Γ¶♠♠”Γ¶♠♠”Γ¶♠♠”Γ¶♠¶♠”Γ¶¶♠♠”");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Γ¶♠");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"Γ\"Γ\"Γ\"\"t\'\'\"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ\"\"Γ\"\'ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//34 linia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηVη");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηU");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V√");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUłłηłłUłł");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠Γ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠¶Γ♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η¶Γ¶UUηUηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└─┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UUηUUU");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠ηΓ¶¶Γζ♠Γ¶♠Γ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠ηn¶Γn¶");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUUUηUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"ΓΓ\"\"\"ΓΓ\"\"\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶¶Γn¶ηΓUΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓnΓΓ♠♠♠♠ΓΓ♠ΓΓ\"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",♠,");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"\'\'\'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",.,Δ,");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nη");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"~≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nη\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"n\"\"łη\"η\"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ηη\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        #region//35 linia

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√√");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"√V√V");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"η");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"\'\'\'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηU\"Γł\"♠♠Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ¶Γ¶");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηUηηU¶U¶UηU");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"UηηUUU¶η¶ΓU♠¶ΓΓ♠Γ¶♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌──┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶η¶Γ♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUηUUUU");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓΓ\"\"ΓΓΓ\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶¶Γ¶ΓnnΓ¶¶¶ΓnU¶Γ♠♠Γ♠♠¶♠Γ♠ΓΓ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($",\'\'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($".ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"*┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"♠♠");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"Π");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"NN\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔΔΔΔΔΔ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\"\"ηη\"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.Write($",\'\'");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($".ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");

                        #endregion
                        #region//36 linia
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"V");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"VV√√VV");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"η\"η\"ł\"\"łłnł\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠♠");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌┘");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"♠ηη¶¶¶♠¶nΓΓΓn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηnnł");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"┌──┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"Γ♠ΓΓUΓΓnΓ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓU♠U¶♠n¶¶¶♠");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"ηηUUUη");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"ΓΓΓ\"ΓΓ\"\"\"Γ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓΓ¶¶nΓΓ♠¶Uηη♠♠ΓΓ♠Γ♠ΓΓΓnn\"łΓΓ\"\"ΓΓΓΓΓζ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"¶ΓΓ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"ΔΔ,Δ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"nn");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"│");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($",ΔΔΔ▲ΔΔΔΠ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"η\"\"η\"\'\"");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"└┐");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($",ΓΓ.ηη\"ł\"");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
                        #endregion
                        Console.ForegroundColor = ConsoleColor.White;


                        Console.WriteLine($"                                       ┌───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐   ");
                        Console.WriteLine($"                                       │███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████   ");
                        Console.WriteLine($"                                       │███                                                                              MAPA TEGO SKROMNEGO ŚWIATU                                                                             ███              ");
                        Console.WriteLine($"                                       │███                                                                                 KLIKNIJ - 1 - COFNIJ                                                                                ███        ");
                        Console.WriteLine($"                                       │███                                                                                                                                                                                     ███   ");
                        Console.WriteLine($"                                       │███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████ ");
                        Console.WriteLine($"                                       └───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                        Console.WriteLine($"");
                        Console.Write(">>");
                        Console.ReadLine();
                    }
    static void Walka(double widz, double zycie1, double atak1, double obrona, int lvlBochater, int n)
                    {
                
                        int zycie = Convert.ToInt32(zycie1);
                        int atak = Convert.ToInt32(atak1);
                        #region//walka
                        int HPenemy, manaEnemy, pancerzEnemy, silaEnemy;
                        string NazwaEnemy;
                        Random rand = new Random();

                        int a = rand.Next(1, 75);
                        ;
                        switch (a)
                        {
                            case 1:
                                NazwaEnemy = "Wilk";
                                HPenemy = 120;
                                manaEnemy = 0;
                                pancerzEnemy = 10;
                                silaEnemy = 2;
                                break;

                            case 2:
                                NazwaEnemy = "Niedźwiedź";
                                HPenemy = 150;
                                manaEnemy = 0;
                                pancerzEnemy = 15;
                                silaEnemy = 5;
                                break;

                            case 3:
                                NazwaEnemy = "Żbik";
                                HPenemy = 100;
                                manaEnemy = 0;
                                pancerzEnemy = 8;
                                silaEnemy = 3;
                                break;

                            case 4:
                                NazwaEnemy = "Jeleń";
                                HPenemy = 130;
                                manaEnemy = 0;
                                pancerzEnemy = 12;
                                silaEnemy = 4;
                                break;

                            case 5:
                                NazwaEnemy = "Sarna";
                                HPenemy = 110;
                                manaEnemy = 0;
                                pancerzEnemy = 9;
                                silaEnemy = 3;
                                break;

                            case 6:
                                NazwaEnemy = "Dzik";
                                HPenemy = 100;
                                manaEnemy = 0;
                                pancerzEnemy = 7;
                                silaEnemy = 3;
                                break;

                            case 7:
                                NazwaEnemy = "Lisek";
                                HPenemy = 90;
                                manaEnemy = 0;
                                pancerzEnemy = 6;
                                silaEnemy = 2;
                                break;

                            case 8:
                                NazwaEnemy = "Bóbr";
                                HPenemy = 80;
                                manaEnemy = 0;
                                pancerzEnemy = 5;
                                silaEnemy = 2;
                                break;

                            case 9:
                                NazwaEnemy = "Ryś";
                                HPenemy = 140;
                                manaEnemy = 0;
                                pancerzEnemy = 11;
                                silaEnemy = 4;
                                break;

                            case 10:
                                NazwaEnemy = "Żubr";
                                HPenemy = 160;
                                manaEnemy = 0;
                                pancerzEnemy = 14;
                                silaEnemy = 6;
                                break;

                            case 11:
                                NazwaEnemy = "Kuna";
                                HPenemy = 95;
                                manaEnemy = 0;
                                pancerzEnemy = 7;
                                silaEnemy = 3;
                                break;

                            case 12:
                                NazwaEnemy = "Wiewiórka";
                                HPenemy = 85;
                                manaEnemy = 0;
                                pancerzEnemy = 6;
                                silaEnemy = 2;
                                break;

                            case 13:
                                NazwaEnemy = "Borsuk";
                                HPenemy = 105;
                                manaEnemy = 0;
                                pancerzEnemy = 8;
                                silaEnemy = 4;
                                break;

                            case 14:
                                NazwaEnemy = "Zając";
                                HPenemy = 95;
                                manaEnemy = 0;
                                pancerzEnemy = 7;
                                silaEnemy = 3;
                                break;

                            case 15:
                                NazwaEnemy = "Wódka";
                                HPenemy = 80;
                                manaEnemy = 0;
                                pancerzEnemy = 5;
                                silaEnemy = 2;
                                break;

                            case 16:
                                NazwaEnemy = "Ropucha";
                                HPenemy = 75;
                                manaEnemy = 0;
                                pancerzEnemy = 5;
                                silaEnemy = 2;
                                break;

                            case 17:
                                NazwaEnemy = "Jarząbek";
                                HPenemy = 90;
                                manaEnemy = 0;
                                pancerzEnemy = 6;
                                silaEnemy = 2;
                                break;

                            case 18:
                                NazwaEnemy = "Orzeł";
                                HPenemy = 120;
                                manaEnemy = 0;
                                pancerzEnemy = 9;
                                silaEnemy = 4;
                                break;

                            case 19:
                                NazwaEnemy = "Krogulec";
                                HPenemy = 110;
                                manaEnemy = 0;
                                pancerzEnemy = 8;
                                silaEnemy = 3;
                                break;

                            case 20:
                                NazwaEnemy = "Kruk";
                                HPenemy = 100;
                                manaEnemy = 0;
                                pancerzEnemy = 7;
                                silaEnemy = 3;
                                break;

                            case 21:
                                NazwaEnemy = "Dzikuska";
                                HPenemy = 90;
                                manaEnemy = 0;
                                pancerzEnemy = 6;
                                silaEnemy = 3;
                                break;

                            case 22:
                                NazwaEnemy = "Nietoperz";
                                HPenemy = 70;
                                manaEnemy = 0;
                                pancerzEnemy = 4;
                                silaEnemy = 2;
                                break;

                            case 23:
                                NazwaEnemy = "Kret";
                                HPenemy = 85;
                                manaEnemy = 0;
                                pancerzEnemy = 6;
                                silaEnemy = 2;
                                break;

                            case 24:
                                NazwaEnemy = "Jaszczurka";
                                HPenemy = 80;
                                manaEnemy = 0;
                                pancerzEnemy = 5;
                                silaEnemy = 2;
                                break;

                            case 25:
                                NazwaEnemy = "Różanka";
                                HPenemy = 90;
                                manaEnemy = 0;
                                pancerzEnemy = 6;
                                silaEnemy = 2;
                                break;

                            case 26:
                                NazwaEnemy = "Jastrząb";
                                HPenemy = 100;
                                manaEnemy = 0;
                                pancerzEnemy = 7;
                                silaEnemy = 3;
                                break;

                            case 27:
                                NazwaEnemy = "Krogulec 2";
                                HPenemy = 110;
                                manaEnemy = 0;
                                pancerzEnemy = 8;
                                silaEnemy = 3;
                                break;

                            case 28:
                                NazwaEnemy = "Błotniak";
                                HPenemy = 95;
                                manaEnemy = 0;
                                pancerzEnemy = 7;
                                silaEnemy = 3;
                                break;

                            case 29:
                                NazwaEnemy = "Zombie";
                                HPenemy = 140;
                                manaEnemy = 0;
                                pancerzEnemy = 12;
                                silaEnemy = 5;
                                break;

                            case 30:
                                NazwaEnemy = "Lich";
                                HPenemy = 180;
                                manaEnemy = 50;
                                pancerzEnemy = 20;
                                silaEnemy = 8;
                                break;

                            case 31:
                                NazwaEnemy = "Wampirzak";
                                HPenemy = 130;
                                manaEnemy = 30;
                                pancerzEnemy = 15;
                                silaEnemy = 6;
                                break;

                            case 32:
                                NazwaEnemy = "Strzyga";
                                HPenemy = 160;
                                manaEnemy = 40;
                                pancerzEnemy = 18;
                                silaEnemy = 7;
                                break;

                            case 33:
                                NazwaEnemy = "Ghul";
                                HPenemy = 110;
                                manaEnemy = 0;
                                pancerzEnemy = 10;
                                silaEnemy = 4;
                                break;

                            case 34:
                                NazwaEnemy = "Szkielet";
                                HPenemy = 100;
                                manaEnemy = 0;
                                pancerzEnemy = 8;
                                silaEnemy = 5;
                                break;

                            case 35:
                                NazwaEnemy = "Duch";
                                HPenemy = 120;
                                manaEnemy = 80;
                                pancerzEnemy = 10;
                                silaEnemy = 6;
                                break;

                            case 36:
                                NazwaEnemy = "Wilkołak";
                                HPenemy = 170;
                                manaEnemy = 0;
                                pancerzEnemy = 16;
                                silaEnemy = 7;
                                break;

                            case 37:
                                NazwaEnemy = "Mumi";
                                HPenemy = 130;
                                manaEnemy = 0;
                                pancerzEnemy = 12;
                                silaEnemy = 5;
                                break;

                            case 38:
                                NazwaEnemy = "Wiedźma";
                                HPenemy = 150;
                                manaEnemy = 100;
                                pancerzEnemy = 14;
                                silaEnemy = 8;
                                break;

                            case 39:
                                NazwaEnemy = "Czarnoksiężnik";
                                HPenemy = 140;
                                manaEnemy = 120;
                                pancerzEnemy = 13;
                                silaEnemy = 7;
                                break;

                            case 40:
                                NazwaEnemy = "Wąż morski";
                                HPenemy = 160;
                                manaEnemy = 0;
                                pancerzEnemy = 15;
                                silaEnemy = 6;
                                break;

                            case 41:
                                NazwaEnemy = "Widmo";
                                HPenemy = 110;
                                manaEnemy = 150;
                                pancerzEnemy = 10;
                                silaEnemy = 7;
                                break;

                            case 42:
                                NazwaEnemy = "Niedźwiedź zombie";
                                HPenemy = 180;
                                manaEnemy = 0;
                                pancerzEnemy = 16;
                                silaEnemy = 8;
                                break;

                            case 43:
                                NazwaEnemy = "Pająk jadowity";
                                HPenemy = 120;
                                manaEnemy = 0;
                                pancerzEnemy = 11;
                                silaEnemy = 6;
                                break;

                            case 44:
                                NazwaEnemy = "Gargulec";
                                HPenemy = 150;
                                manaEnemy = 0;
                                pancerzEnemy = 14;
                                silaEnemy = 7;
                                break;

                            case 45:
                                NazwaEnemy = "Mroczny elf";
                                HPenemy = 140;
                                manaEnemy = 100;
                                pancerzEnemy = 13;
                                silaEnemy = 8;
                                break;

                            case 46:
                                NazwaEnemy = "Krasnolud zombi";
                                HPenemy = 160;
                                manaEnemy = 0;
                                pancerzEnemy = 15;
                                silaEnemy = 6;
                                break;

                            case 47:
                                NazwaEnemy = "Upadły anioł";
                                HPenemy = 180;
                                manaEnemy = 200;
                                pancerzEnemy = 18;
                                silaEnemy = 9;
                                break;

                            case 48:
                                NazwaEnemy = "Banshee";
                                HPenemy = 130;
                                manaEnemy = 150;
                                pancerzEnemy = 12;
                                silaEnemy = 7;
                                break;

                            case 49:
                                NazwaEnemy = "Bezkresny duch";
                                HPenemy = 150;
                                manaEnemy = 180;
                                pancerzEnemy = 14;
                                silaEnemy = 8;
                                break;

                            case 50:
                                NazwaEnemy = "Cienie";
                                HPenemy = 120;
                                manaEnemy = 0;
                                pancerzEnemy = 11;
                                silaEnemy = 6;
                                break;

                            case 51:
                                NazwaEnemy = "Duszek";
                                HPenemy = 110;
                                manaEnemy = 140;
                                pancerzEnemy = 10;
                                silaEnemy = 7;
                                break;

                            case 52:
                                NazwaEnemy = "Mroczny golem";
                                HPenemy = 200;
                                manaEnemy = 0;
                                pancerzEnemy = 20;
                                silaEnemy = 10;
                                break;

                            case 53:
                                NazwaEnemy = "Niedoszły duch";
                                HPenemy = 100;
                                manaEnemy = 0;
                                pancerzEnemy = 9;
                                silaEnemy = 5;
                                break;

                            case 54:
                                NazwaEnemy = "Topielica";
                                HPenemy = 130;
                                manaEnemy = 0;
                                pancerzEnemy = 12;
                                silaEnemy = 6;
                                break;

                            case 55:
                                NazwaEnemy = "Upiór";
                                HPenemy = 140;
                                manaEnemy = 160;
                                pancerzEnemy = 13;
                                silaEnemy = 7;
                                break;

                            case 56:
                                NazwaEnemy = "Odmieniec";
                                HPenemy = 150;
                                manaEnemy = 0;
                                pancerzEnemy = 14;
                                silaEnemy = 6;
                                break;

                            case 57:
                                NazwaEnemy = "Półdemon";
                                HPenemy = 180;
                                manaEnemy = 200;
                                pancerzEnemy = 16;
                                silaEnemy = 9;
                                break;

                            case 58:
                                NazwaEnemy = "Zombie żołnierz";
                                HPenemy = 160;
                                manaEnemy = 0;
                                pancerzEnemy = 15;
                                silaEnemy = 6;
                                break;

                            case 59:
                                NazwaEnemy = "Wampirzyca";
                                HPenemy = 140;
                                manaEnemy = 180;
                                pancerzEnemy = 13;
                                silaEnemy = 7;
                                break;

                            case 60:
                                NazwaEnemy = "Nekromanta";
                                HPenemy = 160;
                                manaEnemy = 200;
                                pancerzEnemy = 15;
                                silaEnemy = 8;
                                break;

                            case 61:
                                NazwaEnemy = "Duch cmentarny";
                                HPenemy = 150;
                                manaEnemy = 0;
                                pancerzEnemy = 14;
                                silaEnemy = 7;
                                break;

                            case 62:
                                NazwaEnemy = "Ogr";
                                HPenemy = 200;
                                manaEnemy = 0;
                                pancerzEnemy = 18;
                                silaEnemy = 10;
                                break;

                            case 63:
                                NazwaEnemy = "Niedźwiedź wampir";
                                HPenemy = 180;
                                manaEnemy = 0;
                                pancerzEnemy = 16;
                                silaEnemy = 8;
                                break;

                            case 64:
                                NazwaEnemy = "Troll z gór";
                                HPenemy = 220;
                                manaEnemy = 0;
                                pancerzEnemy = 20;
                                silaEnemy = 11;
                                break;

                            case 65:
                                NazwaEnemy = "Szkielet-łucznik";
                                HPenemy = 130;
                                manaEnemy = 0;
                                pancerzEnemy = 12;
                                silaEnemy = 7;
                                break;

                            case 66:
                                NazwaEnemy = "Wampirze drzewo";
                                HPenemy = 160;
                                manaEnemy = 0;
                                pancerzEnemy = 15;
                                silaEnemy = 8;
                                break;

                            case 67:
                                NazwaEnemy = "Latający goblin";
                                HPenemy = 120;
                                manaEnemy = 0;
                                pancerzEnemy = 11;
                                silaEnemy = 6;
                                break;

                            case 68:
                                NazwaEnemy = "Mroczny elf łucznik";
                                HPenemy = 140;
                                manaEnemy = 0;
                                pancerzEnemy = 13;
                                silaEnemy = 8;
                                break;

                            case 69:
                                NazwaEnemy = "Upadły kapłan";
                                HPenemy = 150;
                                manaEnemy = 200;
                                pancerzEnemy = 14;
                                silaEnemy = 9;
                                break;

                            case 70:
                                NazwaEnemy = "Topielec";
                                HPenemy = 130;
                                manaEnemy = 0;
                                pancerzEnemy = 12;
                                silaEnemy = 7;
                                break;

                            case 71:
                                NazwaEnemy = "Zmutowany szczur";
                                HPenemy = 90;
                                manaEnemy = 0;
                                pancerzEnemy = 8;
                                silaEnemy = 4;
                                break;

                            case 72:
                                NazwaEnemy = "Demoniczny pies";
                                HPenemy = 110;
                                manaEnemy = 0;
                                pancerzEnemy = 10;
                                silaEnemy = 5;
                                break;

                            case 73:
                                NazwaEnemy = "Wampirzy krab";
                                HPenemy = 140;
                                manaEnemy = 0;
                                pancerzEnemy = 13;
                                silaEnemy = 7;
                                break;

                            case 74:
                                NazwaEnemy = "Szkieletowy jeździec";
                                HPenemy = 170;
                                manaEnemy = 0;
                                pancerzEnemy = 15;
                                silaEnemy = 8;
                                break;

                            case 75:
                                NazwaEnemy = "Zombie mag";
                                HPenemy = 150;
                                manaEnemy = 100;
                                pancerzEnemy = 14;
                                silaEnemy = 7;
                                break;

                            default:
                                NazwaEnemy = "Nieznany potwór";
                                HPenemy = 0;
                                manaEnemy = 0;
                                pancerzEnemy = 0;
                                silaEnemy = 0;
                                break;
                        }
                        HPenemy += HPenemy * 10;
                        var e = HPenemy;
                        int b = zycie;

                        manaEnemy += manaEnemy * 3;
                        pancerzEnemy += pancerzEnemy * 2;
                        silaEnemy += silaEnemy * 4;
                        #endregion

                        #region// Atak przeciwnika

                        var Yestok = 1;
                        while (Yestok != 0)
                        {

                            if (Yestok == 1)//atak zwykły
                            {
                                int enemyDamage = rand.Next(silaEnemy - 2, silaEnemy + 4);
                                int damageDealtByEnemy = Math.Max(enemyDamage, 0);
                                zycie -= damageDealtByEnemy;
                                Console.Clear();
                                int heroDamage = Math.Max(atak - 2, atak + 4);
                                int damageDealtByHero = Math.Max(heroDamage, 0);
                                HPenemy -= damageDealtByHero;
                                Console.WriteLine($"┌─────────────────────────────────────────────────┬──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │                                                               WALCZYSZ Z {NazwaEnemy} ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│       WPISZ - 1 - BY ZADAĆ CIOS                 │ statatystyki przeciwnika:                  twoje statystyki               ");
                                Console.WriteLine($"│       WPISZ - 2 - BY ZROBIĆ UNIK                │     MP:{manaEnemy}                                    MP:{widz}              ");
                                Console.WriteLine($"│       WPISZ - 3 - BY ZADAĆ CIOS MAGICZNY        │     HP:{HPenemy}                                  HP:{zycie}              ");
                                Console.WriteLine($"│                                                 │     ARM:{pancerzEnemy}                                  ARM:{obrona}              ");
                                Console.WriteLine($"│                                                 │     ATK:{silaEnemy}                                  ATK:{atak}               ");
                                Console.WriteLine($"│                                                 │     ");
                                Console.WriteLine($"│                                                 ├────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────── ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ Zadałeś {NazwaEnemy} {damageDealtByHero} obrażeń. Pozostałe punkty życia przeciwnika: {HPenemy}");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ {NazwaEnemy} zadał ci {damageDealtByEnemy} obrażeń. Pozostałe punkty życia bohatera: {zycie}");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│       0 - wyjdz                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"└─────────────────────────────────────────────────┴───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                Console.Write(">>");

                            }
                            else if (Yestok == 2)//unik
                            {
                                Console.Clear();
                                string Tak = "";
                                string Unik = "";
                                Random rad = new Random();
                                int unik1 = rand.Next(1, n);
                                int unik = unik1;
                                switch (unik)
                                {
                                    case 1:
                                    case 2:
                                    case 3:
                                    case 4:
                                    case 5:
                                        Unik = "Unki się powiudł";
                                        break;
                                    case 6:
                                    case 7:
                                    case 8:
                                    case 9:
                                    case 10:
                                        int enemyDamage = rand.Next(silaEnemy - 2, silaEnemy + 4);
                                        int damageDealtByEnemy = Math.Max(enemyDamage, 0);
                                        zycie -= damageDealtByEnemy;
                                        Tak = $"Dostałeś {damageDealtByEnemy} obrarzeń zostało ci {zycie}";
                                        Unik = "Unki się nie powiudł";
                                        break;


                                }
                                Console.WriteLine($"┌─────────────────────────────────────────────────┬──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │                                                               WALCZYSZ Z {NazwaEnemy} ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│       WPISZ - 1 - BY ZADAĆ CIOS                 │ statatystyki przeciwnika:                  twoje statystyki               ");
                                Console.WriteLine($"│       WPISZ - 2 - BY ZROBIĆ UNIK                │     MP:{manaEnemy}                                    MP:{widz}              ");
                                Console.WriteLine($"│       WPISZ - 3 - BY ZADAĆ CIOS MAGICZNY        │     HP:{HPenemy}                                  HP:{zycie}              ");
                                Console.WriteLine($"│                                                 │     ARM:{pancerzEnemy}                                  ARM:{obrona}              ");
                                Console.WriteLine($"│                                                 │     ATK:{silaEnemy}                                  ATK:{atak}               ");
                                Console.WriteLine($"│                                                 │     ");
                                Console.WriteLine($"│                                                 ├────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────── ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │                     Twuj Unik:{Unik}");
                                Console.WriteLine($"│                                                 │                     {Tak}");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│       0 - wyjdz                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"└─────────────────────────────────────────────────┴───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                Console.Write(">>");
                            }
                            else if (Yestok == 3)
                            {
                                Console.Clear();
                                Console.WriteLine($"┌─────────────────────────────────────────────────┬──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │                                                               WALCZYSZ Z {NazwaEnemy} ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│       WPISZ - 1 - BY ZADAĆ CIOS                 │ statatystyki przeciwnika:                  twoje statystyki               ");
                                Console.WriteLine($"│       WPISZ - 2 - BY ZROBIĆ UNIK                │     MP:{manaEnemy}                                    MP:{widz}              ");
                                Console.WriteLine($"│       WPISZ - 3 - BY ZADAĆ CIOS MAGICZNY        │     HP:{HPenemy}                                  HP:{zycie}              ");
                                Console.WriteLine($"│                                                 │     ARM:{pancerzEnemy}                                  ARM:{obrona}              ");
                                Console.WriteLine($"│                                                 │     ATK:{silaEnemy}                                  ATK:{atak}               ");
                                Console.WriteLine($"│                                                 │     ");
                                Console.WriteLine($"│                                                 ├────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────── ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │  9-Magiczne tarcze:               10");
                                Console.WriteLine($"│                                                 │  10-Tworzenie pól energetycznych: 50");
                                Console.WriteLine($"│                                                 │  11-Modyfikacja rzeczywistości:  100");
                                Console.WriteLine($"│                                                 │  12-Niewidzialność:               30");
                                Console.WriteLine($"│                                                 │  13-Magia słowa:                  20");
                                Console.WriteLine($"│                                                 │  14-Antygrawitacja:               30");
                                Console.WriteLine($"│                                                 │  15-Nekromancja:                  80");
                                Console.WriteLine($"│                                                 │  16-Rozerwanie dusz:            1000");
                                Console.WriteLine($"│                                                 │  17-Magia chaotyczna:             60");
                                Console.WriteLine($"│       0 - wyjdz                                 │  18-Magia ognia:                  40");
                                Console.WriteLine($"│                                                 │  29-Przyciemnienie mentalne:      50");
                                Console.WriteLine($"│                                                 │  20-Telepatia:                    40");
                                Console.WriteLine($"│                                                 │  21-Magia eteru:                  50");
                                Console.WriteLine($"│                                                 │  22-Mistrzostwo iluzji:           40");
                                Console.WriteLine($"│                                                 │  23-Wywoływanie klątw:            70");
                                Console.WriteLine($"│                                                 │  24-Magia światła:                50");
                                Console.WriteLine($"│                                                 │  25-Manipulacja przestrzenią:     70");
                                Console.WriteLine($"│                                                 │  26-Magia ciemności:              45");
                                Console.WriteLine($"│                                                 │  27-Magia wiatru:                 55");
                                Console.WriteLine($"│                                                 │  28-Magia powietrza:              40");
                                Console.WriteLine($"│                                                 │  29-Magia ziemi:                  45");
                                Console.WriteLine($"│                                                 │  30-Magia pustki:                 55");
                                Console.WriteLine($"│                                                 │  31-Absorpcja energii:            50");
                                Console.WriteLine($"│                                                 │  32-Magia lodu:                   40");
                                Console.WriteLine($"│                                                 │  33-Sztuka przeklęta:            120");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"└─────────────────────────────────────────────────┴───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                Console.Write(">>");
                                var atkUmiej = Console.ReadLine();
                                var urzytaUm = "";
                                var atakMagiczny = 0;
                                switch (atkUmiej)
                                {
                                    case "9"://tarcza
                                        if (widz > 10)
                                        {
                                            silaEnemy = 0;
                                            widz -= 10;
                                            urzytaUm = "Urzyłeś Tarczy Magicznej:zablokowałeś atak przeciwnika";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "10"://pole Energetyczne
                                        if (widz > 50)
                                        {
                                            HPenemy = 400;
                                            widz -= 50;
                                            urzytaUm = "Urzyłeś Tworzenie pól energetycznych: Zadałeś obrażenia";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "11"://pole Energetyczne
                                        if (widz > 100)
                                        {
                                            widz -= 100;
                                            HPenemy = b;
                                            zycie = a;
                                            urzytaUm = "Modyfikacja rzeczywistości: Zamiana statystyk";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }

                                        break;
                                    case "12"://niewidzialność

                                        if (widz > 30)
                                        {
                                            zycie += 10;
                                            widz -= 30;
                                            urzytaUm = "Urzyłeś niewidzilność: Uciekłeś od besti masz czas na urzycie HP potki z eq";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }

                                        break;
                                    case "13":
                                        if (widz > 20)
                                        {
                                            HPenemy -= 200;
                                            silaEnemy -= 15;
                                            widz -= 20;
                                            urzytaUm = "Urzyłeś Magi słuw: Zadałeś obrażenia i zmiejszyłeś obrażenia zadawane przez przeciwnika";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "14":
                                        if (widz > 40)
                                        {
                                            widz -= 40;
                                            silaEnemy -= 6;
                                            urzytaUm = "Urzyłes AntyGrawitacji: Besta nie wie co się dzieje i ma jej ataki nie są takie mocne";
                                        }

                                        break;
                                    case "15":
                                        if (widz > 80)
                                        {
                                            widz -= 80;
                                            atak += 20;
                                            urzytaUm = "Urzyłeś nekromancjie: Zwłki poległych przed tobą będą i teraz towarzyszyć do twojej śmierci";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "16":
                                        if (widz > 1000)
                                        {
                                            widz = 1000;
                                            atak += 21;
                                            urzytaUm = "Urzyłeś rozerwania dusz:Zabiłes Beste lecz zapłaciłes za to wyskoką cene ";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "17":
                                        if (widz > 60)
                                        {
                                            widz -= 60;
                                            HPenemy -= 600;
                                            manaEnemy -= 200;
                                            urzytaUm = "Magia Chaosu: Wywołała zamęt w sercu besti a takrze jej skura została doszczętnie zniszczona";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "18":
                                        if (widz > 40)
                                        {
                                            widz -= 40;
                                            HPenemy -= 300;
                                            urzytaUm = "Magia Ognia: Bestia zaznała powarznych obrazeń";
                                        }

                                        break;
                                    case "19":
                                        if (widz > 25)
                                        {
                                            widz -= 25;
                                            HPenemy -= 600;
                                            silaEnemy += 100;
                                            urzytaUm = "Przyciemnienie mentalne: Bestia Poadła w obłęd sama się zaczeł obdzierać ze skury ale ma za to silniejsze ataki";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "20":
                                        if (widz > 40)
                                        {
                                            widz -= 40;
                                            HPenemy -= 30;
                                            silaEnemy -= 1;
                                            urzytaUm = "Telepatia: Wysyszasz z umysłu besti mane ";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "21":
                                        if (widz > 50)
                                        {
                                            widz -= 50;
                                            HPenemy -= 20;
                                            silaEnemy += 10;
                                            pancerzEnemy -= 100;
                                            urzytaUm = "Magia eteru:Przez drgania bestia starcia morzliwość słuchi z czego zwiększ sie jej czujność";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "22":
                                        if (widz > 40)
                                        {
                                            widz -= 40;
                                            zycie += 100;
                                            urzytaUm = "Urzyłeś Magi Iluzji: Bestai się nabrała masz czas żeby letko opatrzeć";
                                        }

                                        break;
                                    case "23":
                                        if (widz > 70)
                                        {
                                            widz -= 70;
                                            zycie -= 20;
                                            silaEnemy -= 10;
                                            pancerzEnemy -= 100;
                                            urzytaUm = "Wywoływanie klątw:Poświęciłeś odrobine krwi na odprawienie rytułału przywołania klątwy, osłabiłeś bestie";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "24":
                                        if (widz > 40)
                                        {
                                            widz -= 40;
                                            zycie -= 100;
                                            urzytaUm = "Magia Światła: Udało ci się uzyskać łaske bożą";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "25":
                                        if (widz > 10)
                                        {
                                            HPenemy -= 500;
                                            widz -= 70;
                                            urzytaUm = "Manipulacja przestrzenią: Podczas biegu zmniejszyłeś dystans dzielący cię od besti i zdałeś jej sporo obrażeń nie ponosząc żednych ";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "26":
                                        if (widz > 10)
                                        {
                                            manaEnemy -= manaEnemy;
                                            widz -= 40;
                                            widz -= 45;
                                            zycie -= 20;
                                            urzytaUm = "Magia Ciemnosći : pozbawiłeś bestie many ale doznałeś takrze efektów ubocznych ciemność";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "27":
                                        if (widz > 10)
                                        {
                                            HPenemy -= 30;
                                            widz -= 50;
                                            urzytaUm = "Magia Wiatru: strzeliłes kilkoma wiatrowmi pociskami ale nie wyrzędziłeś wieklich szkód";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "28":
                                        if (widz > 10)
                                        {
                                            HPenemy -= 60;
                                            widz -= 40;
                                            urzytaUm = "Magia Powietrza: Prubowałeś pozbawić bestie powietrza ale zdołała się wyzwolić ";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "29":
                                        if (widz > 10)
                                        {
                                            widz -= 45;
                                            urzytaUm = "Magia ziemi: stworzyłeś wielki ziemny pilar który ochroni cie przez chwile przed walką ";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "30":
                                        if (widz > 10)
                                        {
                                            widz -= 55;
                                            pancerzEnemy = 0;
                                            urzytaUm = "Magia pustki: stworzyłeś mała czarna dziure bestia w ostatniej woli odpina pancerz i wrzuca go do odchłani zamiast siebie ";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "31":
                                        if (widz > 10)
                                        {
                                            widz -= 50;
                                            zycie += silaEnemy;
                                            HPenemy -= silaEnemy;
                                            urzytaUm = "Absorpcja energii: dostałeś obrażenia ale zamieniłeś je na wałsne zdrowie a best je odałeś";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "32":
                                        if (widz > 10)
                                        {
                                            widz -= 40;
                                            pancerzEnemy -= atak;
                                            urzytaUm = "magia lodu: Zuciłeś zakloęcie na ziemie co utrudniło poruszanie się besti";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                    case "33":
                                        if (widz > 10)
                                        {
                                            widz -= 120;
                                            atak += silaEnemy;
                                            urzytaUm = "Sztuka przeklęta: Prezklnołeś swoją włąsą broń dzięki temu zadajesz wiecej obrażeń";
                                        }
                                        else
                                        {
                                            urzytaUm = "Nie stać cie na tą umiejetność";
                                        }
                                        break;
                                }
                                Console.Clear();
                                Console.WriteLine($"┌─────────────────────────────────────────────────┬──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│                                                 │                                                               WALCZYSZ Z {NazwaEnemy} ");
                                Console.WriteLine($"│                                                 │ ");
                                Console.WriteLine($"│       WPISZ - 1 - BY ZADAĆ CIOS                 │ statatystyki przeciwnika:                  twoje statystyki               ");
                                Console.WriteLine($"│       WPISZ - 2 - BY ZROBIĆ UNIK                │     MP:{manaEnemy}                                    MP:{widz}              ");
                                Console.WriteLine($"│       WPISZ - 3 - BY ZADAĆ CIOS MAGICZNY        │     HP:{HPenemy}                                  HP:{zycie}              ");
                                Console.WriteLine($"│                                                 │     ARM:{pancerzEnemy}                                  ARM:{obrona}              ");
                                Console.WriteLine($"│                                                 │     ATK:{silaEnemy}                                  ATK:{atak}               ");
                                Console.WriteLine($"│                                                 │     ");
                                Console.WriteLine($"│                                                 ├────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────── ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │          {urzytaUm}                ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│       0 - wyjdz                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"│                                                 │  ");
                                Console.WriteLine($"└─────────────────────────────────────────────────┴───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                Console.Write(">>");
                            }
                            if (zycie <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("-------------------------------------------------------------------------Przegryw");
                                Thread.Sleep(2000);
                                break;
                            }
                            if (HPenemy <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("-------------------------------------------------------------------------WYGRYWASZ I ZDOBYWASZ 10 PX");
                                lvlBochater += 10;
                                Thread.Sleep(2000);
                                break;
                            }
                            Yestok = int.Parse(Console.ReadLine());

                        }
                        #endregion


                    }

        }

    }
}



