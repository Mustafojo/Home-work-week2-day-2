
public class Person
{
    public string LastName ;
    public string FirstName;
    public int AGE ;

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    public int GetBirthYear()
    {
        return 2024 - AGE;
    }
}


