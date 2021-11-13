﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void oldAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees obj2 = new Fees();
            obj2.ShowDialog();
        }

        private void newAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewAdmission obj1 = new NewAdmission();
            obj1.ShowDialog();
        }

        private void searchStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchStudent obj3 = new SearchStudent();
            obj3.ShowDialog();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualDetails obj4 = new IndividualDetails();
            obj4.ShowDialog();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent obj5 = new DeleteStudent();
            obj5.ShowDialog();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutSchool obj6 = new AboutSchool();
            obj6.ShowDialog();
        }

        private void aboutSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oldAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OldAdmission obj7 = new OldAdmission();
            obj7.ShowDialog();
        }

        private void registerEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterEmployee obj8 = new RegisterEmployee();
            obj8.ShowDialog();

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void deleteStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteStudent obj3 = new DeleteStudent();
            obj3.ShowDialog();
        }

        private void oldAdmissionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Fees obj3 = new Fees();
            obj3.ShowDialog();
        }
    }
}
