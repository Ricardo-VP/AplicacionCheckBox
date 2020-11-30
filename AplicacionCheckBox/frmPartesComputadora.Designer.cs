namespace AplicacionCheckBox
{
    partial class frmPartesComputadora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4gb = new System.Windows.Forms.RadioButton();
            this.radioButton8gb = new System.Windows.Forms.RadioButton();
            this.radioButton12gb = new System.Windows.Forms.RadioButton();
            this.radioButton80gbds = new System.Windows.Forms.RadioButton();
            this.radioButton300gbds = new System.Windows.Forms.RadioButton();
            this.radioButton500gbds = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonPentiumi3 = new System.Windows.Forms.RadioButton();
            this.radioButtoni5 = new System.Windows.Forms.RadioButton();
            this.radioButtoni7 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxCam = new System.Windows.Forms.CheckBox();
            this.checkBoxImpresora = new System.Windows.Forms.CheckBox();
            this.checkBoxMouse = new System.Windows.Forms.CheckBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton12gb);
            this.groupBox1.Controls.Add(this.radioButton8gb);
            this.groupBox1.Controls.Add(this.radioButton4gb);
            this.groupBox1.Location = new System.Drawing.Point(72, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memoria RAM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton500gbds);
            this.groupBox2.Controls.Add(this.radioButton300gbds);
            this.groupBox2.Controls.Add(this.radioButton80gbds);
            this.groupBox2.Location = new System.Drawing.Point(324, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disco Duro";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton4gb
            // 
            this.radioButton4gb.AutoSize = true;
            this.radioButton4gb.Location = new System.Drawing.Point(35, 39);
            this.radioButton4gb.Name = "radioButton4gb";
            this.radioButton4gb.Size = new System.Drawing.Size(61, 21);
            this.radioButton4gb.TabIndex = 0;
            this.radioButton4gb.TabStop = true;
            this.radioButton4gb.Text = "4 GB";
            this.radioButton4gb.UseVisualStyleBackColor = true;
            // 
            // radioButton8gb
            // 
            this.radioButton8gb.AutoSize = true;
            this.radioButton8gb.Location = new System.Drawing.Point(35, 91);
            this.radioButton8gb.Name = "radioButton8gb";
            this.radioButton8gb.Size = new System.Drawing.Size(61, 21);
            this.radioButton8gb.TabIndex = 1;
            this.radioButton8gb.TabStop = true;
            this.radioButton8gb.Text = "8 GB";
            this.radioButton8gb.UseVisualStyleBackColor = true;
            // 
            // radioButton12gb
            // 
            this.radioButton12gb.AutoSize = true;
            this.radioButton12gb.Location = new System.Drawing.Point(35, 141);
            this.radioButton12gb.Name = "radioButton12gb";
            this.radioButton12gb.Size = new System.Drawing.Size(73, 21);
            this.radioButton12gb.TabIndex = 2;
            this.radioButton12gb.TabStop = true;
            this.radioButton12gb.Text = "12  GB";
            this.radioButton12gb.UseVisualStyleBackColor = true;
            // 
            // radioButton80gbds
            // 
            this.radioButton80gbds.AutoSize = true;
            this.radioButton80gbds.Location = new System.Drawing.Point(25, 39);
            this.radioButton80gbds.Name = "radioButton80gbds";
            this.radioButton80gbds.Size = new System.Drawing.Size(151, 21);
            this.radioButton80gbds.TabIndex = 0;
            this.radioButton80gbds.TabStop = true;
            this.radioButton80gbds.Text = "80 GB Disco Sólido";
            this.radioButton80gbds.UseVisualStyleBackColor = true;
            // 
            // radioButton300gbds
            // 
            this.radioButton300gbds.AutoSize = true;
            this.radioButton300gbds.Location = new System.Drawing.Point(25, 91);
            this.radioButton300gbds.Name = "radioButton300gbds";
            this.radioButton300gbds.Size = new System.Drawing.Size(159, 21);
            this.radioButton300gbds.TabIndex = 1;
            this.radioButton300gbds.TabStop = true;
            this.radioButton300gbds.Text = "300 GB Disco Sólido";
            this.radioButton300gbds.UseVisualStyleBackColor = true;
            // 
            // radioButton500gbds
            // 
            this.radioButton500gbds.AutoSize = true;
            this.radioButton500gbds.Location = new System.Drawing.Point(25, 141);
            this.radioButton500gbds.Name = "radioButton500gbds";
            this.radioButton500gbds.Size = new System.Drawing.Size(159, 21);
            this.radioButton500gbds.TabIndex = 2;
            this.radioButton500gbds.TabStop = true;
            this.radioButton500gbds.Text = "500 GB Disco Sólido";
            this.radioButton500gbds.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtoni7);
            this.groupBox3.Controls.Add(this.radioButtoni5);
            this.groupBox3.Controls.Add(this.radioButtonPentiumi3);
            this.groupBox3.Location = new System.Drawing.Point(579, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesador";
            // 
            // radioButtonPentiumi3
            // 
            this.radioButtonPentiumi3.AutoSize = true;
            this.radioButtonPentiumi3.Location = new System.Drawing.Point(31, 39);
            this.radioButtonPentiumi3.Name = "radioButtonPentiumi3";
            this.radioButtonPentiumi3.Size = new System.Drawing.Size(133, 21);
            this.radioButtonPentiumi3.TabIndex = 0;
            this.radioButtonPentiumi3.TabStop = true;
            this.radioButtonPentiumi3.Text = "Intel Pentium / i3";
            this.radioButtonPentiumi3.UseVisualStyleBackColor = true;
            // 
            // radioButtoni5
            // 
            this.radioButtoni5.AutoSize = true;
            this.radioButtoni5.Location = new System.Drawing.Point(31, 91);
            this.radioButtoni5.Name = "radioButtoni5";
            this.radioButtoni5.Size = new System.Drawing.Size(70, 21);
            this.radioButtoni5.TabIndex = 3;
            this.radioButtoni5.TabStop = true;
            this.radioButtoni5.Text = "Intel i5";
            this.radioButtoni5.UseVisualStyleBackColor = true;
            // 
            // radioButtoni7
            // 
            this.radioButtoni7.AutoSize = true;
            this.radioButtoni7.Location = new System.Drawing.Point(31, 141);
            this.radioButtoni7.Name = "radioButtoni7";
            this.radioButtoni7.Size = new System.Drawing.Size(70, 21);
            this.radioButtoni7.TabIndex = 3;
            this.radioButtoni7.TabStop = true;
            this.radioButtoni7.Text = "Intel i7";
            this.radioButtoni7.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxMouse);
            this.groupBox4.Controls.Add(this.checkBoxImpresora);
            this.groupBox4.Controls.Add(this.checkBoxCam);
            this.groupBox4.Location = new System.Drawing.Point(832, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 195);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accesorios";
            // 
            // checkBoxCam
            // 
            this.checkBoxCam.AutoSize = true;
            this.checkBoxCam.Location = new System.Drawing.Point(29, 40);
            this.checkBoxCam.Name = "checkBoxCam";
            this.checkBoxCam.Size = new System.Drawing.Size(112, 21);
            this.checkBoxCam.TabIndex = 0;
            this.checkBoxCam.Text = "Camara Wéb";
            this.checkBoxCam.UseVisualStyleBackColor = true;
            // 
            // checkBoxImpresora
            // 
            this.checkBoxImpresora.AutoSize = true;
            this.checkBoxImpresora.Location = new System.Drawing.Point(29, 92);
            this.checkBoxImpresora.Name = "checkBoxImpresora";
            this.checkBoxImpresora.Size = new System.Drawing.Size(116, 21);
            this.checkBoxImpresora.TabIndex = 1;
            this.checkBoxImpresora.Text = "Impresora HP";
            this.checkBoxImpresora.UseVisualStyleBackColor = true;
            // 
            // checkBoxMouse
            // 
            this.checkBoxMouse.AutoSize = true;
            this.checkBoxMouse.Location = new System.Drawing.Point(29, 142);
            this.checkBoxMouse.Name = "checkBoxMouse";
            this.checkBoxMouse.Size = new System.Drawing.Size(148, 21);
            this.checkBoxMouse.TabIndex = 2;
            this.checkBoxMouse.Text = "Mouse inalámbrico";
            this.checkBoxMouse.UseVisualStyleBackColor = true;
            // 
            // txtRes
            // 
            this.txtRes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.Location = new System.Drawing.Point(72, 273);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRes.Size = new System.Drawing.Size(960, 83);
            this.txtRes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPartesComputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPartesComputadora";
            this.Text = "Partes de la computadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton12gb;
        private System.Windows.Forms.RadioButton radioButton8gb;
        private System.Windows.Forms.RadioButton radioButton4gb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton500gbds;
        private System.Windows.Forms.RadioButton radioButton300gbds;
        private System.Windows.Forms.RadioButton radioButton80gbds;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtoni7;
        private System.Windows.Forms.RadioButton radioButtoni5;
        private System.Windows.Forms.RadioButton radioButtonPentiumi3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxMouse;
        private System.Windows.Forms.CheckBox checkBoxImpresora;
        private System.Windows.Forms.CheckBox checkBoxCam;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button button1;
    }
}