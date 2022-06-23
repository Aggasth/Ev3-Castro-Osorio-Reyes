using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorLibrary.DAL
{
    public interface iLectura
    {
        void IngresarLectura(Medidor m);
        List<Medidor> ObtenerLecturas();
    }
}
