using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recupero_verifica_classi
{
    internal class annuncio
    {
        private string id;
        private string testo;
        private string data;
        private float costo;

        public annuncio(string id, string testo, string data, float costo)
        {
            ID = id;
            this.id = id;
            this.testo = testo;
            this.data = data;
            this.costo = costo;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Testo
        {
            get { return testo; }
            set { testo = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public void modifica(string testo, string data, float costo)
        {
            this.testo = testo;
            this.data = data;
            this.costo = costo;
        }

        public void elimina()
        {
            this.id = "annuncio cancellato";
            this.testo = null;
            this.data = null;
            this.costo = -1;
        }
    }
}
