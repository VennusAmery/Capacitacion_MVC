using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using CapaModelo;
namespace CapaControlador
{
    public class Controlador
    {
        sentencias sn = new sentencias();
        // LLenar una tabla CAPA CONTROLADOR
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

    }
}
