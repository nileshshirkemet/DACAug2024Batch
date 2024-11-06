package app;

import java.lang.reflect.Method;

import finance.Loans;

public class Program {
    
    public static void main(String[] args) throws Throwable {
        double p = Double.parseDouble(args[0]);
        Class<?> c = Class.forName("finance." + args[1]);
        Object policy = c.getConstructor().newInstance();
        Method scheme = c.getMethod(args[2], double.class, int.class);
        int m = 10;
        for(int n = 1; n <= m; ++n){
            //verify that policy is instance of declaring class of scheme method
            //find callable reference of scheme method for policy object
            //call the implementation specified by above callable reference 
            float r = (float)scheme.invoke(policy, p, n);
            double emi = Loans.monthlyInstallment(p, n, r);
            System.out.printf("%-8d%20.2f%n", n, emi);
        }
    }


}
