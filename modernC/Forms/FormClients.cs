using modernC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modernC.Forms
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            
        }
        

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            panelcnmdte.BackColor = ThemeColor.PrimaryColor;
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjoutter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }
    }
}
