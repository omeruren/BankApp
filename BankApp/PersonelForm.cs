using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class PersonelForm : Form
    {
        private int kullaniciID = 0;
        public PersonelForm()
        {
            InitializeComponent();
        }
        public PersonelForm(int kullaniciID)
        {
            this.kullaniciID=kullaniciID;       
        }
        private void PersonelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
