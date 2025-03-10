using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class frmHerencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                imgFigura.ImageUrl = "~/imagenes/Sphere.jpg";
            }
        }

        protected void rblFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEsfera.Visible = false;
            pnlCubo.Visible = false;
            pnlPrima.Visible = false;

            switch (rblFiguras.SelectedValue)
            {
                case "opcEsf":
                    imgFigura.ImageUrl = "~/imagenes/Sphere.jpg";
                    pnlEsfera.Visible = true;
                    break;
                case "opcCub":
                    imgFigura.ImageUrl = "~/imagenes/Cube.jpg";
                    pnlCubo.Visible = true;
                    break;
                case "opcPri":
                    imgFigura.ImageUrl = "~/imagenes/RectangularPrism.jpg";
                    pnlPrima.Visible = true;
                    break;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double area = 0, volumen = 0;

            switch (rblFiguras.SelectedValue)
            {
                case "opcEsf":
                    double radio = Convert.ToDouble(txtRadio.Text);
                    area = 4 * Math.PI * Math.Pow(radio, 2);
                    volumen = (4.0 / 3) * Math.PI * Math.Pow(radio, 3);
                    break;
                case "opcCub":
                    double lado = Convert.ToDouble(txtLado.Text);
                    area = 6 * Math.Pow(lado, 2);
                    volumen = Math.Pow(lado, 3);
                    break;
                case "opcPri":
                    double ladoA = Convert.ToDouble(txtLadoa.Text);
                    double ladoB = Convert.ToDouble(txtLadob.Text);
                    double altura = Convert.ToDouble(txtAltura.Text);
                    area = 2 * (ladoA * ladoB + ladoA * altura + ladoB * altura);
                    volumen = ladoA * ladoB * altura;
                    break;
            }

            lblArea.Text = area.ToString("F2");
            lblVolumen.Text = volumen.ToString("F2");
            pnlRpta.Visible = true;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRadio.Text = "";
            txtLado.Text = "";
            txtLadoa.Text = "";
            txtLadob.Text = "";
            txtAltura.Text = "";
            lblArea.Text = "";
            lblVolumen.Text = "";
            pnlRpta.Visible = false;
        }
    }
}