using System;

namespace TrackingApp.API.models
{
    public class Mail
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public int Organization { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public int FileType { get; set; }
        public int FileFlow { get; set; }
        public int CurrentLocation { get; set; }
        public DateTime LogDate { get; set; }
        public bool IsActive { get; set; }
    }
}