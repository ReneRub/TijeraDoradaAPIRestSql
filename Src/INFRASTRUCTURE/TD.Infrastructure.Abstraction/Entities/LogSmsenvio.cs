using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class LogSmsenvio
    {
        public string? SmsId { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Custom { get; set; }
        public DateTime? SmsDate { get; set; }
        public string? Status { get; set; }
        public DateTime? DlrDate { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
