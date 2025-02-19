public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public CheckListGoal( int target, int bonus, string name, string description, int point):base(name, description, point){
        _target = target;
        _bonus = bonus;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
    public int GetAmountCompleted(int number){
        return _amountCompleted;
    }
    public void SetAmountCompleted(int number){
        _amountCompleted += number;
    }

    public override bool IsCompleted()
    {
        return true;
    }


    public override void RecordEvent()
    {
        
    }
}