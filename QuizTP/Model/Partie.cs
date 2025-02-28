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
using TextBox = System.Windows.Forms.TextBox;

namespace QuizTP.Model
{
    public class Partie
    {
        public int score;
        public int difficulte;
        public int nbrQuestion;
        public List<Question> question;
        public int numRep;
        public int reponseValidQuestion;
        public int numQuestion;
        public int timerPartie;
        Timer timer;

        public Partie(List<Question> listeQuestions, TextBox txt_timer)
        {
            score = 0;
            difficulte = 0;
            numQuestion = 0;
            question = listeQuestions;
            nbrQuestion = listeQuestions.Count();
            gestionTimer(txt_timer);
        }

        private void changerImg(PictureBox pb_image, bool bonneReponse, bool raz)
        {
            if (!raz)
            {
                if (bonneReponse)
                {
                    pb_image.Image = Properties.Resources.vrai;
                }
                else
                {
                    pb_image.Image = Properties.Resources.faux;
                }
            }
            else
            {
                pb_image.Image = Properties.Resources.Interrogation;
            }
        }
        // Revoir la fonction de fin de partie 
        public void finDePartie(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage)
        {
            // Fonction à revoir !
            DialogResult msg;
            timer.Stop();
            msg = MessageBox.Show("Votre score est de " + score +
                ".\r\n Voulez vous rejouer", "Fin de la partie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);



            if (msg == DialogResult.Yes)
            {
                score = 0;
                numQuestion = 0;
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage);
                changerImg(PbImage, true, true);
                timer.Start();
            }
            else
            {
                // Revoir la fonction pour remettre à zéro 
                /*Form1 Accueil = new Form1();
                Accueil.Show();*/
                Form1.ActiveForm.Hide();
                Jeu.ActiveForm.Hide();
            }
        }
        private void calculerScore(bool bonneRep)
        {
            if (bonneRep)
            {
                score ++;
            }
        }

        public void validerReponse(int reponse, PictureBox pb_image)
        {
            if (reponse == reponseValidQuestion) // Revoir la condition de bonne réponse 
            {
                calculerScore(true);
                changerImg(pb_image, true, false);
            }
            else
            {
                changerImg(pb_image, false, false);
            }
        }

        private CheckBox getCheckBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox) && c.Name == "ckb_reponse" + indice.ToString())
                {
                    return (CheckBox)c;
                }
            }
            return null;
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
                getCheckBox(i, gd_reponse).Text = reponse;
                if (bonneReponse == random)
                { 
                    reponseValidQuestion = i; 
                }
            }

        }
        private void Timer_Tick(object sender, EventArgs e, TextBox txt_timer)
        {
            timerPartie++;
            txt_timer.Text = timerPartie.ToString() + " sec";
        }

        private void gestionTimer(TextBox txt_timer)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer);
            timer.Start();
        }

        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3,  CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox pb_image)
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
                finDePartie(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, pb_image);
            }
        }

    }
}
