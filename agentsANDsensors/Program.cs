// See https://aka.ms/new-console-template for more information
using agentsANDsensors;

class Game
{
    private void playMenu(Agent agent)
    {
        Console.WriteLine("chose a sensor:");
        GameEnums.printSensors();
        string choseSens = Console.ReadLine().ToLower().Replace(" ", "");//normaliz the input
        switch (choseSens)
        {
            case "audiosensor":
                AudioSensor audioSensor = new AudioSensor();
                audioSensor.Activate(agent);
                break;
            case "thermalsensor":
                ThermalSensor thermalSensor = new ThermalSensor();
                thermalSensor.Activate(agent);
                break;
            default:
                break;
        }
        Console.WriteLine($"you discovered {agent.discoveredWeaknesses}/{agent.weaknessesNum} of the weaknesses");
    }

    public void start()
    {
        Console.WriteLine("Welcome to my game!");
        Agent footSoldier = new FootSoldier();
        while (footSoldier.weaknessesNum > footSoldier.discoveredWeaknesses)
        {
            playMenu(footSoldier);
        }
    }
    public static void Main(string[] args)
    {
        // Agent agent = new Agent(AgentEnum.SquadLeader);
        Game game = new Game();
        game.start();
    }
}
