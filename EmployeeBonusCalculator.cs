public abstract class Employee
{
    public abstract double CalculateBonus(double salary);
}

public class PermanentEmployee : Employee
{
    public override double CalculateBonus(double salary)
    {
        return salary * 0.1;
    }
}

public class ContractEmployee : Employee
{
    public override double CalculateBonus(double salary)
    {
        return salary * 0.05;
    }
}
