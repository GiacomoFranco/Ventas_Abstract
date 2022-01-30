
namespace loginAbstract
{
    partial class LoginAbstract
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAbstract));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::loginAbstract.Properties.Resources.btnIngresar;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(184, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnIngresar);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(63, 388);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(440, 21);
            this.txt_password.TabIndex = 21;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(63, 281);
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_usuario.Size = new System.Drawing.Size(440, 21);
            this.txt_usuario.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::loginAbstract.Properties.Resources.Grupo_17;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(305, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 25);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::loginAbstract.Properties.Resources.rememberMeUnchecked;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(58, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 25);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnRecuerdame);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1400, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // LoginAbstract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginAbstract.Properties.Resources.loginWindowBackground;
            this.ClientSize = new System.Drawing.Size(1487, 769);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginAbstract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abstract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

