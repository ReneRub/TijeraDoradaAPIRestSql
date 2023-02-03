using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class TipoMsg
    {
        public TipoMsg()
        {
            NotificacionesxTokens = new HashSet<NotificacionesxToken>();
        }

        public int TipoMsgId { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<NotificacionesxToken> NotificacionesxTokens { get; set; }
    }
}
