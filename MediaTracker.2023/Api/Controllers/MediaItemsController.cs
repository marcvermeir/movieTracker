﻿////using Core.Entities;
////using Microsoft.AspNetCore.Mvc;

////namespace Api.Controllers
////{
////    [Route("api/v1.0/[controller]")]
////    [ApiController]
////    public class MediaItemsController : ControllerBase
////    {
////        private List<MediaItem> _mediaItems = new List<MediaItem>
////        {
////            new MediaItem(id: 1, title: "Napoleon", authorOrDirector: "Ridley Scott", media: MediaItem.MediaType.Movie ),
////            new MediaItem(id: 2, title: "Gladiator", authorOrDirector: "Ridley Scott", media : MediaItem.MediaType.Movie),
////            new MediaItem(id: 3, title: "Mannen die vrouwen haten", authorOrDirector: "Stieg Larsson", media : MediaItem.MediaType.Book),
////            new MediaItem(id: 4, title: "Handmaid's Tale /S01", authorOrDirector: "???", media : MediaItem.MediaType.TVShow)
////        };

////        [HttpGet]
////        public IActionResult GetAll()
////        {
////            return Ok(_mediaItems);
////        }

////        [HttpGet("{id}")]
////        public IActionResult GetById(int id)
////        {
////            var mediaItem = _mediaItems.Find(x => x.Id == id);
////            if (mediaItem == null)
////                return NotFound();

////            return Ok(mediaItem);
////        }
////    }
////}