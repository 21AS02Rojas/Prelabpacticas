using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prelabpacticas
{
    public partial class Form2 : Form
    {

        private int elecc = 1; // Inicializada en 1
        public Form2()
        {
            InitializeComponent();
        }

        private void cREDITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 cambio1=new Form3(); // Crea una nueva instancia de Form3
            cambio1.Show();// Muestra el Form3
            this.Hide(); // Oculta el formulario actual
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            elecc=e.RowIndex;

            if (elecc >= 0) // Almacena el índice de la fila click
            {
                DataGridViewRow row = dataGridView1.Rows[elecc]; // Verifica que se haya seleccionado una fila válida

                textBox1.Text = row.Cells[0].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox2.Text = row.Cells[1].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox3.Text = row.Cells[2].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox4.Text = row.Cells[3].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox5.Text = row.Cells[4].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox6.Text = row.Cells[5].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox7.Text = row.Cells[6].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox8.Text = row.Cells[7].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox9.Text = row.Cells[8].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox10.Text = row.Cells[9].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
                textBox11.Text = row.Cells[10].Value?.ToString(); // Asigna los valores de cada celda de la fila a los TextBox correspondientes
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[] row = new string[]
                {
                    textBox1.Text,
                    textBox2.Text,
                    textBox3.Text,
                    textBox4.Text,
                    textBox5.Text,
                    textBox6.Text,
                    textBox7.Text,
                    textBox8.Text,
                    textBox9.Text,
                    textBox10.Text,
                    textBox11.Text
                };
            dataGridView1.Rows.Add(row); // Agrega una nueva fila al DataGridView con los valores
            LimpiarCampos(); // Limpia los TextBox
        }

        private void LimpiarCampos() {

            textBox1.Clear(); //Limpia el textbox
            textBox2.Clear(); //Limpia el textbox
            textBox3.Clear(); //Limpia el textbox
            textBox4.Clear(); //Limpia el textbox
            textBox5.Clear(); //Limpia el textbox
            textBox6.Clear(); //Limpia el textbox
            textBox7.Clear(); //Limpia el textbox
            textBox8.Clear(); //Limpia el textbox
            textBox9.Clear(); //Limpia el textbox
            textBox10.Clear(); //Limpia el textbox
            textBox11.Clear(); //Limpia el textbox

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (elecc>=0) // Verifica que haya una fila seleccionada
            {
                dataGridView1.Rows[elecc].SetValues(
                   textBox1.Text,
                   textBox2.Text,
                   textBox3.Text,
                   textBox4.Text,
                   textBox5.Text,
                   textBox6.Text,
                   textBox7.Text,
                   textBox8.Text,
                   textBox9.Text,
                   textBox10.Text,
                   textBox11.Text
                    
                    ); // Actualiza los valores de la fila seleccionada con los valores de los TextBox
                LimpiarCampos();// Limpia los TextBox

            }
            else
            {
                MessageBox.Show("Elige la casilla/ o fila que quieras editar"); //Muestra un mensaje al no cumplir la condicion
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (elecc>=0) // Verifica que haya una fila seleccionada
            {
                dataGridView1.Rows.RemoveAt(elecc); // Elimina la fila seleccionada
                elecc = 1; // Restablece el índice de selección
                LimpiarCampos(); LimpiarCampos(); // Limpia los TextBox
            }
            else
            {
                MessageBox.Show("Elige la casilla/fila para eliminarla"); //Muestra un mensaje al no cumplir la condicion
            }
        }
    }
}
