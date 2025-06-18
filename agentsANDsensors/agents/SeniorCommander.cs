namespace agentsANDsensors;

public class SeniorCommander: Agent
{
    public SeniorCommander(): base(GameEnums.AgentEnum.SeniorCommander){}

    protected override void counterAttack()
    {
        if (cancelCounterAttack > 0)
        {
            cancelCounterAttack--;
            return;
        }
        if (base.turnsCounter % 3 == 0)
        {
            RemoveRandomSensors(2);
        }
    }

    public override void ActivateSensors()
    {
        base.ActivateSensors();
        counterAttack();
    }
}