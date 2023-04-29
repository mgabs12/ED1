﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb03
{
    class Test
    {

        private static string _path = @"C:\Users\Monica\Documents\URL\QUINTO CICLO\Estructura de datos I\ED1\Laboratorio 3\input_auctions_example_lab_3.txt";
        private static string _path2 = @"C:\Users\Monica\Documents\URL\QUINTO CICLO\Estructura de datos I\ED1\Laboratorio 3\input_customer_example_lab_3.txt";

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
            Console.Title = "LAB 3 MÓNICA ORTÍZ";

            string[] informacion1 = { };
            string[] informacionP3 = { };
            string[] informacionP2 = { };
            string[] separI22 = { };
            string[] Cadena2 = new string[1000];
            var saveCadena = "";
            int[] ndata = new int[1000];
            int dataf = 0;
            int max = ndata[0];
            var dpi = "";
            var gdpi = "";
            var Sdpi = "";
            string key = "";
            int conteo = 0;

            Console.WriteLine("LAB3");
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
                            informacion1 = u.Split('{');
                            var comp1 = informacion1[1];

                            for (int r = 1; r < informacion1.Length; r++)
                            {
                                saveCadena = informacion1[r].ToString();
                                Cadena2[r] = saveCadena;
                                string[] informacion2 = saveCadena.Split('"' + "budget" + '"' + ":");
                                string[] informacion3 = informacion2[1].Split(',');
                                var rdata = informacion3[0];
                                //Console.WriteLine(rdata);
                                dataf = Convert.ToInt32(rdata);
                                ndata[r - 1] = dataf;

                                if (ndata[r - 1] > max)
                                {
                                    max = ndata[r - 1];
                                }
                            }
                        }
                        for (int r = 1; r < informacion1.Length; r++)
                        {

                            conteo++;
                        }
                    }

                    Console.WriteLine("Se aprovó el budget más grande con: " + max);

                    for (int r = 1; r < informacion1.Length; r++)
                    {
                        if (informacion1[r].Contains(max.ToString()))
                        {
                            Console.WriteLine("El resultado fue: " + informacion1[r]);
                            dpi = informacion1[r];
                            string[] informacion4 = dpi.Split('"' + "dpi" + '"' + ":");
                            gdpi = informacion4[1];
                            string[] informacion5 = gdpi.Split(',');
                            Sdpi = informacion5[0];
                            Console.WriteLine("El DPI del usuario ganador es: " + Sdpi);
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error" + ex);
                }
            }
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
                            if (informacion[1].Contains(Sdpi.ToString()))
                            {
                                Random signature = new Random();
                                for (int r = 0; r < 10; r++)
                                {
                                    int n = signature.Next(0, 10);
                                    key += n.ToString();
                                }
                                Console.WriteLine("Información del usuario ganador: " + informacion[1]);
                                Console.WriteLine("Signature: " + key);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex);
                }
            }
            Console.WriteLine("Se rechazaron: " + (conteo - 1) + " usuarios");
        }
    }
}