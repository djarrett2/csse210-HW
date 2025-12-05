using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public Simple(string name, string description, int points, bool complete) : base(name, description, points)
    {
        _isComplete = complete;
    }

    public override bool CompleteGoal()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_goalName} ({_goalDescription})";
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _goalPoints;
        }
        return 0;
    }

    public override string SaveToString()
    {
        return $"Simple Goal:{_goalName},{_goalDescription},{_goalPoints},{_isComplete}";
    }
}