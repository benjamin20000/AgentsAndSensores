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
        base.agentSensors[randomSens].active = false;
        Console.WriteLine("HHHH i remove one of your sensors...");
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