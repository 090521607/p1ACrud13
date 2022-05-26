using Microsoft.AspNet.SignalR.Infrastructure;
using p1ACrud13.Clases.CapaDatos;
using p1ACrud13.Clases.entidades;
using p1ACrud13.Clases.Servicio;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WFP1AC14
{
    public partial class Form1 : Form
    {

        ServicioAlumno srvAlumno = new();
        MdAlumnos oAlumnos = new();
        ClsConexion cont = new();

        public Form1()
        {
            InitializeComponent();
        }


        private void DesplegarGrid()
        {
            var respuesta = srvAlumno.ConsultaSQL("select * from tb_alumnos");
            dataGridViewAlumnos.DataSource = respuesta;
        }


        private void buttonObtenerDatos_Click(object sender, EventArgs e)
        {
            DesplegarGrid();
        }


        private void MapaoDatosFormulario(MdAlumnos _alumnos)
        {
            textBoxCarnet.Text = _alumnos.carnet;
            textBoxNombre.Text = _alumnos.nombre;
            textBoxCorreo.Text = _alumnos.correo;
            comboBoxClase.Text = _alumnos.clase;
            comboBoxSeccion.Text = _alumnos.seccion;
            parcial1.Text = _alumnos.parcial1.ToString();
            parcial2.Text = _alumnos.parcial2.ToString();
            parcial3.Text = _alumnos.parcial2.ToString();
        }


        private void LimpiarDatos()
        {
            oAlumnos = new();
            MapaoDatosFormulario(oAlumnos);
        }

        private void buscaAlumno(string carnet)
        {
            oAlumnos = null;
            oAlumnos = srvAlumno.ObtenerAlumno(carnet);
            if (oAlumnos == null)
            {
                MessageBox.Show("no existe este cuate");
                LimpiarDatos();
            }
            else
            {
                MapaoDatosFormulario(oAlumnos);
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            buscaAlumno(carnet);
        }



        private MdAlumnos DatosFormulario()
        {
            MdAlumnos _alumnos = new();
            _alumnos.carnet = textBoxCarnet.Text.Trim();
            _alumnos.nombre = textBoxNombre.Text.Trim();
            _alumnos.correo = textBoxCorreo.Text.Trim();
            _alumnos.clase = comboBoxClase.Text;
            _alumnos.seccion = comboBoxSeccion.Text;
            _alumnos.parcial1 = 0;
            _alumnos.parcial2 = 0;
            _alumnos.parcial3 = 0;

            _alumnos.parcial1 = Convert.ToInt16(parcial1.Text.Trim());
            _alumnos.parcial2 = Convert.ToInt16(parcial2.Text.Trim());
            _alumnos.parcial3 = Convert.ToInt16(parcial3.Text.Trim());
            return _alumnos;
        }





        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            oAlumnos = DatosFormulario();
            int respuesta = srvAlumno.CrearAlumno(oAlumnos);
            buscaralum(carnet);
            

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            oAlumnos = DatosFormulario();
            datos();



        }








        private void buttonImportar_Click(object sender, EventArgs e)
        {
            string archivo = @"c:\tmp2\alumnos.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.importar(archivo));
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string archivo = @"c:\tmp2\salida.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from tb_alumnos where seccion='A'", archivo));
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            oAlumnos = DatosFormulario();
            int respuesta = srvAlumno.borrar(oAlumnos);
            DialogResult res = MessageBox.Show("¿ESTA SEGURO DE BORRAR EL ALUMNO?", "BORRAR", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                MessageBox.Show("ALUMNO BORRADO CON EXITO");
                LimpiarDatos();
                DesplegarGrid();
            }
            
            else
            {
                MessageBox.Show("cancelado");
            }
        }
    

            

        private void datos()
        {
            int n1 = Convert.ToInt16(parcial1.Text.Trim());
            int n2 = Convert.ToInt16(parcial2.Text.Trim());
            int n3 = Convert.ToInt16(parcial3.Text.Trim());
            if (n1 > -1 & n1 < 21 & n2 > -1 & n2 < 21 & n3 > -1 & n3 < 36)
            {
                int respuesta = srvAlumno.actualizarAlumno(oAlumnos);
                if (respuesta > 0)
                {
                    MessageBox.Show("SE ACTUALIZARON LOS DATOS DEL ALUMNO");
                   
                    
                }
                else
                {
                    MessageBox.Show("Perdon hay un problema con la Grabacion");
                }
            }
            else
            {
                MessageBox.Show("UPPPPS! LA NOTA NO ESTA EN EL RANGO PERMITIDO");
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            
        }


        private void buscaralum(string carnet)
        {
            oAlumnos = null;
            oAlumnos = srvAlumno.ObtenerAlumno(carnet);
            if (oAlumnos == null)
            {
                srvAlumno.CrearAlumno(oAlumnos);
            }
            else
            {

                MessageBox.Show("CREADO");
                LimpiarDatos();
            }
        }

       
    }
}