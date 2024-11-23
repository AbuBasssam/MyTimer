﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTimer
{
    public partial class frmArabicEditTimer : Form
    {
        public frmArabicEditTimer()
        {
            InitializeComponent();
            maskedTextBox1.Text = "00:00:00";//Default value 

        }
        //Check no missing input
        bool WrongMinutesOrHoursInput()
        {
            return (maskedTextBox1.Text[3] > 53 && maskedTextBox1.Text[3] < 57 || maskedTextBox1.Text[6] > 53 && maskedTextBox1.Text[3] < 57 || (maskedTextBox1.Text[6] > 53 && maskedTextBox1.Text[3] < 57)) ? true : false;

        }
        
        //Close Form
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        
        //Edit Present Timer in Form
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Data isn't completed
            if (maskedTextBox1.Text.Length != 8)
            {
                MessageBox.Show("يوجد حقل فارغ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

           
            // No more 60 Minutes/Seconds
            if (WrongMinutesOrHoursInput())
            {
                MessageBox.Show("يوجد ثواني /دقائق زائدة حاول مرة أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Defalut input not accepted
            if (maskedTextBox1.Text != "00:00:00")
            {

                var frm = Application.OpenForms["ArabicForm"] as frmArabic;

                frmArabic.btnToModifying.Text = maskedTextBox1.Text;

            }

            this.Close();


        }
    }
}
