using loginAbstract.Model;
using System;
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
            amountTextbox.Text = cant.ToString();
            autoComplete();
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

            amountTextbox.Text = cant.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cant > 1)
            {
                cant = --cant;
            }


            amountTextbox.Text = cant.ToString();

        }



        private int count = 0;



        private void crearVenta()
        {
            Panel panelInfo = new Panel();
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Size = new System.Drawing.Size(765, 74);
            panelInfo.Name = $"panelInfo_{count}";
            pan_principal.Controls.Add(panelInfo);
            panelInfo.BringToFront();

            System.Drawing.Color grayBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            System.Drawing.Color whiteBackground = System.Drawing.Color.White;

            //Delete Button

            Button deleteButton = new Button();
            deleteButton.BackColor = System.Drawing.Color.Transparent;
            deleteButton.BackgroundImage = global::loginAbstract.Properties.Resources.trash;
            deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteButton.ForeColor = System.Drawing.Color.Transparent;
            deleteButton.Location = new System.Drawing.Point(694, 24);
            deleteButton.Size = new System.Drawing.Size(22, 26);
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Name = $"deleteButton_{count}";


            deleteButton.Click += new System.EventHandler(this.deletePanel);

            //MessageBox.Show(deleteButton.Name);

            panelInfo.Controls.Add(deleteButton);

            //Total

            TextBox total = new TextBox();
            total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            total.Font = new System.Drawing.Font("Publica Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total.Location = new System.Drawing.Point(546, 27);
            total.Enabled = false;
            total.Multiline = true;
            total.Size = new System.Drawing.Size(102, 23);
            total.TabIndex = 42;
            total.Text = "300.000";
            panelInfo.Controls.Add(total);

            //Amount

            TextBox amount = new TextBox();
            amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            amount.Font = new System.Drawing.Font("Publica Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amount.Location = new System.Drawing.Point(459, 27);
            amount.Enabled = false;
            amount.Multiline = true;
            amount.Size = new System.Drawing.Size(55, 23);
            amount.Size = new System.Drawing.Size(55, 23);
            amount.Text = "1";
            panelInfo.Controls.Add(amount);

            //Unit Price

            TextBox unitPrice = new TextBox();
            unitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            unitPrice.Font = new System.Drawing.Font("Publica Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitPrice.Location = new System.Drawing.Point(313, 27);
            unitPrice.Enabled = false;
            unitPrice.Multiline = true;
            unitPrice.Size = new System.Drawing.Size(102, 23);
            unitPrice.Text = "300.000";
            panelInfo.Controls.Add(unitPrice);


            TextBox references = new TextBox();
            references.BorderStyle = System.Windows.Forms.BorderStyle.None;
            references.Font = new System.Drawing.Font("Publica Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            references.Location = new System.Drawing.Point(232, 27);
            references.Enabled = false;
            references.Multiline = true;
            references.Size = new System.Drawing.Size(61, 23);
            references.Text = "C40";
            panelInfo.Controls.Add(references);

            TextBox hash = new TextBox();
            int hashIndex = count + 1;
            hash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            hash.Font = new System.Drawing.Font("Publica Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hash.Location = new System.Drawing.Point(25, 27);
            hash.Enabled = false;
            hash.Size = new System.Drawing.Size(36, 23);
            hash.Text = hashIndex.ToString();
            panelInfo.Controls.Add(hash);


            TextBox product = new TextBox();
            product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            product.Font = new System.Drawing.Font("Publica Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product.Location = new System.Drawing.Point(81, 13);
            product.Enabled = false;
            product.Multiline = true;
            product.Size = new System.Drawing.Size(100, 46);
            product.Text = "Camisa Amarilla";
            panelInfo.Controls.Add(product);

            //Odd or Even BACKGROUND

            if (count % 2 == 0)
            {
                panelInfo.BackgroundImage = global::loginAbstract.Properties.Resources.space1;
                product.BackColor = whiteBackground;
                hash.BackColor = whiteBackground;
                references.BackColor = whiteBackground;
                unitPrice.BackColor = whiteBackground;
                total.BackColor = whiteBackground;

            }
            else
            {
                panelInfo.BackgroundImage = global::loginAbstract.Properties.Resources.space2;
                product.BackColor = grayBackground;
                hash.BackColor = grayBackground;
                references.BackColor = grayBackground;
                unitPrice.BackColor = grayBackground;
                total.BackColor = grayBackground;

            }


            count++;


        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            crearVenta();
        }



        //private void ElimnarPanel(string panel)
        //{
            


        //    var deletePanel = pan_principal.Controls.OfType<Panel>().
        //                              Where(c => c.Name == panel).
        //                              FirstOrDefault();


        //    deletePanel.Visible = false;
            
        //}



        private void deletePanel(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            btn.Parent.Visible = false;
        }









        private void button10_Click(object sender, EventArgs e)
        {

        }

        ABSTRACTEntities baseDatos = new ABSTRACTEntities();
        


        private void refSearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }


        void autoComplete()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            IEnumerable<string> productos = from p in baseDatos.PRODUCTOS
                                            orderby p.REFERENCIA
                                            select p.REFERENCIA;

            foreach (var a in productos)
            {
                lista.Add(a);
            }

            refSearchTextbox.AutoCompleteCustomSource = lista;
        }
    }
}
