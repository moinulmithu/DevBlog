﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsCraft.Core.Objects
{
    public class Tag
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string UrlSlag { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Post> Posts { get; set; }
    }
}
