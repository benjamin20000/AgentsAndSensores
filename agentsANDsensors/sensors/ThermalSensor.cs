namespace agentsANDsensors;

public class ThermalSensor:Sensor
{
    public ThermalSensor():base(GameEnums.SensorEnum.ThermalSensor){}

    private void RevealWeaknes(Agent agent)
    {
        GameEnums.SensorEnum[] UnrevealedWeaknesses = agent.getUnrevealedWeaknesses();
        Random rnd = new Random();
        int rndWeak = rnd.Next(0, UnrevealedWeaknesses.Length);
        Console.WriteLine($"ThermalSensor revealing weakness {UnrevealedWeaknesses[rndWeak]}");
    }

    public override void Activate(Agent agent)
    {
        base.Activate(agent);
        RevealWeaknes(agent);
    }
}