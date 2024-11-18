package app.shopping.data;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name = "counters")
public class CounterEntity {
    
    @Id
    @Column(name = "ctr_name")
    private String name;

    @Column(name = "cur_val")
    private int currentValue;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getCurrentValue() {
        return currentValue;
    }

    public void setCurrentValue(int currentValue) {
        this.currentValue = currentValue;
    }

    public final int generateNextId(int seed) {
        return ++currentValue + seed;
    }
}
