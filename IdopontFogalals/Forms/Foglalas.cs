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


            szereloId = SzereloHelper.getMechanicId(cbName.Text);
            string date = monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd");
            List<string> taken = SzereloHelper.getTakenDates(date, szereloId);

            List<int> hours = new List<int>();
            List<int> minutes = new List<int>();
            foreach (var item in taken)
            {
                string[] split = item.Split(':');
                hours.Add(Convert.ToInt32(split[0]));
                minutes.Add(Convert.ToInt32(split[1]));
            }

            cbHour.Items.Clear();
            for (int i = 8; i < 17; i++)
            {
                if (hours.Contains(i))
                {
                    if (hours.Count>1)
                    {
                        int index = hours.IndexOf(i);
                        if (index==hours.Count-1)
                        {
                            if (hours[index] == hours[index - 1])
                            {
                                continue;
                            }
                            else
                            {
                                cbHour.Items.Add(i);
                            }
                        }
                        else
                        {
                            if (hours[index] == hours[index + 1])
                            {
                                continue;
                            }
                            else
                            {
                                cbHour.Items.Add(i);
                            }
                        }
                    }
                    else
                    {
                        cbHour.Items.Add(i);
                    }
                }
                else
                {
                    cbHour.Items.Add(i);
                }
            }
        }

        private void btnFoglalas_Click(object sender, EventArgs e)
        {
            
            if (monthCalendar1.SelectionStart.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Please select a valid date");
                return;
            }
            if (cbHour.Text=="H" || cbMinute.Text=="M" || cbSpecialist.Text=="" || cbName.Text=="")
            {
                MessageBox.Show("Please fill every field.");
                return;
            }
            else
            {
                
                string date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                string hour = cbHour.Text + ":" + cbMinute.Text + ":00";

                SzereloHelper.IdopontFoglalas(userId, szereloId, date, hour);

                MessageBox.Show("Reservation successful.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void cbHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            szereloId = SzereloHelper.getMechanicId(cbName.Text);
            string date = monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd");
            List<string> taken = SzereloHelper.getTakenDates(date, szereloId);

            List<int> hours = new List<int>();
            List<int> minutes = new List<int>();
            foreach (var item in taken)
            {
                string[] split = item.Split(':');
                hours.Add(Convert.ToInt32(split[0]));
                minutes.Add(Convert.ToInt32(split[1]));
            }

            cbMinute.Items.Clear();
            int hour = Convert.ToInt32(cbHour.Text);
            if (hours.Contains(hour))
            {
                int index = hours.IndexOf(hour);
                int value = minutes[index];
                if (value==00)
                {
                    cbMinute.Items.Add("30");
                }
                else if (value==30)
                {
                    cbMinute.Items.Add("00");
                }
            }
            else
            {
                cbMinute.Items.Add("00");
                cbMinute.Items.Add("30");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            cbSpecialist.Text = "";
            cbName.Text = "";
            cbHour.Text = "H";
            cbMinute.Text = "M";
        }
    }
}
