using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using XammySFCalendar.ViewModels;
using XammySFCalendar.Views;

namespace XammySFCalendar
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDE0Nzg0QDMxMzgyZTM0MmUzMEowUmJiajN3NWhqaHY4TlJudnNGNE9ZMit0cUNyMnJhNDF6YUVTYjRZZFk9");

            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/JCalendar");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<JCalendar, JCalendarViewModel>();
        }
    }
}
