using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorLibrary.DAL
{
    public class Medidor : iMedidor
    {
        private iLectura lecturasDAL = new Lectura();

        private int id;
        private DateTime fecha;
        private double consumo;
        private string tipo;

        public int Id { get => id; set => id = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public static List<Medidor> medidores = new List<Medidor>();
        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }

        public void AgregarMedidor(Medidor m)
        {
            medidores.Add(m);
        }

        public bool Filtrar(Medidor m)
        {
            bool flag = false;
            for (int i = 0; i < medidores.Count; i++)
            {
                Medidor actual = medidores[i];
                if (actual.Id == m.id)
                {
                    flag = true;
                }
            }
            return flag;
        }
        
        public string TipoTxt(string t)
        {
            string tipo = "";
            if (t=="1")
            {
                tipo = "Agua";
            }
            else
            {
                if (t=="2")
                {
                    tipo = "Luz";
                }
                else
                {
                    tipo = "Gas";
                }
            }
            return tipo;
        }
    }
}
