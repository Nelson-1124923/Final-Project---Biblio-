﻿namespace SistemaGestionBibliotecaAPI.Models
{
    public class TipoUsuario
    {
        public Guid TipoUsuarioId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
