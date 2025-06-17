namespace agentsANDsensors;

public abstract class Sensor
{
    public GameEnums.SensorEnum type;
    public bool active { get; set; }
    protected int activationCounter;

    protected Sensor(GameEnums.SensorEnum type)
    {
        this.active = false;
        this.type = type;
    }
    public abstract void Activate(Agent agent);
}