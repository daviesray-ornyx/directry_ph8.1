using directry.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace directry.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonProfileView : Page
    {
        public PersonProfileView()
        {
            this.InitializeComponent();
        }

        private UserDetailViewModel userDetailVM;
        public UserDetailViewModel UserDetailVM
        {
            get
            {
                if (userDetailVM == null)
                    userDetailVM = new UserDetailViewModel();
                userDetailVM.CurrentPage = this;
                // Retrieve current user profile
                userDetailVM.UserType = "person";
                userDetailVM.GetCurrentUserProfile();
                return userDetailVM;
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tblUsername.Text = "Got into tapped";
            var openPicker = new FileOpenPicker
            {
                SuggestedStartLocation = PickerLocationId.PicturesLibrary,
                ViewMode = PickerViewMode.Thumbnail
            };

            // Filter to include a sample subset of file types.
            openPicker.FileTypeFilter.Clear();
            openPicker.FileTypeFilter.Add(".bmp");
            openPicker.FileTypeFilter.Add(".png");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".jpg");
            CoreApplicationView view = CoreApplication.GetCurrentView();
            view.Activated += viewActivated;

            openPicker.PickSingleFileAndContinue();
             
        }

        public async void viewActivated(CoreApplicationView sender, IActivatedEventArgs args1)
        {
            FileOpenPickerContinuationEventArgs args = args1 as FileOpenPickerContinuationEventArgs;

            CoreApplicationView view = CoreApplication.GetCurrentView();
            view.Activated -= viewActivated;
            var file = args.Files.FirstOrDefault();
            if (file == null)
                return;

            IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.DecodePixelHeight = (int)ProfilePic.Height;
            bitmapImage.DecodePixelHeight = (int)ProfilePic.Width;
            bitmapImage.SetSource(fileStream);
            ProfilePic.Source = bitmapImage;
        }
    }
}
