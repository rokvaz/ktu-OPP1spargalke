using System;

// TLDR
// as tiesiog rasau is galvos koda, jis gali neveikti
// turit smegenis pasitikrinkit tiesiog cia spargalka

namespace spargalke
{
    class PavyzdinisKonteineris
    {
        // tai bus konteineris skirtas "PavyzdineKlase" klasei
        int Cn = 100;
        PavyzdineKlase[] duomenys;
        int kiek;
        // konstruktorius su kuriuo pradedame konteineri
        public PavyzdinisKonteineris()
        {
            duomenys = new PavyzdineKlase[Cn];
            kiek = 0;
        }
        // su sia funkcija idedame duomenis ( jie jau sufoormuoti i pavyzdine klase)
        // kiek pasikels pats
        public void Deti(PavyzdineKlase idejimoDuomenys)
        {
            duomenys[kiek++] = idejimoDuomenys;
        }
        // Su sia funkcija skaitome duomenis is nurodytos pozicijos
        public PavyzdineKlase Skaityti(int pozicija) { return duomenys[pozicija]; }
        // Su sia klase irasome duomenis i tam tikra pozicija ( jei juos pakeiciam ar kazkas pan)
        public void Modifikuoti(int pozicija, PavyzdineKlase modDuomenys)
        {
            duomenys[pozicija] = modDuomenys;
        }
        // rikiavimo funkcija
        // i have no idea db kaip cia rikiuoja, bet tiesiog
        // rekomenduoju paliekat sita default ir uzklojimus ziurit
        // xd
        public void Rikiuoti()
        {
            for (int i = 0; i < kiek; i++)
            {
                PavyzdineKlase min = duomenys[i];
                int im = i;
                for (int j = i + 1; j < kiek; j++)
                {
                    if (duomenys[j] <= min)
                    {
                        min = duomenys[j];
                        im = j;
                    }
                }
                duomenys[im] = duomenys[i];
                duomenys[i] = min;
            }
        }
    }
    class PavyzdineKlase
    {
        // labai daug funkciju tinka ir is virsaus tai...
        private int[] pazymiai;
        private double vidurkis;
        private string vardas, pavarde;
        int kiek;
        // konstruktorius, su kuriuo isirasome duomenis
        public PavyzdineKlase(string vardas, string pavarde, int[] pazymiai, int kiek)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.pazymiai = pazymiai;
            vidurkis = -1; // tarkim ji skaiciuosime veliau ir -1 tiesiog kad galetume erorr catchinti
            // inijungiam ji (initialise) kad nebutu erroru skaityme jei per anksti uzklaustume
            this.kiek = kiek;
        }
        // dabar standartiniai vardo pavardes ir vidurkio skaitymai
        public string SkaitytiVarda() { return vardas;}
        public string SkaitytiPavarde() { return pavarde;}
        public double SkaitytiVidurki() { return vidurkis;}
        // dabar pazymiu uzklausimas
        public int GautiPazymi(int pozicija) { return pazymiai[pozicija]; }
        // cia irgi pazymiu kiekis paprastas, bet imanoma padaryti su pazymiai.length, bet tuomet turi buti 100% tirkas, kad jo dydis yra cyp cyp
        // cia reiketu skaitant duomenis kazkaip apdoroti, kad tai atitiktu tikrove
        public int GautiPazymiuKieki() { return kiek; }
        // funkcija, kuri skaiciuoja vidurki ir iraso ji iskarto i klase
        public void SkaiciuotiVidurki()
        {
            for(int i=0;i<kiek;i++)
            {
                vidurkis = vidurkis + pazymiai[i];
            }
            vidurkis = vidurkis / kiek;
        }
        // dabar reailiai sioje funkcijoje turim padaryti uzklojimus jei rusiuoti norim ar kazka pan
        // as ju nekenciu, bet reikia...

        // dabar jei gerai suprantu
        // tikrinam pirma vidurkis (nzn ar nuo maziausio ar nuo didziausio kazkuri kazkaip
        // jei yra == tikrina vardus pagal abecele arba atvirksciai abeceles rusiuoja
        // jei pakeiciat pavadinimus ir zenklus returne palauzot kol duomenys gerai iseina
        // ir fsio
        // db ntr laiko zaistis aiskintis xdd
        public static bool operator <=(PavyzdineKlase st1, PavyzdineKlase st2)
        {
            int p = st1.vidurkis.CompareTo(st2.vidurkis);
            int v = String.Compare(st1.vardas, st2.vardas,
            StringComparison.CurrentCulture);
            return (p < 0 || (p == 0 && v < 0));
        }
        public static bool operator >=(PavyzdineKlase st1, PavyzdineKlase st2)
        {
            int p = st1.vidurkis.CompareTo(st2.vidurkis);
            int v = String.Compare(st1.vardas, st2.vardas,
            StringComparison.CurrentCulture);
            return (p > 0 || (p == 0 && v > 0));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
