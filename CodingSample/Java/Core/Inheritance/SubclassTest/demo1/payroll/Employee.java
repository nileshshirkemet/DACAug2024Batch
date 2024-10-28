package payroll;

//a class defined with 'public' keyword can be referenced
//from outside of this packaged using its fully qualified name
public class Employee {
    
    private int hours;
    private float rate;

    //parameterized constructor
    public Employee(int h, float r) {
        hours = h;
        rate = r;
    }

    //parameterless constructor
    public Employee() {
        this(0, 0); //calling another constructor of this class
    }

    public int getDaysWorked() {
        return hours / 8;
    }

    public void setDaysWorked(int value) {
        hours = 8 * value;
    }

    public float getDailyWages() {
        return 8 * hours;
    }

    public void setDailyWages(float value) {
        rate = value / 8;
    }

    public double monthlyIncome() {
        double income = hours * rate;
        int ot = hours - 180;
        if(ot > 0)
            income += 50 * ot;
        return income;
    }
}
