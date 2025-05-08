using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU1_A4_INT
{
    //    Nombre de práctica. BecaTEc
    //    Tema de referencia. Eventos.
    //    Objetivo de la práctica. DESARROLLAR E IMPLEMENTAR UNA APLICACIÓN PARA WINDOWS FORMS,
    //                             HACIENDO USO DEL LENGUAJE DE PROGRAMACIÓN C# Y EL IDE VISUAL STUDIO
    //                             COMMUNITY EDITION(2015+), QUE PERMITA IDENTIFICAR LAS BECAS
    //                             DISPONIBLES PARA LOS ALUMNOS DEL INSTITUTO.
    //    Materia. Tópicos Avanzados de Programación
    //    Alumno. Daniela Ailyn Rodriguez Diaz
    public partial class frmInicio : Form
    {
        //Se crea el Dictionary para el registro de usuarios y también otro Dictionary con el registro de los nombres de los usuarios
        Dictionary<string,string> usuarios = new Dictionary<string,string>();
        Dictionary<string,string> informacionUsuarios = new Dictionary<string,string>();
        Dictionary<string, string> contrasenas = new Dictionary<string, string>();

        //Declaramos dos variables estáticas string para poder usarlas en otro form en la StatusStrip
        public static string nombreUsuario,tipoUsuarioConectado;

        //Creamos una variable llamada becas de tipo frmBecas
        frmBecas becas;

        public frmInicio()
        {
            InitializeComponent();
        }
        //Dentro del evento Load, se inicializará toda la información que contengan los usuarios y el registro de sus nombres
        private void frmInicio_Load(object sender, EventArgs e)
        {
            //Usuarios (usuario y si es alumno o trabajador)
            usuarios.Add("211000122", "Alumno");
            usuarios.Add("211000183", "Alumno");
            usuarios.Add("211000109", "Alumno");
            usuarios.Add("211000115", "Alumno");
            usuarios.Add("130001989", "Empleado");
            usuarios.Add("252502003", "Empleado");
            usuarios.Add("131342004", "Empleado");
            usuarios.Add("070761980", "Empleado");

            //Información de los usuarios (usuario y su nombre)
            informacionUsuarios.Add("211000122", "DANIELA AILYN RODRIGUEZ DIAZ");
            informacionUsuarios.Add("211000183", "SONIA ABIGAIL HUERTA CARRILLO");
            informacionUsuarios.Add("211000109", "CUAUHTÉMOC ARMANDO ARAIZA CHAIREZ");
            informacionUsuarios.Add("211000115", "WALTER ANTONIO CARRILLO CAÑEDO");
            informacionUsuarios.Add("130001989", "TANIA ALISON SOLIS");
            informacionUsuarios.Add("252502003", "DIANA RODRIGUEZ DOMINGUEZ");
            informacionUsuarios.Add("131342004", "CARLOS ALVAREZ CRUZ");
            informacionUsuarios.Add("070761980", "BERTHA DIAZ CASTRO");

            //Informacion de los usuarios y contraseñas
            contrasenas.Add("211000122", "DARD122");
            contrasenas.Add("211000183", "SAHC183");
            contrasenas.Add("211000109", "CAAC109");
            contrasenas.Add("211000115", "WACC115");
            contrasenas.Add("130001989", "TAS1989");
            contrasenas.Add("252502003", "DRD2003");
            contrasenas.Add("131342004", "CAC2004");
            contrasenas.Add("070761980", "BDC1980");
        }

        //En el evento Click del botón Aceptar, sucederán varios procesos, entre ellos la validación de datos que se han ingresado y lo que
        //se ha chequeado en los radiobutton.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Se declaran dos variables de tipo string, la varible usuario almacenará lo que contenga txtUsuario.Text
            string usuario = txtUsuario.Text;
            //La variable tipoUsuario tendrá un valor vacío temporalmente, esto para poder devolver si el
            //usuario que se ha ingresado es Alumno o Empleado
            string tipoUsuario = "";
            string contrasena = txtContrasena.Text;

            //Para evaluar si el usuario es Alumno o Empleado, implementaremos una condición if,
            //la cual evaluará el radio button que se ha seleccionado.
            if (rbAlumno.Checked)
            {
                //Si rbAlumno ha sido seleccionado, tipoUsuario tendrá como valor "Alumno"
                tipoUsuario = "Alumno";
            }
            else if (rbEmpleado.Checked)
            {
                //Pero si rbEmpleado fue seleccionado, tipoUsuario será "Empleado"
                tipoUsuario = "Empleado";
            }
            if (contrasenas.ContainsKey(usuario) && contrasenas[usuario] == contrasena)
            {
                //Se implementará otra condición If, en la cual si el Dictionary usuarios contiene la key que se almacenó en la variable usuario
                // y también el Dictionary usuarios en la posición donde se encuentra el valor de la variable usuario es igual a tipo usuario,
                // se permitirá entrar al sistema.
                if (usuarios.ContainsKey(usuario) && usuarios[usuario] == tipoUsuario)
                {
                    //Si la condición se cumple, aparecerá un MessageBox donde dé la bienvenida al sistema.
                    MessageBox.Show("Bienvenido al sistema.", "Inicio | BecaTec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //La variable estática nombreUsuario tendrá asignado el valor que se encuentra en la linea
                    //de posición de lo que se escribió en txtUsuario
                    nombreUsuario = informacionUsuarios[txtUsuario.Text];
                    //A la variable estática tipoUsuarioConectado se le va a asignar el valor que se encuentre en tipoUsuario
                    tipoUsuarioConectado = tipoUsuario;

                    //Instanciamos la variable de tipo frmBecas que anteriormente se había declarado globalmente
                    becas = new frmBecas();
                    //Se oculta el form original (frmInicio) porque se ha abierto el frmBecas con su instanciación
                    this.Hide();
                    //respuesta guardará lo que se seleccionó en el formulario Becas con respecto a su DialogResult
                    DialogResult respuesta = becas.ShowDialog();
                    //Si la respuesta fue OK (en este caso si se seleccionó Salir), entonces el frmInicio se mostrará
                    //y lo que se había escrito anteriormente en los textbox se borrará para dar paso a nuevos datos.
                    if (respuesta == DialogResult.OK)
                    {
                        this.Show();
                        txtUsuario.Clear();
                        txtContrasena.Clear();
                    }
                    //si no, el frmBecas se mostrará
                    else
                    {
                        becas.Show();
                    }
                }

                //Si lo que se puso en el txtUsuario no se encuentra en el Dictionary usuarios y también, si no
                //se encuentra un usuario con el tipo de usuario que se ha seleccionado, entonces saltará un mensaje de error
                else
                {
                    MessageBox.Show("Error. Inténtelo de nuevo.", "Inicio | BecaTEc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
            //Si los datos colocados en txtUsuario y txtContrasena son incorrectos o no se encuentran en el Dictionary, saltará un mensaje de error.
            else
            {
                MessageBox.Show("Contraseña o Usuario incorrecto.Intentelo de nuevo.", "Inicio | BecaTEc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //El evento KeyPress en txtUsuario servirá para detectar si se ha presionado cierta tecla, en este caso no se permitirán
        //aquellas teclas que no sean numeros y el borrar
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Con una condición If se ingresan todos aquellos datos que no queremos (en este caso tocas aquellas teclas que no sean numeros),
            //esto con la numeración del codigo ASCII
            if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;
                //Si se presiona una tecla de las que se encuentran especificadas en el IF, un pequeño icono de advertencia saltará al
                //lado de txtUsuario, y por lo tanto también el mensaje del error que está ocurriendo
                epNumeros.SetError(txtUsuario, "Sólo se pueden ingresar números.");
                return;
            }
            //Si no cumple con la condición especificada en el if, mandamos otro invalidando el anterior.
            else
            {
                epNumeros.SetError(txtUsuario, "");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Al hacer click en btnSalir, el formulario se cerrará.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
