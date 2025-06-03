namespace MediaTek86.view
{
    partial class FrmPersonnelPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listPersonnels = new System.Windows.Forms.DataGridView();
            this.frmPersonnelPageControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listPersonnels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPersonnelPageControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste du personnel :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(597, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Afficher les absences";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listPersonnels
            // 
            this.listPersonnels.AllowUserToOrderColumns = true;
            this.listPersonnels.AutoGenerateColumns = false;
            this.listPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPersonnels.DataSource = this.frmPersonnelPageControllerBindingSource;
            this.listPersonnels.Location = new System.Drawing.Point(17, 60);
            this.listPersonnels.Name = "listPersonnels";
            this.listPersonnels.RowHeadersWidth = 62;
            this.listPersonnels.RowTemplate.Height = 28;
            this.listPersonnels.Size = new System.Drawing.Size(760, 216);
            this.listPersonnels.TabIndex = 6;
            this.listPersonnels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPersonnels_CellContentClick);
            // 
            // frmPersonnelPageControllerBindingSource
            // 
            this.frmPersonnelPageControllerBindingSource.DataSource = typeof(MediaTek86.controller.FrmPersonnelPageController);
            // 
            // FrmPersonnelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPersonnels);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPersonnelPage";
            this.Text = "Gestion du personnel";
            this.Load += new System.EventHandler(this.personnel_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPersonnels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPersonnelPageControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView listPersonnels;
        private System.Windows.Forms.BindingSource frmPersonnelPageControllerBindingSource;
    }
}