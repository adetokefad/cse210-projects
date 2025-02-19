public abstract class Goal {
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;
    protected List<String> _goalsList;

    public Goal(){
        _shortName = "Later i will describe it";
        _description = "Later i will describe it";
        _points = 0;
    }

    public Goal(string name, string description, int point){
        _shortName = name;
        _description = description;
        _points += point;
    }

    
    public string GetName(){
        return _shortName;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetPoint(){
        return _points;
    }
    public void SetDetailsList(){}

    public void DisplayGoal(){
    }
    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public string GetDetailsString(){
        return $"{_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();

    public void Loading(){
        for (int i = 5; i > 0; i--){
            Console.Write("...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}