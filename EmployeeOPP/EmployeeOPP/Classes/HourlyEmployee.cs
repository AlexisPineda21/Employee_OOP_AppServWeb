namespace EmployeeOPP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public decimal Hours { get; set; }

        public decimal HourValue { get; set; }

        #endregion

        #region Methods
        public HourlyEmployee()
        {
        }
        public override decimal GetValueToPay()
        {
            return (Hours * HourValue);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario devengado por horas: {(Hours * HourValue):C2} \n\t ";
        }

        #endregion 
    }
}
