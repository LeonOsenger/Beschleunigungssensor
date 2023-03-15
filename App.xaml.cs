using Microsoft.Maui.Devices.Sensors;

namespace Beschleunigungssensor;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override void OnStart()
    {
        base.OnStart();
		Accelerometer.Start(SensorSpeed.Default);
    }
}
