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
    public class Difficulte 
    {
        // Instancier la méthode dans gestionQuestion.cs 
        public DataTable GetListeDifficulte()
        {
            DataTable dtListeDifficulte = new DataTable();
            ConnectionBDD conn = new ConnectionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE, LABELDIFFICULTE  FROM difficulte", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeDifficulte.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            conn.MySqlCo.Close();
            conn.MySqlCo = null;

            DataRow workRow = dtListeDifficulte.NewRow();
            	workRow[0] = -1;
            	workRow[1] = "";
            	dtListeDifficulte.Rows.InsertAt(workRow,0);

            return dtListeDifficulte;

        }
    }
}
