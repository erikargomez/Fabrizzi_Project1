namespace Fabrizzi_Project
{
    partial class frmRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ImprimirRoles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ModifRol = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_NuevoRol = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Dgv_Roles = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_BuscarRol = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cBox_ArealRolBuscar = new System.Windows.Forms.ComboBox();
            this.cBox_EstadoRolBuscar = new System.Windows.Forms.ComboBox();
            this.lbl_AreaRolBuscar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 43);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(248, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(182, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(792, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Roles";
            // 
            // btn_ImprimirRoles
            // 
            this.btn_ImprimirRoles.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ImprimirRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ImprimirRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ImprimirRoles.BorderRadius = 0;
            this.btn_ImprimirRoles.ButtonText = "Imprimir";
            this.btn_ImprimirRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImprimirRoles.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ImprimirRoles.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ImprimirRoles.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ImprimirRoles.Iconimage")));
            this.btn_ImprimirRoles.Iconimage_right = null;
            this.btn_ImprimirRoles.Iconimage_right_Selected = null;
            this.btn_ImprimirRoles.Iconimage_Selected = null;
            this.btn_ImprimirRoles.IconMarginLeft = 0;
            this.btn_ImprimirRoles.IconMarginRight = 0;
            this.btn_ImprimirRoles.IconRightVisible = true;
            this.btn_ImprimirRoles.IconRightZoom = 0D;
            this.btn_ImprimirRoles.IconVisible = true;
            this.btn_ImprimirRoles.IconZoom = 90D;
            this.btn_ImprimirRoles.IsTab = false;
            this.btn_ImprimirRoles.Location = new System.Drawing.Point(643, 65);
            this.btn_ImprimirRoles.Name = "btn_ImprimirRoles";
            this.btn_ImprimirRoles.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ImprimirRoles.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_ImprimirRoles.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ImprimirRoles.selected = false;
            this.btn_ImprimirRoles.Size = new System.Drawing.Size(136, 49);
            this.btn_ImprimirRoles.TabIndex = 23;
            this.btn_ImprimirRoles.Text = "Imprimir";
            this.btn_ImprimirRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImprimirRoles.Textcolor = System.Drawing.Color.White;
            this.btn_ImprimirRoles.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_ModifRol
            // 
            this.btn_ModifRol.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ModifRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ModifRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModifRol.BorderRadius = 0;
            this.btn_ModifRol.ButtonText = "Modificar Rol";
            this.btn_ModifRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModifRol.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ModifRol.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ModifRol.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ModifRol.Iconimage")));
            this.btn_ModifRol.Iconimage_right = null;
            this.btn_ModifRol.Iconimage_right_Selected = null;
            this.btn_ModifRol.Iconimage_Selected = null;
            this.btn_ModifRol.IconMarginLeft = 0;
            this.btn_ModifRol.IconMarginRight = 0;
            this.btn_ModifRol.IconRightVisible = true;
            this.btn_ModifRol.IconRightZoom = 0D;
            this.btn_ModifRol.IconVisible = true;
            this.btn_ModifRol.IconZoom = 90D;
            this.btn_ModifRol.IsTab = false;
            this.btn_ModifRol.Location = new System.Drawing.Point(643, 393);
            this.btn_ModifRol.Name = "btn_ModifRol";
            this.btn_ModifRol.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ModifRol.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_ModifRol.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ModifRol.selected = false;
            this.btn_ModifRol.Size = new System.Drawing.Size(136, 49);
            this.btn_ModifRol.TabIndex = 20;
            this.btn_ModifRol.Text = "Modificar Rol";
            this.btn_ModifRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModifRol.Textcolor = System.Drawing.Color.White;
            this.btn_ModifRol.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModifRol.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btn_NuevoRol
            // 
            this.btn_NuevoRol.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_NuevoRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_NuevoRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NuevoRol.BorderRadius = 0;
            this.btn_NuevoRol.ButtonText = "Nuevo Rol";
            this.btn_NuevoRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NuevoRol.DisabledColor = System.Drawing.Color.Gray;
            this.btn_NuevoRol.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_NuevoRol.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_NuevoRol.Iconimage")));
            this.btn_NuevoRol.Iconimage_right = null;
            this.btn_NuevoRol.Iconimage_right_Selected = null;
            this.btn_NuevoRol.Iconimage_Selected = null;
            this.btn_NuevoRol.IconMarginLeft = 0;
            this.btn_NuevoRol.IconMarginRight = 0;
            this.btn_NuevoRol.IconRightVisible = true;
            this.btn_NuevoRol.IconRightZoom = 0D;
            this.btn_NuevoRol.IconVisible = true;
            this.btn_NuevoRol.IconZoom = 90D;
            this.btn_NuevoRol.IsTab = false;
            this.btn_NuevoRol.Location = new System.Drawing.Point(434, 393);
            this.btn_NuevoRol.Name = "btn_NuevoRol";
            this.btn_NuevoRol.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_NuevoRol.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_NuevoRol.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_NuevoRol.selected = false;
            this.btn_NuevoRol.Size = new System.Drawing.Size(136, 49);
            this.btn_NuevoRol.TabIndex = 19;
            this.btn_NuevoRol.Text = "Nuevo Rol";
            this.btn_NuevoRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoRol.Textcolor = System.Drawing.Color.White;
            this.btn_NuevoRol.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoRol.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Dgv_Roles
            // 
            this.Dgv_Roles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_Roles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Roles.ColumnHeadersVisible = false;
            this.Dgv_Roles.Location = new System.Drawing.Point(38, 205);
            this.Dgv_Roles.Name = "Dgv_Roles";
            this.Dgv_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Roles.Size = new System.Drawing.Size(741, 150);
            this.Dgv_Roles.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(35, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nombre de Rol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(255, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Secciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(190, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Area";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Menu;
            this.label9.Location = new System.Drawing.Point(446, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fecha Alta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(365, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(700, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fecha Baja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(550, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Fecha Modificaciòn";
            // 
            // btn_BuscarRol
            // 
            this.btn_BuscarRol.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_BuscarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_BuscarRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarRol.BorderRadius = 0;
            this.btn_BuscarRol.ButtonText = "Buscar";
            this.btn_BuscarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarRol.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BuscarRol.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BuscarRol.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_BuscarRol.Iconimage")));
            this.btn_BuscarRol.Iconimage_right = null;
            this.btn_BuscarRol.Iconimage_right_Selected = null;
            this.btn_BuscarRol.Iconimage_Selected = null;
            this.btn_BuscarRol.IconMarginLeft = 0;
            this.btn_BuscarRol.IconMarginRight = 0;
            this.btn_BuscarRol.IconRightVisible = true;
            this.btn_BuscarRol.IconRightZoom = 0D;
            this.btn_BuscarRol.IconVisible = true;
            this.btn_BuscarRol.IconZoom = 90D;
            this.btn_BuscarRol.IsTab = false;
            this.btn_BuscarRol.Location = new System.Drawing.Point(449, 65);
            this.btn_BuscarRol.Name = "btn_BuscarRol";
            this.btn_BuscarRol.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_BuscarRol.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_BuscarRol.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_BuscarRol.selected = false;
            this.btn_BuscarRol.Size = new System.Drawing.Size(136, 49);
            this.btn_BuscarRol.TabIndex = 40;
            this.btn_BuscarRol.Text = "Buscar";
            this.btn_BuscarRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscarRol.Textcolor = System.Drawing.Color.White;
            this.btn_BuscarRol.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarRol.Click += new System.EventHandler(this.btn_BuscarRol_Click);
            // 
            // cBox_ArealRolBuscar
            // 
            this.cBox_ArealRolBuscar.FormattingEnabled = true;
            this.cBox_ArealRolBuscar.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Depósito",
            "Fábrica",
            "Ventas"});
            this.cBox_ArealRolBuscar.Location = new System.Drawing.Point(193, 65);
            this.cBox_ArealRolBuscar.Name = "cBox_ArealRolBuscar";
            this.cBox_ArealRolBuscar.Size = new System.Drawing.Size(121, 21);
            this.cBox_ArealRolBuscar.TabIndex = 41;
            // 
            // cBox_EstadoRolBuscar
            // 
            this.cBox_EstadoRolBuscar.FormattingEnabled = true;
            this.cBox_EstadoRolBuscar.Items.AddRange(new object[] {
            "Seleccione",
            "Activo",
            "Inactivo"});
            this.cBox_EstadoRolBuscar.Location = new System.Drawing.Point(193, 109);
            this.cBox_EstadoRolBuscar.Name = "cBox_EstadoRolBuscar";
            this.cBox_EstadoRolBuscar.Size = new System.Drawing.Size(121, 21);
            this.cBox_EstadoRolBuscar.TabIndex = 42;
            // 
            // lbl_AreaRolBuscar
            // 
            this.lbl_AreaRolBuscar.AutoSize = true;
            this.lbl_AreaRolBuscar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_AreaRolBuscar.ForeColor = System.Drawing.Color.White;
            this.lbl_AreaRolBuscar.Location = new System.Drawing.Point(99, 65);
            this.lbl_AreaRolBuscar.Name = "lbl_AreaRolBuscar";
            this.lbl_AreaRolBuscar.Size = new System.Drawing.Size(48, 17);
            this.lbl_AreaRolBuscar.TabIndex = 43;
            this.lbl_AreaRolBuscar.Text = "Área: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Estado:";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(828, 454);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_AreaRolBuscar);
            this.Controls.Add(this.cBox_EstadoRolBuscar);
            this.Controls.Add(this.cBox_ArealRolBuscar);
            this.Controls.Add(this.btn_BuscarRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dgv_Roles);
            this.Controls.Add(this.btn_ImprimirRoles);
            this.Controls.Add(this.btn_ModifRol);
            this.Controls.Add(this.btn_NuevoRol);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ModifRol;
        private Bunifu.Framework.UI.BunifuFlatButton btn_NuevoRol;
        private System.Windows.Forms.DataGridView Dgv_Roles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuFlatButton btn_ImprimirRoles;
        public Bunifu.Framework.UI.BunifuFlatButton btn_BuscarRol;
        public System.Windows.Forms.ComboBox cBox_ArealRolBuscar;
        public System.Windows.Forms.ComboBox cBox_EstadoRolBuscar;
        public System.Windows.Forms.Label lbl_AreaRolBuscar;
        public System.Windows.Forms.Label label5;
    }
}