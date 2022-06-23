using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorLibrary.DAL
{
    public class Lectura : iLectura
    {
        private static string archivo = "lecturas.txt";
        private static string ruta = Directory.GetCurrentDirectory() + "/" + archivo;

        public void IngresarLectura(Medidor m)
        {
            //1. Crear el streamwriter.
            //2. Agregar una linea del archivo.
            //3. Cerrar el streamwriter.
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    string texto = m.Id + "|"
                        + m.Fecha + "|"
                        + m.Consumo + "|"
                        + m.Tipo;
                    writer.WriteLine(texto);
                    writer.Flush(); //permite asegurar de que los datos llegan al archivo destinatario.

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al escribir en archivo.txt" + ex.Message);
            }
            finally
            {

            }
        }

        public List<Medidor> ObtenerLecturas()
        {
            List<Medidor> medidores = new List<Medidor>();
            using (StreamReader reader = new StreamReader(ruta))
            {
                string texto;
                do
                {
                    //Leer desde el archivo hasta que no haya nada.
                    texto = reader.ReadLine();
                    if (texto != null)
                    {
                        string[] textoarr = texto.Trim().Split('|');
                        int idtxt = Convert.ToInt32(textoarr[0]);
                        DateTime fecha = Convert.ToDateTime(textoarr[1]);
                        double consumotxt = Convert.ToDouble(textoarr[2]);
                        string tipo = textoarr[3];

                        //Crear un medidor.
                        Medidor m = new Medidor()
                        {
                            Id = idtxt,
                            Fecha = fecha,
                            Consumo = consumotxt,
                            Tipo = tipo
                        };

                        medidores.Add(m);
                    };
                } while (texto != null);
            }
            return medidores;
        }
    }
}
