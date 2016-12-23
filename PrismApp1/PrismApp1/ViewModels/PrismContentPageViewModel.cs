using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismApp1.ViewModels
{
    public class PrismContentPageViewModel : BindableBase, INavigationAware
    {
        private string _KeyLbl;

        public string KeyLbl
        {
            get { return _KeyLbl; }
            set { _KeyLbl = value; }
        }

        public PrismContentPageViewModel()
        {
           
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Key"))
            {
                var queryStringA = parameters["Key"] as string;
                var queryStringB = parameters["ID"] as string;

                KeyLbl = $"{queryStringA}/{queryStringB}";
            }
            else
            {
                KeyLbl = $"No Parameter/Querystring";
            }
        }
    }
}
