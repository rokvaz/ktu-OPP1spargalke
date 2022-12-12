using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TLDR
// as tiesiog rasau is galvos koda, jis gali neveikti
// turit smegenis pasitikrinkit tiesiog cia spargalka

namespace spargalke
{
    
    class DvimaciaiMasyvai
    {
        // get set tas tipo yra kaip mes darydavom ranka viska, jis auto padaro
        // aceit galima kazkaip geta arba seta atsidaryt ir ten koda rasyt, bus kaip detiN detiM arba imtiN imtiM rasytum
        // pasizaiskit jei norit suprast, nemoku paaiskint
        public int N { get; set; }
        public int M { get; set; }

        // maximumai, realiai kiek maksimaliai musu masyvas gali lipti
        private int NMax = 100;
        private int MMax = 100;

        private int[,] duomenys;

        // kaip konteineri sitam konstruktoriui paleidziam klase
        public DvimaciaiMasyvai()
        {
            N = 0;
            M = 0;
            duomenys = new int[NMax, MMax];
        }
        public void IdetiDuomenis(int i, int j, int duomenys)
        {
            this.duomenys[i, j] = duomenys;
        }
        public int ImtiDuomenys(int i, int j) { return duomenys[i, j]; }

    }
    internal class main
    {
        // cia tipo main ignore
    }
}
