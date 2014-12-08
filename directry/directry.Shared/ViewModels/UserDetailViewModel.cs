using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.Generic;
using Windows.UI.Popups;
using directry.Models;
using System.IO;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using directry.Views;
using Windows.UI.Xaml.Media.Imaging;



namespace directry.ViewModels
{
    public class UserDetailViewModel : INotifyPropertyChanged
    {
        public UserDetailViewModel()
        {
            // happens on creation
        }
        

        /*
         * PROPERTIES
         */

        public Page CurrentPage { get; set; }

        private bool loggedIn = false;

        public enum UserTypes { Person, Institution };

        private String userType;
        public String UserType 
        {
            get { return userType; }
            set
            {
                if (userType != value)
                {
                    userType = value;
                    NotifyPropertyChanged("UserType");
                }
            }
        }

        private BitmapImage profileImage;
        public BitmapImage ProfileImage
        { 
            get 
            {               
                
                if (profileImage == null)
                {
                    BitmapImage bImage = new BitmapImage();
                    bImage.UriSource = new Uri("ms-appx:///Assets/SmallLogo.png");
                    return bImage;
                }
                else
                {
                    return profileImage;
                }
            }
            set 
            {
                if (profileImage != value)
                {
                    profileImage = value;
                    NotifyPropertyChanged("ProfileImage");
                }
            }
        }

        private String username ;
        public String Username
        {
            get { return username;  }
            set
            {
                if (username != value)
                {
                    username = value;
                    NotifyPropertyChanged("Username");
                }
            }
        }

        private String password;
        public String Password {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    NotifyPropertyChanged("Password");
                }
            }
        }

        private String confirmPassword;
        public String ConfirmPassword {
            get { return confirmPassword; }
            set 
            {
                if (confirmPassword != value)
                {
                    confirmPassword = value;
                    NotifyPropertyChanged("ConfirmPassword");
                }
            }
            
        }

        private String resetCode;
        public String ResetCode
        {
            get { return resetCode; }
            set
            {
                if (resetCode != value)
                {
                    password = value;
                    NotifyPropertyChanged("ResetCode");
                }
            }
        }

        private PersonProfile currentPersonProfile;
        public PersonProfile CurrentPersonProfile 
        {
            get { return currentPersonProfile; }
            set 
            {
                if (currentPersonProfile != value)
                {
                    currentPersonProfile = value;
                    //NotifyPropertyChanged("CurrentPersonProfile");
                }
            }
        }


        private InstitutionProfile currentInstitutionProfile;
        public InstitutionProfile CurrentInstitutionProfile
        {
            get { return currentInstitutionProfile; }
            set
            {
                if (currentInstitutionProfile != value)
                {
                    currentInstitutionProfile = value;
                    //NotifyPropertyChanged("CurrentInstitutionProfile");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(null != handler)
                handler(this,new PropertyChangedEventArgs(propertyName));
        }

               

        /* 
         * METHODS 
         */
        public bool isLoggedIn()
        {
            return loggedIn;
        }

        public async Task<bool> PersistProfileLocal(String type, String jsonValue)
        {
            try
            {
                if (type.Equals("institution"))
                {
                    // parse institution
                    InstitutionProfile profile = JsonConvert.DeserializeObject<InstitutionProfile>(jsonValue);
                    var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                    localSettings.Values["username"] = Username;
                    localSettings.Values["password"] = Password;
                    // saving to file
                    var localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                    using (Stream stream = await localFolder.OpenStreamForWriteAsync("profile", CreationCollisionOption.ReplaceExisting))
                    {
                        // Profile(message) is in json format already otherwise we'd have used
                        System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(InstitutionProfile));
                        serializer.WriteObject(stream, profile);
                    }
                }
                else if (type.Equals("person"))
                {
                    //parse person
                    PersonProfile profile = JsonConvert.DeserializeObject<PersonProfile>(jsonValue);
                    var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                    localSettings.Values["username"] = Username;
                    localSettings.Values["password"] = Password;
                    // saving to file
                    var localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                    using (Stream stream = await localFolder.OpenStreamForWriteAsync("profile", CreationCollisionOption.ReplaceExisting))
                    {
                        // Profile(message) is in json format already otherwise we'd have used
                        System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(PersonProfile));
                        serializer.WriteObject(stream, profile);

                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }            
        }

        public void UpdateProfileVariables()
        {
            if (userType.Equals("person"))
            {
                Username = CurrentPersonProfile.Username;
                //ProfileImage = CurrentPersonProfile.Person.ProfilePic;
            }
        }
        public async void SignIn()
        {

            Uri postUri = new Uri("http://boiling-beach-2332.herokuapp.com/api/auth/login");
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var keyValues = new List<KeyValuePair<string, string>>();
                    keyValues.Add(new KeyValuePair<string, string>("username", Username));
                    keyValues.Add(new KeyValuePair<string, string>("password", Password));
                    

                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, postUri);
                    requestMessage.Content = new FormUrlEncodedContent(keyValues);

                    var response = await httpClient.SendAsync(requestMessage);
                    response.EnsureSuccessStatusCode();
                    String message = await response.Content.ReadAsStringAsync();

                    var messageDialog = new MessageDialog(message);
                    Username = message;
                    if (response.IsSuccessStatusCode)
                    {                        
                        bool status = false;
                        PersonProfile profile = JsonConvert.DeserializeObject<PersonProfile>(message);
                        UserType = profile.UserType;
                        profile = null;

                        status = await PersistProfileLocal(UserType, message);
                        
                        if (!status)
                        {
                            //Error saving user profile to file
                            messageDialog.Content = "Could not retrieve user profile. Please try again";
                            await messageDialog.ShowAsync();
                        }
                        else
                        {
                            if (UserType == "person")
                            {
                                ((Login)CurrentPage).Frame.Navigate(typeof(PersonProfileView));
                            }
                            else if (UserType == "institution")
                            {
                                ((Login)CurrentPage).Frame.Navigate(typeof(InstitutionProfileView));
                            }                                
                        }
                            
                    }
                    else
                    {
                        ((Login)CurrentPage).ShowResetPasswordLink();
                    }
                }
                catch (Exception e)
                {
                    ((Login)CurrentPage).ShowResetPasswordLink();
                }
            }
        }

        public async void SignUp()
        {
            // 
            Uri postUri = new Uri("http://boiling-beach-2332.herokuapp.com/api/auth/register");
            
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var keyValues = new List<KeyValuePair<string, string>>();
                    keyValues.Add(new KeyValuePair<string, string>("username", Username));
                    keyValues.Add(new KeyValuePair<string, string>("password", Password));
                    keyValues.Add(new KeyValuePair<string, string>("userType", UserType));
                    
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, postUri);
                    requestMessage.Content = new FormUrlEncodedContent(keyValues);

                    var response = await httpClient.SendAsync(requestMessage);
                    response.EnsureSuccessStatusCode();
                    String message =  await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        // get status code
                        var messageDialog = new MessageDialog(message);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            //everything went as planned
                                // Parse user profile and move to profile page
                            bool status = false;
                            if (UserType.ToLower().Equals("institution"))
                            {
                                status = await PersistProfileLocal(UserType, message);
                                // move person to profile page
                                if (!status)
                                {
                                    //Error saving user profile to file
                                    messageDialog.Content = "Could not retrieve user profile. Please try again";
                                    await messageDialog.ShowAsync();
                                }
                                else
                                    ((Signup)CurrentPage).Frame.Navigate(typeof(InstitutionProfileView));
                            }
                            else if (UserType.ToLower().Equals("person"))
                            {
                                status = await PersistProfileLocal(UserType, message);
                                if (!status)
                                {
                                    //Error saving user profile to file
                                    messageDialog.Content = "Could not retrieve user profile. Please try again";
                                    await messageDialog.ShowAsync();
                                }
                                else
                                    ((Signup)CurrentPage).Frame.Navigate(typeof(PersonProfileView));
                            }
                            
                        }
                        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                        {
                            //Bad request, this is our default error
                            await messageDialog.ShowAsync();
                        }
                        else
                        {
                            //Just show the message and move on
                            await messageDialog.ShowAsync();
                        }                    
                                                
                        
                    }
                    else
                    {
                        //Show a dialog with error
                        // testing message dialog
                        
                        var messageDialog = new MessageDialog(message);
                        messageDialog.Commands.Add(new UICommand("Try Again", new UICommandInvokedHandler(this.CommandInvokedHandler)));
                        messageDialog.Commands.Add(new UICommand("Cancel", new UICommandInvokedHandler(this.CommandInvokedHandler)));
                        await messageDialog.ShowAsync();
                    }
                }
                catch (Exception e)
                {
                    Username = e.ToString();
                }
                
            }

            //using (var httpClient = new HttpClient())
            //{
            //    var postData = new StringContent(JsonConvert.SerializeObject(messageBody).ToString(), Encoding.UTF8, "application/x-www-form-urlencoded");
            //    var response = await httpClient.PostAsync(postUri, postData, CancellationToken.None);
            //    response.EnsureSuccessStatusCode();
            //    Username =  await response.Content.ReadAsStringAsync();
            //}
            
        }

        public async void RequestCode()
        {
            String uriString = "http://boiling-beach-2332.herokuapp.com/api/auth/request_password_reset_code" + "?username=" + Username;
            Uri getUri = new Uri(uriString);
            HttpResponseMessage response = new HttpResponseMessage();
            String message = "";
             using (var httpClient = new HttpClient())
             {
                 try
                 {
                        var requestMessage = new HttpRequestMessage(HttpMethod.Get, getUri);
                        //requestMessage.Content = new FormUrlEncodedContent(keyValues);

                        response = await httpClient.SendAsync(requestMessage);
                        response.EnsureSuccessStatusCode();
                        message =  await response.Content.ReadAsStringAsync();                        
                        if (response.IsSuccessStatusCode)
                        {
                            // get status code
                            //var messageDialog = new MessageDialog("Password reset code sent to " + Username);
                            var messageDialog = new MessageDialog(message);
                            messageDialog.Commands.Add(new UICommand("Reset Password", new UICommandInvokedHandler(this.CommandInvokedHandler)));
                            messageDialog.Commands.Add(new UICommand("Cancel Reset", new UICommandInvokedHandler(this.CommandInvokedHandler)));
                            await messageDialog.ShowAsync();
                        }
                 }
                 catch (Exception e)
                 {
                     MessageDialog messageDialog;
                     if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                     {
                         // we're safe to show the badd request message
                         messageDialog  = new MessageDialog(message);
                     }
                     else
                     {
                         messageDialog = new MessageDialog("An error occurred while generating reset password code, Please try again");
                     }
                     
                     ((RequestPasswordResetCodeView)CurrentPage).Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () => messageDialog.ShowAsync());
                 }
             }
        }

        public async void ResetPassword()
        {
            Uri getUri = new Uri("http://boiling-beach-2332.herokuapp.com/api/auth/reset_password");

            HttpResponseMessage response = new HttpResponseMessage();
            String message = "";
             using (var httpClient = new HttpClient())
             {
                 try
                 {
                        var keyValues = new List<KeyValuePair<string, string>>();
                        keyValues.Add(new KeyValuePair<string, string>("username", Username));
                        keyValues.Add(new KeyValuePair<string, string>("password", Password));
                        keyValues.Add(new KeyValuePair<string, string>("confirmPassword", Password));
                        keyValues.Add(new KeyValuePair<string, string>("resetCode", ResetCode));

                        var requestMessage = new HttpRequestMessage(HttpMethod.Post, getUri);
                        requestMessage.Content = new FormUrlEncodedContent(keyValues);

                        response = await httpClient.SendAsync(requestMessage);
                        response.EnsureSuccessStatusCode();
                        message =  await response.Content.ReadAsStringAsync();
                        var messageDialog = new MessageDialog(message);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            messageDialog.Commands.Add(new UICommand("Sign In", new UICommandInvokedHandler(this.CommandInvokedHandler)));
                            await messageDialog.ShowAsync();
                        }
                        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                        {
                            await messageDialog.ShowAsync();
                        }
                 }
                 catch (Exception e)
                 {
                     var messageDialog = new MessageDialog(message);
                     if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                     {
                         messageDialog.Content = message;
                     }
                     else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                     {
                         messageDialog.Content = e.Message;
                     }
                     ((Page)CurrentPage).Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () => messageDialog.ShowAsync());
                 }
             }
        }


        public async void GetCurrentUserProfile()
        {
            var localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            using (Stream stream = await localFolder.OpenStreamForReadAsync("profile"))
            {
                // Profile(message) is in json format already otherwise we'd have used
                if (UserType.Equals("person"))
                {
                    System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(PersonProfile));
                    CurrentPersonProfile = (PersonProfile)serializer.ReadObject(stream);
                    UpdateProfileVariables();
                }
                else
                {
                    System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(InstitutionProfile));
                    CurrentInstitutionProfile = (InstitutionProfile)serializer.ReadObject(stream);
                    UpdateProfileVariables();
                }
                
            }
            
        }

        private void CommandInvokedHandler(IUICommand command)
        {
            if (command.Label == "Try Again")
            {
                // we need to try again
                SignUp();

            }
            else if (command.Label == "Cancel")
            {
                // cancel anything happening here!
                    //Leave user where they are
            }
            else if (command.Label == "Reset Password")
            {   
                    // Navigate to password reset view
                ((Page)CurrentPage).Frame.Navigate(typeof(PasswordResetView));
            }
            else if (command.Label == "Cancel Reset")
            {
                // Cancel Password Reset
                ((Page)CurrentPage).Frame.Navigate(typeof(Login));
            }
            else if (command.Label == "Sign In")
            {
                // Navigate to login page
                ((Page)CurrentPage).Frame.Navigate(typeof(Login));
            }
        }
                        

        /* COMMANDS */
        public ICommand SignUpCommand // registration
        {
            get { return new SignUpCommand(); } 
        }

        public ICommand SignInCommand   //login
        {
            get { return new SignInCommand(); }
        }
        
        public ICommand RequestCodeCommand   //Request Code
        {
            get { return new RequestCodeCommand(); }
        }

        public ICommand ResetPasswordCommand   //Request Code
        {
            get { return new ResetPasswordCommand(); }
        }
    }

    /* COMMAND CLASSES */
    public class SignUpCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            // let's pass in the data context -- UserDetailViewModel
            ((UserDetailViewModel)parameter).SignUp();
        }
    }

    public class SignInCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            // let's pass in the data context -- UserDetailViewModel
            ((UserDetailViewModel)parameter).SignIn();
        }
    }

    public class RequestCodeCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            // let's pass in the data context -- UserDetailViewModel
            ((UserDetailViewModel)parameter).RequestCode();
        }
    }

    public class ResetPasswordCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            // let's pass in the data context -- UserDetailViewModel
            ((UserDetailViewModel)parameter).ResetPassword();
        }
    }

    
}
