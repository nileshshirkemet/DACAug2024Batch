package payroll;

//defining SalesPerson as a subclass of 
//Employee (super-class)
public class SalesPerson extends Employee {
    
    private double sales;

    public SalesPerson(int h, float r, double s) {
        super(h, r); //calling constructor of super-class
        sales = s;
    }

    public double getSales() {
        return sales;
    }

    public void setSales(double value) {
        sales = value;
    }

    //overriding method of super-class
    public double monthlyIncome() {
        double income = super.monthlyIncome();
        if(sales >= 20000)
            income += 0.05 * sales;
        return income;
    }
}
