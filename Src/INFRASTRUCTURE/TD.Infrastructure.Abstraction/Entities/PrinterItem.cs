using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class PrinterItem
    {
        public Guid Id { get; set; }
        public Guid Documento { get; set; }
        public string? Address { get; set; }
        public bool IsPrint { get; set; }
    }
}
