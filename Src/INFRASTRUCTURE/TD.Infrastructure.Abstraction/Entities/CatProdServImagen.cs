using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatProdServImagen
    {
        public int CveProdServ { get; set; }
        public string RutaImagen { get; set; } = null!;

        public virtual CatProdServ CveProdServNavigation { get; set; } = null!;
    }
}
