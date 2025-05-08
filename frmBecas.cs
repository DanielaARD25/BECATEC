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
    public partial class frmBecas : Form
    {
        //    Nombre de práctica. BecaTEc
        //    Tema de referencia. Eventos.
        //    Objetivo de la práctica. DESARROLLAR E IMPLEMENTAR UNA APLICACIÓN PARA WINDOWS FORMS,
        //                             HACIENDO USO DEL LENGUAJE DE PROGRAMACIÓN C# Y EL IDE VISUAL STUDIO
        //                             COMMUNITY EDITION(2015+), QUE PERMITA IDENTIFICAR LAS BECAS
        //                             DISPONIBLES PARA LOS ALUMNOS DEL INSTITUTO.
        //    Materia. Tópicos Avanzados de Programación
        //    Alumno. Daniela Ailyn Rodriguez Diaz
        frmInformacionBeca informacionBeca = new frmInformacionBeca();

        public frmBecas()
        {
            InitializeComponent();
        }

        //En el evento Load de frmBecas se realizan distintas acciones que aparecerán en la frmBecas
        private void frmBecas_Load(object sender, EventArgs e)
        {
            //La tool strip status label llamada nombreUsuario será igual al nombre guardado
            //en la variable estática nombreUsuario, que se encuentra en el frmInicio
            tsslnombreUsuario.Text = frmInicio.nombreUsuario;
            //se define la imagen que se mostrará en el status label
            tsslnombreUsuario.Image = Properties.Resources.verified_FILL1_wght400;
            //de igual manera que en la variable estática tipoUsuario, se le asigna el valor de la variable estática tipoUsuarioConectado
            tsslTipoUsuario.Text = frmInicio.tipoUsuarioConectado;
            //Se crea una condición en la que si tipoUsuarioConectado es igual a "Alumno", entonces se agregará cierta imagen de identificación
            if(frmInicio.tipoUsuarioConectado=="Alumno")
            {
                tsslTipoUsuario.Image = Properties.Resources.person_FILL0;
            }
            //Pero si tipoUsuarioConectado es igual a "Empleado", entonces será otra imagen diferente de identificación
            else if(frmInicio.tipoUsuarioConectado =="Empleado")
            {
                tsslTipoUsuario.Image = Properties.Resources.supervisor_account_FILL0;
            }
        }

        // El evento click de tsmiSalir sirve para que cuando se seleccione la opción de salir, guarde el DialogResult y
        // pueda utilizarse en el primer formulario y regresar a este.
        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //Es para cerrar el formulario una vez que se haya seleccionado el Salir
            this.Close();
        }

        private void btnDeportiva_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        //Con un evento MouseEnter hacemos posible que al pasar el mouse sobre el botón, se abra otro formulario
        private void btnDeportiva_MouseEnter(object sender, EventArgs e)
        {
            //En el form agregamos un control llamado ToolTrip, que lo que hace es mostrar información cuando el mouse se coloca
            //sobre un control. En este caso lo mandamos a llamar y con un punto accedemos a la propiedad SetToolTrip, en la que designamos
            //cual control va a mostrar información y el texto que va a contener, en este caso será un valor vacío.
            ttInformacion.SetToolTip(btnDeportiva, "");
            //con la instancia del formulario que se va a mostrar, accedemos a la propiedad de su ubicación en pantalla,
            //ahí modificamos su posición de las X y Y
            informacionBeca.Location = new Point(this.Location.X+570,this.Location.Y);
            //se muestra el formulario de la información con un Show
            informacionBeca.Show();
            //Accederemos a las propiedades de los controles del formulario que queremos abrir para modificar su información.
            //En el diseño se encuentra una label vacía, y en cada botón la información de esta label irá cambiando.
            informacionBeca.lbInformacionBeca.Text = "La Beca Deportiva va dirigida para estudian-\n" +
                                                     "tes del instituto que en estos momentos perte-\n" +
                                                     "nezcan a un club o selectivo perteneciente a la\n" +
                                                     "institución que esté relacionado a este ámbito.\n" +
                                                     "También que de alguna manera sobresalgan por \n" +
                                                     "encima de otros estudiantes. Esta beca busca \n" +
                                                     "impulsar a los jóvenes estudiantes deportistas\n" +
                                                     "tanto en sus estudios como en lo que los apa-\n" +
                                                     "siona,el deporte. Es así por lo cual se les \n" +
                                                     "proporciona cierto monto que puede ser descon-\n" +
                                                     "tado de su colegiatura.";
            //De la misma forma que en la linea anterior, se accede a la propiedad de imagen de los picture box y se modifica la imagen
            informacionBeca.pbImagen.Image = Properties.Resources.BecaDeportiva;
            informacionBeca.pbNombre.Image = Properties.Resources.BecaDeportivaLetra;
        }

        //De la misma forma, con un MouseLeave haremos que el formulario anteriormente abierto en el MouseEnter se
        //cierre una vez que el mouse se vaya de la zona del botón. Para eso se usa un Hide.
        private void btnDeportiva_MouseLeave(object sender, EventArgs e)
        {
            informacionBeca.Hide();
        }

        //Lo realizado en btnDeportiva_MouseEnter y btnDeportiva_MouseLeave se vuelve a realizar en
        //cada botón y los valores de los controles se modifican dependiendo de la beca de la que se esté hablando

        public void btnAcademica_MouseEnter(object sender, EventArgs e)
        {
            ttInformacion.SetToolTip(btnAcademica, "");
            informacionBeca.Location = new Point(this.Location.X + 570, this.Location.Y);
            informacionBeca.Show();
            informacionBeca.lbInformacionBeca.Text = "La Beca Académica va a dirigida a estudiantes \n" +
                                                     "pertenecientes al instituto que cursen un se-\n" +
                                                     "mestre actualmente. Para poder postular,estos \n" +
                                                     "estudiantes deben de contar con un promedio \n" +
                                                     "general mínimo de 85 (sin redondear) y máxi-\n" +
                                                     "mo de 94. Esta beca busca ayudar a los jóve-\n" +
                                                     "nes que se empeñan para poder impulsarlos en \n" +
                                                     "seguir estudiando. Es por eso por lo que la \n" +
                                                     "beca ofrece un descuento en el pago de reins-\n" +
                                                     "cripción, todo dependiendo del promedio con \n" +
                                                     "el que cuente.";
            informacionBeca.pbImagen.Image = Properties.Resources.BecaAcadémica;
            informacionBeca.pbNombre.Image = Properties.Resources.BecaAcademicaLetra;
        }

        private void btnAcademica_MouseLeave(object sender, EventArgs e)
        {
            informacionBeca.Hide();
        }

        private void btnExcelencia_MouseEnter(object sender, EventArgs e)
        {
            ttInformacion.SetToolTip(btnExcelencia, "");
            informacionBeca.Location = new Point(this.Location.X+570, this.Location.Y);
            informacionBeca.Show();
            informacionBeca.lbInformacionBeca.Text = "La Beca de Excelencia está diseñada para estudi-\n" +
                                                     "antes del instituto que en estos momentos cuenten\n" +
                                                     "con un excelente desempeño académico durante \n" +
                                                     "su estadía en esta institución. Los estudiantes\n" +
                                                     "que decidan postular a esta beca, deberán contar\n" +
                                                     "con un promedio de 95 a 100 (sin redondear). Con\n" +
                                                     "esta beca, la institución tiene como objetivo brindar\n" +
                                                     "apoyo a aquellos estudiantes que se han esforzado y \n" +
                                                     "desempeñado de una manera excepcional.Es así \n" +
                                                     "por lo cual se les proporciona cierto monto que \n" +
                                                     "puede ser descontado de su colegiatura.";
            informacionBeca.pbImagen.Image = Properties.Resources.BecaExcelencia;
            informacionBeca.pbNombre.Image = Properties.Resources.BecaExcelenciaLetra;
        }
        private void btnExcelencia_MouseLeave(object sender, EventArgs e)
        {
            informacionBeca.Hide();
        }

        private void btnManuntencion_MouseEnter(object sender, EventArgs e)
        {
            ttInformacion.SetToolTip(btnManuntencion, "");
            informacionBeca.Location = new Point(this.Location.X + 570, this.Location.Y);
            informacionBeca.Show();
            informacionBeca.lbInformacionBeca.Text = "La Beca de Manutención es proporcionada por \n" +
                                                     "el gobierno Mexicano. Y busca que todos los\n" +
                                                     "estudiantes de la república cuenten con un\n" +
                                                     "apoyo para seguir costeando sus estudios.\n" +
                                                     "Esta beca se ofrece en prioridad para los\n" +
                                                     "estudiantes en zonas vulnerables, sin em-\n" +
                                                     "bargo también es posible postular en zonas\n" +
                                                     "no tan vulnerables y es posible obtenerla\n" +
                                                     "según la cantidad de cupos disponibles.\n" +
                                                     "Esta beca proporciona a los beneficiarios\n" +
                                                     "un monto de $2500 pesos al mes.";
            informacionBeca.pbImagen.Image = Properties.Resources.BecaManutencion;
            informacionBeca.pbNombre.Image = Properties.Resources.BecaManutencionLetra;
        }

        private void btnManuntencion_MouseLeave(object sender, EventArgs e)
        {
            informacionBeca.Hide();
        }


    }
}
