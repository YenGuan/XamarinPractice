using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services;

namespace PrismApp1.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { SetProperty(ref _UserName, value); }
        }
        public DelegateCommand showNew1PageCommand => new DelegateCommand(showNew1Page);
        public DelegateCommand deepLinkingCommand => new DelegateCommand(deepLinking);
        public DelegateCommand dialogCommand => new DelegateCommand(showDialog);
        public DelegateCommand userCommand => new DelegateCommand(userCheck);
        public async void showNew1Page()
        {
            NavigationParameters foo = new NavigationParameters();
            foo.Add("Key", "Value");//查詢字串
            await _navigationService.NavigateAsync("PrismContentPage?ID=A");//查詢字串 可與上行混用
        }
        public async void deepLinking()
        {          
            await _navigationService.NavigateAsync("PrismContentPage/NaviPage/SecondPage");//deeplink
        }
        public async void showDialog()
        {
            await _dialogService.DisplayAlertAsync("warning","content","OK","cancel");//showdialog
        }
        public void userCheck()
        {
            _UserName = _UserCheck.Check();
        }
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _dialogService;
        private IUserCheck _UserCheck;
        public MainPageViewModel(INavigationService navigationService, IPageDialogService dialogService, IUserCheck UserCheck)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;
            _UserCheck = UserCheck;

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
