using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consoli_Ricette.Models
{
    public class Recipe
    {
        public string id { get; set; }
        public string authorId { get; set; }
        public string authorName { get; set; }
        public int difficulty { get; set; }
        public int time { get; set; }
        public string ingredients { get; set; }
        public string description { get; set; }
        public string procedures { get; set; }
    }
}
