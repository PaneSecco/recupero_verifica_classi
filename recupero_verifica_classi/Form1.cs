using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recupero_verifica_classi
{
    public partial class Form1 : Form
    {
        private bacheca el;
        public Form1()
        {
            InitializeComponent();
            el = new bacheca();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button4.Enabled = false;
            string[] intestazione = new string[] { "ID", "Testo", "Data", "Costo" };

            for (int i = 0; i < intestazione.Length; i++)
            {
                listView1.Columns.Add(intestazione[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null)
            {
                throw new Exception("uno dei valori richiesti non è stato inserito");
            }
            else
            {
                el.aggiungi(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox1.Focus();

                //li mostro sulla listview

                int a = el.get_contatore();
                annuncio[] annunci = el.stampa();

                ListViewItem u = new ListViewItem(annunci[a-1].ID);
                u.SubItems.Add(annunci[a-1].Testo);
                u.SubItems.Add(annunci[a-1].Data);
                u.SubItems.Add(Convert.ToString(annunci[a-1].Costo));
                listView1.Items.Add(u);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox4.Text;
            annuncio[] annunci = el.stampa();
            int id_trovato = 0;

            for (int i = 0; i < annunci.Length; i++)
            {
                if (annunci[i].ID == id)
                {
                    id_trovato = i;
                }
            }
            annunci[id_trovato].modifica(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            riordina_list();

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id=textBox4.Text;
            annuncio[] annunci = el.stampa();
            int indice =0;
            bool esiste = false;

            for(int i = 0; i < annunci.Length; i++)
            {
                if(annunci[i].ID == id)
                {
                    indice = i;
                    esiste= true;
                }
            }

            if (esiste==false)
            {
                throw new Exception("l'id da lei inserito non esiste nella nostra bacheca di annunci");
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                textBox1.Focus();

                textBox1.Text = annunci[indice].Testo;
                textBox2.Text = annunci[indice].Data;
                textBox3.Text = Convert.ToString(annunci[indice].Costo);
            }
        }

        public void riordina_list()
        {
            listView1.Clear();
            string[] intestazione = new string[] { "ID", "Testo", "Data", "Costo" };

            for (int i = 0; i < intestazione.Length; i++)
            {
                listView1.Columns.Add(intestazione[i]);
            }

            int a = el.get_contatore();
            annuncio[] annunci = el.stampa();

            for (int i = 0; i < annunci.Length; i++)
            {
                ListViewItem u = new ListViewItem(annunci[i].ID);
                u.SubItems.Add(annunci[i].Testo);
                u.SubItems.Add(annunci[i].Data);
                u.SubItems.Add(Convert.ToString(annunci[i].Costo));
                listView1.Items.Add(u);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox4.Text;
            annuncio[] annunci = el.stampa();
            int id_trovato = 0;

            for (int i = 0; i < annunci.Length; i++)
            {
                if (annunci[i].ID == id)
                {
                    id_trovato = i;
                }
            }
            annunci[id_trovato].elimina();
            el.riordina(id_trovato);
            riordina_list();

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

            button1.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count==0)
            {

            }
            else
            {
                annuncio[] annunci = el.stampa();
                int volte=annunci.Length;
                float somma=0;

                for ( int i = 0; i < annunci.Length; i++)
                {
                    somma += annunci[i].Costo;
                }

                label5.Text = Convert.ToString(somma);
            }
        }
    }
}
