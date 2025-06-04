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
    public partial class FrmAjModPers : Form
    {
        private FrmAjModPersController controller;

        public Personnel personnel = null;

        public FrmAjModPers(Personnel personnel = null)
        {
            InitializeComponent();
            controller = new FrmAjModPersController();
            RemplirComboBoxService();
            this.personnel = personnel;
            // Si l'objet personnel est null on doit ajouter, sinon on récupère les infos du personnel dans les TextBox
            if (this.personnel != null)
            {
                textboxnom.Text = this.personnel.Nom;
                textboxprenom.Text = this.personnel.Prenom;
                textboxtel.Text = this.personnel.Tel;
                textboxmail.Text = this.personnel.Mail;
                comboBox1.SelectedIndex = this.personnel.Service.IdService;

            }
        }

        private void RemplirComboBoxService()
        {
            List<Service> services = controller.GetLesServices();
            services.Insert(0, new Service(0, " "));
            comboBox1.DataSource = services;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "IdService";
            comboBox1.SelectedIndex = 0;

        }


        private void textboxnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmAjModPers_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Bouton Valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Création ou mise à jour de l'objet Personnel
                Service service = (Service)comboBox1.SelectedItem;
                Personnel nouveau = new Personnel(
                    personnel?.IdPersonnel ?? 0,
                    textboxnom.Text,
                    textboxprenom.Text,
                    textboxtel.Text,
                    textboxmail.Text,
                    service
                );

                if (personnel == null)
                {
                    // Mode ajout
                    controller.AjouterPersonnel(nouveau);
                    MessageBox.Show("Personnel ajouté avec succès.");
                }
                else
                {
                    // Mode modification
                    controller.ModifierPersonnel(nouveau);
                    MessageBox.Show("Personnel modifié avec succès.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde du personnel : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textboxprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxtel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxmail_TextChanged(object sender, EventArgs e)
        {

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
