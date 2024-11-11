package app.tourism.models;

import app.tourism.data.TravelerEntity;
import app.tourism.data.TripEntity;
import jakarta.persistence.EntityManagerFactory;
import jakarta.persistence.Persistence;

public class SiteModel {
    
    private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("app.data");

    public Iterable<Visitor> getVisitors() {
        try(var em = emf.createEntityManager()){
            var query = em.createQuery("SELECT t FROM TravelerEntity t WHERE LENGTH(t.id) > 3", TravelerEntity.class);
            return query.getResultStream()
                .map(Visitor::fromTraveler)
                .toList();
        }
    }

    public boolean acceptVisit(String visitorId, int visitorRating) {
        if(visitorId == null || visitorRating < 1 || visitorRating > 5)
            return false;
        try(var em = emf.createEntityManager()){
            var traveler = em.find(TravelerEntity.class, visitorId);
            if(traveler == null){
                traveler = new TravelerEntity();
                traveler.setId(visitorId);
            }
            traveler.setRating(visitorRating);
            var trip = new TripEntity();
            trip.setGuest(traveler);
            traveler.getTours().add(trip);
            var tx = em.getTransaction();
            tx.begin();
            em.persist(traveler);
            tx.commit();
            return true;
        }
    }

}
