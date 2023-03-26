using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblError
    {
        public int ErrorId { get; set; }
        public int? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; } = null!;
        public string ErrorProcedure { get; set; } = null!;
        public int? ErrorState { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorLine { get; set; }
        public DateTime CrtdOn { get; set; }
    }
}
