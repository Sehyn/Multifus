using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multifus
{
    public partial class Bienvenue : Form
    {
        public Bienvenue()
        {
            InitializeComponent();
            if (Multifus.Properties.Settings.Default.Accepted == true)
            {
                this.Hide();
                Main MainForm = new Main();
                MainForm.ShowDialog();
                this.Close();
            }
           
        }

        private void RefuseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vous refusez la charte d'utilisation, de ce fait vous ne respectez pas les conditions requises pour utiliser notre logiciel. \rLe programme va donc se fermer.", "Refuser la charte d'utilisation?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            Multifus.Properties.Settings.Default.Accepted = true;
            Multifus.Properties.Settings.Default.Save();

            this.Hide();
            Main MainForm = new Main();
            MainForm.ShowDialog();
            this.Close();
        }
    }
}
