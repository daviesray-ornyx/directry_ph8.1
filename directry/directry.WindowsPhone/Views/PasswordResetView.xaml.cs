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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace directry.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PasswordResetView : Page
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


        public PasswordResetView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
        }

        private void tblockGetPasswordResetCode_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(RequestPasswordResetCodeView));
        }
    }
}
