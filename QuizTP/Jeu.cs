using QuizTP;
using QuizTP.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace QuizTP
{
   
    public partial class Jeu : Form
    {
        

        Partie partie;
        int reponseQuestion = 0;
        

        public void Init()
        {
            InitializeComponent();
            
            List<Question> ListeQuestions = new List<Question>();
            ListeQuestions.Add(new Question("Quelle est la capitale de la France ?", 1, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'espagne ?", 4, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'allemagne ?", 3, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Italie ?", 5, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Angleterre ?", 2, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Belgique ?", 1, 1, "Bruxelles", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Suisse ?", 2, 1, "Bruxelles", "Berne", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Luxembourg ?", 3, 1, "Bruxelles", "Berne", "Luxembourg", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Portugal ?", 4, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Autriche ?", 5, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Vienne"));

            partie = new Partie(ListeQuestions, txt_timer);
            partie.changerQuestion(txt_affichage,ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gd_reponse,PbImage, (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pnl_principal);
            partie.gestionTimer(txt_timer, pb_dureeRepQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gd_reponse, PbImage, lbl_numero, (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pnl_principal);
        }
        

        public Jeu(string nomJ, string prenomJ, string difficultePartie)
        {
            Init();
            txt_joueur.Text = nomJ +" "+ prenomJ;
            txt_difficulte.Text = difficultePartie;
            
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            
            partie.validerReponse(reponseQuestion, PbImage);
            partie.numQuestion++;
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gd_reponse, PbImage, (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pnl_principal);
            lbl_numero.Text = "Question " +(partie.numQuestion + 1).ToString();
            reponseQuestion = 0;
            pb_dureeRepQuestion.Value = 0;
            partie.dureeTQuestion = 0;
            
        }

        private void ckb_reponse1_Click(object sender, EventArgs e)
        {
            foreach (var box in gd_reponse.Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }

            ((CheckBox)sender).Checked = true;
            reponseQuestion = Convert.ToInt16(((CheckBox)sender).Name.Substring(11, 1));
        }

        
        private void btn_fermerJeu_MouseHover(object sender, EventArgs e)
        {
            btn_fermerJeu.BackColor = Color.Red;
        }

        private void btn_fermerJeu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
