namespace PryPresentacion
{
    partial class Frmnomina
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
            this.btn_buscartipo = new MaterialSkin.Controls.MaterialButton();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_buscartipo
            // 
            this.btn_buscartipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_buscartipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_buscartipo.Depth = 0;
            this.btn_buscartipo.HighEmphasis = true;
            this.btn_buscartipo.Icon = null;
            this.btn_buscartipo.Location = new System.Drawing.Point(5, 102);
            this.btn_buscartipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_buscartipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscartipo.Name = "btn_buscartipo";
            this.btn_buscartipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_buscartipo.Size = new System.Drawing.Size(214, 36);
            this.btn_buscartipo.TabIndex = 1;
            this.btn_buscartipo.Text = "buscar tipo profesional";
            this.btn_buscartipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_buscartipo.UseAccentColor = false;
            this.btn_buscartipo.UseVisualStyleBackColor = true;
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(252, 90);
            this.materialMaskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(188, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 2;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.Text = "profesional";
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // Frmnomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 214);
            this.Controls.Add(this.materialMaskedTextBox1);
            this.Controls.Add(this.btn_buscartipo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frmnomina";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Frmnomina";
            this.Load += new System.EventHandler(this.Frmnomina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_buscartipo;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
    }
}