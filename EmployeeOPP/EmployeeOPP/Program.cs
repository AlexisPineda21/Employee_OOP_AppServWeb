// See https://aka.ms/new-console-template for more information
using EmployeeOPP.Classes;
using System;

try
{
    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    int day, month, year;
    string firstName;
    string lastName;
    decimal salary;
    decimal CommissionPercentaje;
    decimal HourValue;
    decimal Sales;
    decimal BaseCommission;
    int Hours;

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.Write("Ingresar Nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar Apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar Salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());


    //HardCoding = Quemar código

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary
    };


    Console.WriteLine(salaryEmployee);


    Console.Write("Ingresar comision (Porcentaje): ");
    CommissionPercentaje = Decimal.Parse(Console.ReadLine());

    Console.Write("Ingresar el valor de ventas: ");
    Sales = Decimal.Parse(Console.ReadLine());

    CommissionEmployee commissionEmployee = new CommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = Sales,
        CommissionPercentaje = CommissionPercentaje
    };

    Console.WriteLine(commissionEmployee);

    Console.WriteLine("\n");


    Console.Write("Ingresar comision base del empleado: ");
    BaseCommission = Decimal.Parse(Console.ReadLine());

    BaseCommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = Sales,
        CommissionPercentaje = CommissionPercentaje,
        Base = BaseCommission,
    };

    Console.WriteLine(baseCommissionEmployee);

    Console.WriteLine("\n");


    Console.Write("Ingresar número de horas: ");
    Hours = Int32.Parse(Console.ReadLine());

    Console.Write("Ingresar valor por hora: ");
    HourValue = Decimal.Parse(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        HourValue = HourValue,
        Hours = Hours,
    };

    Console.WriteLine(hourlyEmployee);

    Console.WriteLine("\n");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


