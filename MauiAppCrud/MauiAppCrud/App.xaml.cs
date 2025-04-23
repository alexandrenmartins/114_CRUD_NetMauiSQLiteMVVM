
namespace MauiAppCrud
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            Window win = base.CreateWindow(activationState);
            win.Height = 600;
            win.Width = 400;
            return win;
        }
    }
}