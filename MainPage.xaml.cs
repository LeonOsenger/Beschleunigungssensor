using Microsoft.Maui.Devices.Sensors;

namespace Beschleunigungssensor;

public partial class MainPage : ContentPage
{
    private AccelerometerData SensorData = new AccelerometerData();

    public MainPage()
	{
        InitializeComponent();

        try
        {
            ActivateAccelerometerEventhandler();
        }
        catch (Exception ex)
        {
            LabelSensorData.Text = ex.Message;
        }
    }
    
    //
    public void ActivateAccelerometerEventhandler()
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
        }else
        {
            LabelSensorData.Text = "Sensor nicht verfügbar";
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

        //Sensor der Daten misst wird einem AccelerometerData Objekt zugewissen, damit Daten verarbeitet werden können  
        SensorData = e.Reading;

        //Sensorpsoistion wird ermittelt und schaut wie das Handy Positioniert ist
        if (SensorData.Acceleration.Y > 0.7 || SensorData.Acceleration.Y < -0.7)  
        {
            LabelPositionInfo.Text = "Sie heben das Handy Vertikal";
        }
        else if (SensorData.Acceleration.X > 0.7 || SensorData.Acceleration.X < -0.7)
        {
            LabelPositionInfo.Text = "Sie heben das Handy Horizontal";
        }
        else
        {
            LabelPositionInfo.Text = "";
        }
    }
}

