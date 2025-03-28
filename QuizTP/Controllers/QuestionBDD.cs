using MySqlConnector;
using QuizTP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuizTP.Controllers
{
    public class QuestionBDD 
    {

        public DataTable GetListeQuestion()
        {
            DataTable dt = new DataTable();
            ConnectionBDD conn = new ConnectionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDPARTIE as partie, LABELDIFFICULTE as difficulte, NOMJOUEUR as nom, PRENOMJOUEUR as prenom  FROM partie part INNER JOIN difficulte dif ON part.IDDIFFICULTE = dif.IDDIFFICULTE INNER JOIN joueur j ON part.IDJOUEUR = j.IDJOUEUR ;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;
        }

    }
}
