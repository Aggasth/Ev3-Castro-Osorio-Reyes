using MedidorLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvaluacionASP_Castro_Osorio_Reyes
{
    public partial class Ingresar : System.Web.UI.Page
    {
        private iMedidor medidorDAL = new Medidor();
        private iLectura lecturasDAL = new Lectura();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.fechaBox.Text = DateTime.Now.ToString("g");

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            int idMedidor = Convert.ToInt32(this.txtId.Text.Trim());
            double consumoMedidor = Convert.ToDouble(this.txtConsumo.Text.Trim());
            string tipoMedidor = this.tiposRbl.SelectedValue;
            DateTime fecha = Convert.ToDateTime(this.fechaBox.Text.Trim());
            string tipo = medidorDAL.TipoTxt(tipoMedidor);
            Medidor m = new Medidor
            {
                Id = idMedidor,
                Consumo = consumoMedidor,
                Tipo = tipo,
                Fecha = fecha
            };
            bool flag = medidorDAL.Filtrar(m);
            if (flag == true)
            {
                this.errorMsg.Text = "Este Medidor ya existe, intente nuevamente";
            }
            else
            {
                lecturasDAL.IngresarLectura(m);
                this.successMsg.Text = "Medidor ingresado correctamente";
            }
            Response.Redirect("VerMedidores.aspx");
        }

    }
}