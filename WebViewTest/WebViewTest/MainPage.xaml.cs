using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Mybtn.Clicked += Mybtn_Clicked;
        }

        private void Mybtn_Clicked(object sender, EventArgs e)
        {
            var browser = new WebView { HeightRequest = 500 };
            browser.SetBinding(WebView.SourceProperty, "UrlSource");
            browser.SetBinding(WebView.IsVisibleProperty, "IsWebViewVisible");

            Root.Children.Add(browser);

            var ViewModel = BindingContext as MainPageViewModel;
            ViewModel.IsWebViewVisible = true;
            //   MyWebView.Source = "https://www.cnet.com";
        }
    }
}