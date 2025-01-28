using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KineFive
{
    public partial class Form1 : Form
    {
        int Angle1 => int.Parse(tbMotor1.Text);
        int Angle2 => int.Parse(tbMotor2.Text);
        int Angle3 => int.Parse(tbMotor3.Text);
        int Angle4 => int.Parse(tbMotor4.Text);
        int Angle5 => int.Parse(tbMotor5.Text);
        int Gripper => int.Parse(tbMotor6.Text);
        

        public Form1()
        {
            InitializeComponent();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                object[] row = new object[] { Angle1, Angle2, Angle3, Angle4, Angle5, Gripper };
                dgvPose.Rows.Add(row);
                MessageBox.Show("Renglon agregado exitosamente", "Renglon agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Se detectó una excepción \n \r {err.Message}", "Error al agregar registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPose_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMotor1.Text = dgvPose[0, e.RowIndex].Value.ToString();
            tbMotor2.Text = dgvPose[1, e.RowIndex].Value.ToString();
            tbMotor3.Text = dgvPose[2, e.RowIndex].Value.ToString();
            tbMotor4.Text = dgvPose[3, e.RowIndex].Value.ToString();
            tbMotor5.Text = dgvPose[4, e.RowIndex].Value.ToString();
            tbMotor6.Text = dgvPose[5, e.RowIndex].Value.ToString();

            MessageBox.Show($"El renglón \n{e.RowIndex} a sido vaciado", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
