using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_difficulte.Items.Add("Facile");
            cb_difficulte.Items.Add("Moyen");
            cb_difficulte.Items.Add("Difficile");
            cb_difficulte.Items.Add("Enfer");
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            Jeu j = new Jeu();
            
            
            if (txt_nom.Text != "" || txt_prenom.Text != "")
            {
                txt_nom.Text.ToLower();
                txt_prenom.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Aucun nom n'est rentré", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cb_difficulte.SelectedIndex >- 1)
            { 
                j.Show();
            } else 
            {
                j.Hide();
            }
        }
        private void cb_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_difficulte.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                txt_nom.Font = new Font(txt_nom.Font, FontStyle.Bold);
                txt_prenom.Font = new Font(txt_prenom.Font, FontStyle.Bold);
                cb_difficulte.Font = new Font(cb_difficulte.Font, FontStyle.Bold);

            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                txt_nom.Font = Font;
                txt_prenom.Font = Font;
                cb_difficulte.Font = Font;
            }

        }

        
    }
}
