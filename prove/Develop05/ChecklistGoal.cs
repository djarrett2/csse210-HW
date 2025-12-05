public class Checklist : Goal
{
    private int _targetNum;
    private int _currentCompleted;
    private int _bonusPoints;

    public Checklist(string name, string description, int points, int targetNum, int bonusPoints) : base(name, description, points)
    {
        _targetNum = targetNum;
        _currentCompleted = 0;
        _bonusPoints = bonusPoints;
    }

    public Checklist(string name, string description, int points, int targetNum, int bonusPoints, int currentCompleted) : base(name, description, points)
    {
        _targetNum = targetNum;
        _currentCompleted = currentCompleted;
        _bonusPoints = bonusPoints;
    }

    public override bool CompleteGoal()
    {
        return _currentCompleted >= _targetNum;
    }

    public override string GetStatus()
    {
        string checkbox = CompleteGoal() ? "[X]" : "[ ]";
        return $"{checkbox} {_goalName} ({_goalDescription}) -- Currently completed: {_currentCompleted}/{_targetNum}";
    }

    public override int RecordEvent()
    {
        _currentCompleted++;
        
        if (_currentCompleted >= _targetNum)
        {
            return _goalPoints + _bonusPoints;
        }
        return _goalPoints;
    }

    public override string SaveToString()
    {
        return $"Checklist Goal:{_goalName},{_goalDescription},{_goalPoints},{_targetNum},{_bonusPoints},{_currentCompleted}";
    }
}