package app.tourism.data;

import java.util.ArrayList;
import java.util.List;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "travelers")
public class TravelerEntity {
    
    @Id
    @Column(name = "traveler_name")
    private String id;

    @Column
    private int rating;

    @OneToMany(mappedBy = "guest", cascade = CascadeType.ALL)
    private List<TripEntity> tours = new ArrayList<>();

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public int getRating() {
        return rating;
    }

    public void setRating(int rating) {
        this.rating = rating;
    }

    public List<TripEntity> getTours() {
        return tours;
    }

    public void setTours(List<TripEntity> tours) {
        this.tours = tours;
    }

}
