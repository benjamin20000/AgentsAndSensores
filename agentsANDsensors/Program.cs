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
                agent.ActivateSensor(GameEnums.SensorEnum.AudioSensor);
                break;
            case "thermalsensor":
                agent.ActivateSensor(GameEnums.SensorEnum.ThermalSensor);
                break;
            case "pulsesensor":
                foreach (var sens in agent.agentSensors)
                {
                    if (sens.type == GameEnums.SensorEnum.PulseSensor && sens.Active == false)
                    {
                        sens.Active = true;
                    }
                }
                break;
            default:
                break;
        }
        Console.WriteLine($"you discovered {agent.countActiveSensors()}/{agent.agentSensors.Length} of the weaknesses");
    }

    public void start()
    {
        Console.WriteLine("Welcome to my game!");
        Agent footSoldier = new FootSoldier();
        while (footSoldier.countActiveSensors() < footSoldier.agentSensors.Length)
        {
            playMenu(footSoldier);
        }
    }
    public static void Main(string[] args)
    {
        // Agent agent = new FootSoldier();
        Game game = new Game();
        game.start();
    }
}
