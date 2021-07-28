using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer
{
    [Serializable]
    public sealed class Repositorio
    {
        public static Repositorio Instancia { get; } = new Repositorio();

        public List<Contacto> Contancto { get; set; } = new List<Contacto>();

        private Repositorio() { }
    }
}
