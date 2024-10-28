//import directive enables compiler to expand unqualified 
//name (Employee) to its fully qualified form (payroll.Employee)
import payroll.Employee;
import payroll.SalesPerson;

class Program {

    private static double tax(Employee emp) {
        double i = emp.monthlyIncome(); 
        return i > 10000 ? 0.15 * (i - 10000) : 0;
    }

    private static double bonus(Employee emp) {
        if(emp instanceof SalesPerson)
            return 0;
        return emp.monthlyIncome() / 12;
    }

    public static void main(String[] args) {
        Employee jack = new Employee();
        jack.setDaysWorked(23);
        jack.setDailyWages(424);
        System.out.printf("Jack's income is %.2f, tax is %.2f and bonus is %.2f%n", jack.monthlyIncome(), tax(jack), bonus(jack));
        SalesPerson jill = new SalesPerson(184, 53, 62000);
        System.out.printf("Jill's income is %.2f, tax is %.2f and bonus is %.2f%n", jill.monthlyIncome(), tax(jill), bonus(jill));
    }
}
