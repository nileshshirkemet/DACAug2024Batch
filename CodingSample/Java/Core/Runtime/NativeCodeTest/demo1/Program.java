class Program {

    public static void main(String[] args) {
        int n = args.length > 0 ? Integer.parseInt(args[0]) : 6;
        System.out.printf("OTP = %s%n", Entropy.captcha(n));
    }
}