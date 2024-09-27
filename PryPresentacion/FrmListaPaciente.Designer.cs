namespace PryPresentacion
{
    partial class FrmListaPaciente
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
            this.btn_diagnostico = new MaterialSkin.Controls.MaterialButton();
            this.txb_turno = new MaterialSkin.Controls.MaterialTextBox();
            this.data_citas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_citas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_diagnostico
            // 
            this.btn_diagnostico.AutoSize = false;
            this.btn_diagnostico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_diagnostico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_diagnostico.Depth = 0;
            this.btn_diagnostico.HighEmphasis = true;
            this.btn_diagnostico.Icon = null;
            this.btn_diagnostico.Location = new System.Drawing.Point(841, 234);
            this.btn_diagnostico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_diagnostico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_diagnostico.Name = "btn_diagnostico";
            this.btn_diagnostico.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_diagnostico.Size = new System.Drawing.Size(189, 36);
            this.btn_diagnostico.TabIndex = 43;
            this.btn_diagnostico.Text = "dar diagnostigo";
            this.btn_diagnostico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_diagnostico.UseAccentColor = false;
            this.btn_diagnostico.UseVisualStyleBackColor = true;
            // 
            // txb_turno
            // 
            this.txb_turno.AnimateReadOnly = false;
            this.txb_turno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_turno.Depth = 0;
            this.txb_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_turno.Hint = "buscar turno";
            this.txb_turno.LeadingIcon = null;
            this.txb_turno.Location = new System.Drawing.Point(825, 150);
            this.txb_turno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_turno.MaxLength = 50;
            this.txb_turno.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_turno.Multiline = false;
            this.txb_turno.Name = "txb_turno";
            this.txb_turno.Size = new System.Drawing.Size(219, 50);
            this.txb_turno.TabIndex = 42;
            this.txb_turno.Text = "";
            this.txb_turno.TrailingIcon = null;
            // 
            // data_citas
            // 
            this.data_citas.AllowUserToAddRows = false;
            this.data_citas.AllowUserToDeleteRows = false;
            this.data_citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_citas.Location = new System.Drawing.Point(43, 109);
            this.data_citas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_citas.Name = "data_citas";
            this.data_citas.ReadOnly = true;
            this.data_citas.RowHeadersWidth = 51;
            this.data_citas.RowTemplate.Height = 24;
            this.data_citas.Size = new System.Drawing.Size(699, 361);
            this.data_citas.TabIndex = 41;
            // 
            // FrmListaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 502);
            this.Controls.Add(this.btn_diagnostico);
            this.Controls.Add(this.txb_turno);
            this.Controls.Add(this.data_citas);
            this.Name = "FrmListaPaciente";
            this.Text = "FrmListaPaciente";
            this.Load += new System.EventHandler(this.FrmListaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_citas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_diagnostico;
        private MaterialSkin.Controls.MaterialTextBox txb_turno;
        private System.Windows.Forms.DataGridView data_citas;
    }
}