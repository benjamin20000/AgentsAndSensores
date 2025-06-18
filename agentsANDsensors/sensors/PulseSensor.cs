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
            Console.WriteLine($"{this.type}: too much work for me i am broke now....");
            this.active = false;
            activationCounter = 0;
        }
    }
    
}