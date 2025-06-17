namespace agentsANDsensors;

public abstract class Agent
{
    public GameEnums.AgentEnum AgentType;
    public int senssorsNum { get;}
    public Sensor[] agentSensors;

    public Agent(GameEnums.AgentEnum agentType)
    {
        senssorsNum = (int)(agentType);
        agentSensors = new Sensor[senssorsNum];
        createSensors();//fill it with randomly sensors
    }

    public void createSensors()
    {
        var allSensors = GameEnums.getSensors();
        Random rnd = new Random();
        for(int i = 0; i < senssorsNum; i++)
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
            if (sens.Active)
            {
                count++;
            }
        }
        return count;
    }

    public Sensor[] getUnActiveSensores()
    {
        return (Sensor[])(agentSensors.Where(sens => sens.Active == false).ToArray());
    }
    

    public void ActivateSensor(GameEnums.SensorEnum sensorType)
    {
        foreach (var sens in agentSensors)
        {
            if (sens.type == sensorType && sens.Active == false)
            {
                sens.Activate(this);
                sens.Active = true;
                break;
            }
        }
        
    }

    
}