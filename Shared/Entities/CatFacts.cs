using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrasBlog.Infraestructure.Entities
{
    public class CatFacts
    {
        public class response
        {
            public int Code { get; set; }
            public string Message { get; set; }
            public Data Detail { get; set; }
            public Data Books { get; set; }
        }
        public class Data
        {
            public int length { get; set; }
            public string fact { get; set; }
        }
    }
}
