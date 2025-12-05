public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override bool CompleteGoal()
    {
        return false;
    }

    public override string GetStatus()
    {
        return $"[ ] {_goalName} ({_goalDescription})";
    }

    public override int RecordEvent()
    {
        return _goalPoints;
    }

    public override string SaveToString()
    {
        return $"Eternal Goal:{_goalName},{_goalDescription},{_goalPoints}";
    }
}