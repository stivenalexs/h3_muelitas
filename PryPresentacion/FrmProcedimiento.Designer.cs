namespace PryPresentacion
{
    partial class FrmProcedimiento
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
            this.label_codorden = new MaterialSkin.Controls.MaterialLabel();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_tipo_procedimiento = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_hora_procedimiento = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_estado = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_profesional = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_agendar_procedimiento = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label_codorden
            // 
            this.label_codorden.AutoSize = true;
            this.label_codorden.Depth = 0;
            this.label_codorden.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_codorden.Location = new System.Drawing.Point(799, 75);
            this.label_codorden.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_codorden.Name = "label_codorden";
            this.label_codorden.Size = new System.Drawing.Size(71, 19);
            this.label_codorden.TabIndex = 0;
            this.label_codorden.Text = "cod orden";
            // 
            // date_fecha
            // 
            this.date_fecha.CustomFormat = "";
            this.date_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fecha.Location = new System.Drawing.Point(185, 178);
            this.date_fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(201, 22);
            this.date_fecha.TabIndex = 13;
            // 
            // cmb_tipo_procedimiento
            // 
            this.cmb_tipo_procedimiento.AutoResize = false;
            this.cmb_tipo_procedimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_tipo_procedimiento.Depth = 0;
            this.cmb_tipo_procedimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_tipo_procedimiento.DropDownHeight = 174;
            this.cmb_tipo_procedimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_procedimiento.DropDownWidth = 121;
            this.cmb_tipo_procedimiento.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_tipo_procedimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_tipo_procedimiento.FormattingEnabled = true;
            this.cmb_tipo_procedimiento.IntegralHeight = false;
            this.cmb_tipo_procedimiento.ItemHeight = 43;
            this.cmb_tipo_procedimiento.Location = new System.Drawing.Point(506, 178);
            this.cmb_tipo_procedimiento.MaxDropDownItems = 4;
            this.cmb_tipo_procedimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_tipo_procedimiento.Name = "cmb_tipo_procedimiento";
            this.cmb_tipo_procedimiento.Size = new System.Drawing.Size(144, 49);
            this.cmb_tipo_procedimiento.StartIndex = 0;
            this.cmb_tipo_procedimiento.TabIndex = 14;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(503, 132);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "tipo procedimiento";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(182, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "fecha procedimiento";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(190, 247);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(138, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "hora procedimiento";
            // 
            // cmb_hora_procedimiento
            // 
            this.cmb_hora_procedimiento.AutoResize = false;
            this.cmb_hora_procedimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_hora_procedimiento.Depth = 0;
            this.cmb_hora_procedimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_hora_procedimiento.DropDownHeight = 174;
            this.cmb_hora_procedimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_procedimiento.DropDownWidth = 121;
            this.cmb_hora_procedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_hora_procedimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_hora_procedimiento.FormattingEnabled = true;
            this.cmb_hora_procedimiento.IntegralHeight = false;
            this.cmb_hora_procedimiento.ItemHeight = 43;
            this.cmb_hora_procedimiento.Location = new System.Drawing.Point(185, 300);
            this.cmb_hora_procedimiento.MaxDropDownItems = 4;
            this.cmb_hora_procedimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_hora_procedimiento.Name = "cmb_hora_procedimiento";
            this.cmb_hora_procedimiento.Size = new System.Drawing.Size(144, 49);
            this.cmb_hora_procedimiento.StartIndex = 0;
            this.cmb_hora_procedimiento.TabIndex = 18;
            // 
            // cmb_estado
            // 
            this.cmb_estado.AutoResize = false;
            this.cmb_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_estado.Depth = 0;
            this.cmb_estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_estado.DropDownHeight = 174;
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.DropDownWidth = 121;
            this.cmb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.IntegralHeight = false;
            this.cmb_estado.ItemHeight = 43;
            this.cmb_estado.Location = new System.Drawing.Point(506, 300);
            this.cmb_estado.MaxDropDownItems = 4;
            this.cmb_estado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(144, 49);
            this.cmb_estado.StartIndex = 0;
            this.cmb_estado.TabIndex = 19;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(512, 247);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(179, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "estado del procedimiento";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(357, 389);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(138, 19);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "profesional a cargo";
            // 
            // cmb_profesional
            // 
            this.cmb_profesional.AutoResize = false;
            this.cmb_profesional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_profesional.Depth = 0;
            this.cmb_profesional.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_profesional.DropDownHeight = 174;
            this.cmb_profesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_profesional.DropDownWidth = 121;
            this.cmb_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_profesional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_profesional.FormattingEnabled = true;
            this.cmb_profesional.IntegralHeight = false;
            this.cmb_profesional.ItemHeight = 43;
            this.cmb_profesional.Location = new System.Drawing.Point(351, 438);
            this.cmb_profesional.MaxDropDownItems = 4;
            this.cmb_profesional.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_profesional.Name = "cmb_profesional";
            this.cmb_profesional.Size = new System.Drawing.Size(144, 49);
            this.cmb_profesional.StartIndex = 0;
            this.cmb_profesional.TabIndex = 22;
            // 
            // btn_agendar_procedimiento
            // 
            this.btn_agendar_procedimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agendar_procedimiento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_agendar_procedimiento.Depth = 0;
            this.btn_agendar_procedimiento.HighEmphasis = true;
            this.btn_agendar_procedimiento.Icon = null;
            this.btn_agendar_procedimiento.Location = new System.Drawing.Point(749, 525);
            this.btn_agendar_procedimiento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_agendar_procedimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agendar_procedimiento.Name = "btn_agendar_procedimiento";
            this.btn_agendar_procedimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agendar_procedimiento.Size = new System.Drawing.Size(89, 36);
            this.btn_agendar_procedimiento.TabIndex = 23;
            this.btn_agendar_procedimiento.Text = "agendar";
            this.btn_agendar_procedimiento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_agendar_procedimiento.UseAccentColor = false;
            this.btn_agendar_procedimiento.UseVisualStyleBackColor = true;
            // 
            // FrmProcedimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 615);
            this.Controls.Add(this.btn_agendar_procedimiento);
            this.Controls.Add(this.cmb_profesional);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.cmb_hora_procedimiento);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmb_tipo_procedimiento);
            this.Controls.Add(this.date_fecha);
            this.Controls.Add(this.label_codorden);
            this.Name = "FrmProcedimiento";
            this.Text = "FrmProcedimiento";
            this.Load += new System.EventHandler(this.FrmProcedimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_codorden;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private MaterialSkin.Controls.MaterialComboBox cmb_tipo_procedimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmb_hora_procedimiento;
        private MaterialSkin.Controls.MaterialComboBox cmb_estado;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cmb_profesional;
        private MaterialSkin.Controls.MaterialButton btn_agendar_procedimiento;
    }
}