using System;
using System.Collections.Generic;

namespace EcommAPI.DoonKartModel
{
    public partial class TblSlider
    {
        public int SliderId { get; set; }
        public string SliderName { get; set; } = null!;
        public string SliderDesc { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CrtdOn { get; set; }
        public DateTime UpdtOn { get; set; }
    }
}
