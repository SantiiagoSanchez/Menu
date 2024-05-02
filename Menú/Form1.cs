using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionaste esta fecha: " + dateTimePicker1.Value.Date);

            MessageBox.Show("La fecha de hoy es: " + DateTime.Now);
        }

        private void cambiarColorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Bold);
            this.label2.Font = new Font(this.label2.Font.FontFamily, this.label2.Font.Size, this.label2.Font.Style ^ FontStyle.Bold);
            this.label3.Font = new Font(this.label3.Font.FontFamily, this.label3.Font.Size, this.label3.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Italic);
            this.label2.Font = new Font(this.label2.Font.FontFamily, this.label2.Font.Size, this.label2.Font.Style ^ FontStyle.Italic);
            this.label3.Font = new Font(this.label3.Font.FontFamily, this.label3.Font.Size, this.label3.Font.Style ^ FontStyle.Italic);
        }

        private void strikeOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Strikeout);
            this.label2.Font = new Font(this.label2.Font.FontFamily, this.label2.Font.Size, this.label2.Font.Style ^ FontStyle.Strikeout);
            this.label3.Font = new Font(this.label3.Font.FontFamily, this.label3.Font.Size, this.label3.Font.Style ^ FontStyle.Strikeout);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Underline);
            this.label2.Font = new Font(this.label2.Font.FontFamily, this.label2.Font.Size, this.label2.Font.Style ^ FontStyle.Underline);
            this.label3.Font = new Font(this.label3.Font.FontFamily, this.label3.Font.Size, this.label3.Font.Style ^ FontStyle.Underline);

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();

            info.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
