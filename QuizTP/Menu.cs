using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizTP.Model;
namespace QuizTP
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }
        public Form activeForm = null;

        public void OpenChildForm(Form formEnfant)
        {
            if (activeForm != null)
            { activeForm.Close(); }
                

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            pnl_principal.Controls.Add(formEnfant);
            pnl_principal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
            
        }

        public void démarrerToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            OpenChildForm(new Form1());
        }
    }
}
