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
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_temps = new System.Windows.Forms.Label();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.txt_affichage = new System.Windows.Forms.TextBox();
            this.gb_reponse = new System.Windows.Forms.GroupBox();
            this.ckb_reponse2 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse5 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse4 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse3 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse1 = new System.Windows.Forms.CheckBox();
            this.pb_question = new System.Windows.Forms.PictureBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.txt_joueur = new System.Windows.Forms.TextBox();
            this.txt_difficulte = new System.Windows.Forms.TextBox();
            this.lbl_joueur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_reponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).BeginInit();
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
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(72, 111);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(77, 16);
            this.lbl_numero.TabIndex = 1;
            this.lbl_numero.Text = "Questions 1";
            // 
            // lbl_temps
            // 
            this.lbl_temps.AutoSize = true;
            this.lbl_temps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temps.Location = new System.Drawing.Point(663, 83);
            this.lbl_temps.Name = "lbl_temps";
            this.lbl_temps.Size = new System.Drawing.Size(78, 16);
            this.lbl_temps.TabIndex = 3;
            this.lbl_temps.Text = "Temps total";
            // 
            // txt_timer
            // 
            this.txt_timer.Enabled = false;
            this.txt_timer.Location = new System.Drawing.Point(666, 111);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.Size = new System.Drawing.Size(252, 20);
            this.txt_timer.TabIndex = 6;
            // 
            // txt_affichage
            // 
            this.txt_affichage.Enabled = false;
            this.txt_affichage.Location = new System.Drawing.Point(75, 139);
            this.txt_affichage.Multiline = true;
            this.txt_affichage.Name = "txt_affichage";
            this.txt_affichage.Size = new System.Drawing.Size(471, 83);
            this.txt_affichage.TabIndex = 7;
            // 
            // gb_reponse
            // 
            this.gb_reponse.Controls.Add(this.ckb_reponse2);
            this.gb_reponse.Controls.Add(this.ckb_reponse5);
            this.gb_reponse.Controls.Add(this.ckb_reponse4);
            this.gb_reponse.Controls.Add(this.ckb_reponse3);
            this.gb_reponse.Controls.Add(this.ckb_reponse1);
            this.gb_reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_reponse.Location = new System.Drawing.Point(75, 248);
            this.gb_reponse.Name = "gb_reponse";
            this.gb_reponse.Size = new System.Drawing.Size(333, 166);
            this.gb_reponse.TabIndex = 8;
            this.gb_reponse.TabStop = false;
            this.gb_reponse.Text = "Réponse possibles";
            // 
            // ckb_reponse2
            // 
            this.ckb_reponse2.AutoSize = true;
            this.ckb_reponse2.Location = new System.Drawing.Point(34, 58);
            this.ckb_reponse2.Name = "ckb_reponse2";
            this.ckb_reponse2.Size = new System.Drawing.Size(92, 20);
            this.ckb_reponse2.TabIndex = 4;
            this.ckb_reponse2.Text = "Réponse 2";
            this.ckb_reponse2.UseVisualStyleBackColor = true;
            this.ckb_reponse2.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse5
            // 
            this.ckb_reponse5.AutoSize = true;
            this.ckb_reponse5.Location = new System.Drawing.Point(34, 136);
            this.ckb_reponse5.Name = "ckb_reponse5";
            this.ckb_reponse5.Size = new System.Drawing.Size(92, 20);
            this.ckb_reponse5.TabIndex = 3;
            this.ckb_reponse5.Text = "Réponse 5";
            this.ckb_reponse5.UseVisualStyleBackColor = true;
            this.ckb_reponse5.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse4
            // 
            this.ckb_reponse4.AutoSize = true;
            this.ckb_reponse4.Location = new System.Drawing.Point(34, 110);
            this.ckb_reponse4.Name = "ckb_reponse4";
            this.ckb_reponse4.Size = new System.Drawing.Size(92, 20);
            this.ckb_reponse4.TabIndex = 2;
            this.ckb_reponse4.Text = "Réponse 4";
            this.ckb_reponse4.UseVisualStyleBackColor = true;
            this.ckb_reponse4.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse3
            // 
            this.ckb_reponse3.AutoSize = true;
            this.ckb_reponse3.Location = new System.Drawing.Point(34, 84);
            this.ckb_reponse3.Name = "ckb_reponse3";
            this.ckb_reponse3.Size = new System.Drawing.Size(92, 20);
            this.ckb_reponse3.TabIndex = 1;
            this.ckb_reponse3.Text = "Réponse 3";
            this.ckb_reponse3.UseVisualStyleBackColor = true;
            this.ckb_reponse3.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse1
            // 
            this.ckb_reponse1.AutoSize = true;
            this.ckb_reponse1.Location = new System.Drawing.Point(34, 32);
            this.ckb_reponse1.Name = "ckb_reponse1";
            this.ckb_reponse1.Size = new System.Drawing.Size(92, 20);
            this.ckb_reponse1.TabIndex = 0;
            this.ckb_reponse1.Text = "Réponse 1";
            this.ckb_reponse1.UseVisualStyleBackColor = true;
            this.ckb_reponse1.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // pb_question
            // 
            this.pb_question.Image = global::QuizTP.Properties.Resources.Interrogation;
            this.pb_question.Location = new System.Drawing.Point(666, 144);
            this.pb_question.Name = "pb_question";
            this.pb_question.Size = new System.Drawing.Size(252, 246);
            this.pb_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_question.TabIndex = 5;
            this.pb_question.TabStop = false;
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(475, 429);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(150, 50);
            this.button_valider.TabIndex = 9;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // txt_joueur
            // 
            this.txt_joueur.Enabled = false;
            this.txt_joueur.Location = new System.Drawing.Point(732, 436);
            this.txt_joueur.Name = "txt_joueur";
            this.txt_joueur.Size = new System.Drawing.Size(186, 20);
            this.txt_joueur.TabIndex = 10;
            // 
            // txt_difficulte
            // 
            this.txt_difficulte.Enabled = false;
            this.txt_difficulte.Location = new System.Drawing.Point(732, 494);
            this.txt_difficulte.Name = "txt_difficulte";
            this.txt_difficulte.Size = new System.Drawing.Size(186, 20);
            this.txt_difficulte.TabIndex = 11;
            // 
            // lbl_joueur
            // 
            this.lbl_joueur.AutoSize = true;
            this.lbl_joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_joueur.Location = new System.Drawing.Point(729, 417);
            this.lbl_joueur.Name = "lbl_joueur";
            this.lbl_joueur.Size = new System.Drawing.Size(48, 16);
            this.lbl_joueur.TabIndex = 12;
            this.lbl_joueur.Text = "Joueur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Difficulté";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_joueur);
            this.Controls.Add(this.txt_difficulte);
            this.Controls.Add(this.txt_joueur);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.pb_question);
            this.Controls.Add(this.gb_reponse);
            this.Controls.Add(this.txt_affichage);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.lbl_temps);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_titre);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.gb_reponse.ResumeLayout(false);
            this.gb_reponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_temps;
        private System.Windows.Forms.PictureBox pb_question;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.TextBox txt_affichage;
        private System.Windows.Forms.GroupBox gb_reponse;
        private System.Windows.Forms.CheckBox ckb_reponse2;
        private System.Windows.Forms.CheckBox ckb_reponse5;
        private System.Windows.Forms.CheckBox ckb_reponse4;
        private System.Windows.Forms.CheckBox ckb_reponse3;
        private System.Windows.Forms.CheckBox ckb_reponse1;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.TextBox txt_joueur;
        private System.Windows.Forms.TextBox txt_difficulte;
        private System.Windows.Forms.Label lbl_joueur;
        private System.Windows.Forms.Label label1;
    }
}