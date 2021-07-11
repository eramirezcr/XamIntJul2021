using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace XamIntJul2021.AppBase
{
    public class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {
        }

        private string title;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        private string subtitle;

        public string Subtitle
        {
            get => subtitle;
            set => SetProperty(ref subtitle, value);
        }

        private string icon;

        public string Icon
        {
            get => icon;
            set => SetProperty(ref icon, value);
        }

        private string pageID;

        public string PageId
        {
            get => pageID;
            set => SetProperty(ref pageID, value);
        }

        private string isBusy;

        public string IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        public ICommand OnAppearingCommnad { get; set; }

        public ICommand OnDisapearing { get; set; }

        public virtual void OnBackButtonPressed()
        {

        }

        public virtual void Save()
        {

        }

        private Dictionary<String, object> navigationParametersToSend;

        protected Dictionary<String, object> NavigationParametersToSend
        {
            get
            {
                if (navigationParametersToSend is null)
                    navigationParametersToSend = new();

                return navigationParametersToSend;
            }
        }
    }
}
