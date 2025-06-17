namespace agentsANDsensors;

public static class SensorFactory
{
    public static Sensor CreateSensor(GameEnums.SensorEnum sensorEnum)
    {
        switch (sensorEnum)
        {
            case GameEnums.SensorEnum.AudioSensor:
                return new AudioSensor();
            case GameEnums.SensorEnum.ThermalSensor:
                return new ThermalSensor();
            case GameEnums.SensorEnum.PulseSensor:
                return new PulseSensor();
            default:
                throw new ArgumentException("Unknown sensor type");
        }
    }
}
