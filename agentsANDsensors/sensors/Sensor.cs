namespace agentsANDsensors;

public abstract class Sensor
{
    private GameEnums.SensorEnum type;

    public Sensor(GameEnums.SensorEnum type)
    {
        this.type = type;
    }
    public virtual void Activate(Agent agent)
    {
        for (int i = 0; i < agent.agentWeaknesses.Length; i++)
        {
            if (agent.agentWeaknesses[i] == this.type)
            {
                agent.agentWeaknesses[i] = GameEnums.SensorEnum.NullSensor;
                agent.agentSensors[agent.weaknessesNum - agent.discoveredWeaknesses-1] = this;
                agent.discoveredWeaknesses++;
                break;
            }
        }
    }

}