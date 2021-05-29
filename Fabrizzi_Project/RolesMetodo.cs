using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fabrizzi_Project
{
    class RolesMetodo : Coneccion
    {

        public Boolean grabarUsuario(Rol rolNew)
        {
            try
            {

                //var idMax = ultimoId();

                var sel = "set dateformat dmy INSERT INTO Roles( rol_NombreDeRol , rol_Descripcion, rol_Area, rol_FechaDeAlta, rol_Estado)" +
                    " VALUES ('" + rolNew.NombreRol + "','" + rolNew.DescripcionRol + "','" + rolNew.Area + "','" + rolNew.FechaAlta + "'," + "'Activo'" + ")";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DataTable ConsultarPorArea(String Area)
        {

            var sqlStr = "select rol_NombreDeRol, rol_Descripcion ,rol_Area ,rol_Estado, rol_FechaDeAlta, rol_FechaDeMod, rol_FechaDeBaja from roles where rol_Area = " + "'" + Area +"'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }
    }
}
