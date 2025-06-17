namespace agentsANDsensors;

public abstract class Agent
{
    public GameEnums.AgentEnum AgentType;
    public int weaknessesNum { get;}
    public int discoveredWeaknesses{get;set;}
    public GameEnums.SensorEnum[] agentWeaknesses;
    public Sensor[] agentSensors;

    public Agent(GameEnums.AgentEnum agentType)
    {
        discoveredWeaknesses = 0;
        weaknessesNum = (int)(agentType);
        agentSensors = new Sensor[weaknessesNum];
        agentWeaknesses = new GameEnums.SensorEnum[weaknessesNum]; //create the weakness arr in the size of the agent rank
        createAgentWeakness();//fill it with randomly sensors
    }

    public void createAgentWeakness()
    {
        var allSensors = GameEnums.getSensors();
        Random rnd = new Random();
        for(int i = 0; i < agentWeaknesses.Length; i++)
        {
            int sns_rnd  = rnd.Next(0, allSensors.Length);
            agentWeaknesses[i] = allSensors[sns_rnd];
        }
    }

    public void printAgentWeakness()
    {
        foreach (var sensor in agentWeaknesses)
        {
            Console.WriteLine(sensor);
        }
    }

    public GameEnums.SensorEnum[] getUnrevealedWeaknesses()
    {
        return (GameEnums.SensorEnum[])(agentWeaknesses.Where(weakness => weakness != GameEnums.SensorEnum.NullSensor).ToArray());
    }

    
}