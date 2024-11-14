package app.components;

public class GreeterBean {
    
    private String person;

    private String period;

    private int greetings;

    public String getPerson() {
        return person;
    }

    public void setPerson(String person) {
        this.person = person;
    }

    public String getPeriod() {
        return period;
    }

    public void setPeriod(String period) {
        this.period = period;
    }

    public synchronized String getGreetingMessage() {
        if(person == null)
            return "Hello Friend";
        greetings += 1;
        return String.format("Good %s %s", period, person);
    }

    public int getGreetCount() {
        return greetings;
    }
}
