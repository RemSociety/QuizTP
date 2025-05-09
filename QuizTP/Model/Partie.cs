using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using ProgressBar = System.Windows.Forms.ProgressBar;
using Timer = System.Windows.Forms.Timer;



namespace QuizTP.Model
{
    public class Partie
    {
        public int score;
        public string difficulte;
        public int nbrQuestion;
        public int numQuestion;
        public List<Question> question;
        public int numRep;
        public int reponseValidQuestion;
        public string nomJoueur, prenomJoueur;
        public int dureePartie;
        public int dureeQuestion;
        public int timerPartie;
        public Timer timer;
        public int dureeTQuestion;
        private SousFormulaire SF;

        public Partie(List<Question> listeQuestions, TextBox txt_timer)
        {
            score = 0;
            difficulte = "";
            numQuestion = 0;
            question = listeQuestions;
            nbrQuestion = listeQuestions.Count();
        }


        public Partie(List<Question> ListeQuestions, string nomJ, string prenomJ, string difficulteJ)
        {
            score = 0;
            difficulte = difficulteJ;
            numQuestion = 0;
            question = ListeQuestions;
            nbrQuestion = question.Count;
            nomJoueur = nomJ;
            prenomJoueur = prenomJ;
        }

        
        
        

        public void validerReponse(int reponse, PictureBox PbImage)
        {
            if (reponse == reponseValidQuestion) // Revoir la condition de bonne réponse 
            {
                calculerScore(true);
                changerImg(PbImage, true, false);
                
            }
            else
            {
                calculerScore(false);
                changerImg(PbImage, false, false);
            }
        }

        private void calculerScore(bool bonneRep)
        {
            if (bonneRep)
            {
                score++;
            }
        }

        private void changerImg(PictureBox PbImage, bool bonneReponse, bool raz)
        {
            if (!raz)
            {
                if (bonneReponse)
                {
                    PbImage.Image = Properties.Resources.vrai;
                }
                else
                {
                    PbImage.Image = Properties.Resources.faux;
                }
            }
            else
            {
                PbImage.Image = Properties.Resources.Interrogation;
            }
        }

        // Revoir la fonction de fin de partie 
        public void finDePartie(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Panel pnl_principal)
        {
            // Fonction à revoir !r\n Voulez vous rejouer 
            DialogResult msg;
            timer.Stop();
            SF = new SousFormulaire(pnl_principal);
            msg = MessageBox.Show("Votre score est de " + score + "\r\n vous avez fini la partie en cours " + timerPartie + " secondes.\r\n Voulez vous rejouer ", "Fin de la partie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);



            if (msg == DialogResult.Yes)
            {
                SF.OpenChildForm(new Form1());
                score = 0; 
                numQuestion = 0;
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pnl_principal);
                changerImg(PbImage, true, true);
                timer.Start();
            }
            else
            {
                // Revoir la fonction pour remettre à zéro 
                /*Form1 Accueil = new Form1();
                Accueil.Show();*/
                Form1.ActiveForm.Close();
                //Form1.ActiveForm.Hide();
                //Jeu.ActiveForm.Hide();

            }
        }


        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Panel pnl_Principal)
        {
            // PHASE 18: TESTER SI IL RESTE DES QUESTIONS (Revoir la phase précedente)
            if (nbrQuestion > numQuestion)
            {
                aleatoireReponse(txt_affichage, gd_reponse);
                ckb_reponse1.Checked = false;
                ckb_reponse2.Checked = false;
                ckb_reponse3.Checked = false;
                ckb_reponse4.Checked = false;
                ckb_reponse5.Checked = false;
            }
            else
            {
                // Appel methode de fin de partie !
                finDePartie(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pnl_Principal);
            }
        }

        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            int bonneReponse = question[numQuestion].reponse; 
            txt_affichage.Text = question[numQuestion].enonce;
            List<int> reponseAleatoire = new List<int>() {1, 2, 3, 4, 5};
            Random rand = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rand.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";

                // Revoir l'égalité en appelant le prof ! 
                switch (random)
                {
                    case 1:
                        reponse = question[numQuestion].proposition1;
                        break;
                    case 2:
                        reponse = question[numQuestion].proposition2;
                        break;
                    case 3:
                        reponse = question[numQuestion].proposition3;
                        break;
                    case 4:
                        reponse = question[numQuestion].proposition4;
                        break;
                    case 5:
                        reponse = question[numQuestion].proposition5;
                        break;
                }
                getTextBox(i, gd_reponse).Text = reponse;
                if (bonneReponse == random)
                { 
                    reponseValidQuestion = i; 
                }
            }

        }
        private CheckBox getTextBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox) && c.Name == "ckb_reponse" + indice.ToString())
                {
                    return ((CheckBox)c);
                }
            }
            return null;
        }


        public void gestionTimer(TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label numeroQuestion, Panel pnl_principal)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer, pb_dureeRepQuestion,txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, numeroQuestion, pnl_principal);
            timer.Start();
            
        }

        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label numeroQuestion, Panel pnl_principal)
        {
            timerPartie++;
            dureeTQuestion++;
            pb_dureeRepQuestion.Increment(1);
            txt_timer.Text = timerPartie.ToString() + " sec";
            

            if (dureeTQuestion > 15)
            {
                validerReponse(0, PbImage);
                numQuestion++;
                numeroQuestion.Text = (numQuestion + 1).ToString();
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pnl_principal);
                pb_dureeRepQuestion.Value = 0;
                dureeTQuestion = 0;
            }
        }

        

    }
}
