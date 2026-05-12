using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            SecondForm secondForm = new SecondForm(name);
            secondForm.ShowDialog();
        }
    }
}
