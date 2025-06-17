namespace agentsANDsensors;

public abstract class Agent
{
    public GameEnums.AgentEnum AgentType;
    public int senssorsLen { get;}
    public Sensor[] agentSensors;

    public Agent(GameEnums.AgentEnum agentType)
    {
        senssorsLen = (int)(agentType);
        agentSensors = new Sensor[senssorsLen];
        createSensors();//fill it with randomly sensors
    }

    public void createSensors()
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

    public void printAgentSensors()
    {
        foreach (var sensor in agentSensors)
        {
            Console.WriteLine(sensor.ToString());
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

    public Sensor[] getUnActiveSensores()
    {
        return (Sensor[])(agentSensors.Where(sens => sens.active == false).ToArray());
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

    public void ActivateSensors()
    {
        foreach (var sens in agentSensors)
        {
            if (sens.active == true)
            {
                sens.Activate(this);
            }
        }
    }

    
}