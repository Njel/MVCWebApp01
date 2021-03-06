﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCWebApp01.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public int ArtistID { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}
