namespace agentsANDsensors;

public class ThermalSensor:Sensor
{
    public ThermalSensor():base(GameEnums.SensorEnum.ThermalSensor){}

    private void RevealWeaknes(Agent agent)
    {
        Sensor[] sensors = agent.getUnActiveSensores();
        if (sensors.Length == 0)
        {
            Console.WriteLine($"no weakness to reveal");
        }
        else
        {
            Random rnd = new Random();
            int rndSns = rnd.Next(0, sensors.Length);
            Console.WriteLine($"ThermalSensor revealing weakness {sensors[rndSns].type}");
        }
       
    }

    public override void Activate(Agent agent)
    {
        Console.WriteLine("ThermalSensor working");
        RevealWeaknes(agent);
    }
}