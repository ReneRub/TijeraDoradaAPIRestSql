using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class PrinterDocument
    {
        public Guid Id { get; set; }
        public string Contenido { get; set; } = null!;
        public string Settings { get; set; } = null!;
    }
}
