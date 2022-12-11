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
        private int posizioni = 0;

        public bacheca()
        {
            
        }

        public annuncio[] ann()
        {
            return elenco;
        }

        public void aggiungi(string testo, string data, float costo)
        {
            string id ="ann"+contatore;
            elenco[posizioni] = new annuncio(id, testo, data, costo);
            contatore++;
            posizioni++;
        }

        public int get_contatore()
        {
            return posizioni;
        }

        public annuncio[] stampa()
        {
            annuncio[] a = new annuncio[posizioni];

            for (int i = 0; i < posizioni; i++)
            {
                a[i] = elenco[i];
            }
            return a;
        }

        public void riordina(int id_inizio)
        {
            if (posizioni== 1)
            {
                elenco[0].ID = null;
                elenco[0].Testo = null;
                elenco[0].Data = null;
                elenco[0].Costo = -1;
            }
            else
            {
                for (int i = id_inizio; i < posizioni; i++)
                {
                    elenco[id_inizio].ID = elenco[id_inizio + 1].ID;
                    elenco[id_inizio].Testo = elenco[id_inizio + 1].Testo;
                    elenco[id_inizio].Data = elenco[id_inizio + 1].Data;
                    elenco[id_inizio].Costo = elenco[id_inizio + 1].Costo;
                }
            }

            posizioni--;
        }
    }
}
