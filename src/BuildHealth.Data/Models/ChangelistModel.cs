using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHealth.Data.Models
{
    public class ChangelistModel
    {
        public int Id { get; set; }
        public int ChangelistNumber { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
