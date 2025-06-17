namespace agentsANDsensors;

public class AudioSensor: Sensor
{
    public AudioSensor():base(GameEnums.SensorEnum.AudioSensor){}
    public override void Activate(Agent agent)
    {
        Console.WriteLine("Audio Sensor working");
    }
}