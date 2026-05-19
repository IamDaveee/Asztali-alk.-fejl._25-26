using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdopontFogalals
{
    public partial class Foglalas : Form
    {
        public Foglalas()
        {
            InitializeComponent();
        }

        static int szereloId = 0;
        static int userId = Session.UserId;
        private void Foglalas_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome back, {Session.Username}";

            List<string> specials = SzereloHelper.GetSpecials();
            foreach (var item in specials)
            {
                if (!cbSpecialist.Items.Contains(item))
                {
                    cbSpecialist.Items.Add(item);
                }
            }
        }

        private void cbSpecialist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbName.Items.Clear();
            List<string> mechanics = SzereloHelper.GetMechanic(cbSpecialist.Text);
            foreach (var item in mechanics)
            {
                if (!cbName.Items.Contains(item))
                {
                    cbName.Items.Add(item);
                }
            }
            cbName.SelectedIndex = 0;

        }

        private void btnFoglalas_Click(object sender, EventArgs e)
        {
            szereloId = SzereloHelper.getMechanicId(cbName.Text);
            string date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string hour = cbHour.Text + ":" + cbMinute.Text + ":00";

            SzereloHelper.IdopontFoglalas(userId, szereloId, date, hour);

            MessageBox.Show("Reservation successful.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
