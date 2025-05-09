namespace QuizTP
{
    partial class gestionQuestion
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
            this.dataGV_gestionQuestion = new System.Windows.Forms.DataGridView();
            this.btn_gestionQuestion = new System.Windows.Forms.Button();
            this.cbb_difficulte = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.txt_rechercheMot = new System.Windows.Forms.TextBox();
            this.lbl_recherche_mot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_gestionQuestion)).BeginInit();
            this.gb_recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_gestionQuestion
            // 
            this.dataGV_gestionQuestion.AllowUserToAddRows = false;
            this.dataGV_gestionQuestion.AllowUserToDeleteRows = false;
            this.dataGV_gestionQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_gestionQuestion.Location = new System.Drawing.Point(33, 145);
            this.dataGV_gestionQuestion.Name = "dataGV_gestionQuestion";
            this.dataGV_gestionQuestion.ReadOnly = true;
            this.dataGV_gestionQuestion.Size = new System.Drawing.Size(876, 411);
            this.dataGV_gestionQuestion.TabIndex = 0;
            // 
            // btn_gestionQuestion
            // 
            this.btn_gestionQuestion.Location = new System.Drawing.Point(913, 12);
            this.btn_gestionQuestion.Name = "btn_gestionQuestion";
            this.btn_gestionQuestion.Size = new System.Drawing.Size(40, 32);
            this.btn_gestionQuestion.TabIndex = 1;
            this.btn_gestionQuestion.Text = "X";
            this.btn_gestionQuestion.UseVisualStyleBackColor = true;
            this.btn_gestionQuestion.Click += new System.EventHandler(this.btn_gestionQuestion_Click);
            // 
            // cbb_difficulte
            // 
            this.cbb_difficulte.FormattingEnabled = true;
            this.cbb_difficulte.Location = new System.Drawing.Point(134, 92);
            this.cbb_difficulte.Name = "cbb_difficulte";
            this.cbb_difficulte.Size = new System.Drawing.Size(173, 21);
            this.cbb_difficulte.TabIndex = 2;
            this.cbb_difficulte.SelectionChangeCommitted += new System.EventHandler(this.cbb_difficulte_SelectionChangeCommitted);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.lbl_difficulte);
            this.gb_recherche.Controls.Add(this.txt_rechercheMot);
            this.gb_recherche.Controls.Add(this.lbl_recherche_mot);
            this.gb_recherche.Controls.Add(this.cbb_difficulte);
            this.gb_recherche.Location = new System.Drawing.Point(551, 12);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(356, 130);
            this.gb_recherche.TabIndex = 3;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Recherche";
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(69, 92);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 5;
            this.lbl_difficulte.Text = "Difficulté";
            // 
            // txt_rechercheMot
            // 
            this.txt_rechercheMot.Location = new System.Drawing.Point(134, 40);
            this.txt_rechercheMot.Name = "txt_rechercheMot";
            this.txt_rechercheMot.Size = new System.Drawing.Size(173, 20);
            this.txt_rechercheMot.TabIndex = 4;
            this.txt_rechercheMot.TextChanged += new System.EventHandler(this.txtbox_recherche_mot_TextChanged);
            // 
            // lbl_recherche_mot
            // 
            this.lbl_recherche_mot.AutoSize = true;
            this.lbl_recherche_mot.Location = new System.Drawing.Point(17, 43);
            this.lbl_recherche_mot.Name = "lbl_recherche_mot";
            this.lbl_recherche_mot.Size = new System.Drawing.Size(100, 13);
            this.lbl_recherche_mot.TabIndex = 3;
            this.lbl_recherche_mot.Text = "Recherche de mots";
            // 
            // gestionQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 568);
            this.Controls.Add(this.gb_recherche);
            this.Controls.Add(this.btn_gestionQuestion);
            this.Controls.Add(this.dataGV_gestionQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionQuestion";
            this.Text = "gestionQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_gestionQuestion)).EndInit();
            this.gb_recherche.ResumeLayout(false);
            this.gb_recherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_gestionQuestion;
        private System.Windows.Forms.Button btn_gestionQuestion;
        private System.Windows.Forms.ComboBox cbb_difficulte;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.GroupBox gb_recherche;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.TextBox txt_rechercheMot;
        private System.Windows.Forms.Label lbl_recherche_mot;
    }
}