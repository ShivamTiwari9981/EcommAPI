using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
