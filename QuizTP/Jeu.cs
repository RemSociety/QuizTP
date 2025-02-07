using QuizTP.Model;
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
    public partial class Jeu : Form
    {
        int reponseQuestion = 0;
        Partie partie;

        public Jeu()
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

            partie = new Partie(ListeQuestions);
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gb_reponse, pb_question);
            

        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            
            partie.validerReponse(reponseQuestion, pb_question);
            partie.numQuestion++;
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gb_reponse, pb_question);
            lbl_numero.Text = "Question " +(partie.numQuestion + 1).ToString();
            reponseQuestion = 0;
        }

        private void ckb_reponse1_Click(object sender, EventArgs e)
        {
            foreach (var box in gb_reponse.Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }

            ((CheckBox)sender).Checked = true;
            reponseQuestion = Convert.ToInt16(((CheckBox)sender).Name.Substring(11, 1));
        }
    }
}
