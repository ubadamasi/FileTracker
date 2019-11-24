using System;

namespace TrackingApp.API.models
{
    public class MailDetail
    {
        public int Id { get; set; }
        public int MailId { get; set; }
        public string User { get; set; }
        public int Location { get; set; }
        public string Comments { get; set; }
        public DateTime LogDate { get; set; }
    }
}