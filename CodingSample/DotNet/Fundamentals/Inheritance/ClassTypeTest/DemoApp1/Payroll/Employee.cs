//A namespace is a named group of types such that any type T
//in namespace N is refered by its qualified name of N.T
//outside of N
namespace Payroll
{
    class Employee
    {
        private int hours;
        private float rate;

        //parameterized constructor
        public Employee(int h, float r)
        {
            hours = h;
            rate = r;
        }

        //parameterless (zero-argument) constructor
        public Employee() : this(0, 0) {}

        //A property is a class member that provides methods to
        //'get' and 'set' a value associated with an instance of
        //this class and these methods can be called using a syntax
        //similar to accessing and assigning a member field.
        public int DaysWorked
        {
            get
            {
                return hours / 8;
            }

            set
            {
                hours = 8 * value;
            }
        }

        public float DailyWages
        {
            get { return 8 * rate; }
            set { rate = value / 8; }
        }

        //A method declared with 'virtual' keyword can be
        //overidden in a derived class
        public virtual double MonthlyIncome()
        {
            double amount = hours * rate;
            int ot = hours - 180;
            if(ot > 0)
                amount += 50 * ot;
            return amount;
        }
    }
}
