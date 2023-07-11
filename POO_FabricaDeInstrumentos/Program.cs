using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FabricaDeInstrumentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fabrica f = new Fabrica();
            cargarFabrica(f);
            //PUNTO A   
            //f.listarInstrumentos();

            //PUNTO B
            //List<Instrumento> listaInstrumentos = f.instrumentosPorTipo(TipoDeInstrumento.VIENTO);
            //foreach (Instrumento inst in listaInstrumentos)
            //{
            //    Console.WriteLine(inst);
            //}
            

            //PUNTO C
            //Console.WriteLine("\n****** BORRANDO INSTRUMENTO *******");
            //Instrumento borrado = f.borrarInstrumento("GHY789");
            //Console.WriteLine($"SE BORRO {borrado}");
            //Console.WriteLine("***********************************");
            //f.listarInstrumentos();

            //PUNTO D
            Console.WriteLine("Porcentajes");
            double[] porcentajes = f.porcInstrumentosPorTipo("Supcursal A");

            for(int i =0; i < porcentajes.Length; i++)
            {
                Console.WriteLine(porcentajes[i]);
            }







        }
        private static void cargarFabrica(Fabrica f)
        {
            Sucursal s1 = new Sucursal("Sucursal A");
            Sucursal s2 = new Sucursal("Sucursal B");

            //Agregamos instrumentos
            //Instrumento inst1 = new Instrumento();
            s1.agregarInstrumentos(new Instrumento("ABC123", 12350, TipoDeInstrumento.VIENTO));
            s1.agregarInstrumentos(new Instrumento("DEF456", 15700, TipoDeInstrumento.CUERDA));
            s1.agregarInstrumentos(new Instrumento("GHY789", 22500, TipoDeInstrumento.PERCUSION));
            
            s2.agregarInstrumentos(new Instrumento("YKO123", 9350, TipoDeInstrumento.VIENTO));
            s2.agregarInstrumentos(new Instrumento("DXX456", 19700, TipoDeInstrumento.CUERDA));

            //Agregamos sucursales
            f.agregarSucursales(s1);
            f.agregarSucursales(s2);
        }
    }
}
