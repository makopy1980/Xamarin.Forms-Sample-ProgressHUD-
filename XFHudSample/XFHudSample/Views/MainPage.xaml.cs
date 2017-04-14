using ProgressHud;
using Xamarin.Forms;

namespace XFHudSample.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// WebView遷移中処理
        /// </summary>
        private void webviewOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            // HUDを表示する
            DependencyService.Get<IProgressHud>().Show("Loading...");
        }

        /// <summary>
        /// WebView遷移完了時処理
        /// </summary>
        private void webviewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            // HUDを表示する
            DependencyService.Get<IProgressHud>().Dismiss();
        }
    }
}

