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
        DataTable dt = new DataTable();

        public DataTable GetListeQuestion()
        {
            ConnectionBDD conn = new ConnectionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION, ENONCEQUESTION AS LABELQUESTION, LABELDIFFICULTE FROM question INNER JOIN difficulte ON question.IDDIFFICULTE = difficulte.IDDIFFICULTE", conn.MySqlCo))
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

        public DataTable GetListeQuestionRecherche(string rechercheMot, int difficulte)
        {
            dt = new DataTable();
            try
            {
                ConnectionBDD conn = new ConnectionBDD();
                string rqtSql = "SELECT IDQUESTION, ENONCEQUESTION AS LABELQUESTION, LABELDIFFICULTE FROM question INNER JOIN difficulte ON question.IDDIFFICULTE = difficulte.IDDIFFICULTE WHERE question.IDDIFFICULTE LIKE @difficulte AND question.ENONCEQUESTION LIKE @rechercheMot";
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.MySqlCo))
                {
          
                    conn.MySqlCo.Open();
                    cmd.Parameters.AddWithValue("@rechercheMot", "%" + rechercheMot + "%");
                    cmd.Parameters.AddWithValue("@difficulte", difficulte);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dt;


        }



    }
}
