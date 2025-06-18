using System.Collections.Concurrent;

namespace agentsANDsensors;

public class SquadLeader: Agent
{
    public SquadLeader(): base(GameEnums.AgentEnum.SquadLeader){}

    protected override void counterAttack()
    {
        Sensor[] activeSensors  = getActiveSensors();
        if (activeSensors.Length == 0)
        {
            Console.WriteLine("No active sensors for counter attack...");
            return;
        }
        Random rnd = new Random();
        int randomSens = rnd.Next(0, activeSensors.Length);
        Console.WriteLine(activeSensors[randomSens].active);
        activeSensors[randomSens].active = false;
        Console.WriteLine(activeSensors[randomSens].active);
        Console.WriteLine($"H-H-H-H i remove one of your sensors... {activeSensors[randomSens].type}");
    }

    public override void ActivateSensors()
    {
        base.ActivateSensors();
        if (base.turnsCounter % 3 == 0)
        {
            counterAttack();
        }
    }
}