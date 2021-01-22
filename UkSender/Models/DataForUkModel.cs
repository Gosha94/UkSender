using System;

namespace UkSender.Models
{
    public class DataForUkModel
    {
        public string MeteringDevice { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public string EmailedStatus { get; set; }
    }
}
