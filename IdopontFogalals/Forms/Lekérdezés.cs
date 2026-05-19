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
    public partial class Lekérdezés : Form
    {
        public Lekérdezés()
        {
            InitializeComponent();
        }

        static int userId = Session.UserId;

        public void Render()
        {
            listBox1.Items.Clear();
            List<string> adatok = ReservationHelper.GetUserData(userId);

            foreach (var item in adatok)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Lekérdezés_Load(object sender, EventArgs e)
        {
            Render();   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Foglalas foglalas = new Foglalas();
            foglalas.ShowDialog();
            if (foglalas.DialogResult==DialogResult.OK)
            {
                Render();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int selectedIndex=listBox1.SelectedIndex;
            string values = listBox1.Items[selectedIndex].ToString().Trim();
            string[]egysor=values.Split('|');

            string date = egysor[0].Trim();
            string time=egysor[1].Trim();
            string mechanicName = egysor[2].Trim();
            int mechanicId = SzereloHelper.getMechanicId(mechanicName);

            //MessageBox.Show($"{date}\n{time}\n{mechanicName}\n{mechanicId}\n{userId}");

            ReservationHelper.CancelReservation(userId, mechanicId, date, time);

            MessageBox.Show("Reservation cancalled successfully.");

            Render();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
