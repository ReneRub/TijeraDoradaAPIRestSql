using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class NotificacionesEstatus
    {
        public NotificacionesEstatus()
        {
            NotificacionesxTokens = new HashSet<NotificacionesxToken>();
        }

        public int EstatusId { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<NotificacionesxToken> NotificacionesxTokens { get; set; }
    }
}
