using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recupero_verifica_classi
{
    internal class bacheca
    {
        private annuncio[] elenco = new annuncio[999];
        private int contatore = 0;

        public bacheca()
        {
            
        }

        public annuncio[] ann()
        {
            return elenco;
        }

        public void aggiungi(string testo, string data, float costo)
        {
            string id = "ann" + contatore;
            elenco[contatore] = new annuncio(id, testo, data, costo);
            contatore++;
        }

        public int get_contatore()
        {
            return contatore;
        }

        public annuncio[] stampa()
        {
            annuncio[] a = new annuncio[contatore-1];

            for (int i = 0; i < contatore-1; i++)
            {
                a[i] = elenco[i];
            }
            return a;
        }
    }
}
