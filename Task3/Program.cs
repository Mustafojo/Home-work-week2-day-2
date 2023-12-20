var Students = new(list<Student>());
for (int i = 1; i <= 3; i++)
{
    var Student1 = new Student();
    Student1.Name = Console.ReadLine();
    Student1.Surename = Console.ReadLine();
    Student1.GradeLevel = Convert.ToDouble(Console.ReadLine());
    Student1.TestScores = new list<double>() { Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()) }
    for (int j = 1; j <= 5; j++)
    {
        Student1.TestScores.Add(Convert.ToDouble(Console.ReadLine()));
    }
    Students.Add(Student1);

}
for (int i = 1; i <= 3; i++)
{
    var Student2 = new Student();
    Student2.Name = Console.ReadLine();
    Student2.Surename = Console.ReadLine();
    Student2.GradeLevel = Convert.ToDouble(Console.ReadLine());
    Student2.TestScores = new list<double>() { Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()) }
    for (int j = 1; j <= 5; j++)
    {
        Student2.TestScores.Add(Convert.ToDouble(Console.ReadLine()));
    }
    Students.Add(Student2);

}

for (int i = 1; i <= 3; i++)
{
    var Student3 = new Student();
    Student3.Name = Console.ReadLine();
    Student3.Surename = Console.ReadLine();
    Student3.GradeLevel = Convert.ToDouble(Console.ReadLine());
    Student3.TestScores = new list<double>() { Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()) }
    for (int j = 1; j <= 5; j++)
    {
        Student3.TestScores.Add(Convert.ToDouble(Console.ReadLine()));
    }
    Students.Add(Student3);

}


for (int i = 1; i <= 3; i++)
{
    var Student4 = new Student();
    Student4.Name = Console.ReadLine();
    Student4.Surename = Console.ReadLine();
    Student4.GradeLevel = Convert.ToDouble(Console.ReadLine());
    Student4.TestScores = new list<double>() { Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()) }
    for (int j = 1; j <= 5; j++)
    {
        Student4.TestScores.Add(Convert.ToDouble(Console.ReadLine()));
    }
    Students.Add(Student4);

}

for (int i = 1; i <= 3; i++)
{
    var Student5 = new Student();
    Student5.Name = Console.ReadLine();
    Student5.Surename = Console.ReadLine();
    Student5.GradeLevel = Convert.ToDouble(Console.ReadLine());
    Student5.TestScores = new list<double>() { Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()) }
    for (int j = 1; j <= 5; j++)
    {
        Student5.TestScores.Add(Convert.ToDouble(Console.ReadLine()));
    }
    Students.Add(Student5);

}

foreach (var Student in Students)
{
    var average = Student.AverageScores();
    if (average >= 85)
    {
        System.Console.WriteLine($"Congratulations{Student.FullName()} {average} {Student.AverageScores} Ofarin nekogda ne sdavaysya!");
    }
    else if (average >= 70 && average < 85)
    {
        System.Console.WriteLine($"Congratulations{Student.FullName()} {average} {Student.AverageScores} Beshtar kushish kuned!");
    }
    else if (average < 70)
    {
        System.Console.WriteLine($"Congratulations{Student.FullName()} {average} {Student.AverageScores} Keep working hard for even better results!");
    }
}


