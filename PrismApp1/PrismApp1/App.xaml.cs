using Prism.Unity;
using PrismApp1.Views;

namespace PrismApp1
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NaviPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<PrismContentPage>();      
            Container.RegisterTypeForNavigation<NaviPage>();
            Container.RegisterTypeForNavigation<SecondPage>();
        }
    }
}
