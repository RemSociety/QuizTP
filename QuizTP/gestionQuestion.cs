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

        DataView dv;

        public gestionQuestion()
        {
            InitializeComponent();


            // CONTINUER PHASE 5 !
            /*
            dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestion());
            dgv_questions.DataSource = dv;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgv_questions.Columns["IDQUESTION"].Visible = false;
            //Gérer la largeur des colonnes
            dgv_questions.Columns["ENONCEQUESTION"].Width = 190;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.
            */


        }

        private void btn_gestionQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
