namespace agentsANDsensors;

public class ThermalSensor:Sensor
{
    public ThermalSensor():base(GameEnums.SensorEnum.ThermalSensor){}

    private void RevealWeaknes(Agent agent)
    {
        Sensor[] sensors = agent.getUnActiveSensores();
        Random rnd = new Random();
        int rndSns = rnd.Next(0, sensors.Length);
        Console.WriteLine($"ThermalSensor revealing weakness {sensors[rndSns].type}");
    }

    public override void Activate(Agent agent)
    {
        base.Activate(agent);
        RevealWeaknes(agent);
    }
}