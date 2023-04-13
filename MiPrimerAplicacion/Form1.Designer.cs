namespace MiPrimerAplicacion
{
    partial class Miprimeraplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miprimeraplicacion));
            this.boton1 = new System.Windows.Forms.Button();
            this.etiqueta1 = new System.Windows.Forms.Label();
            this.Texto = new System.Windows.Forms.TextBox();
            this.Texto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.Yellow;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Image = ((System.Drawing.Image)(resources.GetObject("boton1.Image")));
            this.boton1.Location = new System.Drawing.Point(309, 50);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(228, 107);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "Run";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etiqueta1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta1.Location = new System.Drawing.Point(203, 80);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.Size = new System.Drawing.Size(79, 24);
            this.etiqueta1.TabIndex = 1;
            this.etiqueta1.Text = "etiqueta";
            this.etiqueta1.MouseLeave += new System.EventHandler(this.etiqueta1_MouseLeave);
            this.etiqueta1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.etiqueta1_MouseMove);
            // 
            // Texto
            // 
            this.Texto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Texto.Location = new System.Drawing.Point(403, 227);
            this.Texto.MaxLength = 20;
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(100, 20);
            this.Texto.TabIndex = 2;
            this.Texto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Texto_KeyPress);
            // 
            // Texto2
            // 
            this.Texto2.Location = new System.Drawing.Point(434, 272);
            this.Texto2.Multiline = true;
            this.Texto2.Name = "Texto2";
            this.Texto2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Texto2.Size = new System.Drawing.Size(100, 20);
            this.Texto2.TabIndex = 3;
            this.Texto2.Leave += new System.EventHandler(this.Texto2_Leave);
            // 
            // Miprimeraplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Texto2);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.etiqueta1);
            this.Controls.Add(this.boton1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Miprimeraplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPrimerAplicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Miprimeraplicacion_FormClosed);
            this.Load += new System.EventHandler(this.Miprimeraplicacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Label etiqueta1;
        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.TextBox Texto2;
    }
}

