using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.PersistentLogin;


namespace BusinessLayer 
{
    [Serializable]
    public class ServicioUsuario
    {
        public readonly string directory;
        public readonly string fileName;
        public readonly Serializer serializer;
        public ServicioUsuario()
        {
            directory = "User";
            fileName = "user.dat";
            serializer = new Serializer();
        }
        public void Add(Usuarios Item)
        {
            RepositorioUser.Instancia.Usuario.Add(Item);
            serializer.Serialize(RepositorioUser.Instancia.Usuario, directory, fileName);
        }

    
        public Usuarios GetItemUser(string UserName)
        {
            List<Usuarios> listadoUsuarios = (List<Usuarios>)serializer.Deserialize(directory, fileName);
            if (listadoUsuarios != null)
            {
                RepositorioUser.Instancia.Usuario = listadoUsuarios;
            }

            if (RepositorioUser.Instancia.Usuario != null)
            {
                foreach (Usuarios item in RepositorioUser.Instancia.Usuario)
                {
                    if (item.UserName == UserName || item.Name == UserName)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
