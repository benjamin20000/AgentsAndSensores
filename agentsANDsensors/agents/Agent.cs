namespace agentsANDsensors;

public abstract class Agent
{
    public GameEnums.AgentEnum AgentType;
    public int senssorsLen { get;}
    public Sensor[] agentSensors;
    protected int turnsCounter;

    public Agent(GameEnums.AgentEnum agentType)
    {
        turnsCounter = 0;
        senssorsLen = (int)(agentType);
        agentSensors = new Sensor[senssorsLen];
        createSensors(); //fill it with randomly sensors
    }

    private void createSensors()
    {
        var allSensors = GameEnums.getSensors();
        Random rnd = new Random();
        for(int i = 0; i < senssorsLen; i++)
        {
            int sns_rnd  = rnd.Next(0, allSensors.Length);
            Sensor newSens = SensorFactory.CreateSensor(allSensors[sns_rnd]);
            agentSensors[i] = newSens;
        }
    }

    private void printAgentSensors()
    {
        foreach (var sensor in agentSensors)
        {
            Console.WriteLine($"{sensor.type} {sensor.active}");
        }
    }

    public int countActiveSensors()
    {
        int count = 0;
        foreach (var sens in agentSensors)
        {
            if (sens.active)
            {
                count++;
            }
        }
        return count;
    }

    public Sensor[] getUnActiveSensors()
    {
        return (Sensor[])(agentSensors.Where(sens => sens.active == false).ToArray());

    }
    protected Sensor[] getActiveSensors()
    {
        return (Sensor[])(agentSensors.Where(sens => sens.active).ToArray());
    }

    

    public void AddSensor(GameEnums.SensorEnum sensorType)
    {
        foreach (var sens in agentSensors)
        {
            if (sens.type == sensorType && sens.active == false)
            {
                sens.active = true;
                break;
            }
        }
    }

    public virtual void ActivateSensors()
    {
        foreach (var sens in agentSensors)
        {
            if (sens.active == true)
            {
                sens.Activate(this);
            }
        }
        turnsCounter++;
    }

    protected virtual void counterAttack(){}
}