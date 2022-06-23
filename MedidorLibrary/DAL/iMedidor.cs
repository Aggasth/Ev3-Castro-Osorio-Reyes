using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorLibrary.DAL
{
    public interface iMedidor
    {
        List<Medidor> ObtenerMedidores();
        void AgregarMedidor(Medidor m);
        bool Filtrar(Medidor m);
        string TipoTxt(string t);
    }
}
