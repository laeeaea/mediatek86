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

        public FrmSupPers()
        {
            InitializeComponent();
            controller = new FrmSupPersController();
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

        }


        /// <summary>
        /// Bouton Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
