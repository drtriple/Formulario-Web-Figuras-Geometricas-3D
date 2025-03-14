using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libFiguras3D;

namespace WebApp
{
    public partial class frmHerencia : System.Web.UI.Page
    {
        private void limpiarCampos()
        {
            txtRadio.Text = "";
            txtLado.Text = "";
            txtLadoa.Text = "";
            txtLadob.Text = "";
            txtAltura.Text = "";
            lblArea.Text = "";
            lblVolumen.Text = "";
            pnlRpta.Visible = false;
            rblFiguras.SelectedValue = "opcEsf";
            imgFigura.ImageUrl = "~/imagenes/Sphere.jpg";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Cargar 1 vez el form
            {
                imgFigura.ImageUrl = "~/imagenes/Sphere.jpg";
                this.txtRadio.Focus();
            }
        }

        protected void rblFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEsfera.Visible = false;
            pnlCubo.Visible = false;
            pnlPrima.Visible = false;
            pnlRpta.Visible = false;
            // poner funcion limpiar
            switch (rblFiguras.SelectedValue)
            {
                case "opcEsf":
                    imgFigura.ImageUrl = "~/imagenes/Sphere.jpg";
                    pnlEsfera.Visible = true;
                    this.txtRadio.Focus();
                    break;
                case "opcCub":
                    imgFigura.ImageUrl = "~/imagenes/Cube.jpg";
                    pnlCubo.Visible = true;
                    this.txtLado.Focus();
                    break;
                case "opcPri":
                    imgFigura.ImageUrl = "~/imagenes/RectangularPrism.jpg";
                    pnlPrima.Visible = true;
                    this.txtLadoa.Focus();
                    break;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            this.lblMsj.Text = string.Empty;
            this.pnlRpta.Visible = false;

            float v1, v2, v3;
            try
            {
                switch (rblFiguras.SelectedValue)
                {
                    case "opcEsf":

                        v1 = Convert.ToSingle(this.txtRadio.Text);

                        clsEsfera oE = new clsEsfera(_Radio: v1);

                        if(!oE.hallarArea() || !oE.hallarVolumen())
                        {
                            this.lblMsj.Text = oE.Error;
                            oE = null;
                        }
                        else
                        {
                            // Recuperar Información
                            this.lblArea.Text = Convert.ToString(oE.Area);
                            this.lblVolumen.Text = Convert.ToString(oE.Volumen);

                            oE = null;
                            this.pnlRpta.Visible = true;
                        }
                        break;
                    case "opcCub":
                        v1 = Convert.ToSingle(this.txtLado.Text);
                        clsCubo oC = new clsCubo(_LadoA: v1);

                        if (!oC.hallarArea() || !oC.hallarVolumen())
                        {
                            this.lblMsj.Text = oC.Error;
                            oC = null;
                        }
                        else
                        {
                            // Recuperar Información
                            this.lblArea.Text = Convert.ToString(oC.Area);
                            this.lblVolumen.Text = Convert.ToString(oC.Volumen);
                            oC = null;
                            this.pnlRpta.Visible = true;
                        }
                        break;
                    case "opcPri":
                        v1 = Convert.ToSingle( txtLadoa.Text );
                        v2 = Convert.ToSingle( txtLadob.Text );
                        v3 = Convert.ToSingle( txtAltura.Text );

                        // Crear el objeto
                        clsPrismaRect oP = new clsPrismaRect(_LadoA : v1, _LadoB : v2, _Altura : v3);

                        //Tratamiento del error
                        if ( !oP.hallarArea() || !oP.hallarVolumen() ) {
                            this.lblMsj.Text = oP.Error;
                            oP = null;
                        }
                        else
                        {
                            // Recuperar Información
                            this.lblArea.Text = Convert.ToString(oP.Area);
                            this.lblVolumen.Text = Convert.ToString(oP.Volumen);
                            oP = null;
                            this.pnlRpta.Visible = true;
                        }
                        break;
                }
            }
            catch ( Exception ex)
            {
                this.lblMsj.Text = "Error, existe un dato no valido " + ex;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}