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
    public partial class dlg_aendern : Form
    {
        public dlg_aendern()
        {
            InitializeComponent();
        }
        public cls_song Songs
        {
            get;
            set;
        }
        public dlg_aendern(cls_song song)
        {
            InitializeComponent();
            Songs = song;
            tbx_song.Text = song.Songname;
            tbx_interpret.Text = song.Interpret;
            tbx_dauer.Text = Convert.ToString(song.Songdauer);
        }
    }
}
