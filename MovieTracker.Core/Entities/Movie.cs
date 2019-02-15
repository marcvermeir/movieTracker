﻿using MovieTracker.Core.Interfaces;
using System;

namespace MovieTracker.Core.Entities
{
    public class Movie : BaseEntity, IAggregateRoot
    {
        //// public int Id { get; set; }

        public string Title { get; set; }

        public DateTime? YearOfRelease { get; set; }

        public string WatchPriority { get; set; }

        public int UserId { get; set; }
    }
}
