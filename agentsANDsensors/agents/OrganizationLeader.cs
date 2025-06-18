namespace agentsANDsensors;

public class OrganizationLeader:Agent
{
    public OrganizationLeader():base(GameEnums.AgentEnum.OrganizationLeader){}
    protected override void counterAttack()
    {
        if (base.turnsCounter % 3 == 0)
        {
            base.RemoveRandomSensors(1);
        }

        if (base.turnsCounter % 10 == 0)
        {
            RemoveAllSensors();
        }
    }

    public override void ActivateSensors()
    {
        base.ActivateSensors();
        counterAttack();
    }
    
}