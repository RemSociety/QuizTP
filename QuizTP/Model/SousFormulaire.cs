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
        public Panel PanelSousFormulaire;
        
        public SousFormulaire(Panel panelenvoit) 
        {
            PanelSousFormulaire = panelenvoit;
        }

        public Form activeForm = null;


        public void OpenChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            PanelSousFormulaire.Controls.Add(formEnfant);
            PanelSousFormulaire.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
            
        }

    }
}
