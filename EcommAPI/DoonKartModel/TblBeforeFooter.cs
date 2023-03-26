using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblBeforeFooter
    {
        public int BeforeFooterId { get; set; }
        public string BeforeFooterName { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
