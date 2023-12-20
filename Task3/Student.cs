public class Student
{
    public string Name;
    public string Surename;
    public double GradeLevel;
    public list<double> TestScores;

    public double AverageScores()
    {
        double sum = 0;
        foreach (var score in TestScores)
        {
            sum += score;
        }
        return sum / TestScores.Count
    }
    public string FullName()
    {
        return $"{Name} {Surename}"
    }
}