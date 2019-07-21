using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cliente> ListaCliente = new List<cliente>
            {
                new cliente{Id=1, Nombre="NEIVIS" },
                new cliente{Id=2, Nombre="DAYANARA" },
                new cliente{Id=3, Nombre="MARIA" },
                new cliente{Id=4, Nombre="DAYANNA" },
                new cliente{Id=5, Nombre="NIXON" },
                new cliente{Id=6, Nombre="ARIEL" },
                new cliente{Id=7, Nombre="EMMELY" },
                new cliente{Id=8, Nombre="GABRIELA" },
                new cliente{Id=9, Nombre="SANTIAGO" },
                new cliente{Id=10, Nombre="PATRICIO" },

            };
            List<Factura> ListaFactura = new List<Factura>
            {
                new Factura{Id=1, Observacion="Articulo 1", IdCliente=1, Fecha=new DateTime(2018,01,2,14,50,20), Total=90},
                new Factura{Id=2, Observacion="Articulo 2", IdCliente=2, Fecha=new DateTime(2018,03,4,12,33,40), Total=40},
                new Factura{Id=3, Observacion="Articulo 3", IdCliente=1, Fecha=new DateTime(2018,04,2,13,12,34), Total=200},
                new Factura{Id=4, Observacion="Articulo 4", IdCliente=3, Fecha=new DateTime(2018,01,2,9,11,23), Total=60},
                new Factura{Id=5, Observacion="Articulo 5", IdCliente=6, Fecha=new DateTime(2019,01,3,14,12,56), Total=420},
                new Factura{Id=6, Observacion="Articulo 6", IdCliente=2, Fecha=new DateTime(2018,10,5,20,33,29), Total=80},
                new Factura{Id=7, Observacion="Articulo 7", IdCliente=3, Fecha=new DateTime(2017,01,2,16,23,10), Total=110},
                new Factura{Id=8, Observacion="Articulo 8", IdCliente=8, Fecha=new DateTime(2018,11,2,16,13,59), Total=200},
                new Factura{Id=9, Observacion="Articulo 9", IdCliente=10, Fecha=new DateTime(2018,01,6,13,12,36), Total=100},
                new Factura{Id=10, Observacion="Articulo 10", IdCliente=9, Fecha=new DateTime(2018,12,2,18,10,01), Total=20},
            };
            var resultado = from i in ListaCliente orderby i.Nombre select i;
            Console.WriteLine("");
            Console.WriteLine("********NOMBRE DE LOS CLIENTE********");
            foreach (var item in resultado)
            {
                Console.WriteLine(item.Nombre);
            }
            
            var resultado2 = from i in ListaFactura orderby i.Fecha select i;
            Console.WriteLine("********LAS VENTAS ORDENADAS POR FECHAS********");
            foreach (var item in resultado2)
            {
                Console.WriteLine(item.Fecha);
            }

            int mayor1 = 0;
            int mayor2 = 0;
            int mayor3 = 0;

            string primero = "";
            string segundo = "";
            string tercero = "";
           
            var factura = from i in ListaFactura orderby i.Fecha select i;
            foreach (var item in factura)
            {
                if (item.Total > mayor1)
                {
                    mayor1 = item.Total;
                    primero = item.Observacion;
                }
            }
            foreach (var item in factura)
            {
                if (item.Total> mayor2 && item.Total != mayor1)
                {
                    mayor2 = item.Total;
                    segundo = item.Observacion;
                }
            }
            foreach (var item in factura)
            {
                if (item.Total> mayor3 && item.Total!= mayor1 && item.Total!= mayor2)
                {
                    mayor3 = item.Total;
                    tercero = item.Observacion;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("************LOS 3 CLIENTES CON MÁS MONTO EN VENTAS*******");
            Console.WriteLine("");
            Console.WriteLine("EL"+primero+"  "+"TIENE UNA VENTA DE:"+mayor1);
            Console.WriteLine("EL" + segundo + "  " + "TIENE UNA VENTA DE:" + mayor2);
            Console.WriteLine("EL" + tercero + "  " + "TIENE UNA VENTA DE:" + mayor3);

            int mayor = 0;
            int x = 0, y = 0, z = 0;

            int menor1 = 0;
            int menor2= 0;
            int menor3 = 0;

            string priMenor = "";
            string seguMenor = "";
            string terMenor = "";

            foreach (var item in factura)
            {
                if (item.Total>mayor)
                {
                    mayor = item.Total;
                    x = item.Total;
                    y = item.Total;
                    z = item.Total;
                }
            }
            foreach (var item in factura)
            {
                if (item.Total<x)
                {
                    x = item.Total;
                    menor1 = item.Total;
                    priMenor = item.Observacion;
                }
            }
            foreach (var item in factura)
            {
                if (item.Total < y && item.Total != menor1)
                {
                    y = item.Total;
                    menor2 = item.Total;
                    seguMenor = item.Observacion;
                }
            }
            foreach (var item in factura)
            {
                if (item.Total < z && item.Total != menor1 && item.Total!=menor2 )
                {
                    z = item.Total;
                    menor3 = item.Total;
                    terMenor = item.Observacion;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("************LOS 3 CLIENTES CON MENOS MONTO EN VENTAS*******");
            Console.WriteLine("");
            Console.WriteLine("EL" + priMenor + "  " + "TIENE UNA VENTA DE:" + menor1);
            Console.WriteLine("EL" + seguMenor + "  " + "TIENE UNA VENTA DE:" + menor2);
            Console.WriteLine("EL" + terMenor + "  " + "TIENE UNA VENTA DE:" + menor3);

            Console.WriteLine("");
            Console.WriteLine("*********CLIENTE CON MÁS VENTAS REALIZADAS**************");
            Console.WriteLine("");

            var Mayor = factura.Max(i => i.Total);
            Console.WriteLine("Cliente con más ventas realizadas es:"+"  "+ primero+"  "+"Con  un Total de="+"  "+Mayor+"  "+"Ventas");

            var r = from i in factura select i;
            System.DateTime afecha = new DateTime(2018, 05, 12);
            var RangoFecha = from i in factura where i.Fecha >= afecha select i;
            Console.WriteLine("");
            Console.WriteLine("*******VENTAS REALIZADAS HACE MENOS DE UN AÑO**********");
            foreach (var item in RangoFecha)
            {
                Console.WriteLine("EL CLIENTE " + item.IdCliente + "  REALIZO SU COMPRA EL:" + "  "+item.Fecha);

            }
            //int nom = 0, Ant=0;

            System.DateTime bfecha = new DateTime(2017, 05, 12);
            var Rf = from i in factura where i.Fecha < bfecha select i;
            Console.WriteLine("");
            Console.WriteLine("*******LAS VENTA MÁS ANTIGUA**********");
            foreach (var item in Rf)
            {
                Console.WriteLine("EL CLIENTE "+item.IdCliente+"  REALIZO SU COMPRA EL:"+"  "+item.Fecha);
            }

            
            System.DateTime cfecha = new DateTime(2019, 01, 1);
            var CF = from i in factura where i.Fecha > cfecha select i;
            Console.WriteLine("");
            Console.WriteLine("*******LA ULTIMA VENTA REALIZADA**********");
            foreach (var item in CF)
            {
                Console.WriteLine("EL CLIENTE " + item.IdCliente + "  REALIZO SU COMPRA EL:" + "  " + item.Fecha);
            }


            Console.ReadKey();
        }
    }


    class cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    class Factura
    {
        public int Id { get; set; }
        public string Observacion { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int Total { get; set; }
    }


}

