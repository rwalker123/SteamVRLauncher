using System;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SteamVRLauncher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //GetRecentlyPlayedGames();
            LaunchSteamVR();
        }

        private async void GetRecentlyPlayedGames()
        {
            System.Uri endURI = new Uri("http://localhost:3000"); // Windows.Security.Authentication.Web.WebAuthenticationBroker.GetCurrentApplicationCallbackUri();
            string startURL = "https://steamcommunity.com/openid"; // /?client_id=1B6A6494CBCC9A890399C4F9E1A2997D&response_type=token&scope=read_stream" + "&redirect_uri=" + Uri.EscapeDataString("https://localhost.com"); // endURI.AbsoluteUri);
            System.Uri startURI = new System.Uri(startURL);

            string result;

            try
            {
                var webAuthenticationResult =
                    await Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAsync(
                    Windows.Security.Authentication.Web.WebAuthenticationOptions.None,
                    startURI, endURI);

                switch (webAuthenticationResult.ResponseStatus)
                {
                    case Windows.Security.Authentication.Web.WebAuthenticationStatus.Success:
                        // Successful authentication. 
                        result = webAuthenticationResult.ResponseData.ToString();
                        break;
                    case Windows.Security.Authentication.Web.WebAuthenticationStatus.ErrorHttp:
                        // HTTP error. 
                        result = webAuthenticationResult.ResponseErrorDetail.ToString();
                        break;
                    default:
                        // Other error.
                        result = webAuthenticationResult.ResponseData.ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                // Authentication failed. Handle parameter, SSL/TLS, and Network Unavailable errors here. 
                result = ex.Message;
            }
            //HttpClient c = new HttpClient();
            //HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, "https://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v0001/?key=AF180717A746D13DA1C0CFFC54F0AF06&steamid=76561198007662579&format=json");
            //var resp = await c.SendAsync(req);
            //if (resp.IsSuccessStatusCode)
            //{
            //    var body = await resp.Content.ReadAsStringAsync();
            //}
        }

        private async void LaunchSteamVR()
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("steam://rungameid/250820"));
            App.Current.Exit();
        }
    }
}
