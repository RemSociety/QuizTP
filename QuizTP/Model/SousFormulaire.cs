using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace QuizTP.Model
{
    public class SousFormulaire
    {
        public Panel PanelSousFormaulire;
        public Form activeForm = null;

        public SousFormulaire(Panel panelenvoit) 
        {
            PanelSousFormaulire = panelenvoit;
        }

        public void OpenChildForm(Form formEnfant)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = formEnfant;
                formEnfant.TopLevel = false;
                formEnfant.FormBorderStyle = FormBorderStyle.None;
                formEnfant.Dock = DockStyle.Fill;
                PanelSousFormaulire.Controls.Add(formEnfant);
                PanelSousFormaulire.Tag = formEnfant;
                formEnfant.BringToFront();
                formEnfant.Show();
            }
        }

    }
}
