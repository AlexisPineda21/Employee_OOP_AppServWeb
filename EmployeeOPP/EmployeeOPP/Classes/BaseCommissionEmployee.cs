namespace EmployeeOPP.Classes
{
    public class BaseCommissionEmployee : CommissionEmployee
    {

        #region Properties

        public decimal Base { get; set; }


        #endregion

        #region Methods

        public BaseCommissionEmployee() 
        { 
        }

        public override decimal GetValueToPay()
        {
            return Base + ((CommissionPercentaje / 100) * Sales);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario devengado por comisiones + base es: {Base + ((CommissionPercentaje / 100) * Sales):C2} \n\t ";
        }

        #endregion

    }
}
