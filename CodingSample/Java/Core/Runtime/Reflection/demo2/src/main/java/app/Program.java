package app;

import java.lang.invoke.MethodHandle;
import java.lang.invoke.MethodHandles;
import java.lang.reflect.Method;

import finance.Loans;
import finance.MaxDuration;

public class Program {
    
    public static void main(String[] args) throws Throwable {
        double p = Double.parseDouble(args[0]);
        Class<?> c = Class.forName("finance." + args[1]);
        Object policy = c.getConstructor().newInstance();
        Method scheme = c.getMethod(args[2], double.class, int.class);
        MaxDuration md = scheme.getAnnotation(MaxDuration.class);
        int m = md != null ? md.value() : 10;
        //a method-handle provides a direct typed reference to the
        //implementation of a method for the object to which it is bound
        MethodHandle mh = MethodHandles.lookup()
            .unreflect(scheme)
            .bindTo(policy);
        for(int n = 1; n <= m; ++n){
            float r = (float)mh.invokeExact(p, n);
            double emi = Loans.monthlyInstallment(p, n, r);
            System.out.printf("%-8d%20.2f%n", n, emi);
        }
    }


}
