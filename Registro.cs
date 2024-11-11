using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Registro : Form
    {
        List<alumno> alumnos = new List<alumno>();

        string expediente;
        public Registro(string exp)
        {
            expediente = exp;
            InitializeComponent();
            label1.Text = "EXPEDIENTE: " + exp;
        }

        private void facultadbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carrerasbox.Items.Clear();
            switch (facultadbox.SelectedItem.ToString())
            {
                case "Bellas Artes":
                    carrerasbox.Items.Add("Licenciatura en Actuación");
                    carrerasbox.Items.Add("Licenciatura en Arte Danzario");
                    carrerasbox.Items.Add("Licenciatura en Artes Visuales");
                    carrerasbox.Items.Add("Licenciatura en Composición Musical");
                    carrerasbox.Items.Add("Licenciatura en Danza Folklórica Mexicana");
                    carrerasbox.Items.Add("Licenciatura en Diseño y Comunicación Visual");
                    carrerasbox.Items.Add("Licenciatura en Docencia del Arte");
                    carrerasbox.Items.Add("Licenciatura en Música");
                    carrerasbox.Items.Add("Licenciatura en Música Popular Contemporanea");
                    carrerasbox.Items.Add("Licenciatura en Restauración de Bienes Muebles");
                    carrerasbox.Items.Add("Licenciatura en Realización Cinematográfica");
                    break;
                case "Contaduría y administración":
                    carrerasbox.Items.Add("Contador Público");
                    carrerasbox.Items.Add("Licenciatura en Actuaría");
                    carrerasbox.Items.Add("Licenciatura en Administración");
                    carrerasbox.Items.Add("Licenciatura en Administración Financiera");
                    carrerasbox.Items.Add("Licenciatura en Economía Empresarial");
                    carrerasbox.Items.Add("Licenciatura en Gestión y Desarrollo de Empresas Sociales");
                    carrerasbox.Items.Add("Licenciatura en Gestión del Turismo Cultural y Natural");
                    carrerasbox.Items.Add("Licenciatura en Negocios y Comercio Internacional");
                    carrerasbox.Items.Add("Licenciatura en Negocios Turisticos");
                    break;
                case "Derecho":
                    carrerasbox.Items.Add("Licenciatura en Ciencias de la Seguridad");
                    carrerasbox.Items.Add("Licenciatura en Criminología");
                    carrerasbox.Items.Add("Licenciatura en Derecho");
                    break;
                case "Ciencias naturales":
                    carrerasbox.Items.Add("Licenciatura en Biología");
                    carrerasbox.Items.Add("Licenciatura en Geografía Ambiental");
                    carrerasbox.Items.Add("Licenciatura en Horticultura Ambiental");
                    carrerasbox.Items.Add("Licenciatura en Microbiología");
                    carrerasbox.Items.Add("Licenciatura en Nutrición");
                    carrerasbox.Items.Add("Licenciatura en Medicina Veterinaria y Zootecnia");
                    carrerasbox.Items.Add("Licenciatura en Produccion Agropecuaria Sustentable");
                    break;
                case "Ciencias políticas y sociales":
                    carrerasbox.Items.Add("Licenciatura en Desarrollo Local");
                    carrerasbox.Items.Add("Licenciatura en Ciencias Políticas y Administración Pública");
                    carrerasbox.Items.Add("Licenciatura en Comunicación y Periodismo");
                    carrerasbox.Items.Add("Licenciatura en Gestión Pública y Gobierno");
                    carrerasbox.Items.Add("Licenciatura en Relaciones Internacionales");
                    carrerasbox.Items.Add("Licenciatura en Sociología");
                    break;
                case "Enfermería":
                    carrerasbox.Items.Add("Licenciatura en Educación Física y Ciencias del Deporte");
                    carrerasbox.Items.Add("Licenciatura en Enfermería");
                    carrerasbox.Items.Add("Licenciatura en Fisioterapia");
                    carrerasbox.Items.Add("Licenciatura en Enfermería por Nivelación");
                    break;
                case "Filosofía":
                    carrerasbox.Items.Add("Licenciatura en Filosofía");
                    carrerasbox.Items.Add("Licenciatura en Historia");
                    carrerasbox.Items.Add("Licenciatura en Antropología");
                    carrerasbox.Items.Add("Licenciatura en Desarrollo Hunamo pra la Sustentabilidad");
                    carrerasbox.Items.Add("Licenciatura en Gastronomía");
                    carrerasbox.Items.Add("Licenciatura en Educación y Mediación Intercultural");
                    carrerasbox.Items.Add("Licenciatura en Humanidades y producción de Imágenes");
                    break;
                case "Informática":
                    carrerasbox.Items.Add("Licenciatura en Informática");
                    carrerasbox.Items.Add("Licenciatura en Administración de las T.I.");
                    carrerasbox.Items.Add("Ingeniería de Software");
                    carrerasbox.Items.Add("Ingeniería en Computación");
                    carrerasbox.Items.Add("Ingeniería en Telecomunicaciones y Redes ");
                    carrerasbox.Items.Add("Ingeniería en Ciencia y Analítica de Datos");
                    carrerasbox.Items.Add("Ingeniería en Tecnologias de Información y Ciberseguirdad");
                    break;
                case "Ingeniería":
                    carrerasbox.Items.Add("Ingeniería en Mecánica y Automotriz");
                    carrerasbox.Items.Add("Ingeniería Física");
                    carrerasbox.Items.Add("Ingeniería Agroindustrial");
                    carrerasbox.Items.Add("Ingeniería Civil");
                    carrerasbox.Items.Add("Ingeniería Industrial y Manufactura");
                    carrerasbox.Items.Add("Ingeniería Electromecánica");
                    carrerasbox.Items.Add("Ingeniería en Automatización");
                    carrerasbox.Items.Add("Ingeniería en Nanotecnologiá");
                    carrerasbox.Items.Add("Licenciatura en Matemáticas Aplicadas");
                    carrerasbox.Items.Add("Licenciatura en Diseño Industrial");
                    carrerasbox.Items.Add("Licenciatura en Arquitectura");
                    carrerasbox.Items.Add("Licenciatura en Animación Digital y Medios Interactivos");
                    carrerasbox.Items.Add("Ingeniería Biomédica");
                    break;
                case "Lenguas y letras":
                    carrerasbox.Items.Add("Licenciatura en Lenguas Modernas en Español");
                    carrerasbox.Items.Add("Licenciatura en Estudios Literarios");
                    carrerasbox.Items.Add("Licenciatura en Lenguas Modernas en Francés");
                    carrerasbox.Items.Add("Licenciatura en Lenguas Modernas en Inglés");
                    carrerasbox.Items.Add("Profesor Asociado en la Enseñanza de Lenguas");
                    break;
                case "Medicina":
                    carrerasbox.Items.Add("Licenciatura en Medicina General");
                    carrerasbox.Items.Add("Licenciatura en Odontología");
                    carrerasbox.Items.Add("Licenciatura en Optometría");
                    break;
                case "Psicología":
                    carrerasbox.Items.Add("Licenciatura en Psicología");
                    carrerasbox.Items.Add("Licenciatura en Psicología Educativa");
                    carrerasbox.Items.Add("Licenciatura en Psicología del Trabajo");
                    carrerasbox.Items.Add("Licenciatura en Psicología Social");
                    carrerasbox.Items.Add("Licenciatura en Innovación y Gestión Educativa");
                    break;
                case "Química":
                    carrerasbox.Items.Add("Licenciatura en Ingeniería Química Ambiental");
                    carrerasbox.Items.Add("Licenciatura en Químico Farmacéutico Biólogo");
                    carrerasbox.Items.Add("Licenciatura en Ingeniería Química en Materiales");
                    carrerasbox.Items.Add("Licenciatura en Ingeniería Química en Alimentos");
                    carrerasbox.Items.Add("Ingeniería en Biotecnología");
                    carrerasbox.Items.Add("Licenciatura en Ingeniería en Agrobiotecnología");
                    break;
                default:
                    carrerasbox.Items.Clear();
                    break;
            }
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptarbutton_Click(object sender, EventArgs e)
        {
            bool estelefono = double.TryParse(telefonobox.Text.ToString(),out _);
            if (telefonobox.Text.Length != 10)
                estelefono = false;

            if (nombres.Text == null || apellidos.Text == null || facultadbox.Text == null || carrerasbox.Text == null || !estelefono || NIPbox.Text == null)
                errorlabel.Text = "Datos erroneos o incompletos";
            else
            {
                alumno.iniciar_alumnos(alumnos);
                alumnos.Add(new alumno(expediente, NIPbox.Text, nombres.Text + ' ' + apellidos.Text, telefonobox.Text, carrerasbox.Text, facultadbox.Text, "000", "000", "000", "000", "000"));
                alumno.guardar_alumnos(alumnos);
                MessageBox.Show("Alumno registrado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
