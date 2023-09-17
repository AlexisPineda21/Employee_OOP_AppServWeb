namespace EmployeeOPP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public decimal CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }


        #endregion

        #region Methods

        public CommissionEmployee() 
        { 

        }

        public override decimal GetValueToPay()
        {
            return (CommissionPercentaje/100) * Sales ;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario devengado por comisiones: {(CommissionPercentaje / 100) * Sales:C2} \n\t ";
        }

        #endregion


    }
}
