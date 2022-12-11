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

                //listView1.Clear();

                int a = el.get_contatore();
                annuncio[] annunci = el.stampa();

                ListViewItem u = new ListViewItem(annunci[a - 1].ID);
                u.SubItems.Add(annunci[a - 1].Testo);
                u.SubItems.Add(annunci[a - 1].Data);
                u.SubItems.Add(Convert.ToString(annunci[a - 1].Costo));
                listView1.Items.Add(u);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //controllo cancellato

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
