using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kztek.Model.CustomModel
{
    public class GetTotalItems
    {
        public int TotalCount { get; set; }
    }
    public class HomeModel
    {
        public int Count { get; set; }
        public DateTime FirstDay { get; set; }
    }
    public class DayModel
    {
        public int OrderOfWeek { get; set; }
        public DateTime Day { get; set; }
    }
}
