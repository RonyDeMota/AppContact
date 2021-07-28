using System;

namespace BuisnessLayer
{ [Serializable]
    public class Contacto
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string CellPhone { get; set; }
        public string Phone { get; set; }

        public Contacto(string Name, string Lastname, string Adress, string CellPhone, string Phone)
        {

            this.Name = Name;
            this.Lastname = Lastname;
            this.Adress = Adress;
            this.CellPhone = CellPhone;
            this.Phone = Phone;
        }
    }
}
