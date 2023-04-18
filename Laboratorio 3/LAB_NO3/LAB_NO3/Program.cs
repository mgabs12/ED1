using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb02
{

    class Test
    {

        private static string _path = @"C:\ClonRepo\jsonLab3.txt";
        private static string _path2 = @"C:\ClonRepo\LAb30.txt";

        public static string GetUsuarios()
        {

            string usu;
            using (var reader = new StreamReader(_path))
            {
                usu = reader.ReadToEnd();

            }


            return usu;
        }

        public static string GetUsuarios2()
        {

            string usu;
            using (var reader = new StreamReader(_path2))
            {
                usu = reader.ReadToEnd();

            }


            return usu;
        }
        static void Main(string[] args)
        {


            int contador = 0;
            int con = 0;
            int i = 0;

            string[] arreglo = new string[1000];
            string[] arreglo2 = new string[1000];
            int conT = 0;
            int conP = 1;
            Console.Title = "AVL";

            //string decode = arbolHH.Decodificacion(encode);

            var infodd = "";
            var info1 = "";
            var infoN = "";
            var infoD = "";
            var infoG = "";
            string[] informacion1 = { };
            string[] informacionP3 = { };
            string[] informacionP2 = { };
            string[] separI22 = { };
            int c = 0, b = 0, a = 0;



            if (GetUsuarios2() != null && contador == con)
            {
                try
                {

                    string allFileData = File.ReadAllText(_path2);
                    foreach (string lineaActual in allFileData.Split('\n'))
                    {

                        if (!string.IsNullOrEmpty(lineaActual) && contador == con)
                        {
                            conT = 0;
                            string[] informacion = lineaActual.Split("{");

                            Console.WriteLine("Usuario: " + informacion[1]);





                        }


                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error" + ex);
                }

            }//



            Console.WriteLine("----------------------------------------------------------------------");
            if (GetUsuarios() != null && contador == con)
            {
                try
                {

                    string allFileData = File.ReadAllText(_path);
                    foreach (string lineaActual in allFileData.Split('\n'))
                    {

                        if (!string.IsNullOrEmpty(lineaActual) && contador == con)
                        {
                            conT = 0;
                            string[] informacion = lineaActual.Split("customers");
                            var u = (informacion[1]);
                            string[] comp = u.Split('{');
                            var comp1 = comp[0];
                            var comp2 = comp[0];

                            for (int r = 0; r < comp.Length; r++)
                            {
                                Console.WriteLine("Datos: " + comp[r]);
                            }


                            //string[] informacionN = infoN.Split('{');
                            //var infonn = informacionN[1];


                            //string[] informacionD = infoD.Split("],");
                            //infodd = informacionD[1];
                            //var info3 = informacionD[0];

                            //string[] informacionP = info3.Split("," + '"');

                            //informacionP2 = info3.Split("},{");



                            //string[] separI2 = infodd.Split('[');
                            //var info4 = separI2[1];

                            //string[] separI21 = info4.Split(']');
                            //var info5 = separI21[0];

                            //separI22 = info5.Split(',');





                            //for (int b = 0; b < informacionP.Length; b++)
                            //{
                            //    for (int a = 0; a < separI22.Length; a++)
                            //    {
                            //        if (informacionP[b].Contains(separI22[a]+":true") && informacionP[b].Contains(separI22[a]) && separI22[a] != null)
                            //        {
                            //            conT++;
                            //        }


                            //    }
                            //}



                        }


                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error" + ex);
                }

            }//






        }



    }
}
