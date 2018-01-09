using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebViewTest
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainPageViewModel()
        {
        }

        private bool isWebViewVisible = true;

        public bool IsWebViewVisible
        {
            get { return isWebViewVisible; }
            set
            {
                isWebViewVisible = value;
                OnPropertyChanged();
            }
        }

        private string urlSource = "https://www.cnet.com";

        public string UrlSource
        {
            get
            {
                return urlSource;
            }
            set
            {
                urlSource = value;
                OnPropertyChanged();
            }
        }
    }
}