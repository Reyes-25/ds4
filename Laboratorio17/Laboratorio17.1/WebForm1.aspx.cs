using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Laboratorio17._1
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectionStringSettings connectionString = ConfigurationManager.ConnectionStrings["Northwind"];
                if (connectionString == null)
                {
                    throw new ConfigurationErrorsException("La cadena de conexión 'Northwind' no está definida en el archivo Web.config.");
                }

                using (SqlConnection conexion = new SqlConnection(connectionString.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SalesByCategory", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = "Seafood";

                        conexion.Open();
                        Response.Write("<script>alert('Conexión establecida');</script>");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Response.Write("<script>alert('Datos encontrados');</script>");
                                GridV.DataSource = reader;
                                GridV.DataBind();
                            }
                            else
                            {
                                Response.Write("<script>alert('No se encontraron datos en el procedimiento almacenado');</script>");
                            }
                        }
                    }
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                Response.Write($"<script>alert('Error de configuración: {ex.Message}');</script>");
            }
            catch (SqlException ex)
            {
                Response.Write($"<script>alert('Error en la base de datos: {ex.Message}');</script>");
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Ocurrió un error: {ex.Message}');</script>");
            }
        }
    }
}
