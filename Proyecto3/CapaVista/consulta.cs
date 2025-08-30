using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;


namespace CapaVista
{
    public partial class consulta : Form
    {

        string emp = "empleados";

        Controlador cn = new Controlador();

        public consulta()
        {
            InitializeComponent();
        }

        //Mostrar los datos CAPA VISTA
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dgv_registros.DataSource = dt;
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
