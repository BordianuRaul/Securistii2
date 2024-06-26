﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UBB_SE_2024_Gaborment.Components;
using UBB_SE_2024_Gaborment.MVVM.ViewModel;
using UBB_SE_2024_Gaborment.Server.LoggerUtils;
using UBB_SE_2024_Gaborment.Session;

namespace UBB_SE_2024_Gaborment
{
    /// <summary>
    /// Interaction logic for UserCard.xaml
    /// </summary>
    public partial class UserCard : UserControl
    {
        public UserCard()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        public static readonly DependencyProperty FirstNameProperty = DependencyProperty.Register("FirstName", typeof(string), typeof(UserCard));

        public string LastName
        {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }


        public static readonly DependencyProperty UserIdProperty =
        DependencyProperty.Register("UserId", typeof(string), typeof(UserCard));


        public string UserId
        {
            get { return (string)GetValue(UserIdProperty); }
            set { SetValue(UserIdProperty, value); }
        }

        public static readonly DependencyProperty LastNameProperty = DependencyProperty.Register("LastName", typeof(string), typeof(UserCard));

        private void BlockButtonFriends_Click(object sender, RoutedEventArgs e)
        {
            ApplicationService service = ApplicationService.Instance;
            var session = ApplicationSession.Instance;
            service.blockUser(session.CurrentUserId, UserId, "I AM SICK OF THEM");
            MessageBox.Show("Blocked!");
        }

        private void UnfollowButtonFriends_Click(object sender, RoutedEventArgs e)
        {
            ApplicationService service = ApplicationService.Instance;
            var session = ApplicationSession.Instance;
            service.unfollowUser(session.CurrentUserId, UserId);
            MessageBox.Show("Unfollowed!");
        }
    }
}
