namespace PryPresentacion
{
    partial class FrmCancelarCita
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
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.txb_turno = new MaterialSkin.Controls.MaterialTextBox();
            this.data_cancelar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_cancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = false;
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(838, 274);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(189, 36);
            this.btn_cancelar.TabIndex = 40;
            this.btn_cancelar.Text = "cancelar cita";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txb_turno
            // 
            this.txb_turno.AnimateReadOnly = false;
            this.txb_turno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_turno.Depth = 0;
            this.txb_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_turno.Hint = "buscar turno";
            this.txb_turno.LeadingIcon = null;
            this.txb_turno.Location = new System.Drawing.Point(823, 160);
            this.txb_turno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_turno.MaxLength = 50;
            this.txb_turno.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_turno.Multiline = false;
            this.txb_turno.Name = "txb_turno";
            this.txb_turno.Size = new System.Drawing.Size(219, 50);
            this.txb_turno.TabIndex = 39;
            this.txb_turno.Text = "";
            this.txb_turno.TrailingIcon = null;
            // 
            // data_cancelar
            // 
            this.data_cancelar.AllowUserToAddRows = false;
            this.data_cancelar.AllowUserToDeleteRows = false;
            this.data_cancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cancelar.Location = new System.Drawing.Point(45, 126);
            this.data_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_cancelar.Name = "data_cancelar";
            this.data_cancelar.ReadOnly = true;
            this.data_cancelar.RowHeadersWidth = 51;
            this.data_cancelar.RowTemplate.Height = 24;
            this.data_cancelar.Size = new System.Drawing.Size(699, 361);
            this.data_cancelar.TabIndex = 38;
            // 
            // FrmCancelarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 612);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txb_turno);
            this.Controls.Add(this.data_cancelar);
            this.Name = "FrmCancelarCita";
            this.Text = "FrmCancelarCita";
            this.Load += new System.EventHandler(this.FrmCancelarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_cancelar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialTextBox txb_turno;
        private System.Windows.Forms.DataGridView data_cancelar;
    }
}