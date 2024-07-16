namespace AppFlip;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        if (activationState is not null)
        {
            // check activationState
        }
        return base.CreateWindow(activationState);
    }
}