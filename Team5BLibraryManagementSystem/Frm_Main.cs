﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5BLibraryManagementSystem
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();       
        }
        
        private void Usercontrol(bool visibility)
        {
             uc_Addbook1.Visible = visibility;
             uc_LendBook1.Visible = visibility;
             uc_Reports4.Visible = visibility;
             uc_Researchbook1.Visible = visibility;
             uc_ReturnBook1.Visible = visibility;
             uc_Addmember1.Visible = visibility;
             uc_Membersearchedit1.Visible = visibility;
        }

        private void BooksMenu(bool visibility)
        {
            btn_Searchbooks.Visible = visibility;
            btn_Registernewbooks.Visible = visibility;
            btn_Loanbooks.Visible = visibility;
            btn_Returnbooks.Visible = visibility;
        }

        private void MemberMenu(bool visibility)
        {
            btn_Searcheditmember.Visible = visibility;
            btn_Addnewmember.Visible = visibility;
        }
        private void AllMenu(bool visibility)
        {
            MemberMenu(visibility);
            BooksMenu(visibility);
        }

        private void btn_Searchbooks_MouseEnter(object sender, EventArgs e)
        {
            BooksMenu(true);
            MemberMenu(false);
        }

        private void btn_Registernewbooks_MouseEnter(object sender, EventArgs e)
        {
            BooksMenu(true);
            MemberMenu(false);
        }

        private void btn_Loanbooks_MouseEnter(object sender, EventArgs e)
        {
            BooksMenu(true);
            MemberMenu(false);
        }

        private void btn_Returnbooks_MouseEnter(object sender, EventArgs e)
        {
            BooksMenu(true);
            MemberMenu(false);
        }

        private void btn_Searcheditmember_MouseEnter(object sender, EventArgs e)
        {
            MemberMenu(true);
            BooksMenu(false);
        }

        private void btn_Addnewmember_MouseEnter(object sender, EventArgs e)
        {
            MemberMenu(true);
            BooksMenu(false);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void btn_Books_MouseEnter_1(object sender, EventArgs e)
        {
            BooksMenu(true);
            MemberMenu(false);
        }

        private void btn_Members_MouseEnter_1(object sender, EventArgs e)
        {
            BooksMenu(false);
            MemberMenu(true);
        }

        private void btn_Reports_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void btn_Searchbooks_Click(object sender, EventArgs e)
        {
            AllMenu(false);
            Usercontrol(false);
            uc_Researchbook1.Visible = true;      
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Usercontrol(false);
            AllMenu(false);
            uc_Researchbook1.Visible = true;           
        }

        private void btn_Searcheditmember_Click(object sender, EventArgs e)
        {
            AllMenu(false);
            Usercontrol(false);
            uc_Membersearchedit1.Visible = true;
        }

        private void btn_Loanbooks_Click(object sender, EventArgs e)
        {
            AllMenu(false);
            Usercontrol(false);
            uc_LendBook1.Visible = true;
        }

        private void btn_Returnbooks_Click(object sender, EventArgs e)
        {
            AllMenu(false);
            Usercontrol(false);
            uc_ReturnBook1.Visible = true;
        }

        private void btn_Registernewbooks_Click(object sender, EventArgs e)
        {
            AllMenu(false);
            Usercontrol(false);
            uc_Addbook1.Visible = true;
        }

        private void btn_Addnewmember_Click(object sender, EventArgs e)
        {
            AllMenu(false);
            Usercontrol(false);
            uc_Addmember1.Visible = true;
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            AllMenu(false);
            Usercontrol(false);
            uc_Reports4.Visible = true;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Frm_Login f1 = new Frm_Login();
                f1.Show();
            }
            else
            {
                e.Cancel = true;
            }
        
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void btn_Logout_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void Frm_Main_MouseLeave(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Researchbook1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Reports4_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Membersearchedit1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_LendBook1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Addbook1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_ReturnBook1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Addmember1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Researchbook1_MouseEnter_1(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Addmember1_MouseEnter_1(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Addbook1_MouseEnter_1(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_ReturnBook1_MouseEnter_1(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_LendBook1_MouseEnter_1(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void uc_Reports4_MouseEnter_1(object sender, EventArgs e)
        {
            AllMenu(false);
        }
    }
}
