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
        try 
        {
            if (Accelerometer.Default.IsSupported)
            {
                Accelerometer.Start(SensorSpeed.UI);
            }
        } 
        catch (Exception) 
        {
            throw;
        }
    }

    protected override void OnSleep()
    {
        base.OnSleep();
        try
        {
            if (Accelerometer.Default.IsSupported)
            {
                Accelerometer.Default.Stop();
            }
        }
        catch (Exception)
        {

            throw;
        }
        
    }
}