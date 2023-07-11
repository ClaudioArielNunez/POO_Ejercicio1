using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FabricaDeInstrumentos
{
    public class Instrumento
    {
        private string ID;
        private double precio;
        private TipoDeInstrumento tipo;

        //Constructor
        public Instrumento(string id, double precio, TipoDeInstrumento tipo)
        {
            this.ID = id;
            this.precio = precio;
            this.tipo = tipo;
        }


        //Getter otra forma de poner un getter
        public TipoDeInstrumento Tipo { get => tipo; }
        public string ID1 { get => ID; }



        //Metodos
        public override string ToString()
        {
            return "Instrumento:\nid: " + ID + " PRECIO: " + precio + " tipo: " + tipo;
        }
    }
}
