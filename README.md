# OCP Example (Open/Closed Principle)

Цей репозиторій містить приклад принципу відкритості/закритості з SOLID.

## Принцип відкритості/закритості (OCP)

Програмні сутності (класи, модулі, функції) мають бути відкритими для розширення, але закритими для модифікації. Це означає, що ми можемо додавати нову функціональність, не змінюючи вже існуючий код.

### Приклад коду:

```csharp
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
