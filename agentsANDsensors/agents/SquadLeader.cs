using System.Collections.Concurrent;

namespace agentsANDsensors;

public class SquadLeader: Agent
{
    public SquadLeader(): base(GameEnums.AgentEnum.SquadLeader){}

    protected override void counterAttack()
    {
        if (base.turnsCounter % 3 == 0)
        {
            base.RemoveRandomSensors(1);
        }
    }

    public override void ActivateSensors()
    {
        base.ActivateSensors();
        counterAttack();
    }
}