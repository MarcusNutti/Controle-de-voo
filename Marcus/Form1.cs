using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Marcus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            AcmeFlightManager acmeflightmanager = new AcmeFlightManager();
            acmeflightmanager.ShowDialog();

            /*Form1 form1 = new Form1();
            form1.Close();*/
        }
    }
}
