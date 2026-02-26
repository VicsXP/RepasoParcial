using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoParcial
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Asistencia> asistencias = new List<Asistencia>();
        public Form1()
        {
            InitializeComponent();
        }
        private void LeerEmpleado()
        {

            string fileName = @"Empleados.txt";
            if (File.Exists(fileName))
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (reader.Peek() > -1)
                    {
                        //Lee 1 empleado del archivo en cada vuelta del ciclo
                        Empleado empleado = new Empleado();
                        empleado.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                        empleado.Nombre = reader.ReadLine();
                        empleado.Apellido = reader.ReadLine();
                        empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());

                        //Guardar el empleado en la lista
                        empleados.Add(empleado);
                    }
                }
            }
        }
        private void GuardarEmpleado()
        {
            using (FileStream stream = new FileStream(@"Empleados.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                foreach (var empleado in empleados)
                {
                    writer.WriteLine(empleado.NoEmpleado);
                    writer.WriteLine(empleado.Nombre);
                    writer.WriteLine(empleado.Apellido);
                    writer.WriteLine(empleado.SueldoHora);
                }
            }
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardar los del empleado
            Empleado empleado = new Empleado();
            empleado.NoEmpleado = Convert.ToInt16(numericUpDownEmpleado.Value);
            empleado.Nombre = textBoxNombre.Text;
            empleado.Apellido = textBoxApellido.Text;
            empleado.SueldoHora = numericUpDownSueldoHora.Value;

            //Guardar al empleado en la lista de empleados
            empleados.Add(empleado);

            //Guardar la lista de empleados en el archivo
            GuardarEmpleado();

            //Mostrar en pantalla
            Mostrar();
        }

        List<EmpleadosSueldo> CalcularSueldos()
        {
            var resultado =
                from a in asistencias
                join e in empleados
                on a.NoEmpleado equals e.NoEmpleado
                select new EmpleadosSueldo
                {
                    NombreCompleto = e.Nombre + " " + e.Apellido,
                    Mes = a.Mes,
                    HorasTrabajadas = a.HorasTrabajadas,
                    SueldoMensual = a.HorasTrabajadas * e.SueldoHora
                };

            return resultado.ToList();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void GuardarAsistencia()
        {
            using (FileStream stream = new FileStream("Asistencias.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                foreach (var a in asistencias)
                {
                    writer.WriteLine(a.NoEmpleado);
                    writer.WriteLine(a.HorasTrabajadas);
                    writer.WriteLine(a.Mes);
                }
            }
        }
        private void buttonGuardarAsistencia_Click(object sender, EventArgs e)
        {

            Asistencia a = new Asistencia();

            a.NoEmpleado = (int)numericUpDownNumEmpleado.Value;
            a.HorasTrabajadas = (int)numericUpDownHoras.Value;
            a.Mes = textBoxMes.Text;

            asistencias.Add(a);

            GuardarAsistencia();
        }
        private void MostrarSueldos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CalcularSueldos();
        }
    }
}