using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int ID { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public int? StockID { get; set; }              //This is convention this is the key that actually forms the relationshiop within the database.

        public Stock? Stock { get; set; }             // navigation property
    } 
}