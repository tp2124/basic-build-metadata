using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHealth.Data.Models
{
    public class BuildResultModel
    {
        public int Id { get; set; }
        public int ChangelistCutoff { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public bool Result { get; set; }
    }
}
