using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;

namespace MediaTek86.view
{
    public partial class FrmConnexionPage : Form
    {
        private FrmConnexionPageController controller;
        public FrmConnexionPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new FrmConnexionPageController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String password = textBox2.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, password);
                if (controller.ControleAuthentification(responsable))
                {
                    FrmPersonnelPage frm = new FrmPersonnelPage();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
