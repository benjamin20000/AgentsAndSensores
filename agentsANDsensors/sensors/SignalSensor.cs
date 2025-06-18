namespace agentsANDsensors;

public class SignalSensor: Sensor
{
    public SignalSensor():base(GameEnums.SensorEnum.SignalSensor){}
    public override void Activate(Agent agent)
    {
        base.Activate(agent);
        Console.WriteLine($"the agent rank is {agent.AgentType}");
    }
}