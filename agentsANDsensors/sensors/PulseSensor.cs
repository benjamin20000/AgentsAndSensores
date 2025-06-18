namespace agentsANDsensors;

public class PulseSensor: Sensor
{
    public PulseSensor():base(GameEnums.SensorEnum.PulseSensor){}

    public override void Activate(Agent agent)
    {
        base.Activate(agent);
        base.activationCounter++;
        if (base.activationCounter == 3)
        {
            this.active = false;
            activationCounter = 0;
        }
    }
    
}