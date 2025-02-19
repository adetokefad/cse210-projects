public class EternalGoal : Goal
{
    
    public EternalGoal(string name, string description, int point) : base(name, description, point){
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}, {_description}, {_points}";
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override void RecordEvent()
    {
        return;
    }
}