using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassHerenciaVSJL.Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void EmpleadoradioButton_CheckedChanged(object sender, EventArgs e)
        {
            codEmptextBox.Enabled = true;
            DirecciontextBox.Enabled = true;
            NITtextBox.Enabled = false;
            ProcedenciatextBox.Enabled = false;
        }

        private void ClienteradioButton_CheckedChanged(object sender, EventArgs e)
        {
            NITtextBox.Enabled = true;
            ProcedenciatextBox.Enabled = true;
            codEmptextBox.Enabled = false;
            DirecciontextBox.Enabled = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            EmpleadoradioButton.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ClienteradioButton.Checked == true)
            {
                
                    if (nombretextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Llene todos los campos");
                    }
                    else if (apellidotextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Llene todos los campos");
                    }
                    else if (CItextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Llene todos los campos");
                    }
                    else
                    {
                       try
                       {
                        Clases.Cliente cli = new Clases.Cliente();
                        cli.Nombre1 = nombretextBox.Text;
                        cli.Apellido1 = apellidotextBox.Text;
                        cli.CI1 = CItextBox.Text;
                        cli.NIT1 = NITtextBox.Text;
                        cli.Procedencia1 = ProcedenciatextBox.Text;
                        dataGridView1.Rows.Add(cli.Nombre1, cli.Apellido1, cli.CI1, cli.NIT1, cli.Procedencia1);
                        }
                         catch (InvalidExpressionException)
                        {
                            MessageBox.Show("err");
                        }
                }
            }
            else if (EmpleadoradioButton.Checked == true)
            {
                
                    if (nombretextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Llene todos los campos");
                    }
                    else if (apellidotextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Llene todos los campos");
                    }
                    else if (CItextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Llene todos los campos");
                    }
                    else
                    {
                        try
                        {
                            Clases.Empleado emp = new Clases.Empleado();
                            emp.Nombre1 = nombretextBox.Text;
                            emp.Apellido1 = apellidotextBox.Text;
                            emp.CI1 = CItextBox.Text;
                            emp.CodEmpleado = Convert.ToInt32(codEmptextBox.Text);
                            emp.Direccion1 = DirecciontextBox.Text;
                            dataGridView2.Rows.Add(emp.Nombre1, emp.Apellido1, emp.CI1, Convert.ToString(emp.CodEmpleado), emp.Direccion1);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Error! El codigo del empleado tiene que ser un numero");
                        }
                    }
            }
        }
    }
}
