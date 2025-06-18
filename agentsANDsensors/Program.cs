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

    public void start(Agent agent)
    {
        while (agent.countActiveSensors() < agent.agentSensors.Length)
        {
            play(agent);
        }
    }

    private void initGame()
    {
        Console.WriteLine("Welcome to the game!");
        Agent footSoldier = new FootSoldier();
        start(footSoldier);
        Console.WriteLine("type yes fot continue to the next agent");
        string decision1 = Console.ReadLine();
        if (decision1 != "yes")
        {
            return;
        }
        Agent squadLeader = new SquadLeader();
        start(squadLeader);
        Console.WriteLine("type yes fot continue to the next agent");
        string decision2 = Console.ReadLine();
        if (decision2 != "yes")
        {
            return;
        }
        Agent seniorCommander = new SeniorCommander();
        start(seniorCommander);
        
        
    }
    public static void Main(string[] args)
    {
        // Agent agent = new FootSoldier();
        Game game = new Game();
        game.initGame();
    }
}
