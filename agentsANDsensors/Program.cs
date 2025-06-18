// See https://aka.ms/new-console-template for more information
using agentsANDsensors;

class Game
{
    private void play(Agent agent)
    {
        Console.WriteLine("chose a sensor:");
        GameEnums.printSensors();
        string choseSens = Console.ReadLine().ToLower().Replace(" ", "");//normaliz the input
        switch (choseSens)
        {
            case "audiosensor":
                agent.AddSensor(GameEnums.SensorEnum.AudioSensor);
                break;
            case "thermalsensor":
                agent.AddSensor(GameEnums.SensorEnum.ThermalSensor);
                break;
            case "pulsesensor":
                agent.AddSensor(GameEnums.SensorEnum.PulseSensor);
                break;
            default:
                break;
        }

        Console.WriteLine($"you discovered {agent.countActiveSensors()}/{agent.agentSensors.Length} of the weaknesses");
        agent.ActivateSensors();
    }

    public void startLevel(Agent agent)
    {
        while (agent.countActiveSensors() < agent.agentSensors.Length)
        {
            play(agent);
        }
    }

    private void initGame()
    {
        Func<Agent>[] agentFactories = new Func<Agent>[]
        {
            () => new FootSoldier(),
            () => new SquadLeader(),
            () => new SeniorCommander()
        };
        int level = 0;
        string continueGame = "yes";
        while (level < agentFactories.Length && continueGame == "yes")
        {
            Agent squadLeader = agentFactories[level]();
            startLevel(squadLeader);
            if (level < agentFactories.Length-1)
            {
                Console.WriteLine("type yes fot continue to the next agent");
                continueGame = Console.ReadLine();
            }
            level++;
        }
        Console.WriteLine("game over");
    }
    
    public static void Main(string[] args)
    {
        // Agent agent = new FootSoldier();
        Game game = new Game();
        game.initGame();
    }
}
