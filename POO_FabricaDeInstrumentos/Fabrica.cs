using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace POO_FabricaDeInstrumentos
{
    public class Fabrica
    {
        private List<Sucursal> sucursales;

        //Constructor
        public Fabrica()
        {
            this.sucursales = new List<Sucursal>();
        }

        //Metodos
        public void agregarSucursales(Sucursal suc)
        {
            this.sucursales.Add(suc);
        }
        public void listarInstrumentos()
        {
            foreach (Sucursal sucursal in sucursales)
            {
                Console.WriteLine(sucursal.getNombre());
                sucursal.listarInstrumentos();
            }
        }
        public List<Instrumento> instrumentosPorTipo(TipoDeInstrumento tipo)
        {
            List<Instrumento>listaEncontrados = new List<Instrumento>();

            Console.WriteLine($"Instrumentos Encontrados de: {tipo}");
            foreach (Sucursal sucursal in sucursales)
            {
                listaEncontrados.AddRange(sucursal.InstrumentosPorTipo(tipo));
            }
            return listaEncontrados;
        }
        public Instrumento borrarInstrumento(string id)
        {
            Instrumento borrado = null;

            int i = 0;

            while (i < sucursales.LongCount() && borrado == null)
            {
                borrado = sucursales[i].borrarInstrumento(id);
                i++;
            }          

            return borrado;
        }
        public double[] porcInstrumentosPorTipo(string nombreSuc)
        {                                      //Esto viene de sucursales, contenido d CANT_INSTRUMENTOS
            double[] porcentajes = new double[Enum.GetValues(typeof(TipoDeInstrumento)).Length];

            Sucursal sucEncontrada = buscarSucursal(nombreSuc);
            if(sucEncontrada != null)
            {
                porcentajes = sucEncontrada.porcInstrumentosPorTipo();
            }
            return porcentajes;
        }
        private Sucursal buscarSucursal(string nombreSuc)
        {
            int i = 0;
            Sucursal sucEncontrada = null;

            while (i < sucursales.LongCount() && !this.sucursales[i].getNombre().Equals(nombreSuc))
            {
                i++;
            }
            if (i < sucursales.LongCount())
            {
                sucEncontrada = sucursales[i];
            }
            return sucEncontrada;
        }
        //Una vez que el bucle while termina, se verifica si i sigue siendo menor que la cantidad de
        //elementos en el arreglo sucursales.Esto indica que se encontró una sucursal con el nombre 
        //buscado. Si se encontró una sucursal, se asigna la sucursal en la posición i del arreglo 
        //sucursales a la variable sucEncontrada.

    }
}
