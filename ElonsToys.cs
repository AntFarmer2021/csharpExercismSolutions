using System;
class RemoteControlCar
{
    private int _distanceDriven = 0;
    private int _batteryPercentage = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }
    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
    }
    public string BatteryDisplay()
    {
        string message;
        if(_batteryPercentage > 0)
        {
            message = $"Battery at {_batteryPercentage}%";
        }
        else
        {
            message = "Battery empty";    
        }
        return message;
    }
    public void Drive()
    {
        if(_batteryPercentage > 0)
        {
            _distanceDriven += 20;
            _batteryPercentage -= 1;
        }
    }
}