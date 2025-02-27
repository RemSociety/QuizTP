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
    internal class Partie
    {
        public int score;
        public int difficulte;
        public int nbrQuestion;
        public List<Question> question;
        public int numRep;
        public int numQuestion;

        public Partie(List<Question> listeQuestions)
        {
            score = 0;
            difficulte = 0;
            numQuestion = 0;
            question = listeQuestions;
            nbrQuestion = listeQuestions.Count();
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
        private void calculerScore(bool bonneRep)
        {
            if (bonneRep == true)
            {
                score += 1;
            }
        }

        public void validerReponse(int reponse, PictureBox pb_image)
        {
            if (reponse == numRep) // Revoir la condition de bonne réponse 
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
                    numRep = i; 
                }
            }

        }
        // Revoir la fonction de fin de partie 
        public void finDePartie(PictureBox pb_image)
        {
            // Fonction à revoir !
            DialogResult msg = MessageBox.Show("Votre score est de " + score +
                ".\r\n Voulez vous rejouer", "Fin de la partie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            if (msg == DialogResult.Yes)
            {
                score = 0;
                pb_image.Image = Properties.Resources.Interrogation;
                // voir l'énoncé pour réafficher la première question 
                numQuestion = 0;
                
            } 
            else if (msg == DialogResult.No)
            {
                // Revoir la fonction pour remettre à zéro 
                /*Form1 Accueil = new Form1();
                Accueil.Show();*/
                Form1.ActiveForm.Hide();
                Jeu.ActiveForm.Hide();

            }
        }

        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3,  CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox pb_image)
        {
            // PHASE 18: TESTER SI IL RESTE DES QUESTIONS (Revoir la phase précedente)
            if (numQuestion < nbrQuestion)
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
                finDePartie(pb_image);
            }
        }

    }
}
