using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Escuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no esten vacios
            if(string.IsNullOrWhiteSpace(txtMatricula.Text) ||
               string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtGrupo.Text) ||
               string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show(
                    "Completa todos los campos antes de guardar.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            //Obtenemos los datos del formulario
            try
            {
                using (OleDbConnection conexion = 
                    ConexionBD.ObtenerConexion()) 
                {
                    conexion.Open();
                    string consulta = 
                        "INSERT INTO Alumnos " +
                        "(Matricula, Nombre, Semestre, Grupo, Especialidad) " +
                        "VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand comando =
                        new OleDbCommand(consulta, conexion))
                    {
                        //Con OleDb importa el orden de los parametros
                        comando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = txtMatricula.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = txtNombre.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.Integer
                            ).Value = (int)nudSemestre.Value;
                        comando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = txtGrupo.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = txtEspecialidad.Text.Trim();
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Alumno guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizamos la tabla automáticamente
                        CargarAlumnos();

                        // Limpiamos los campos para registrar uno nuevo
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al guardar los datos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        private void CargarAlumnos()
        {
            try
            {
                using (OleDbConnection conexion=
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = 
                        "SELECT  idAlumno, Matricula, Nombre," +
                        "Semestre, Grupo, Especialidad " +
                        "FROM Alumnos Order By IdAlumno";
                    using (OleDbDataAdapter adaptador = 
                        new OleDbDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvAlumnos.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al cargar los datos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarAlumnos();
        }
        // Método que limpia todas las cajas de texto y reinicia el semestre
        private void LimpiarCampos()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            nudSemestre.Value = 1;
            txtGrupo.Clear();
            txtEspecialidad.Clear();
            txtMatricula.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }
    }
}
