namespace miPictureViewer
{
    partial class frmVIEWER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVIEWER));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAJUSTAR = new System.Windows.Forms.Button();
            this.btANTERIOR = new System.Windows.Forms.Button();
            this.btABRIR = new System.Windows.Forms.Button();
            this.btSIGUIENTE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pVIEWER = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pVIEWER)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.btAJUSTAR);
            this.panel2.Controls.Add(this.btANTERIOR);
            this.panel2.Controls.Add(this.btABRIR);
            this.panel2.Controls.Add(this.btSIGUIENTE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 742);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 51);
            this.panel2.TabIndex = 5;
            // 
            // btAJUSTAR
            // 
            this.btAJUSTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAJUSTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btAJUSTAR.FlatAppearance.BorderSize = 0;
            this.btAJUSTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAJUSTAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAJUSTAR.ForeColor = System.Drawing.Color.Gainsboro;
            this.btAJUSTAR.Image = ((System.Drawing.Image)(resources.GetObject("btAJUSTAR.Image")));
            this.btAJUSTAR.Location = new System.Drawing.Point(60, 7);
            this.btAJUSTAR.Name = "btAJUSTAR";
            this.btAJUSTAR.Size = new System.Drawing.Size(45, 37);
            this.btAJUSTAR.TabIndex = 7;
            this.btAJUSTAR.UseVisualStyleBackColor = false;
            this.btAJUSTAR.Click += new System.EventHandler(this.btTAMORI_Click);
            // 
            // btANTERIOR
            // 
            this.btANTERIOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btANTERIOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btANTERIOR.FlatAppearance.BorderSize = 0;
            this.btANTERIOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btANTERIOR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btANTERIOR.ForeColor = System.Drawing.Color.Gainsboro;
            this.btANTERIOR.Image = ((System.Drawing.Image)(resources.GetObject("btANTERIOR.Image")));
            this.btANTERIOR.Location = new System.Drawing.Point(997, 7);
            this.btANTERIOR.Name = "btANTERIOR";
            this.btANTERIOR.Size = new System.Drawing.Size(45, 37);
            this.btANTERIOR.TabIndex = 4;
            this.btANTERIOR.UseVisualStyleBackColor = false;
            this.btANTERIOR.Click += new System.EventHandler(this.btANTERIOR_Click);
            // 
            // btABRIR
            // 
            this.btABRIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btABRIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btABRIR.FlatAppearance.BorderSize = 0;
            this.btABRIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btABRIR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btABRIR.ForeColor = System.Drawing.Color.Gainsboro;
            this.btABRIR.Image = ((System.Drawing.Image)(resources.GetObject("btABRIR.Image")));
            this.btABRIR.Location = new System.Drawing.Point(7, 7);
            this.btABRIR.Name = "btABRIR";
            this.btABRIR.Size = new System.Drawing.Size(45, 37);
            this.btABRIR.TabIndex = 2;
            this.btABRIR.UseVisualStyleBackColor = false;
            this.btABRIR.Click += new System.EventHandler(this.btABRIR_Click);
            // 
            // btSIGUIENTE
            // 
            this.btSIGUIENTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSIGUIENTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btSIGUIENTE.FlatAppearance.BorderSize = 0;
            this.btSIGUIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSIGUIENTE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSIGUIENTE.ForeColor = System.Drawing.Color.Gainsboro;
            this.btSIGUIENTE.Image = ((System.Drawing.Image)(resources.GetObject("btSIGUIENTE.Image")));
            this.btSIGUIENTE.Location = new System.Drawing.Point(1054, 7);
            this.btSIGUIENTE.Name = "btSIGUIENTE";
            this.btSIGUIENTE.Size = new System.Drawing.Size(45, 37);
            this.btSIGUIENTE.TabIndex = 3;
            this.btSIGUIENTE.UseVisualStyleBackColor = false;
            this.btSIGUIENTE.Click += new System.EventHandler(this.btSIGUIENTE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pVIEWER);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 795);
            this.panel1.TabIndex = 0;
            // 
            // pVIEWER
            // 
            this.pVIEWER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pVIEWER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pVIEWER.Location = new System.Drawing.Point(1, 1);
            this.pVIEWER.Name = "pVIEWER";
            this.pVIEWER.Size = new System.Drawing.Size(1105, 740);
            this.pVIEWER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pVIEWER.TabIndex = 6;
            this.pVIEWER.TabStop = false;
            // 
            // frmVIEWER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1109, 795);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVIEWER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PicVi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVIEWER_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pVIEWER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAJUSTAR;
        private System.Windows.Forms.Button btANTERIOR;
        private System.Windows.Forms.Button btABRIR;
        private System.Windows.Forms.Button btSIGUIENTE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pVIEWER;
    }
}

