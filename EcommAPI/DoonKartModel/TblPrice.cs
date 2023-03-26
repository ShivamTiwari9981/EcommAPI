using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblPrice
    {
        public int PriceId { get; set; }
        public decimal Price { get; set; }
        public int? ProductId { get; set; }
        public string PriceDesc { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
