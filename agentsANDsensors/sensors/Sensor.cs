namespace agentsANDsensors;

public abstract class Sensor
{
    public GameEnums.SensorEnum type;
    public bool Active { get; set; }

    protected Sensor(GameEnums.SensorEnum type)
    {
        this.Active = false;
        this.type = type;
    }
    public virtual void Activate(Agent agent)
    {
        this.Active = true;
    }

}