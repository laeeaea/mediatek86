using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.model;
using MediaTek86.dal;
using MediaTek86.controller;

namespace MediaTek86.view
{
    public partial class FrmSupPers : Form
    {
        private FrmSupPersController controller;

        public Personnel SelectedPersonnel = null;

        public FrmSupPers(Personnel personnel)
        {
            InitializeComponent();
            controller = new FrmSupPersController();
            this.SelectedPersonnel = personnel;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton Valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            controller.SupprimerPersonnel(SelectedPersonnel);
            MessageBox.Show("Personnel supprimé avec succès.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /// <summary>
        /// Bouton Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
