namespace QuizTP
{
    partial class Jeu
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_qts1 = new System.Windows.Forms.Label();
            this.lbl_temps = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_qts1 = new System.Windows.Forms.TextBox();
            this.gb_reponse = new System.Windows.Forms.GroupBox();
            this.checkB_rep1 = new System.Windows.Forms.CheckBox();
            this.checkB_rep3 = new System.Windows.Forms.CheckBox();
            this.checkB_rep4 = new System.Windows.Forms.CheckBox();
            this.checkb_rep5 = new System.Windows.Forms.CheckBox();
            this.checkB_rep2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_reponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(271, 48);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(254, 39);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Quizz And Test";
            // 
            // lbl_qts1
            // 
            this.lbl_qts1.AutoSize = true;
            this.lbl_qts1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qts1.Location = new System.Drawing.Point(72, 111);
            this.lbl_qts1.Name = "lbl_qts1";
            this.lbl_qts1.Size = new System.Drawing.Size(77, 16);
            this.lbl_qts1.TabIndex = 1;
            this.lbl_qts1.Text = "Questions 1";
            // 
            // lbl_temps
            // 
            this.lbl_temps.AutoSize = true;
            this.lbl_temps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temps.Location = new System.Drawing.Point(583, 92);
            this.lbl_temps.Name = "lbl_temps";
            this.lbl_temps.Size = new System.Drawing.Size(78, 16);
            this.lbl_temps.TabIndex = 3;
            this.lbl_temps.Text = "Temps total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(586, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 147);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 6;
            // 
            // txt_qts1
            // 
            this.txt_qts1.Location = new System.Drawing.Point(75, 139);
            this.txt_qts1.Multiline = true;
            this.txt_qts1.Name = "txt_qts1";
            this.txt_qts1.Size = new System.Drawing.Size(471, 83);
            this.txt_qts1.TabIndex = 7;
            // 
            // gb_reponse
            // 
            this.gb_reponse.Controls.Add(this.checkB_rep2);
            this.gb_reponse.Controls.Add(this.checkb_rep5);
            this.gb_reponse.Controls.Add(this.checkB_rep4);
            this.gb_reponse.Controls.Add(this.checkB_rep3);
            this.gb_reponse.Controls.Add(this.checkB_rep1);
            this.gb_reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_reponse.Location = new System.Drawing.Point(75, 248);
            this.gb_reponse.Name = "gb_reponse";
            this.gb_reponse.Size = new System.Drawing.Size(333, 166);
            this.gb_reponse.TabIndex = 8;
            this.gb_reponse.TabStop = false;
            this.gb_reponse.Text = "Réponse possibles";
            // 
            // checkB_rep1
            // 
            this.checkB_rep1.AutoSize = true;
            this.checkB_rep1.Location = new System.Drawing.Point(34, 32);
            this.checkB_rep1.Name = "checkB_rep1";
            this.checkB_rep1.Size = new System.Drawing.Size(92, 20);
            this.checkB_rep1.TabIndex = 0;
            this.checkB_rep1.Text = "Réponse 1";
            this.checkB_rep1.UseVisualStyleBackColor = true;
            // 
            // checkB_rep3
            // 
            this.checkB_rep3.AutoSize = true;
            this.checkB_rep3.Location = new System.Drawing.Point(34, 84);
            this.checkB_rep3.Name = "checkB_rep3";
            this.checkB_rep3.Size = new System.Drawing.Size(92, 20);
            this.checkB_rep3.TabIndex = 1;
            this.checkB_rep3.Text = "Réponse 3";
            this.checkB_rep3.UseVisualStyleBackColor = true;
            // 
            // checkB_rep4
            // 
            this.checkB_rep4.AutoSize = true;
            this.checkB_rep4.Location = new System.Drawing.Point(34, 110);
            this.checkB_rep4.Name = "checkB_rep4";
            this.checkB_rep4.Size = new System.Drawing.Size(92, 20);
            this.checkB_rep4.TabIndex = 2;
            this.checkB_rep4.Text = "Réponse 4";
            this.checkB_rep4.UseVisualStyleBackColor = true;
            // 
            // checkb_rep5
            // 
            this.checkb_rep5.AutoSize = true;
            this.checkb_rep5.Location = new System.Drawing.Point(34, 136);
            this.checkb_rep5.Name = "checkb_rep5";
            this.checkb_rep5.Size = new System.Drawing.Size(92, 20);
            this.checkb_rep5.TabIndex = 3;
            this.checkb_rep5.Text = "Réponse 5";
            this.checkb_rep5.UseVisualStyleBackColor = true;
            // 
            // checkB_rep2
            // 
            this.checkB_rep2.AutoSize = true;
            this.checkB_rep2.Location = new System.Drawing.Point(34, 58);
            this.checkB_rep2.Name = "checkB_rep2";
            this.checkB_rep2.Size = new System.Drawing.Size(92, 20);
            this.checkB_rep2.TabIndex = 4;
            this.checkB_rep2.Text = "Réponse 2";
            this.checkB_rep2.UseVisualStyleBackColor = true;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_reponse);
            this.Controls.Add(this.txt_qts1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_temps);
            this.Controls.Add(this.lbl_qts1);
            this.Controls.Add(this.lbl_titre);
            this.Name = "Jeu";
            this.Text = "Jeu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_reponse.ResumeLayout(false);
            this.gb_reponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_qts1;
        private System.Windows.Forms.Label lbl_temps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_qts1;
        private System.Windows.Forms.GroupBox gb_reponse;
        private System.Windows.Forms.CheckBox checkB_rep2;
        private System.Windows.Forms.CheckBox checkb_rep5;
        private System.Windows.Forms.CheckBox checkB_rep4;
        private System.Windows.Forms.CheckBox checkB_rep3;
        private System.Windows.Forms.CheckBox checkB_rep1;
    }
}