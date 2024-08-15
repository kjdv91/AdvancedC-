using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de Transaccion
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Transaccion : System.Web.Services.WebService
{

    public Transaccion()
    {


        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public decimal Sumar(decimal num1, decimal num2)
    {
        decimal result = num1 + num2;
        return result;
    }

    public DataSet Clientes()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
        int idCliente = 2;
        //string query = @"select * from clientes where idPais = @idPais";

        using (SqlConnection sql = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("ObtenerClientePorID", sql))
            {
                cmd.CommandType = CommandType.StoredProcedure; //llamo al procedure
                // paso el parametro
                cmd.Parameters.Add(new SqlParameter("@idCliente", idCliente));

                //// select 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);


                da.Fill(dt);
                return dt;
            }

        }


    }

    //ObtenerTodosLosClientes
    //ActualizarCliente

    public void CreateCliente()
    {
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
        
        
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                sql.Open();

                    using (SqlCommand cmd = new SqlCommand("CrearNuevoCliente", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure; //llamo al procedure
                    // paso el parametro
                    cmd.Parameters.Add(new SqlParameter("@nombreCliente", "Pepe"));
                    cmd.Parameters.Add(new SqlParameter("@apellidoCliente", "Perez"));
                    cmd.Parameters.Add(new SqlParameter("@direccionCliente", "Guayaquil"));
                    cmd.Parameters.Add(new SqlParameter("@edad", 75));
                    cmd.ExecuteNonQuery();
                }
                // inicio una transaccion
                SqlTransaction transaction = sql.BeginTransaction();

                // sentencia dentro de una transaccion
                using (SqlCommand cmd = new SqlCommand("CrearNuevoCliente", sql, transaction))
                {
                    cmd.CommandType = CommandType.StoredProcedure; //llamo al procedure
                    // paso el parametro
                    cmd.Parameters.Add(new SqlParameter("@nombreCliente", "Pepe"));
                    cmd.Parameters.Add(new SqlParameter("@apellidoCliente", "Perez"));
                    cmd.Parameters.Add(new SqlParameter("@direccionCliente", "Guayaquil"));
                    cmd.Parameters.Add(new SqlParameter("@edad", 19));
                    cmd.ExecuteNonQuery();
                }

                // exception
                //throw new ApplicationException("Err");

            using (SqlCommand cmd = new SqlCommand("CrearNuevoCliente", sql, transaction))
            {
                cmd.CommandType = CommandType.StoredProcedure; //llamo al procedure
                // paso el parametro
                cmd.Parameters.Add(new SqlParameter("@nombreCliente", "Pepe"));
                cmd.Parameters.Add(new SqlParameter("@apellidoCliente", "Perez"));
                cmd.Parameters.Add(new SqlParameter("@direccionCliente", "Guayaquil"));
                cmd.Parameters.Add(new SqlParameter("@edad", 22));
                cmd.ExecuteNonQuery();
            }
            transaction.Commit();

        }

    }catch(ApplicationException ex){
            Console.WriteLine(ex.Message);        
}
    }

    public void UpdateCliente()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
        using (SqlConnection sql = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("CrearNuevoCliente", sql))
            {
                cmd.CommandType = CommandType.StoredProcedure; //llamo al procedure
                // paso el parametro
                cmd.Parameters.Add(new SqlParameter("@nombreCliente", "Pepe"));
                cmd.Parameters.Add(new SqlParameter("@apellidoCliente", "Perez"));
                cmd.Parameters.Add(new SqlParameter("@direccionCliente", "Guayaquil"));
                cmd.Parameters.Add(new SqlParameter("@edad", 19));


                sql.Open(); //comunicacion abierta
                cmd.ExecuteNonQuery();

            }

        }
    }

}
