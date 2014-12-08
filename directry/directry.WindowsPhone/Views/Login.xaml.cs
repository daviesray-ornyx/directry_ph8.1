using directry.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

/* Project Namespaces */


namespace directry.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {

        private UserDetailViewModel userDetailVM;
        public UserDetailViewModel UserDetailVM
        {
            get
            {
                if (userDetailVM == null)
                    userDetailVM = new UserDetailViewModel();
                userDetailVM.CurrentPage = this;
                return userDetailVM;
            }
        }

        public Login()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        public void ShowResetPasswordLink()
        {
            tblockResetPassword.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void tblockSignUp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Signup));
            
        }


        private void tblockResetPassword_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Redirect to password reset page
            Frame.Navigate(typeof(PasswordResetView));
        }
    }
}
