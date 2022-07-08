using System;
static class AssemblyLine
{
    private static readonly int _speedMultiplier = 221;
    public static double SuccessRate(int speed) => speed switch
    {
        int s when (s == 0) => 0.0,
        int s when (1 <= s && s <= 4) => 1.0,
        int s when (5 <= s && s <= 8) => 0.9,
        int s when (s == 9) => 0.8,
        int s when (s == 10) => 0.77,
        _ => throw new ArgumentOutOfRangeException(),
    };
    public static double ProductionRatePerHour(int speed)
    {
        SuccessRate(speed) * speed * _speedMultiplier;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        ProductionRatePerHour(speed) / 60;
    }
}