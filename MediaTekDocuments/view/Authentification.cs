using MediaTekDocuments.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
    public partial class Authentification : Form
    {
        private readonly FrmLoginController controller;

        public Authentification()
        {
            InitializeComponent();
            this.controller = new FrmLoginController();
        }

        private void validerAuthentification_Click(object sender, EventArgs e)
        {
            if (controller.GetLogin(textBoxLoginAuthentification.Text, textBoxPasswordAuthentification.Text))
            {
                Console.WriteLine("Entrer dans le formulaire");
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrecte");
                textBoxLoginAuthentification.Text = "";
                textBoxPasswordAuthentification.Text = "";
            }
        }
    }
}
