using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    [Serializable]
    public class RepositorioUser
    {
        public List<Usuarios> Usuario { get; set; } = new List<Usuarios>();
        public static RepositorioUser Instancia { get; } = new RepositorioUser();


        private RepositorioUser(){}

    }
}
