using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblFooterHeading
    {
        public int FooterHeadingId { get; set; }
        public string FooterHeadingName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
