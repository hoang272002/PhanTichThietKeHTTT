﻿using Analysis_and_Design_Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Analysis_and_Design_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.Close();
            Login login = new Login();
            login.Show();
            
        }

    }
}
