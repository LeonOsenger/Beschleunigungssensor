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
            //Wenn Sensor vorhanden: Sensor Wird gestartet 
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
            //Wenn Sensor vorhanden: Sensor Wird gestopt
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