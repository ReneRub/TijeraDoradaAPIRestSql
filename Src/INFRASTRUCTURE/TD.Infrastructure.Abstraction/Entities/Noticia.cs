using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class Noticia
    {
        public int CveNoticia { get; set; }
        public DateTime Fecha { get; set; }
        public string Titulo { get; set; } = null!;
        public string Abstract { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public short CveUsuario { get; set; }
        public DateTime FechaCambios { get; set; }
        public short CveUsuarioC { get; set; }
        public int Status { get; set; }
        public string? Imagen { get; set; }
        public string? Archivo { get; set; }
    }
}
