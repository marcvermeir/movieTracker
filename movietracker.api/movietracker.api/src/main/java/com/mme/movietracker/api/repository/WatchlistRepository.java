package com.mme.movietracker.api.repository;

import com.mme.movietracker.api.domain.Watchlist;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface WatchlistRepository extends JpaRepository<Watchlist, Long> {
    List<Watchlist> findByNameContaining(String name);
}