using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
