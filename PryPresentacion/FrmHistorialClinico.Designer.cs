namespace PryPresentacion
{
    partial class FrmHistorialClinico
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
            this.data_vercitas = new System.Windows.Forms.DataGridView();
            this.btn_verorden = new MaterialSkin.Controls.MaterialButton();
            this.txt_buscarpaciente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btn_buscarpaciente = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_vercitas)).BeginInit();
            this.SuspendLayout();
            // 
            // data_vercitas
            // 
            this.data_vercitas.AllowUserToAddRows = false;
            this.data_vercitas.AllowUserToDeleteRows = false;
            this.data_vercitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_vercitas.Location = new System.Drawing.Point(46, 136);
            this.data_vercitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_vercitas.Name = "data_vercitas";
            this.data_vercitas.ReadOnly = true;
            this.data_vercitas.RowHeadersWidth = 51;
            this.data_vercitas.RowTemplate.Height = 24;
            this.data_vercitas.Size = new System.Drawing.Size(613, 244);
            this.data_vercitas.TabIndex = 35;
            // 
            // btn_verorden
            // 
            this.btn_verorden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verorden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_verorden.Depth = 0;
            this.btn_verorden.HighEmphasis = true;
            this.btn_verorden.Icon = null;
            this.btn_verorden.Location = new System.Drawing.Point(46, 71);
            this.btn_verorden.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_verorden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_verorden.Name = "btn_verorden";
            this.btn_verorden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_verorden.Size = new System.Drawing.Size(117, 36);
            this.btn_verorden.TabIndex = 36;
            this.btn_verorden.Text = "Ver Ordenes";
            this.btn_verorden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_verorden.UseAccentColor = false;
            this.btn_verorden.UseVisualStyleBackColor = true;
            // 
            // txt_buscarpaciente
            // 
            this.txt_buscarpaciente.AllowPromptAsInput = true;
            this.txt_buscarpaciente.AnimateReadOnly = false;
            this.txt_buscarpaciente.AsciiOnly = false;
            this.txt_buscarpaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_buscarpaciente.BeepOnError = false;
            this.txt_buscarpaciente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_buscarpaciente.Depth = 0;
            this.txt_buscarpaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_buscarpaciente.HidePromptOnLeave = false;
            this.txt_buscarpaciente.HideSelection = true;
            this.txt_buscarpaciente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_buscarpaciente.LeadingIcon = null;
            this.txt_buscarpaciente.Location = new System.Drawing.Point(487, 69);
            this.txt_buscarpaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_buscarpaciente.Mask = "";
            this.txt_buscarpaciente.MaxLength = 32767;
            this.txt_buscarpaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_buscarpaciente.Name = "txt_buscarpaciente";
            this.txt_buscarpaciente.PasswordChar = '\0';
            this.txt_buscarpaciente.PrefixSuffixText = null;
            this.txt_buscarpaciente.PromptChar = '_';
            this.txt_buscarpaciente.ReadOnly = false;
            this.txt_buscarpaciente.RejectInputOnFirstFailure = false;
            this.txt_buscarpaciente.ResetOnPrompt = true;
            this.txt_buscarpaciente.ResetOnSpace = true;
            this.txt_buscarpaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_buscarpaciente.SelectedText = "";
            this.txt_buscarpaciente.SelectionLength = 0;
            this.txt_buscarpaciente.SelectionStart = 0;
            this.txt_buscarpaciente.ShortcutsEnabled = true;
            this.txt_buscarpaciente.Size = new System.Drawing.Size(188, 48);
            this.txt_buscarpaciente.SkipLiterals = true;
            this.txt_buscarpaciente.TabIndex = 37;
            this.txt_buscarpaciente.TabStop = false;
            this.txt_buscarpaciente.Text = "Paciente";
            this.txt_buscarpaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_buscarpaciente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_buscarpaciente.TrailingIcon = null;
            this.txt_buscarpaciente.UseSystemPasswordChar = false;
            this.txt_buscarpaciente.ValidatingType = null;
            // 
            // btn_buscarpaciente
            // 
            this.btn_buscarpaciente.AutoSize = false;
            this.btn_buscarpaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_buscarpaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_buscarpaciente.Depth = 0;
            this.btn_buscarpaciente.HighEmphasis = true;
            this.btn_buscarpaciente.Icon = null;
            this.btn_buscarpaciente.Location = new System.Drawing.Point(351, 69);
            this.btn_buscarpaciente.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_buscarpaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscarpaciente.Name = "btn_buscarpaciente";
            this.btn_buscarpaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_buscarpaciente.Size = new System.Drawing.Size(106, 48);
            this.btn_buscarpaciente.TabIndex = 38;
            this.btn_buscarpaciente.Text = "buscar paciente";
            this.btn_buscarpaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_buscarpaciente.UseAccentColor = false;
            this.btn_buscarpaciente.UseVisualStyleBackColor = true;
            // 
            // FrmHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 391);
            this.Controls.Add(this.btn_buscarpaciente);
            this.Controls.Add(this.txt_buscarpaciente);
            this.Controls.Add(this.btn_verorden);
            this.Controls.Add(this.data_vercitas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHistorialClinico";
            this.Text = "FrmHistorialClinico";
            this.Load += new System.EventHandler(this.FrmHistorialClinico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_vercitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_vercitas;
        private MaterialSkin.Controls.MaterialButton btn_verorden;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_buscarpaciente;
        private MaterialSkin.Controls.MaterialButton btn_buscarpaciente;
    }
}