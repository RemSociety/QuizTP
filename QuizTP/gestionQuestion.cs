using QuizTP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTP
{
    public partial class gestionQuestion : Form
    {

        DataView dv, dl;

        public gestionQuestion()
        {
            InitializeComponent();
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestion());

            
            dataGV_gestionQuestion.DataSource = dv;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dataGV_gestionQuestion.Columns["IDQUESTION"].Visible = false;
            //Gérer la largeur des colonnes
            dataGV_gestionQuestion.Columns["LABELQUESTION"].Width = 500;
            dataGV_gestionQuestion.Columns["LABELDIFFICULTE"].Width = 500;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.
            Difficulte dt_difficulte = new Difficulte();
            dl = new DataView(dt_difficulte.GetListeDifficulte());
            cbb_difficulte.DataSource = dt_difficulte.GetListeDifficulte();
            cbb_difficulte.DisplayMember = "LABELDIFFICULTE";
            cbb_difficulte.ValueMember = "IDDIFFICULTE";


        }

        private void txtbox_recherche_mot_TextChanged(object sender, EventArgs e)
        {
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_rechercheMot.Text, cbb_difficulte.SelectedIndex));
            dataGV_gestionQuestion.DataSource = dv;

        }

        private void cbb_difficulte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_rechercheMot.Text, cbb_difficulte.SelectedIndex));
            dataGV_gestionQuestion.DataSource = dv;
        }

        private void btn_gestionQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
