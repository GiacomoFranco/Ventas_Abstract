﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginAbstract
{
    public partial class newPurchaseAbstract : Form
    {
        public newPurchaseAbstract()
        {
            InitializeComponent();
            textBox6.Text = cant.ToString();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            newPurchaseAbstract purchase = new newPurchaseAbstract();
            purchase.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            informAbstract inform = new informAbstract();
            inform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            queryAbstract query = new queryAbstract();
            query.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            referencesAbstract references = new referencesAbstract();
            references.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAbstract login = new LoginAbstract();
            login.Show();
        }


        //CONTROLADOR NUMERIC UP & DOWN


        int cant = 1;

        private void button7_Click(object sender, EventArgs e)
        {
            cant = ++cant;

            textBox6.Text = cant.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cant > 1)
            {
                cant = --cant;
            }


            textBox6.Text = cant.ToString();
        }


        private int y = 0;
        private int count = 0;

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            
        }

    }
}
