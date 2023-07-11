using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FabricaDeInstrumentos
{
    public class Sucursal
    {
        private List<Instrumento> instrumentos;
        private string nombre;


        //Getter
        public string getNombre()
        {
            return nombre;
        }

        //Constructor
        public Sucursal(string nombre)
        {
            this.nombre = nombre;
            this.instrumentos = new List<Instrumento>();
        }
                      

        //Metodos
        public void agregarInstrumentos (Instrumento ins)
        {
            this.instrumentos.Add(ins);
        }
        public void listarInstrumentos()
        {
            foreach (Instrumento instrumento in instrumentos)
            {
                Console.WriteLine(instrumento);
            }
        }
        public List<Instrumento> InstrumentosPorTipo(TipoDeInstrumento tipo) 
        {
            //Devolvemos una nueva lista
            List<Instrumento>instrumEncontrados = new List<Instrumento>();
            foreach (Instrumento instrumento in instrumentos)
            {
                if (instrumento.Tipo.Equals(tipo))
                {
                    instrumEncontrados.Add(instrumento);
                }
            }

            return instrumEncontrados;
        }
        public Instrumento borrarInstrumento(string ID)
        {
            Instrumento instABorrar = buscarInstrumento(ID);
            this.instrumentos.Remove(instABorrar);
            return instABorrar;

        }
        public Instrumento buscarInstrumento(string ID)
        {
            int i = 0;
            Instrumento instEncontrado = null;
            instEncontrado = instrumentos.Find(x => x.ID1 == ID);
            
            //while (i < instrumentos.LongCount() && !this.instrumentos[i].ID1.Equals(ID))
            //{
            //    i++;
            //}
            //if(i < instrumentos.LongCount())
            //{
            //    instEncontrado = this.instrumentos[i];
            //}
            return instEncontrado;
        }
        public double[] porcInstrumentosPorTipo()
        {
            int CANT_INSTRUMENTOS = Enum.GetValues(typeof(TipoDeInstrumento)).Length;//conseguimos la cant. d elem enumerados
            double[] porcentajes = new double[CANT_INSTRUMENTOS];

            foreach (Instrumento inst in instrumentos)
            {
                porcentajes[Convert.ToInt32(inst.Tipo)]++;
            }
            absolutoaPorcentaje(porcentajes);
            return porcentajes;
        }
        private void absolutoaPorcentaje(double[] porcentajes)
        {
            for (int i = 0; i < porcentajes.Length; i++)
            {                
                porcentajes[i] = (porcentajes[i] * 100) / instrumentos.Count();

            }
        }

    }
}
