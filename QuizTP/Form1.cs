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

            if (txt_nom.Text == "" || txt_prenom.Text == ""|| cb_difficulte.SelectedIndex < 0) { 
                if (txt_nom.Text == "" )
                {
                    MessageBox.Show("Aucun nom n'est rentré", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txt_prenom.Text == "")
                {
                    MessageBox.Show("Aucun prenom n'est rentré", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (cb_difficulte.SelectedIndex < 0)
                {
                    MessageBox.Show("Aucune difficulté n'est rentré", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            { 
                Jeu j = new Jeu(txt_nom.Text, txt_prenom.Text, cb_difficulte.SelectedItem.ToString());
                j.Show();
                this.Hide();
            }
        }
        private void cb_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_difficulte.SelectedItem.ToString() == "Enfer")
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_fermerForm1_MouseHover(object sender, EventArgs e)
        {
            btn_fermerForm1.BackColor = Color.Red;
        }
    }
}
