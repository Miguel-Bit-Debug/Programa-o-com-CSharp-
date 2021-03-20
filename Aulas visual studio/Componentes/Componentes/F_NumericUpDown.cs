﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            try {

                if (Decimal.Parse(tb_valor.Text) >= numericUpDown1.Minimum && Decimal.Parse(tb_valor.Text) <= numericUpDown1.Maximum)
                {
                    numericUpDown1.Value = Decimal.Parse(tb_valor.Text);
                    //numericUpDown1.Value = int.Parse(tb_valor.Text);
                    tb_valor.Clear();
                    tb_valor.Focus();
                }

            } catch
            {
                MessageBox.Show("Erro!");
                tb_valor.Clear();
                tb_valor.Focus();
            }
        }
    }
}