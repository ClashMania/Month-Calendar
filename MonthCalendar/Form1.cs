using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = mCalendar1.SelectionEnd - mCalendar1.SelectionStart;
            if (ts.Days < 1)

            {

                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");

                return;

            }
            MessageBox.Show("Rezervirali ste usluge u trajanju od "+ts.Days.ToString() + " dana.", "Rezervacija");
            MessageBox.Show("Vasa rezervacija počinje " +
            mCalendar1.SelectionStart.ToShortDateString() + " a završava se" + mCalendar1.SelectionEnd.ToShortDateString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
