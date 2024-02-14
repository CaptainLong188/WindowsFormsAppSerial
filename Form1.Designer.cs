using System.Drawing;

namespace WindowsFormsAppSerial
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tbrBit1 = new System.Windows.Forms.TrackBar();
            this.tbrBit2 = new System.Windows.Forms.TrackBar();
            this.tbrBit3 = new System.Windows.Forms.TrackBar();
            this.tbrBit4 = new System.Windows.Forms.TrackBar();
            this.tbrBit5 = new System.Windows.Forms.TrackBar();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbReceive = new System.Windows.Forms.ComboBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.cmbSend = new System.Windows.Forms.ComboBox();
            this.pnlFocos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prueba Comunicación Serial";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMensaje.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(249, 225);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.ShortcutsEnabled = false;
            this.txtMensaje.Size = new System.Drawing.Size(137, 161);
            this.txtMensaje.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.label2.Location = new System.Drawing.Point(67, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mensajes\r\nRecibidos\r\n";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(601, 454);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(166, 60);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // tbrBit1
            // 
            this.tbrBit1.Location = new System.Drawing.Point(619, 210);
            this.tbrBit1.Maximum = 1;
            this.tbrBit1.Name = "tbrBit1";
            this.tbrBit1.Size = new System.Drawing.Size(104, 56);
            this.tbrBit1.TabIndex = 4;
            this.tbrBit1.Scroll += new System.EventHandler(this.TbrBit1_Scroll);
            // 
            // tbrBit2
            // 
            this.tbrBit2.Location = new System.Drawing.Point(619, 249);
            this.tbrBit2.Maximum = 1;
            this.tbrBit2.Name = "tbrBit2";
            this.tbrBit2.Size = new System.Drawing.Size(104, 56);
            this.tbrBit2.TabIndex = 5;
            this.tbrBit2.Scroll += new System.EventHandler(this.TbrBit2_Scroll);
            // 
            // tbrBit3
            // 
            this.tbrBit3.Location = new System.Drawing.Point(619, 290);
            this.tbrBit3.Maximum = 1;
            this.tbrBit3.Name = "tbrBit3";
            this.tbrBit3.Size = new System.Drawing.Size(104, 56);
            this.tbrBit3.TabIndex = 7;
            this.tbrBit3.Scroll += new System.EventHandler(this.TbrBit3_Scroll);
            // 
            // tbrBit4
            // 
            this.tbrBit4.Location = new System.Drawing.Point(619, 330);
            this.tbrBit4.Maximum = 1;
            this.tbrBit4.Name = "tbrBit4";
            this.tbrBit4.Size = new System.Drawing.Size(104, 56);
            this.tbrBit4.TabIndex = 8;
            this.tbrBit4.Scroll += new System.EventHandler(this.TbrBit4_Scroll);
            // 
            // tbrBit5
            // 
            this.tbrBit5.Location = new System.Drawing.Point(619, 367);
            this.tbrBit5.Maximum = 1;
            this.tbrBit5.Name = "tbrBit5";
            this.tbrBit5.Size = new System.Drawing.Size(104, 56);
            this.tbrBit5.TabIndex = 9;
            this.tbrBit5.Scroll += new System.EventHandler(this.TbrBit5_Scroll);
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.Location = new System.Drawing.Point(645, 411);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(78, 29);
            this.lblEnviar.TabIndex = 10;
            this.lblEnviar.Text = "00000";
            this.lblEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(235, 486);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(166, 60);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // cmbReceive
            // 
            this.cmbReceive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceive.FormattingEnabled = true;
            this.cmbReceive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbReceive.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cmbReceive.Location = new System.Drawing.Point(235, 159);
            this.cmbReceive.Name = "cmbReceive";
            this.cmbReceive.Size = new System.Drawing.Size(167, 24);
            this.cmbReceive.TabIndex = 12;
            this.cmbReceive.SelectedIndexChanged += new System.EventHandler(this.CmbReceive_SelectedIndexChanged);
            // 
            // lblReceive
            // 
            this.lblReceive.Image = global::WindowsFormsAppSerial.Properties.Resources.cancel;
            this.lblReceive.Location = new System.Drawing.Point(408, 145);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(79, 48);
            this.lblReceive.TabIndex = 13;
            // 
            // lblSend
            // 
            this.lblSend.Image = global::WindowsFormsAppSerial.Properties.Resources.cancel;
            this.lblSend.Location = new System.Drawing.Point(774, 145);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(79, 48);
            this.lblSend.TabIndex = 15;
            // 
            // cmbSend
            // 
            this.cmbSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSend.FormattingEnabled = true;
            this.cmbSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSend.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cmbSend.Location = new System.Drawing.Point(601, 159);
            this.cmbSend.Name = "cmbSend";
            this.cmbSend.Size = new System.Drawing.Size(167, 24);
            this.cmbSend.TabIndex = 14;
            this.cmbSend.SelectedIndexChanged += new System.EventHandler(this.CmbSend_SelectedIndexChanged);
            // 
            // pnlFocos
            // 
            this.pnlFocos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFocos.Location = new System.Drawing.Point(179, 403);
            this.pnlFocos.Name = "pnlFocos";
            this.pnlFocos.Size = new System.Drawing.Size(285, 55);
            this.pnlFocos.TabIndex = 16;
            this.pnlFocos.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFocos_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1057, 648);
            this.Controls.Add(this.pnlFocos);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.cmbSend);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.cmbReceive);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblEnviar);
            this.Controls.Add(this.tbrBit5);
            this.Controls.Add(this.tbrBit4);
            this.Controls.Add(this.tbrBit3);
            this.Controls.Add(this.tbrBit2);
            this.Controls.Add(this.tbrBit1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Comunicación Serial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBit5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TrackBar tbrBit1;
        private System.Windows.Forms.TrackBar tbrBit2;
        private System.Windows.Forms.TrackBar tbrBit3;
        private System.Windows.Forms.TrackBar tbrBit4;
        private System.Windows.Forms.TrackBar tbrBit5;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbReceive;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.ComboBox cmbSend;
        private System.Windows.Forms.Panel pnlFocos;
    }
}

