package app.tourism.models;

import java.util.Date;

import app.tourism.data.TravelerEntity;
import app.tourism.data.TripEntity;

public record Visitor(String name, int visits, Date recent, String stars) {
    
    public static Visitor fromTraveler(TravelerEntity entity){
        var trips = entity.getTours();
        return new Visitor(
            entity.getId(), 
            trips.size(), 
            trips.stream().map(TripEntity::getCheckin).max(Date::compareTo).get(), 
            "*".repeat(entity.getRating())
        );
    }
}
