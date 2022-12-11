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
            el.aggiungi(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox1.Focus();

            //li mostro sulla listview
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //controllo che siano stati salvati correttamente
            int a = el.get_contatore();
            annuncio[] annunci = el.stampa();

            /*
            for (int i = 0; i < annunci.Length; i++)
            {
                ListViewItem riga = new ListViewItem(annunci[i].ToString().Split(';'));
                listView1.Items.Add(riga);
            }
            */
            textBox4.Text = annunci[0].ID;


        }
    }
}
