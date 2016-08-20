﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Lesson12B_final.Models
{
    public class Album
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Album()
        {

        }

        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public Album(string Title)
        {
            this.Title = Title;
        }
        [Display(Name = "Album")]
        public virtual int AlbumId { get; set; }
        [Display(Name = "Genre")]
        public virtual int GenreId { get; set; }
        [Display(Name = "Artist")]
        public virtual int ArtistId { get; set; }
        public virtual int SongId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        [Display(Name = "Album Art URL")]
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Song Song { get; set; }
    }
}