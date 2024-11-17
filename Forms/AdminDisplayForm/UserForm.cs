﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPRO.Forms.AdminDisplayForm
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            btnAddUser.Click += DoClickAddUser;
        }

        private void DoClickAddUser(object? sender, EventArgs e)
        {
            new UserAddForm().Show();
        }
    }
}
