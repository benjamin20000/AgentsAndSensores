namespace agentsANDsensors;

public class LightSensor: Sensor
{
    public LightSensor():base(GameEnums.SensorEnum.LightSensor){}
    public override void Activate(Agent agent)
    {
        base.Activate(agent);
        agent.cancelCounterAttack++;
        Console.WriteLine($"the agent rank is {agent.AgentType}");
    }
    
}