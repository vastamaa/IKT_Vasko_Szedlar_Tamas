using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Autokereskedes
{
    public partial class Autokereskedes : Form
    {
        string filename = "";

        public Autokereskedes()
        {
            InitializeComponent();
            LoadUI();
        }

        private void LoadUI()
        {
            panel1.Controls.Clear();
            Control control = new Control()
            {
                Location = new Point(100, 50)
            };
            panel1.Controls.Add(control);
        }

        private void névjegy_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            About bout = new About()
            {
                Location = new Point(25, 50)
            };
            panel1.Controls.Add(bout);
        }

        private void kilépés_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "txt";
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.ShowDialog();

                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (Car item in Control.cars)
                    {
                        sw.WriteLine(item.Name + ";" + item.Type + ";" + item.Doc + ";" + item.Color + ";" + item.LicenseNum);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            
        }

        private void kezelőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.ShowDialog();

            using (StreamReader sr = new StreamReader(ofp.FileName))
            {
                
            }

        }
    }
}
