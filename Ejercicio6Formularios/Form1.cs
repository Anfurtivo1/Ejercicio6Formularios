using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txaArticulo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debes escribir un articulo","Error",MessageBoxButtons.OK);
            }
            else
            {
                int i;
                i = this.lbArticulos.FindStringExact(this.txaArticulo.Text);

                if (i==-1)
                {
                    MessageBox.Show("Ese articulo no esta en la lista", "Informacion", MessageBoxButtons.OK);
                }
                else
                {
                    this.lbArticulos.SelectedIndex = i;
                }

            }
        }

        private void btnSeleccionarElemento_Click(object sender, EventArgs e)
        {
            if (this.txaArticulo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debes escribir un articulo", "Error", MessageBoxButtons.OK);
            }
            else
            {
                int numero=2;
                bool success = Int32.TryParse(txaArticulo.Text, out numero);

                if (success)
                {
                    int i;
                    i = Convert.ToInt32(this.txaArticulo.Text);
                    if (i > 0 && i < this.lbArticulos.Items.Count)
                    {
                        this.lbArticulos.SetSelected(i - 1, true);
                    }
                }
                else
                {
                    MessageBox.Show("Indica un numero valido", "Error", MessageBoxButtons.OK);
                }

            }
                
            }

        private void btnTrasladarIzq_Click(object sender, EventArgs e)
        {
            while (this.lbArticulos.SelectedItems.Count>0)
            {
                this.lbArticulosTraspasados.Items.Add(this.lbArticulos.SelectedItems[0]);
                this.lbArticulos.Items.Remove(this.lbArticulos.SelectedItems[0]);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbArticulosTraspasados.Items.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbArticulos.Items.Add(this.txaArticulo.Text);
        }

        private void chBOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            if (chBOrdenar.Checked)
            {
                lbArticulos.Sorted = true;
            }

            if (!chBOrdenar.Checked)
            {
                lbArticulos.Sorted = false;
            }

        }

        private void chBMostrarColumnas_CheckedChanged(object sender, EventArgs e)
        {
            if (chBMostrarColumnas.Checked)
            {
                lbArticulos.MultiColumn = true;
            }

            if (!chBMostrarColumnas.Checked)
            {
                lbArticulos.MultiColumn = false;
            }
        }

        private void rbtnSimple_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSimple.Checked)
            {
                lbArticulos.SelectionMode(One);
            }

            if (!rbtnSimple.Checked)
            {
                lbArticulos.MultiColumn = false;
            }
        }
    }
}
