﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class CoordinatorLogin : Window
    {
        public CoordinatorLogin()
        {
            InitializeComponent();
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            var claimPageWindow = new ClaimPage();
            claimPageWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
