using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    internal class Cart
    {
        
            public int Id { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime UpdatedDate { get; set; }
            public int UserId { get; set; }
            public List<Article> Articles { get; set; }
            public decimal Value { get; set; }
        
    }
}

