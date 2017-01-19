using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingForm.Properties;

namespace TestingForm
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Write an application that will seamlessly encrypt and decrypt any drive the user wants.", "Land Job");
            if (Settings.Default.WindowLocation != null) this.Location = Settings.Default.WindowLocation;
            if (Settings.Default.WindowsSize != null) this.Size = Settings.Default.WindowsSize;

        }

        private void Encryption_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("List all the drives. Put this on top. Remember last position", "Drive List");
        }

        private void Encryption_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.WindowLocation = this.Location;
            if (this.WindowState == FormWindowState.Normal) Settings.Default.WindowsSize = this.Size;
            else Settings.Default.WindowsSize = this.RestoreBounds.Size;    // Handle a minimized or maximized window via REstoreBounds
            Settings.Default.Save();
        }
    }
}
