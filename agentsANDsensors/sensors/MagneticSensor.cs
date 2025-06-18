namespace agentsANDsensors;

public class MagneticSensor: Sensor
{
    public MagneticSensor(): base(GameEnums.SensorEnum.MagneticSensor){}
    
    public override void Activate(Agent agent)
    {
        base.Activate(agent);
        agent.cancelCounterAttack++;
    }
}