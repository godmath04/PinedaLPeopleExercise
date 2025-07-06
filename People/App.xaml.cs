using System.Security.Cryptography.X509Certificates;
namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepo { get; private set; }

    public App(PersonRepository repo)
    {
        InitializeComponent();
        // Initialize the PersonRepository property with the provided repository instance
        PersonRepo = repo;
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        return new Window(new AppShell());
    }
}