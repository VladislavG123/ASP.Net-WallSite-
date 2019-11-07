using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WallSite.Models
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string User { get; set; }
        public string  Text { get; set; }

    }
}