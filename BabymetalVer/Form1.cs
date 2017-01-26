using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabymetalVer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillListbox();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_neu dialog = new dlg_neu();
            dialog.ShowDialog();
        }
        private void FillListbox()
        {
            lbx_songs.Items.Clear();
            try
            {
                lbx_songs.Items.AddRange(DataProvider.GetAlleKommentare().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FEHLER");
            }
        }

        private void btn_aendern_Click(object sender, EventArgs e)
        {
            dlg_aendern dialog = new dlg_aendern();
            dialog.ShowDialog();
        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {

        }
    }
}
