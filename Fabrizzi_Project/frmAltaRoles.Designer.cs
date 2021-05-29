namespace Fabrizzi_Project
{
    partial class frmAltaRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaRoles));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chBox_Usuarios = new System.Windows.Forms.CheckBox();
            this.chBox_MatPri = new System.Windows.Forms.CheckBox();
            this.chBox_Proveedores = new System.Windows.Forms.CheckBox();
            this.cBox_NombreRol = new System.Windows.Forms.ComboBox();
            this.chBox_Productos = new System.Windows.Forms.CheckBox();
            this.chBox_Locales = new System.Windows.Forms.CheckBox();
            this.cBox_AreaRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_GuardarRol = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(67, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre del Rol *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(67, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Permiso";
            // 
            // chBox_Usuarios
            // 
            this.chBox_Usuarios.AutoSize = true;
            this.chBox_Usuarios.ForeColor = System.Drawing.Color.Cornsilk;
            this.chBox_Usuarios.Location = new System.Drawing.Point(176, 95);
            this.chBox_Usuarios.Name = "chBox_Usuarios";
            this.chBox_Usuarios.Size = new System.Drawing.Size(67, 17);
            this.chBox_Usuarios.TabIndex = 9;
            this.chBox_Usuarios.Text = "Usuarios";
            this.chBox_Usuarios.UseVisualStyleBackColor = true;
            // 
            // chBox_MatPri
            // 
            this.chBox_MatPri.AutoSize = true;
            this.chBox_MatPri.ForeColor = System.Drawing.Color.Cornsilk;
            this.chBox_MatPri.Location = new System.Drawing.Point(176, 118);
            this.chBox_MatPri.Name = "chBox_MatPri";
            this.chBox_MatPri.Size = new System.Drawing.Size(100, 17);
            this.chBox_MatPri.TabIndex = 10;
            this.chBox_MatPri.Text = "Materias Primas";
            this.chBox_MatPri.UseVisualStyleBackColor = true;
            // 
            // chBox_Proveedores
            // 
            this.chBox_Proveedores.AutoSize = true;
            this.chBox_Proveedores.ForeColor = System.Drawing.Color.White;
            this.chBox_Proveedores.Location = new System.Drawing.Point(285, 95);
            this.chBox_Proveedores.Name = "chBox_Proveedores";
            this.chBox_Proveedores.Size = new System.Drawing.Size(86, 17);
            this.chBox_Proveedores.TabIndex = 11;
            this.chBox_Proveedores.Text = "Proveedores";
            this.chBox_Proveedores.UseVisualStyleBackColor = true;
            // 
            // cBox_NombreRol
            // 
            this.cBox_NombreRol.FormattingEnabled = true;
            this.cBox_NombreRol.Items.AddRange(new object[] {
            "Seleccione",
            "Supervisor",
            "Encargado",
            "Empleado"});
            this.cBox_NombreRol.Location = new System.Drawing.Point(176, 55);
            this.cBox_NombreRol.Name = "cBox_NombreRol";
            this.cBox_NombreRol.Size = new System.Drawing.Size(121, 21);
            this.cBox_NombreRol.TabIndex = 12;
            // 
            // chBox_Productos
            // 
            this.chBox_Productos.AutoSize = true;
            this.chBox_Productos.ForeColor = System.Drawing.Color.Cornsilk;
            this.chBox_Productos.Location = new System.Drawing.Point(285, 118);
            this.chBox_Productos.Name = "chBox_Productos";
            this.chBox_Productos.Size = new System.Drawing.Size(74, 17);
            this.chBox_Productos.TabIndex = 13;
            this.chBox_Productos.Text = "Productos";
            this.chBox_Productos.UseVisualStyleBackColor = true;
            // 
            // chBox_Locales
            // 
            this.chBox_Locales.AutoSize = true;
            this.chBox_Locales.ForeColor = System.Drawing.Color.Cornsilk;
            this.chBox_Locales.Location = new System.Drawing.Point(176, 141);
            this.chBox_Locales.Name = "chBox_Locales";
            this.chBox_Locales.Size = new System.Drawing.Size(63, 17);
            this.chBox_Locales.TabIndex = 14;
            this.chBox_Locales.Text = "Locales";
            this.chBox_Locales.UseVisualStyleBackColor = true;
            // 
            // cBox_AreaRol
            // 
            this.cBox_AreaRol.FormattingEnabled = true;
            this.cBox_AreaRol.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Depósito",
            "Fábrica",
            "Ventas"});
            this.cBox_AreaRol.Location = new System.Drawing.Point(176, 180);
            this.cBox_AreaRol.Name = "cBox_AreaRol";
            this.cBox_AreaRol.Size = new System.Drawing.Size(121, 21);
            this.cBox_AreaRol.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(67, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Area *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(67, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha Alta";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Enabled = false;
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(176, 222);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(115, 20);
            this.dtp_Fecha.TabIndex = 18;
            // 
            // btn_GuardarRol
            // 
            this.btn_GuardarRol.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_GuardarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_GuardarRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GuardarRol.BorderRadius = 0;
            this.btn_GuardarRol.ButtonText = "Guardar";
            this.btn_GuardarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GuardarRol.DisabledColor = System.Drawing.Color.Gray;
            this.btn_GuardarRol.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_GuardarRol.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_GuardarRol.Iconimage")));
            this.btn_GuardarRol.Iconimage_right = null;
            this.btn_GuardarRol.Iconimage_right_Selected = null;
            this.btn_GuardarRol.Iconimage_Selected = null;
            this.btn_GuardarRol.IconMarginLeft = 0;
            this.btn_GuardarRol.IconMarginRight = 0;
            this.btn_GuardarRol.IconRightVisible = true;
            this.btn_GuardarRol.IconRightZoom = 0D;
            this.btn_GuardarRol.IconVisible = true;
            this.btn_GuardarRol.IconZoom = 90D;
            this.btn_GuardarRol.IsTab = false;
            this.btn_GuardarRol.Location = new System.Drawing.Point(269, 265);
            this.btn_GuardarRol.Name = "btn_GuardarRol";
            this.btn_GuardarRol.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_GuardarRol.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_GuardarRol.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_GuardarRol.selected = false;
            this.btn_GuardarRol.Size = new System.Drawing.Size(125, 49);
            this.btn_GuardarRol.TabIndex = 19;
            this.btn_GuardarRol.Text = "Guardar";
            this.btn_GuardarRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarRol.Textcolor = System.Drawing.Color.White;
            this.btn_GuardarRol.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarRol.Click += new System.EventHandler(this.btn_GuardarRol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 39);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(390, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label9.Location = new System.Drawing.Point(128, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 31);
            this.label9.TabIndex = 5;
            this.label9.Text = "Alta Rol Usuario";
            // 
            // frmAltaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_GuardarRol);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBox_AreaRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chBox_Locales);
            this.Controls.Add(this.chBox_Productos);
            this.Controls.Add(this.cBox_NombreRol);
            this.Controls.Add(this.chBox_Proveedores);
            this.Controls.Add(this.chBox_MatPri);
            this.Controls.Add(this.chBox_Usuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaRoles";
            this.Load += new System.EventHandler(this.frmAltaRoles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBox_Usuarios;
        private System.Windows.Forms.CheckBox chBox_MatPri;
        private System.Windows.Forms.CheckBox chBox_Proveedores;
        private System.Windows.Forms.ComboBox cBox_NombreRol;
        private System.Windows.Forms.CheckBox chBox_Productos;
        private System.Windows.Forms.CheckBox chBox_Locales;
        private System.Windows.Forms.ComboBox cBox_AreaRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private Bunifu.Framework.UI.BunifuFlatButton btn_GuardarRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}