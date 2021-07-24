using System.ComponentModel.DataAnnotations;

namespace BuildMetadata.Models
{
    public class Build
    {
        [Key]
        public uint ChangelistNumber { get; set; }
        public string Notes { get; set; }
        public bool IsNightly { get; set; }
        public bool HasPackagedBinaries { get; set; }
        public bool QVIsTesting { get; set; }
        public bool QVCompleted { get; set; }
        public bool KnownGoodClient { get; set; }
        public bool KnownGoodEditor { get; set; }
    }
}