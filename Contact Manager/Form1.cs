using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Form1 : Form
    {
        String benutzername = "Fabian";
        String passwort = "1234";
        public string _benutzername;
        String _passwort;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _benutzername = textBox1.Text;
                _passwort = textBox2.Text;

                connect();
            }
        }

        void connect()
        {
            if (_benutzername == benutzername && _passwort == passwort)
            {
                Thread thread = new Thread(Form2);
                thread.Start();
                this.Close();
            }
            else
            {
                label3.Text = "Login fehlgeschlagen. Bitte überprüfen Sie Ihre Anmeldedaten.";
            }
        }

        void Form2()
        {
            Form2 t = new Form2();
            t.setbenutzername(_benutzername);
            t.test();
            t.ShowDialog();
            
        }
    }
}
