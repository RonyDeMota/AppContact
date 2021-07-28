using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{ 
    [Serializable]
   public class Usuarios
    {
      
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public string Contraseña { get; set; }

        public Usuarios(string Name, string Lastname, string UserName, string Contraseña)
        {
            this.Name = Name;
            this.Lastname = Lastname;
            this.UserName = UserName;
            this.Contraseña = Contraseña;
        }
        
    }
}
