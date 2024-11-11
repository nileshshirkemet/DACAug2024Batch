package app.tourism.data;

import java.util.ArrayList;
import java.util.List;

public class TravelerEntity {
    
    private String id;

    private int rating;

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
