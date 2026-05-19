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

        private void Lekérdezés_Load(object sender, EventArgs e)
        {
            int userId = Session.UserId;
            List<string> adatok = ReservationHelper.GetUserData(userId);

            foreach (var item in adatok)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
