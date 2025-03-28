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
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_gestionQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_gestionQuestion
            // 
            this.dataGV_gestionQuestion.AllowUserToAddRows = false;
            this.dataGV_gestionQuestion.AllowUserToDeleteRows = false;
            this.dataGV_gestionQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_gestionQuestion.Location = new System.Drawing.Point(25, 25);
            this.dataGV_gestionQuestion.Name = "dataGV_gestionQuestion";
            this.dataGV_gestionQuestion.ReadOnly = true;
            this.dataGV_gestionQuestion.Size = new System.Drawing.Size(726, 503);
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
            // gestionQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 568);
            this.Controls.Add(this.btn_gestionQuestion);
            this.Controls.Add(this.dataGV_gestionQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionQuestion";
            this.Text = "gestionQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_gestionQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_gestionQuestion;
        private System.Windows.Forms.Button btn_gestionQuestion;
    }
}