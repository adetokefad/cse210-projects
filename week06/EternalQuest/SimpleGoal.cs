public class SimpleGoal : Goal{
    private bool _isCompleted = false;

    public SimpleGoal(string name, string description, int point) : base(name, description, point){
        
    }

    public SimpleGoal(){
    }

    public SimpleGoal(bool isCompleted){
        _isCompleted = isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName}, {_description}, Is it completed; {_isCompleted}, Point of completion: {_points}";
    }
    public override bool IsCompleted()
    {
        return _isCompleted;
    }

    
    public override void RecordEvent()
    {
        if (_isCompleted == true){
        }
    }
}