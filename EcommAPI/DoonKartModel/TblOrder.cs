using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblOrder
    {
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public string OrderNo { get; set; } = null!;
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
