using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Layer;

namespace Crud
{
    public partial class Form1 : Form
    {
        AlumnoBL bl = new AlumnoBL();
        BindingList<AlumnoDto> alumnoDataSource = new BindingList<AlumnoDto>();
        List<AlumnoDto> TempInsert = new List<AlumnoDto>();
        List<AlumnoDto> TempEdit = new List<AlumnoDto>();
        List<AlumnoDto> TempDelete = new List<AlumnoDto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           CargarGrilla();
        }

        private void btnRegsitrar_Click(object sender, EventArgs e)
        {
            alumnoDataSource.AddNew();
            gtSalida.Rows[gtSalida.Rows.Count - 1].Cells["RegType"].Value = "Temp";
        }

        void CargarGrilla ()
        {
            alumnoDataSource = bl.ListarAlumnos();
            gtSalida.DataSource = alumnoDataSource;

            foreach (DataGridViewRow Fila in gtSalida.Rows)
            {
                Fila.Cells["RegType"].Value = "NoTemp";
            }
        }

        private void gtSalida_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                if (gtSalida.Rows[e.RowIndex].Cells["RegType"].Value != null)
                {
                    gtSalida.Rows[e.RowIndex].Cells["RegStatus"].Value = "Edited";
                }
            }
        }
        void LlenarTemporales()
        {
            foreach(DataGridViewRow Fila in gtSalida.Rows)
                if (Fila.Cells["RegStatus"].Value != null && Fila.Cells["RegStatus"].Value == "Edited")
                {
                    AlumnoDto Alumno = new AlumnoDto();
                    switch (Fila.Cells["RegType"].Value.ToString())
                    {
                        case"NoTemp":
                            Alumno.id_alumno = int.Parse(Fila.Cells["id_alumno"].Value.ToString());
                            Alumno.FechaNacimiento = Fila.Cells["FechaNacimiento"].Value != null ? DateTime.Parse(Fila.Cells["FechaNacimiento"].Value.ToString()) : DateTime.Today;
                            Alumno.Nombre = Fila.Cells["Nombre"].Value != null ? Fila.Cells["Nombre"].Value.ToString() : "NN";
                            Alumno.Apellido = Fila.Cells["Apellido"].Value != null ? Fila.Cells["Apellido"].Value.ToString() : "NN";
                            Alumno.Telefono = Fila.Cells["Telefono"].Value != null ? Fila.Cells["Telefono"].Value.ToString() : "000000000";
                            TempEdit.Add(Alumno);
                        break;
                        case "Temp":
                        
                        Alumno.FechaNacimiento = Fila.Cells["FechaNacimiento"].Value != null ? DateTime.Parse(Fila.Cells["FechaNacimiento"].Value.ToString()) : DateTime.Today;
                        Alumno.Nombre = Fila.Cells["Nombre"].Value != null ? Fila.Cells["Nombre"].Value.ToString() : "NN";
                        Alumno.Apellido = Fila.Cells["Apellido"].Value != null ? Fila.Cells["Apellido"].Value.ToString() : "NN";
                        Alumno.Telefono = Fila.Cells["Telefono"].Value != null ? Fila.Cells["Telefono"].Value.ToString() : "000000000";
                        TempInsert.Add(Alumno);
                        break;
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gtSalida.SelectedRows.Count != 0)
            {
                if (gtSalida.Rows[gtSalida.SelectedRows[0].Index].Cells["RegType"].Value.ToString() == "NoTemp")
                {
                    AlumnoDto Alumno = new AlumnoDto();
                    Alumno.id_alumno = int.Parse(gtSalida.Rows[gtSalida.SelectedRows[0].Index].Cells["id_alumno"].Value.ToString());
                    TempDelete.Add(Alumno);
                    gtSalida.Rows.Remove(gtSalida.Rows[gtSalida.SelectedRows[0].Index]);
                }
                else
                {
                    gtSalida.Rows.Remove(gtSalida.Rows[gtSalida.SelectedRows[0].Index]);
                }
            
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            LlenarTemporales();
            bl.ActulizarAlumno(TempInsert,TempEdit,TempDelete);
            CargarGrilla();
            TempInsert = new List<AlumnoDto>();
            TempEdit = new List<AlumnoDto>();
            TempDelete = new List<AlumnoDto>();
        }

    }
}
