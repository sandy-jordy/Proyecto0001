using SIS_CA.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIS_CA
{
    public partial class Empleado : Page
    {
        DEmpleados objetoCD = new DEmpleados();
        DCargo objetoCD1 = new DCargo();
        protected void Page_Load(object sender, EventArgs e)
        {
            /*tabla.Attributes.Add("style", "th, td {padding: 15px;}");*/
            if (!IsPostBack)
            {
                IniciarllenadoDropdown();
            }
            mostrar_empleado();
        }
        protected void IniciarllenadoDropdown()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objetoCD1.Mostrar();
            dropCargo.DataSource = tabla1;
            dropCargo.DataTextField = "Nombre_cargo";
            dropCargo.DataValueField = "id_cargo";
            dropCargo.DataBind();
            dropCargo.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
            Calendar1.Attributes.Add("style", "position:absolute");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtCalendar.Text = Calendar1.SelectedDate.ToString();
        }

        protected void mostrar_empleado()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            GridView1.DataSource = tabla;
            GridView1.DataBind();
        }

        

        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1AM46KO;Initial Catalog=Control_de_asistencia;Integrated Security=True");
        protected void btnagregar_Click(object sender, EventArgs e)
        {
            /*int id_empleado = int.Parse(txtidempleado.Text);*/
            string primer_nom = txtPnombre.Text, segundo_nombre = txtSnombre.Text,
                primer_apellido = txtPapellido.Text, segundo_apellido = txtSapellido.Text;
            string estado = RadioButtonList1.SelectedValue;
            DateTime a = DateTime.Parse(txtCalendar.Text);
            string cadena = a.ToString("yyyy-MM-dd");

            int id_cargo = Convert.ToInt32(dropCargo.SelectedValue);

            objetoCD.Insertar_empleado(0,primer_nom,segundo_nombre,primer_apellido,segundo_apellido,cadena,id_cargo,estado);
            mostrar_empleado();
        }
    }
}