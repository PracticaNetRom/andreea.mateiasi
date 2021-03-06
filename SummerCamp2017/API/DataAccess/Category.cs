﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DataAccess
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }

        public Category()
        {
            Announcements = new List<Announcement>();
        }
    }
}