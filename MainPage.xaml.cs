using Microsoft.Maui.Devices.Sensors;

namespace Beschleunigungssensor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();

        try
        {
            ToggleAccelerometer();
        }
        catch (Exception ex)
        {
            LabelSensorData.Text = ex.Message;
        }
    }

    public void ToggleAccelerometer()
    {
        if (Accelerometer.Default.IsSupported)
        {
            if (!Accelerometer.Default.IsMonitoring)
            {
                //Eventhandler für Beschleunigungsmotor wird Aboniert 
                Accelerometer.Default.ReadingChanged += Accelerometer_ReadingChanged;
            }
            else
            {
                //Eventhandler für Beschleunigungsmotor wird nicht mehr Aboniert
                Accelerometer.Default.ReadingChanged -= Accelerometer_ReadingChanged;
            }
        }
    }

    /// <summary>
    /// Eventhandler der AUsgelösst wird wenn der Senosr Datenermittelt
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
    {
        //Ausgabe der Werte des Sensors
        LabelSensorData.Text = e.Reading.ToString();
        
    }
}

