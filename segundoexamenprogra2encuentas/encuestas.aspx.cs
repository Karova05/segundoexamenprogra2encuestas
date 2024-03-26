using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace segundoexamenprogra2encuentas
{
    public partial class encuestas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {

                string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                int numeroencuestas = obtenernumeroencuestas(connectionString);

                
                clsencuesta.insertarnumeroencuestas(connectionString, "numeroencuestas", "nombre", "apellido", "fechadenacimiento", DateTime.Now, "nuevo@correo.com", "carropropio");

                
                clsencuesta.listarnumeroencuestas(connectionString);



            }

        }


    public int obtenernumeroencuestas(string connectionString)

        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "INSERT INTO usuarios DEFAULT VALUES; SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    

                    connection.Open();
                    object result = command.ExecuteScalar();
                     int idGenerado = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    connection.Close();

                    return idGenerado;
                }
            }

        }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            
            
            this.rbutton1.Text = "si";

             this.rbutton1.GroupName = "grupoOpciones";
            

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            
            
            this.rbutton2.Text = "no";

            this.rbutton2.GroupName = "grupoOpciones";

        }

        protected void tingresar_Click(object sender, EventArgs e)
        {

            string connectionString = "conexion";
            string nombreEncuesta = "TextBox2"; // Asegúrate de obtener este valor correctamente, por ejemplo, de otro TextBox

            int numeroencuestas = insertarnumeroencuestas(connectionString, nombreEncuesta);

            // Mostrar el ID en el TextBox
            TextBox2.Text = numeroencuestas.ToString();
        }

        private int insertarnumeroencuestas(string connectionString, string nombreEncuesta)
        {
            throw new NotImplementedException();
        }
    }
    }



