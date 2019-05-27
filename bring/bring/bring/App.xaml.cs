using bring.Framework;
using bring.ViewModel;
using SimpleInjector;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace bring
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (!DesignMode.IsDesignModeEnabled)
            {
                var mainPage = new MainPage();
                var navigationPage = new NavigationPage(mainPage);

                // Register services we need to setup our application.
                Services.RegisterInstance(navigationPage.Navigation);
                Services.Register<IViewMapper, ViewMapper>(Lifestyle.Singleton);
                Services.Register<IBringViewModelFactory, BringViewModelFactory>(Lifestyle.Singleton);
                Services.Register<IBringItemProvider, BringItemProvider>(Lifestyle.Singleton);
                Services.Register<MainViewModel>(Lifestyle.Singleton);
                Services.Register<BringListViewModel>(Lifestyle.Singleton);
                Services.Register<BringItemViewModel>(Lifestyle.Transient);

                // Setup the initial binding context
                mainPage.BindingContext = Services.GetInstance<MainViewModel>();

                // Assign the main page
                MainPage = navigationPage;
            }
        }

        public static Container Services { get; } = new Container();

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
