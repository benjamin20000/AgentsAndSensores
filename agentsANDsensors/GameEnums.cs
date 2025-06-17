namespace agentsANDsensors;

public static class GameEnums
{
    public enum AgentEnum
    {
        FootSoldier = 2,
        SquadLeader = 4,
        SeniorCommander = 6,
        OrganizationLeader = 8
    }
    public enum SensorEnum
    {
        NullSensor,
        AudioSensor,
        ThermalSensor,
        PulseSensor,
        // MotionSensor,
        // MagneticSensor,
        // SignalSensor,
        // LightSensor
    }

    public static SensorEnum[] getSensors()
    {
        SensorEnum[] arr = (SensorEnum[])Enum.GetValues(typeof(SensorEnum));
        return arr.Where(sensor => sensor != SensorEnum.NullSensor).ToArray();
    } 
    
    public static void printSensors()
    {
        SensorEnum[] sensors = getSensors();
        foreach (var sensor in sensors )
        {
            Console.WriteLine(sensor.ToString());
        }
    }
    
    
}