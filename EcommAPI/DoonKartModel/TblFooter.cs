using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblFooter
    {
        public int FooterId { get; set; }
        public string FooterName { get; set; } = null!;
        public int? FooterHeadingId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
