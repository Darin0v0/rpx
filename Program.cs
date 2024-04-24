﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class Program
    {
        private const string Value = "ΔΔΔ";

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("Witaj w grze RPG!");
            Console.WriteLine("Podaj Nick");

            var Input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Classa 1-Mag 2-Łucznik 3-Ryczerz 4-Barbarzyńca 5-Vampir 6-Złodziej 7-Druid 8-Zielarz 9-Mechanik 10-Paladyn 11-Mnich \n12-Kapłan  13-Szermierz 14-Strażnik 15-Łowca 16-Szaman 17-Alchemik 18-Egzekutor 19-Mistrz broni 20-Zwiadowca \n21-Zaklinacz 22-Templariusz 23-Biskup 24-Szlachcic 25-Drwal 26-Samuraj 27-Poszukiwacz przygód 28-Kowal 29-Generał \n30-Architekt 31-Prorok 32-Heretyk 33-Wygnaniec 34-Fanatyk 35-Włóczęga 36-Skryba 37-Łowca Demonów 38-Zabójca Bestii \n39-Uzdrowiciel 40-Zielarz 41-Wieśniak 42-Mag pustki 43-Bochater 44-Bard 45-Wodana Nimfa 46-Nimfa Ognia \n47-Tropiciel 48-Duch Lasu 49-Opiekun 50-Krzyrzak 51-Champion 52-Driada 53-Niewolik 54-wiedzmia 55-Dezerter 56-Szuja \n57-Informatyk 58-Gurnik 59-Przeklęty 60-Uczeń 61-Tamer");
            Console.WriteLine("Na start możesz wybrać klasę, każda ma inne rozdystrybuowanie 10 punktów umiejętności i inne cechy");
            int inputClass = int.Parse(Console.ReadLine());
            #region//klasy


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
                    mana = 400;
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
                case 46:
                    className = "Nimfa Wodna";
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
            #region//zapyrtanie po wartośi
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
            #endregion
            Console.Clear();
            Console.WriteLine("1. Krasnolud 2. Elf 3. Mroczny elf 4. Wysoki elf 5. Ork 6. Człowiek 7. Gnom 8. Halfling 9. Kotmorf 10. Goblin \n11. Faun 12. Minotaur 13. Lizardfolk 14. Tiefling 15. Aarakocra 16. Kenku 17. Oni 18. Firbolg 19. Yuan-ti 20. Gith\n21. Kobold 22. Warforged 23. Genasi 24. Shifter 25. Goliath 26. Drow 27. Aasimar 28. Tortle 29. Svirfnrbil 30. Sylph\n31. Satyr 32. Firran 33. Svirfneblin 34. Changeling 35. Triton 36. Tabaxi 37. Centaur 38. Tengu 39. Warlock 40. Dhampir");
            Console.WriteLine("Wybierz Rase Kazda rasa da ci jakieś bufy i debufy max +5 -10");
            int InputRasy = int.Parse(Console.ReadLine());
            #region //rasy
            switch (InputRasy)
            {
                case 1://Krasnolud 
                    Siła -= 1;
                    pancerz += 20;
                    break;
                case 2://Elf 
                    Zręczność += 5;
                    pancerz -= 10;
                    break;
                case 3://Mroczny elf 
                    Wiedza += 5;
                    zdrowie += 10;
                    break;
                case 4://Wysoki elf
                    WrodzonaWiedza += 5;
                    zdrowie -= 10;
                    break;
                case 5://Ork 
                    Siła += 5;
                    zdrowie -= 10;
                    break;
                case 6://Człowiek 
                    Zwinność += 1;
                    break;
                case 7://Gnom 
                    Wiedza += 5;
                    mana -= 10;
                    break;
                case 8://Halfling 
                    Zręczność += 5;
                    mana -= 10;
                    break;
                case 9://Kotmorf 
                    Elastyczność += 5;
                    zdrowie -= 20;
                    break;
                case 10://Goblin 
                    pancerz -= 10;
                    mana -= 10;
                    break;
                case 11://Faun 
                    poetyckosc += 5;
                    pancerz += 10;
                    break;
                case 12://Minotaur 
                    Siła += 5;
                    mana -= 10;
                    break;
                case 13://Lizardfolk 
                    Wytrzymałość += 5;
                    mana -= 10;
                    break;
                case 14://Tiefling 
                    Wiedza += 5;
                    pancerz -= 10;
                    break;
                case 15://Aarakocra 
                    Zwinność += 5;
                    pancerz -= 10;
                    break;
                case 16://Kenku 
                    SztukaWalkiBroniaBiala += 5;
                    pancerz -= 10;
                    break;
                case 17://oni
                    Siła += 5;
                    zdrowie -= 10;
                    break;
                case 18://Firbolg 
                    Wiedza += 5;
                    pancerz -= 10;
                    break;
                case 19://Yuan-ti 
                    Wiedza += 5;
                    SztukaPrzeklęta += 1;
                    pancerz -= 10;
                    break;
                case 20://Gith 
                    Wiedza += 5;
                    Telepatia += 1;
                    zdrowie -= 10;
                    break;
                case 21://Kobold 
                    Zwinność += 2;
                    RozbrajaniePulapek += 1;
                    break;
                case 22://Warforged 
                    pancerz += 20;
                    Wytrzymałość += 2;
                    Siła -= 1;
                    break;
                case 23://Genasi 
                    Zręczność += 3;
                    zdrowie -= 10;
                    break;
                case 24://Shifter 
                    Siła += 4;
                    ZmienianieKształtu += 1;
                    pancerz -= 20;
                    break;
                case 25://Goliath 
                    Wytrzymałość += 4;
                    SiłaWoli += 1;
                    mana -= 20;
                    break;
                case 26://Drow 
                    Zwinność += 4;
                    Ukrywanie += 1;
                    zdrowie -= 10;
                    break;
                case 27://Aasimar 
                    MagiaŚwiatła += 2;
                    Wiedza += 3;
                    mana -= 20;
                    break;
                case 28://Tortle 
                    Wytrzymałość += 2;
                    pancerz += 10;
                    mana -= 20;
                    break;
                case 29://Svirfnrbil 
                    Wiedza += 3;
                    Ziołolecznictwo += 2;
                    pancerz -= 20;
                    break;
                case 30://Sylph 
                    Zwinność += 4;
                    Niewidzialność += 1;
                    zdrowie -= 10;
                    break;
                case 31://Satyr 
                    poetyckosc += 3;
                    WyczuciePoezji += 1;
                    break;
                case 32://Firran 
                    Zwinność += 4;
                    break;
                case 33://Svirfneblin 
                    Zręczność += 2;
                    Instynkt += 1;
                    break;
                case 34://Changeling 
                    Zręczność += 2;
                    Ukrywanie += 3;
                    pancerz -= 2;
                    break;
                case 35://Triton 
                    pancerz -= 20;
                    WytrzymaloscPsychiczna = 5;
                    break;
                case 36://Tabaxi 
                    Zwinność += 2;
                    Rzemiosło += 3;
                    pancerz -= 10;
                    break;
                case 37://Centaur 
                    Siła += 3;
                    Wytrzymałość += 1;
                    break;
                case 38://Tengu 
                    HeroicznyNatarcie += 1;
                    break;
                case 39://Warlock 
                    Wytrzymałość += 2;
                    PogłębioneZrozumienieMagii += 2;
                    zdrowie -= 10;
                    break;
                case 40://Dhampir 
                    MagiaCiemności += 3;
                    Wiedza += 2;
                    mana -= 10;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
            #endregion
            #region//zapyrtanie po wartośi
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
            #endregion
            Console.Clear();
            // Game loop
            Console.Clear();
            #region//Wybur lokalizacji
            Console.WriteLine("1-Wioska na obrzeżach lasu:\r\n" +
                "2-Stara wieża widokowa na szczytach gór:\r\n" +
                "3-Portowa dzielnica miasta na brzegu morza.\r\n" +
                "4-Opuszczony zamek w głębi lasu.\r\n" +
                "5-Karczma w podrzędnym mieście na szlaku handlowym.\r\n" +
                "6-Jaskinia na stromym zboczu góry.\r\n" +
                "7-Tajemnicza wyspa otoczona mgłą.\r\n" +
                "8-Podziemia starożytnej świątyni.\r\n" +
                "9-Leśna polana z tajemniczymi ruinami.\r\n" +
                "10-Magiczny labirynt pełen pułapek.\r\n" +
                "11-Wysepka na jeziorze, dostępna tylko łodzią.\r\n" +
                "12-Górzysty teren z licznymi jaskiniami i dolinami.\r\n" +
                "13-Osada na pustyni, zdominowana przez nomadów.\r\n" +
                "14-Podwodna jaskinia w głębinach oceanu.");
            #endregion
            #region//Lokalizacje startowe
            int InputLokalizaja = int.Parse(Console.ReadLine());
            switch (InputLokalizaja)
            {
                case 1:
                    Console.WriteLine("1- Wioska na obrzeżach lasu:\nWioska ta spoczywa na pograniczu gęstych drzew i dzikiej przyrody. Zbudowane z drewnianych chat, które otaczają centralny plac, gdzie dzieci bawią się wesoło, a dorośli handlują lokalnymi produktami. Przez wioskę przepływa rwący strumień, nad którym łagodnie wygięty most umożliwia przemieszczanie się między jej dwoma brzegami. Spokój i harmonia są tutaj na porządku dziennym, a mieszkańcy żyją zgodnie z naturą, szanując jej piękno i tajemnicę.");
                    WięźZeSpirytamiNatury += 1;
                    break;
                case 2:
                    Console.WriteLine("2- Stara wieża widokowa na szczytach gór:\nWieża ta, starożytna i majestatyczna, wznosi się dumnie na najwyższym szczycie górskim, jak strażnik nad otaczającymi krajobrazami. Jej kamienna konstrukcja wydaje się przetrwać wieki, opowiadając historie minionych czasów. Z wierzchołka wieży rozpościera się zapierający dech w piersiach widok na rozległe doliny, gęste lasy i nieokiełznane rzeki. To miejsce, gdzie można oderwać się od zgiełku codzienności i zanurzyć w spokoju i pięknie natury, kontemplując majestatyczne góry i ich tajemnice.");
                    break;
                case 3:
                    Console.WriteLine("3- Portowa dzielnica miasta na brzegu morza:\nTa portowa dzielnica pulsuje życiem i działalnością od wczesnych godzin porannych do późnych nocnych godzin. Stare, kolorowe domki rybackie, przemalowane na pastelowe kolory, wystają spomiędzy gęstej mgły, unoszącej się nad morzem. Rybacy wracają z połowów, przynosząc ze sobą świeże łupy, które natychmiast trafiają na tutejsze targowiska. Wąskie uliczki wypełnione są zapachami soli morskiej, świeżego rybnego smażenia i dźwiękami mew krążących w powietrzu. Portowa dzielnica emanuje energią i charakterem, przyciągając zarówno mieszkańców, jak i turystów.");
                    break;
                case 4:
                    Console.WriteLine("4- Opuszczony zamek w głębi lasu:\nTen opuszczony zamek, zatopiony w głębi dzikiego lasu, wydaje się być zatopiony w czasie. Jego mury, choć pokryte mchem i porośnięte dziką roślinnością, wciąż emanują potężną aurą i tajemnicą. Wieże i krużganki, kiedyś majestatyczne, teraz stoją jako zwiędłe świadectwo przemijania. Wnętrze zamku jest pełne zapomnianych sal, w których echo dawnych czasów wciąż wydaje się płynąć. To miejsce wzbudza zarówno fascynację, jak i niepokój, przyciągając odważnych badaczy, gotowych odkrywać jego sekrety.");
                    break;
                case 5:
                    Console.WriteLine("5- Karczma w podrzędnym mieście na szlaku handlowym:\nTa karczma, skryta w podrzędnym mieście na ruchliwym szlaku handlowym, to miejsce spotkań podróżnych, kupców i poszukiwaczy przygód. Jej drewniane ściany są wypisane historiami niezliczonych podróży i wymiany handlowej. Wnętrze karczmy jest wypełnione gwarem rozmów, śmiechem i aromatami przypraw i pieczonych potraw. Właściciel, doświadczony gospodarz, serwuje tutaj najsmaczniejsze dania i trunki, gotowy wysłuchać opowieści każdego podróżnika, który przekroczy próg tego miejsca.");
                    break;
                case 6:
                    Console.WriteLine("6- Jaskinia na stromym zboczu góry:\nTa jaskinia, ukryta na stromym zboczu góry, jest schronieniem dla tych, którzy poszukują ciszy i spokoju. Jej wejście otoczone jest dziką roślinnością, a wewnętrzne komory kryją w sobie bogactwo stalaktytów i stalagmitów. Światło słoneczne przebija się przez szczeliny w skale, oświetlając podziemne jeziora i korytarze. To miejsce emanuje mistyczną energią, przyciągając zarówno badaczy, jak i poszukiwaczy wewnętrznego spokoju.");
                    break;
                case 7:
                    Console.WriteLine("7- Tajemnicza wyspa otoczona mgłą:\nTa tajemnicza wyspa, otoczona gęstą mgłą, budzi ciekawość i lęki tych, którzy próbują zbadać jej tajemnice. Jej brzegi są ostre i skaliste, a plaże pokryte są drobnym piaskiem i ukrytymi skarbami. Gęsta roślinność tropikalna przykrywa wnętrze wyspy, ukrywając w sobie starożytne ruiny i nieodkryte sekrety. Niezliczone opowieści krążą o tej wyspie, często pełne magii i legend, które przyciągają śmiałków gotowych odkryć prawdę za mgiełką.");
                    break;
                case 8:
                    Console.WriteLine("8- Podziemia starożytniej świątyni:\nTe podziemia, skryte pod starożytną świątynią, są labiryntem tajemnic i niebezpieczeństw. Komory i korytarze są pełne starożytnych artefaktów i rytuałów, które pragną zostać odkryte przez odważnych badaczy. Ściany są ozdobione rzeźbami i inskrypcjami, które opowiadają historie zapomnianych bogów i bohaterów. Wśród labiryntu czają się jednak niebezpieczeństwa, które próbują powstrzymać intruzów przed dotarciem do swoich tajemnic.");
                    break;
                case 9:
                    Console.WriteLine("9- Leśna polana z tajemniczymi ruinami:\nTa leśna polana, otoczona przez drzewa i dziką roślinność, kryje w sobie tajemnicze ruiny dawnych budowli. Ich pochodzenie i przeznaczenie pozostają enigmą, która przyciąga badaczy i poszukiwaczy przygód. Wśród porośniętych mchem ścian i kolumn można odnaleźć starożytne artefakty i przedmioty, które prowadzą do jeszcze większych zagadek i tajemnic ukrytych w głębi lasu.");
                    break;
                case 10:
                    Console.WriteLine("10- Magiczny labirynt pełen pułapek:\nTen magiczny labirynt, snujący się między drzewami i skałami, jest miejscem próby dla odważnych i sprytnych. Jego ścieżki zmieniają się i przemieszczają, utrudniając nawigację dla tych, którzy próbują go przemierzyć. Pułapki i zaklęcia czają się na każdym kroku, testując zdolności i determinację wędrowców. Tylko ci najbardziej przebiegli mogą ujrzeć światło na końcu labiryntu i odkryć jego największe tajemnice.");
                    break;
                case 11:
                    Console.WriteLine("11- Wysepka na jeziorze, dostępna tylko łodzią:\nTa wysepka, spokojna i urocza, leży na środku spokojnego jeziora, dostępnego tylko za pomocą łodzi lub kajaka. Jej brzegi są porośnięte gęstą roślinnością, a na środku znajduje się urokliwy domek lub kapliczka. To idealne miejsce dla tych, którzy pragną uciec od zgiełku świata i zanurzyć się w harmonii natury, słuchając szumu fal i śpiewu ptaków.");
                    break;
                case 12:
                    Console.WriteLine("12- Górzysty teren z licznymi jaskiniami i dolinami:\nTen górzysty teren, porywający swym pięknem i surowością, jest domem dla licznych jaskiń i dolin, które kryją w sobie bogactwo fauny i flory. Wysokie szczyty gór i głębokie wąwozy tworzą malowniczy krajobraz, który przyciąga zarówno miłośników przyrody, jak i poszukiwaczy przygód. Tajemnicze jaskinie, ukryte wśród skał, czekają na odważnych odkrywców gotowych zgłębiać ich sekrety.");
                    break;
                case 13:
                    Console.WriteLine("13- Osada na pustyni, zdominowana przez nomadów:\nTa osada na pustyni, wznosząca się wśród fal piasków, jest domem dla nomadycznych plemion, które od wieków przemieszczają się w poszukiwaniu wody i pożywienia. Ich namioty i jurty tworzą skromne, ale funkcjonalne miasteczko, gdzie handel i wymiana kulturowa kwitną na tle surowego krajobrazu. Ludzie ci są twardzi i wytrwali, przywiązani do swych tradycji i zwyczajów, przetrwający w nieustannym wysiłku i walce z przyrodą.");
                    break;
                case 14:
                    Console.WriteLine("14- Podwodna jaskinia w głębinach oceanu:\nTa podwodna jaskinia, schowana głęboko pod powierzchnią oceanu, jest ukrytym skarbem dla tych, którzy poszukują nieodkrytych zakątków podwodnego świata. Jej kryształowe komory są domem dla egzotycznych form życia morskiego i ukrytych skarbów, które czekają na odkrycie. Nurkowie, odważni i zafascynowani, próbują dotrzeć do wnętrza jaskini, gotowi stawić czoła niebezpieczeństwom i tajemnicom, które kryje głębiny oceanu.");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
                    Console.WriteLine("Klikin jakis prtzycisk by kontynułowć");
                    Console.ReadLine();
            }
            #endregion
            //271
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌──────────────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine($"│█     CLASSA:{className,-10}                                                                                                                                                                                                                                              ");
                Console.WriteLine($"│█     PODSTAWOWE INFORMACJE:                                                                                                                                                                                                                                              ");
                Console.WriteLine($"│█     ZDROWIE:{zdrowie,-3}                                                                                                                                                                                                                                                ");
                Console.WriteLine($"│█     MANA:{mana,-3}                                                                                                                                                                                                                                                      ");
                Console.WriteLine($"│█     PANCERZ:{pancerz,-3}                                                                                                                                                                                                                                                ");
                Console.WriteLine($"│█     SIŁA:{Siła,-3}                                                                                                                                                                                                                                                      ");
                Console.WriteLine($"│█     ZRĘCZMOŚĆ: {Zręczność, -3}                                                                                                                                                                                                                                          ");
                Console.WriteLine($"│█     CHARYZMA: {Charyzma,-3}                                                                                                                                                                                                                                             ");
                Console.WriteLine($"│█                                                                                                                                                                                                                                                                         ");
                Console.WriteLine($"│█                                                                                                                                                                                                                                                                         ");
                Console.WriteLine($"│█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine($"├──────────────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│     CO CHCESZ ZROBIĆ?                                                    │  STATYSTYKI:                                                                                                                                                                                  ");
                Console.WriteLine($"│                                                                          │       Sztuka przeklęta: {SztukaPrzeklęta,-3}\tErecyzja: {Precyzja,-3}\tPrzetrwanie w warunkach ekstremalnych: {PrzetrwanieWWarunkachEkstremalnych,-3}            ");
                Console.WriteLine($"│      1 - SPRAWDZ MAPE                                                    │       Wiedza: {Wiedza,-3}\tManipulacja charyzmą: {ManipulacjaCharyzmą,-3}\tPraca nad ciałem: {PracaNadCiałem,-3}                               ");
                Console.WriteLine($"│                                                                          │       Wytrzymałość: {Wytrzymałość,-3}\tWizja mistyczna: {WizjaMistyczna,-3}\tHeroiczny natarcie: {HeroicznyNatarcie,-3}                          ");
                Console.WriteLine($"│      2 - WYLEJ POT I KREW W WALCE                                        │       Szczęście: {Szczęście,-3}\tPrzyciemnienie mentalne: {PrzyciemnienieMentalne,-3}\tMagia światła: {MagiaŚwiatła,-3}                                    ");
                Console.WriteLine($"│                                                                          │       Skrytobójstwo: {Skrytobójstwo,-3}\tFałszerstwo: {Fałszerstwo,-3}\tMagia ciemności: {MagiaCiemności,-3}                                ");
                Console.WriteLine($"│      3- EKSPORUJ                                                         │       Odporność magiczna: {OdpornośćMagiczna,-3}\tRzucanie czarów: {RzucanieCzarów,-3}\tMagia ognia: {MagiaOgnia,-3}                                        ");
                Console.WriteLine($"│                                                                          │       Rzemiosło: {Rzemiosło,-3}\tWarzenie eliksirów: {WarzenieEliksirów,-3}\tMagia wiatru: {MagiaWiatru,-3}                                      ");
                Console.WriteLine($"│                                                                          │       Ujezdzanie konia: {BieganieKonia,-3}\tManipulacja energią: {ManipulacjaEnergią,-3}\tWykorzystanie środowiska: {WykorzystanieSrodowiska,-3}              ");
                Console.WriteLine($"│                                                                          │       Elastyczność: {Elastyczność,-3}\tManipulacja czasem: {ManipulacjaCzasem,-3}\tMagia ziemi: {MagiaZiemi,-3}                                        ");
                Console.WriteLine($"│                                                                          │       Instynkt: {Instynkt,-3}\tWięź ze duchami natury: {WięźZeSpirytamiNatury,-3}\tMagia powietrza: {MagiaPowietrza,-3}                                ");
                Console.WriteLine($"│                                                                          │       Charyzma bojowa: {CharyzmaBojowa,-3}\tMistrzostwo iluzji: {MistrzostwoIluzji,-3}\tMagia pustki: {MagiaPustki,-3}                                      ");
                Console.WriteLine($"│                                                                          │       Koncentracja: {Koncentracja,-3}\t Magia krwi: {MagiaKrwi,-3}\tStrażnik: {Strażnik,-3}                                             ");
                Console.WriteLine($"│                                                                          │       Umiejętności przetrwania: {UmiejętnościPrzetrwania,-3}\tRozerwanie dusz: {RozerwanieDusz,-3}\tSztuka walki bronią białą: {SztukaWalkiBroniaBiala,-3}              ");
                Console.WriteLine($"│                                                                          │       Ukrywanie: {Ukrywanie,3}\tPenetracja: {Penetracja,-3}\tAbsorpcja energii: {AbsorpcjaEnergii,-3}                            ");
                Console.WriteLine($"│                                                                          │       Śledzenie: {Śledzenie,3}\tCzytanie aury: {CzytanieAury,-3}\tOdczytywanie emocji: {OdczytywanieEmocji,-3}                        ");
                Console.WriteLine($"│                                                                          │       Intuicja: {Intuicja,3}\tTworzenie portali: {TworzeniePortali,-3}\tWydobycie wglądu: {WydobycieWglądu,-3}                              ");
                Console.WriteLine($"│                                                                          │       Siła woli: {SiłaWoli,3}\t Magiczne tarcze: {MagiczneTarcze,-3}\tMagia lodu: {MagiaLodu,-3}                                          ");
                Console.WriteLine($"│                                                                          │       Charyzma lidera: {CharyzmaLidera,3}\tModyfikacja rzeczywistości: {ModyfikacjaRzeczywistości,-3}\tNiewidzialność: {Niewidzialność,-3}                                 ");
                Console.WriteLine($"│                                                                          │       Zrozumienie intuicji: {ZrozumienieIntuicji,3}\tPrzełamywanie granicy: {PrzełamywanieGranicy,-3}\tMagia chaotyczna: {MagiaChaotyczna,-3}                              ");
                Console.WriteLine($"│                                                                          │       Elastyczność mentalna: {ElastycznośćMentalna,3}\tManipulacja energią życiową:{ManipulacjaEnergiąŻyciową,-3}Przewidywanie zagrożeń: {PrzewidywanieZagrożeń,-3}                  ");
                Console.WriteLine($"│                                                                          │       Medytacja: {Medytacja,-3}\tManipulacja przestrzenią: {ManipulacjaPrzestrzenią,-3}\tMagia eteru: {MagiaEteru,-3}                                        ");
                Console.WriteLine($"│                                                                          │       Negocjacje: {Negocjacje,-3}\tZiołolecznictwo: {Ziołolecznictwo,-3}\tPerswazja: {Perswazja,-3}                                           ");
                Console.WriteLine($"│                                                                          │       Intuicja walki: {IntuicjaWalki}\tUnikanie: {Unikanie,-3}\tTropienie: {Tropienie,-3}                                           ");
                Console.WriteLine($"│       0 - wyjdz                                                          │       Charyzma zwierząt: {CharyzmaZwierząt,-3}\tMaskowanie magii: {MaskowanieMagii,-3}\tMediacja: {Mediacja,-3}                                             ");
                Console.WriteLine($"│                                                                          │       Nekromancja: {Nekromancja,-3}\tWywoływanie klątw: {WywoływanieKlątw,-3}\tWiedza medyczna: {WiedzaMedyczna,-3}                                ");
                Console.WriteLine($"│                                                                          │       Wrodzona wiedza: {WrodzonaWiedza,-3}\tTelepatia: {Telepatia,-3}\tYing Yang: {yingYang,-3}                                            ");
                Console.WriteLine($"│                                                                          │       Zdolność maskowania: {ZdolnośćMaskowania,-3}\tUdzielanie mocy: {UdzielanieMocy,-3}\tTargowanie się: {TargowanieSie,-3}                                  ");
                Console.WriteLine($"│                                                                          │       Wyostrzone zmysły: {WyostrzoneZmysły,-3}\tDowodzenie armiami: {DowodzenieArmiami,-3}\tTaktyka: {Taktyka,-3}                                               ");
                Console.WriteLine($"│                                                                          │       Czujność: {Czujność,-3}\tMędrzec: {Mędrzec,-3}\tPlotkowanie: {Plotkowanie,-3}                                       ");
                Console.WriteLine($"│                                                                          │       Samodoskonalenie: {Samodoskonalenie,-3}\tKontrola grawitacji: {KontrolaGrawitacji,-3}\tDedukcja: {Dedukcja,-3}                                             ");
                Console.WriteLine($"│                                                                          │       Akrobatyka: {Akrobatyka,-3}\tArcheologia: {Archeologia,-3}\tWytrzymałość psychiczna: {WytrzymaloscPsychiczna}                   ");
                Console.WriteLine($"│                                                                          │       Wyczucie poezji: {WyczuciePoezji,-3}\tInterpretacja znaków: {InterpretacjaZnaków,-3}\tSpecjalizacja elementalistyczna: {SpecjalizacjaElementalistyczna}   ");
                Console.WriteLine($"│                                                                          │       Myślenie analityczne: {MyślenieAnalityczne,-3}Improwizacja: {Improwizacja,-3}\t Fizyka: {Fizyka}                                                    ");
                Console.WriteLine($"│                                                                          │       Tworzenie pól energetycznych:{TworzeniePólEnergetycznych,-3}Bieg: {Bieg,-3}\tSprint: {Sprint,-3}                                                 ");
                Console.WriteLine($"│                                                                          │       Kopnięcie: {Kopnięcie,-3}\tTelekineza: {Telekineza,-3}\tKryptografia: {Kryptografia,-3}                                     ");
                Console.WriteLine($"│                                                                          │       Refleks: {Refleks,-3}\tZmienianie kształtu: {ZmienianieKształtu,-3}\tRozbrajanie pułapek: {RozbrajaniePulapek,-3}                        ");
                Console.WriteLine($"│                                                                          │       Intuicja technologiczna: {IntuicjaTechnologiczna,-3}\tOswojenie zwierząt: {OswojenieZwierząt,-3}\tZwinność: {Zwinność,-3}                                             ");
                Console.WriteLine($"│                                                                          │       Przemierzanie terenu: {PrzemierzanieTerenu,-3}\t Magia słowa: {MagiaSłowa,-3}\tPogłębione zrozumienie magii: {PogłębioneZrozumienieMagii,-3}       ");
                Console.WriteLine($"│                                                                          │       Manipulacja emocjonalna: {ManipulacjaEmocjonalna,-3}\tAntygrawitacja: {Antygrawitacja,-3}\tZnajomość języków obcych: {ZnajomośćJezykowObcych,-3}               ");
                Console.WriteLine($"│                                                                          │                                                                                                                                                                                               ");
                Console.WriteLine($"└──────────────────────────────────────────────────────────────────────────┴───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────   ────");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Eksploracja();
                        break;
                    case "2":
                        Walka();
                        break;
                    case "0":
                        Console.WriteLine("Dziękujemy za grę!");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }
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
            Console.ForegroundColor= ConsoleColor.Blue;
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
            Console.ForegroundColor= ConsoleColor.DarkGreen;
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
            Console.ForegroundColor= ConsoleColor.DarkBlue;
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
            #region


            #endregion
            Console.WriteLine("Klikin jakis prtzycisk by kontynułowć");
            Console.ReadLine();
        }


        static void Walka()

        {
            Console.WriteLine("Rozpoczynasz walkę!");
            // Tutaj możesz dodać kod związany z walką
        }
    }
}


