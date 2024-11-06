class Entropy {

    public native static String captcha(int size);

    //a static block is executed once when the class
    //is used for the first time within the JVM
    static {
        //lookup for platform specific library corresponding
        //to the specified name in each location indicated 
        //within java.library.path property of the JVM and
        //load this library into the memory
        System.loadLibrary("entropy");
    }
}
