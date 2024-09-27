namespace PryPresentacion
{
    partial class FrmCita
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
            this.btn_reprogramar = new MaterialSkin.Controls.MaterialButton();
            this.btn_agendar = new MaterialSkin.Controls.MaterialButton();
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
            this.btn_cancelar.Location = new System.Drawing.Point(747, 374);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(211, 44);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "cancelar cita";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_reprogramar
            // 
            this.btn_reprogramar.AutoSize = false;
            this.btn_reprogramar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reprogramar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_reprogramar.Depth = 0;
            this.btn_reprogramar.HighEmphasis = true;
            this.btn_reprogramar.Icon = null;
            this.btn_reprogramar.Location = new System.Drawing.Point(420, 374);
            this.btn_reprogramar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_reprogramar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reprogramar.Name = "btn_reprogramar";
            this.btn_reprogramar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_reprogramar.Size = new System.Drawing.Size(211, 44);
            this.btn_reprogramar.TabIndex = 4;
            this.btn_reprogramar.Text = "reprogramar cita";
            this.btn_reprogramar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reprogramar.UseAccentColor = false;
            this.btn_reprogramar.UseVisualStyleBackColor = true;
            // 
            // btn_agendar
            // 
            this.btn_agendar.AutoSize = false;
            this.btn_agendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agendar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_agendar.Depth = 0;
            this.btn_agendar.HighEmphasis = true;
            this.btn_agendar.Icon = null;
            this.btn_agendar.Location = new System.Drawing.Point(80, 374);
            this.btn_agendar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_agendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agendar.Size = new System.Drawing.Size(211, 44);
            this.btn_agendar.TabIndex = 3;
            this.btn_agendar.Text = "agendar cita";
            this.btn_agendar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_agendar.UseAccentColor = false;
            this.btn_agendar.UseVisualStyleBackColor = true;
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 537);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_reprogramar);
            this.Controls.Add(this.btn_agendar);
            this.Name = "FrmCita";
            this.Text = "FrmCita";
            this.Load += new System.EventHandler(this.FrmCita_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialButton btn_reprogramar;
        private MaterialSkin.Controls.MaterialButton btn_agendar;
    }
}