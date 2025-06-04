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

namespace MediaTek86.view
{
    public partial class FrmPersonnelPage : Form
    {
        private readonly BindingSource bdgPersonnels = new BindingSource();
        
        private FrmPersonnelPageController controller;
        public FrmPersonnelPage()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
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
            listPersonnels.Columns["IdPersonnel"].Visible = false;
            listPersonnels.Columns["IdService"].Visible = false;
            listPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void personnel_page_Load(object sender, EventArgs e)
        {

        }

        private void listPersonnels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPersonnels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
