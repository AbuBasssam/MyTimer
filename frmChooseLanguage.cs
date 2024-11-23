using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTimer
{
   
    public partial class frmChooseLanguage : Form
    {
        

        public frmChooseLanguage()
        {

            InitializeComponent();
            
        }
        //show english version of application
        private void btnEnglish_Click(object sender, EventArgs e)
        {
          
            frmEnglish frmMain = new frmEnglish();
             frmMain.Show();
             this.Hide();
        }


        //show Arabic version of application
        private void btnArabic_Click(object sender, EventArgs e)
        {
            frmArabic frmArabic = new frmArabic();
            frmArabic.Show();
            this.Hide();
        }

       
    }
}
