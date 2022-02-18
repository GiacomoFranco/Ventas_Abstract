using loginAbstract.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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

        private int cant = 1;

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





        //____________________________________________________________________________

        private int count = 0;
        private int totalCost = 0;
        private int numCompra = 1;


        private void crearVenta()
        {
            if (refSearchTextbox.Text != "")
            {



                Panel panelInfo = new Panel();
                panelInfo.Dock = DockStyle.Top;
                panelInfo.Size = new System.Drawing.Size(765, 74);
                panelInfo.Name = "panelInfo";
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
                total.Text = (Int32.Parse(amountTextbox.Text) * Int32.Parse(priceTextbox.Text)).ToString();
                totalCost += Int32.Parse(total.Text);
                total.Name = "totalLbl";


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
                amount.Text = amountTextbox.Text;
                amount.Name = "amountLbl";
                panelInfo.Controls.Add(amount);

                //Unit Price

                TextBox unitPrice = new TextBox();
                unitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
                unitPrice.Font = new System.Drawing.Font("Publica Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                unitPrice.Location = new System.Drawing.Point(313, 27);
                unitPrice.Enabled = false;
                unitPrice.Multiline = true;
                unitPrice.Size = new System.Drawing.Size(102, 23);
                unitPrice.Text = priceTextbox.Text;
                unitPrice.Name = "UPriceLbl";
                panelInfo.Controls.Add(unitPrice);


                TextBox references = new TextBox();
                references.BorderStyle = System.Windows.Forms.BorderStyle.None;
                references.Font = new System.Drawing.Font("Publica Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                references.Location = new System.Drawing.Point(232, 27);
                references.Enabled = false;
                references.Multiline = true;
                references.Size = new System.Drawing.Size(61, 23);
                references.Text = refSearchTextbox.Text;
                references.Name = "refLbl";
                panelInfo.Controls.Add(references);

                TextBox hash = new TextBox();
                int hashIndex = numCompra;
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
                product.Location = new System.Drawing.Point(70, 13);
                product.Enabled = false;
                product.Multiline = true;
                product.Size = new System.Drawing.Size(150, 46);
                product.Text = productTextbox.Text;
                product.Name = "productLbl";
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
            else
            {
                MessageBox.Show("Todos los campos deben llenarse para añadir el producto al carro de compras ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //AÑADIR PRODUCTO AL CARRO DE COMPRAS

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            crearVenta();
        }

        //ELIMINAR PRODUCTO DEL CARRO DE COMPRAS

        private void deletePanel(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            var tcount = btn.Parent.Controls.OfType<TextBox>().
                          Where(k => k.Name == "totalLbl").
                          FirstOrDefault();


            totalCost -= Int32.Parse(tcount.Text);


            btn.Parent.Visible = false;
        }

        ABSTRACTEntities3 baseDatos = new ABSTRACTEntities3();

        //OPCIÓN AUTOCOMPLETADO

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

        //BUSCAR REFERENCIA

        private void refSearch_Click(object sender, EventArgs e)
        {
            if (baseDatos.PRODUCTOS.Count(x => x.REFERENCIA == refSearchTextbox.Text) > 0)
            {
                var specificProduct = baseDatos.PRODUCTOS.Where(x => x.REFERENCIA == refSearchTextbox.Text).FirstOrDefault();

                productTextbox.Text = specificProduct.PRODUCTO;
                priceTextbox.Text = specificProduct.PRECIO.ToString();

            }
            else
            {
                MessageBox.Show("No se encontró la referencia");
            }



        }

        //TIMER

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (baseDatos.PRODUCTOS.Count(x => x.REFERENCIA == refSearchTextbox.Text) > 0)
                {
                    var specificProduct = baseDatos.PRODUCTOS.Where(x => x.REFERENCIA == refSearchTextbox.Text).FirstOrDefault();

                    productTextbox.Text = specificProduct.PRODUCTO;
                    priceTextbox.Text = specificProduct.PRECIO.ToString();

                }

                if (baseDatos.CLIENTE.Count(d => d.DNI.ToString() == DNITextbox.Text) > 0)
                {
                    var DNId = baseDatos.CLIENTE.Where(d => d.DNI.ToString() == DNITextbox.Text).FirstOrDefault();

                    nameTextbox.Text = DNId.NAME;
                    DNIType.Text = DNId.DNI_TYPE;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("not working");
            }

            if (totalCost > 0)
            {
                totalCostTextBox.Text = totalCost.ToString();
            }

            if (totalCost == 0)
            {
                totalCostTextBox.Text = "";
            }


            //var aPanelthere = pan_principal.Controls.OfType<Panel>().
            //                       Where(c => c).
            //                       FirstOrDefault();

            if (count > 0 )
            {
                if (DNITextbox.Text == "" && DNIType.Text == "" && nameTextbox.Text == "")
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Image = global::loginAbstract.Properties.Resources.advert_c;
                    pictureBox2.Size = new System.Drawing.Size(299, 117);
                }
                if (DNITextbox.Text != "" || DNIType.Text != "" || nameTextbox.Text != "")
                {
                    if (DNITextbox.Text == "" || DNIType.Text == "" || nameTextbox.Text == "")
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Image = global::loginAbstract.Properties.Resources.llenar_campos_c1;
                        pictureBox2.Size = new System.Drawing.Size(323, 117);

                    }
                }
                if (DNITextbox.Text != "" && DNIType.Text != "" && nameTextbox.Text != "")
                {
                    pictureBox1.Visible = false;
                }
                
            }

        }

        //REGISTRAR VENTA

        private void btn_Register_Click(object sender, EventArgs e)
        {

            IEnumerable<Panel> paneles = pan_principal.Controls.OfType<Panel>();

            //try
            //{

            CONSULTA nuevoRegistro = new CONSULTA();

            foreach (var p in paneles)
                {

                    var textboxes = p.Controls.OfType<TextBox>();

                    DateTime fecha = DateTime.Today;
                    string fechaHoy = fecha.ToShortDateString();
                    string horaHoy = fecha.ToShortTimeString();

 

                    var vUnit = textboxes.Where(a => a.Name == "UPriceLbl").FirstOrDefault();
                    var refLbl = textboxes.Where(b => b.Name == "refLbl").FirstOrDefault();
                    var amountLbl = textboxes.Where(c => c.Name == "amountLbl").FirstOrDefault();
                    var total = textboxes.Where(d => d.Name == "totalLbl").FirstOrDefault();

                 
                    nuevoRegistro.HASH = numCompra;
                    nuevoRegistro.PRECIO_U = vUnit.Text;
                    nuevoRegistro.REFERENCIA = refLbl.Text;
                    nuevoRegistro.CANTIDAD = amountLbl.Text;
                    nuevoRegistro.SUBTOTAL = total.Text;

                    nuevoRegistro.FECHA = fechaHoy;
                    nuevoRegistro.HORA = horaHoy;

                    baseDatos.CONSULTA.Add(nuevoRegistro);

                    p.Visible = false;

                if (DNITextbox.Text != "" && nameTextbox.Text != "" && DNIType.Text != "")
                {
                    nuevoRegistro.DNI = DNITextbox.Text;
                }

                baseDatos.SaveChanges();
            }

           
            //}
            //catch (DbEntityValidationException f)
            //{

            //    MessageBox.Show(f.ToString());
            //}
           

            MessageBox.Show("El registro se guardó debidamente");

            numCompra += 1;


        }

        private void msg_hover(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void msg_hover_leave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }
    }
}
