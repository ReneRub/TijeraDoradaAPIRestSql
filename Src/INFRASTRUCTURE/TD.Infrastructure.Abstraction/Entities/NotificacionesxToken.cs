using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class NotificacionesxToken
    {
        public int NotificationId { get; set; }
        public int? TokenId { get; set; }
        public int TypeAlertId { get; set; }
        public string NameAlert { get; set; } = null!;
        public string? Screen { get; set; }
        public int? ValueId { get; set; }
        public string Title { get; set; } = null!;
        public string Descriptions { get; set; } = null!;
        public int? EstatusId { get; set; }
        public int? TipoMsgId { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? FechaLeido { get; set; }

        public virtual NotificacionesEstatus? Estatus { get; set; }
        public virtual TipoMsg? TipoMsg { get; set; }
        public virtual TokenxCliente? Token { get; set; }
    }
}
