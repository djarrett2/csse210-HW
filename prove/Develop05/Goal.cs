using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }

    public abstract bool CompleteGoal();
    public abstract string GetStatus();
    public abstract int RecordEvent();
    public abstract string SaveToString();

    public string GetName()
    {
        return _goalName;
    }
}