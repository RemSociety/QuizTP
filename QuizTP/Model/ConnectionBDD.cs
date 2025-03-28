using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace QuizTP.Model
{
    public class ConnectionBDD
    {

        private MySqlConnection mySqlCo;

        private string serverBDD , nomBDD, loginBDD, mdpBDD;

        private void initConnexion()
        {
            serverBDD = "localhost";
            nomBDD = "bdd_quizzandtest";
            loginBDD = "naime";
            mdpBDD = "Victor@blade976";
            mySqlCo = new MySqlConnection("Server= "+ serverBDD+ " ;Database= " + nomBDD + ";User ID= "+loginBDD+" ;Password= " + mdpBDD);

        }

        public ConnectionBDD()
        { 
            initConnexion();
        }

        public MySqlConnection MySqlCo
        {
            get { return mySqlCo; }
            set { mySqlCo = value; }
        }

    }
}
