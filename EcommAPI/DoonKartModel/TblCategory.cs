using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
