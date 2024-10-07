namespace Payroll
{
    //defining SalesPerson as a derived class of Employee (base class)
    class SalesPerson : Employee
    {
        //automatic property
        public double Sales { get; set; }

        public SalesPerson(int h, float r, double s) : base(h, r)
        {
            Sales = s;
        }

        //optional parameters of method may appear at the end of the
        //parameter list each initialized with a constant expression
        //which is implictly passed if the argument is not passed
        //explictly by the caller of the method
        public double Commission(double minimum, float percentage = 5)
        {
            return Sales < minimum ? 0 : Sales * percentage / 100;
        }

        public override double MonthlyIncome()
        {
            if(DailyWages == 0)
                return Commission(percentage: 15, minimum: 0);
            return base.MonthlyIncome() + Commission(20000);
        }
    }
}