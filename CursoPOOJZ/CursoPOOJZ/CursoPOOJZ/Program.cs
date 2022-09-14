using CursoPOOJZ;

Console.WriteLine("POO Concepts");
Console.WriteLine("========");
Employee employee = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 5, 13),
    IsActive = true,
    Salary=181543.45M
};
Console.WriteLine(employee);