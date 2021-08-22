using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FragranceStoreAPI.Model
{
    public class Fragrance
    {
        [Key]
        public string productId { get; set; }
        public string productName { get; set; }
        public string brandName { get; set; }
        public string productImage { get; set; }
        public string productRating { get; set; }
        public string numberOfReviews { get; set; }
        public string reviewContent { get; set; }
        public string productPrice { get; set; }


    }
}
