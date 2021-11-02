using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Autokereskedes
{
    public partial class Control : UserControl
    {
        public static List<Car> cars;
        public Control()
        {
            InitializeComponent();
             cars = new List<Car>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cars.Add(new Car(tbName.Text + ";" + tbType.Text + ";" + tbDoC.Text + ";" + tbColor.Text + ";" + tbLicenseNumber.Text));
                listBox1.Items.Add(tbName.Text + ";" + tbType.Text + ";" + tbDoC.Text + ";" + tbColor.Text + ";" + tbLicenseNumber.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                cars.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Clear();
                foreach (Car item in cars)
                {
                    listBox1.Items.Add(item.Name + ";" + item.Type + ";" + item.Doc + ";" + item.Color + ";" + item.LicenseNum);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            
        }
    }
}
