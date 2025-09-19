using AppDesktop_FORMNETCORE_.Models;
using AppDesktop_FORMNETCORE_.Services;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop_FORMNETCORE_
{
    public partial class Form1 : Form
    {
        AlumnoClientService service = new();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            List<Alumno>? alumnos = await service.GetAll();
            dgvDatos.Rows.Clear();
            if (alumnos != null)
            {
                foreach (var a in alumnos)
                {
                    dgvDatos.Rows.Add([a.Id, a.Name, a.Age]);
                }
            }
            else
            {
                MessageBox.Show("Response fallido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(txtID.Text);        
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ingrese el id en el formato correcto.\n" + fe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Alumno? a = await BuscarAlumno(id);
            dgvDatos.Rows.Clear();
            if (a != null)
            {
                dgvDatos.Rows.Add([a.Id, a.Name, a.Age]);
            }
            else MessageBox.Show("No se encontro el alumno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LimpiarTextBoxs();
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            if (name != "" && age != "")
            {
                int intAge = 0;
                try
                {
                    intAge = Convert.ToInt32(age);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("La edad debe ser numerica.\n" + fe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (intAge > 0 && intAge <= 100)
                {
                    Alumno a = new()
                    {
                        Name = name,
                        Age = intAge
                    };
                    int createdId = await service.Post(a);
                    if (createdId != 0) MessageBox.Show($"Se creo el Alumno con la id {createdId}.", "Success", MessageBoxButtons.OK);
                    else MessageBox.Show("Error al crear el Alumno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarTextBoxs();
                }
                else MessageBox.Show("La edad debe ser entre 0 y 100.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Rellene los campos Nombre y Edad para ingresar un Alumno.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = 0;
            string name = "";
            int age = 0;
            FormMostrarInfo vtnMI = new();
            try
            {
                id = Convert.ToInt32(txtID.Text);
                name = txtName.Text;
                age = Convert.ToInt32(txtAge.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al convertir alguno/s de los datos, por favor ingrese los datos en el formato correcto.\n" + fe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (age > 0 && age <= 100 && name != "")
            {
                Alumno? a = await BuscarAlumno(id);
                if (a != null)
                {
                    string replacedString = vtnMI.labelPregunta.Text.Replace("-", "actualizar");
                    vtnMI.labelPregunta.Text = replacedString;
                    vtnMI.txtMostrar.Text = @$"Alumno
{"["}
{"{",5}
{$"\"Id\":{a.Id}",-20}
{$"\"Nombre\":\"{a.Name}\"",-20}
{$"\"Edad\":{a.Age}",-20}
{"}",5}
{"]"}";
                    if (vtnMI.ShowDialog() == DialogResult.OK)
                    {
                        bool r = await service.Update(new Alumno { Id = a.Id, Name = name, Age = age});
                        if (r) MessageBox.Show("El Alumno se actualizo con exito.", "Success", MessageBoxButtons.OK);
                        else MessageBox.Show("No se pudo actualizar el Alumno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LimpiarTextBoxs();
                }
                else MessageBox.Show("No se encontro el Alumno.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("La edad debe estar entre 0 y 100.\nEl nombre no puede estar vacio.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            FormMostrarInfo vtnMI = new();
            try
            {
                id = Convert.ToInt32(txtID.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ingrese el id en el formato correcto.\n" + fe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Alumno? a = await BuscarAlumno(id);
            if (a != null)
            {
                string replacedString = vtnMI.labelPregunta.Text.Replace("-", "actualizar");
                vtnMI.labelPregunta.Text = replacedString;
                vtnMI.txtMostrar.Text = @$"Alumno
{"["}
{"{",5}
{$"\"Id\":{a.Id}",-20}
{$"\"Nombre\":\"{a.Name}\"",-20}
{$"\"Edad\":{a.Age}",-20}
{"}",5}
{"]"}";
                if (vtnMI.ShowDialog() == DialogResult.OK)
                {
                    bool r = await service.Delete(a.Id);
                    if (r) MessageBox.Show("El Alumno se elimino con exito.", "Success", MessageBoxButtons.OK);
                    else MessageBox.Show("No se pudo eliminar el Alumno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiarTextBoxs();
            }
            else MessageBox.Show("No se encontro el Alumno.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async Task<Alumno?> BuscarAlumno(int id)
        {
            Alumno? a = null;
            try
            {
                if (id > 0)
                {
                    a = await service.GetById(id);
                }
                else MessageBox.Show("El ID debe ser positivo o mayor a 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al convertir el id.\n" + fe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
            return a;
        }
        
        private void LimpiarTextBoxs()
        {
            txtID.Clear();
            txtAge.Clear();
            txtName.Clear();
        }
    }
}
