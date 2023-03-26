using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblHeader
    {
        public int HeaderId { get; set; }
        public string HeaderName { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public DateTime ImageUrl { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
