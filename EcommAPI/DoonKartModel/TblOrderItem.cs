using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblOrderItem
    {
        public int OrderItemId { get; set; }
        public int? OrderId { get; set; }
        public int? MedicineId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discunt { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
