﻿namespace __Front___Sistema_GYM_Genie.Frms_Cliente
{
    partial class FrmHijaMODCliente
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
            components = new System.ComponentModel.Container();
            PnlMODCliente = new Panel();
            BtnMODCliente = new Button();
            personaBindingSource = new BindingSource(components);
            TxtBuscarDNI = new TextBox();
            LblBuscarDNI = new Label();
            label1 = new Label();
            PnlMODCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PnlMODCliente
            // 
            PnlMODCliente.BackColor = Color.FromArgb(20, 20, 20);
            PnlMODCliente.Controls.Add(BtnMODCliente);
            PnlMODCliente.Controls.Add(TxtBuscarDNI);
            PnlMODCliente.Controls.Add(LblBuscarDNI);
            PnlMODCliente.Controls.Add(label1);
            PnlMODCliente.Dock = DockStyle.Fill;
            PnlMODCliente.Location = new Point(0, 0);
            PnlMODCliente.Name = "PnlMODCliente";
            PnlMODCliente.Size = new Size(1116, 738);
            PnlMODCliente.TabIndex = 0;
            // 
            // BtnMODCliente
            // 
            BtnMODCliente.Anchor = AnchorStyles.None;
            BtnMODCliente.BackColor = Color.FromArgb(64, 64, 64);
            BtnMODCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnMODCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODCliente.Font = new Font("Impact", 16F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODCliente.Location = new Point(371, 135);
            BtnMODCliente.Name = "BtnMODCliente";
            BtnMODCliente.Size = new Size(120, 32);
            BtnMODCliente.TabIndex = 14;
            BtnMODCliente.Text = "MODIFICAR";
            BtnMODCliente.UseVisualStyleBackColor = false;
            // 
            // personaBindingSource
            // 
            // 
            // TxtBuscarDNI
            // 
            TxtBuscarDNI.Anchor = AnchorStyles.None;
            TxtBuscarDNI.Cursor = Cursors.IBeam;
            TxtBuscarDNI.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtBuscarDNI.Location = new Point(171, 141);
            TxtBuscarDNI.Name = "TxtBuscarDNI";
            TxtBuscarDNI.Size = new Size(164, 21);
            TxtBuscarDNI.TabIndex = 12;
            // 
            // LblBuscarDNI
            // 
            LblBuscarDNI.Anchor = AnchorStyles.None;
            LblBuscarDNI.BackColor = Color.White;
            LblBuscarDNI.BorderStyle = BorderStyle.Fixed3D;
            LblBuscarDNI.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblBuscarDNI.Location = new Point(46, 141);
            LblBuscarDNI.Name = "LblBuscarDNI";
            LblBuscarDNI.Size = new Size(97, 21);
            LblBuscarDNI.TabIndex = 11;
            LblBuscarDNI.Text = "BUSCAR DNI: ";
            LblBuscarDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 205, 255);
            label1.Location = new Point(371, 30);
            label1.Name = "label1";
            label1.Size = new Size(378, 66);
            label1.TabIndex = 9;
            label1.Text = "MODIFICAR CLIENTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmHijaMODCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 738);
            Controls.Add(PnlMODCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHijaMODCliente";
            Text = "FrmHijaMODCliente";
            PnlMODCliente.ResumeLayout(false);
            PnlMODCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMODCliente;
        private Label label1;
        private TextBox TxtBuscarDNI;
        private Label LblBuscarDNI;
        private BindingSource personaBindingSource;
        private Button BtnMODCliente;
    }
}