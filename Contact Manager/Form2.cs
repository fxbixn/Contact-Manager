using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Form2 : Form
    {
        string _nutzername;

        public Form2()
        {
            InitializeComponent();
            
        }

        public void setbenutzername(string _benutzername)
        {
            _nutzername = _benutzername;
        }

        public void test()
        {
            this.Text = "Kontakt Manager von: " + _nutzername;
            label1.Text = _nutzername;
        }

        //Alle Kontakte
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = true;
        }

        //Kontakt suchen
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            listView1.Visible = false;
        }

        //Neuer Kontakt
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = false;
        }

        //Einstellungen
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = false;
        }

        //Info
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = false;
        }
    }
}
