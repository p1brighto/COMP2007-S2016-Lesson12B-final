using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Lesson12B_final.Models
{
    public class Song
    {
        public virtual int SongId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Duration { get; set; }
    }
}