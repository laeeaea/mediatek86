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
using MediaTek86.controller;
using MySqlX.XDevAPI.Common;

namespace MediaTek86.view
{
    public partial class FrmPersonnelPage : Form
    {
        private readonly BindingSource bdgPersonnels = new BindingSource();
        
        private FrmPersonnelPageController controller;
        public FrmPersonnelPage()
        {
            InitializeComponent();
            controller = new FrmPersonnelPageController();
            RemplirListePersonnel();

        }

        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels;
            lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            listPersonnels.AutoGenerateColumns = true;
            listPersonnels.DataSource = bdgPersonnels;
            // Masque les colonnes des id
            listPersonnels.Columns["IdPersonnel"].Visible = false;
            // Désactive la sélection multiple
            listPersonnels.MultiSelect = false;
            // Empêche la modification directement dans la liste
            listPersonnels.ReadOnly = true;
            // Supprime la colonne vide de gauche
            listPersonnels.RowHeadersVisible = false;
            // Affiche des en-têtes de colonnes
            listPersonnels.Columns["Nom"].HeaderText = "Nom";
            listPersonnels.Columns["Prenom"].HeaderText = "Prénom";
            listPersonnels.Columns["Tel"].HeaderText = "Téléphone";
            listPersonnels.Columns["Mail"].HeaderText = "Mail";
            // Selectionne la ligne entière
            listPersonnels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void listPersonnels_DataBindingComplete(object sender, EventArgs e)
        {
            listPersonnels.ClearSelection();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton Ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAjModPers frmAjModPers = new FrmAjModPers();
            DialogResult result = frmAjModPers.ShowDialog();
            if (result == DialogResult.OK)
            {
                RemplirListePersonnel();
            }

        }

        private void personnel_page_Load(object sender, EventArgs e)
        {

        }

        private void listPersonnels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPersonnels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
        }
        /// <summary>
        /// Bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            if (listPersonnels.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.");
                return;
            }

            Personnel selectedPersonnel = listPersonnels.SelectedRows[0].DataBoundItem as Personnel;
            if (selectedPersonnel == null)
            {
                MessageBox.Show("Erreur : le personnel sélectionné est nul.");
                return;
            }

            FrmAjModPers frmAjModPers = new FrmAjModPers(selectedPersonnel);
            DialogResult result = frmAjModPers.ShowDialog();
            if (result == DialogResult.OK)
            {
                RemplirListePersonnel();
            }

        }

        /// <summary>
        /// Bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Personnel personnel = listPersonnels.SelectedRows[0].DataBoundItem as Personnel;

        }
    }
}
