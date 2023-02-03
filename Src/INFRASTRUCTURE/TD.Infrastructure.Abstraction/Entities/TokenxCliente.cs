using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class TokenxCliente
    {
        public TokenxCliente()
        {
            NotificacionesxTokens = new HashSet<NotificacionesxToken>();
        }

        public int TokenId { get; set; }
        public string ClienteId { get; set; } = null!;
        public string? TokenFireB { get; set; }
        public int? Activo { get; set; }

        public virtual ICollection<NotificacionesxToken> NotificacionesxTokens { get; set; }
    }
}
