using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using BusinessLayer.PersistentLogin;

namespace BuisnessLayer
{
    [Serializable]
    public class ServicioContactos

   {
        private readonly Serializer serializer;
        private readonly string directory;
        private readonly string fileName;
        public ServicioContactos(string User)
        {
            serializer = new Serializer();
            directory = "Contacto";
            fileName = $"{User}.dat";
        }
        public void Add(Contacto Item) {
            Repositorio.Instancia.Contancto.Add(Item);
            serializer.Serialize(Repositorio.Instancia.Contancto, directory, fileName);

        }
        public void Edit(int Index, Contacto Item) {
            Repositorio.Instancia.Contancto[Index] = Item;
            serializer.Serialize(Repositorio.Instancia.Contancto, directory, fileName);
        }
        public void Delete(int Index) {
            Repositorio.Instancia.Contancto.RemoveAt(Index);
            serializer.Serialize(Repositorio.Instancia.Contancto, directory, fileName);
        }
        public List<Contacto> ListUser()
        {
            List<Contacto> listadoContactos = (List<Contacto>)serializer.Deserialize(directory, fileName);
            if (listadoContactos != null)
            {
                Repositorio.Instancia.Contancto = listadoContactos;
            }

            return Repositorio.Instancia.Contancto;
        }
        public Contacto GetItem(int Index) {


            List<Contacto> Contactos = (List<Contacto>)serializer.Deserialize(directory, fileName);
            if (Contactos != null)
            {
                Repositorio.Instancia.Contancto = Contactos;
            }
            return Repositorio.Instancia.Contancto[Index];
        }
        
       
    }
}
