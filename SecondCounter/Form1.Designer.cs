namespace SecondCounter
{
    partial class Form1
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
            this.txtbx_input = new System.Windows.Forms.TextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.txtbx_output = new System.Windows.Forms.TextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_input
            // 
            this.txtbx_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_input.Location = new System.Drawing.Point(513, 172);
            this.txtbx_input.Name = "txtbx_input";
            this.txtbx_input.Size = new System.Drawing.Size(254, 60);
            this.txtbx_input.TabIndex = 0;
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.BackColor = System.Drawing.Color.Transparent;
            this.lbl_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(254, 175);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(219, 54);
            this.lbl_input.TabIndex = 1;
            this.lbl_input.Text = "Seconds:";
            this.lbl_input.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbx_output
            // 
            this.txtbx_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_output.Location = new System.Drawing.Point(513, 561);
            this.txtbx_output.Name = "txtbx_output";
            this.txtbx_output.Size = new System.Drawing.Size(888, 60);
            this.txtbx_output.TabIndex = 2;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.BackColor = System.Drawing.Color.Transparent;
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(32, 564);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(441, 54);
            this.lbl_output.TabIndex = 3;
            this.lbl_output.Text = "Converted seconds:";
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(513, 348);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(254, 97);
            this.btn_convert.TabIndex = 4;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1710, 858);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.txtbx_output);
            this.Controls.Add(this.txtbx_input);
            this.Controls.Add(this.lbl_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_input;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txtbx_output;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_convert;
    }
}

