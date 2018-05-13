namespace WindowsForm_WcfCalculator
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Sum = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Substract = new System.Windows.Forms.Button();
            this.bt_Multiply = new System.Windows.Forms.Button();
            this.bt_Divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Http";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tcp";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "num1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "num2:";
            // 
            // bt_Sum
            // 
            this.bt_Sum.Location = new System.Drawing.Point(588, 106);
            this.bt_Sum.Name = "bt_Sum";
            this.bt_Sum.Size = new System.Drawing.Size(75, 23);
            this.bt_Sum.TabIndex = 6;
            this.bt_Sum.Text = "Sum";
            this.bt_Sum.UseVisualStyleBackColor = true;
            this.bt_Sum.Click += new System.EventHandler(this.bt_Sum_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result:";
            // 
            // bt_Substract
            // 
            this.bt_Substract.Location = new System.Drawing.Point(588, 160);
            this.bt_Substract.Name = "bt_Substract";
            this.bt_Substract.Size = new System.Drawing.Size(75, 23);
            this.bt_Substract.TabIndex = 9;
            this.bt_Substract.Text = "Substract";
            this.bt_Substract.UseVisualStyleBackColor = true;
            this.bt_Substract.Click += new System.EventHandler(this.bt_Substract_Click);
            // 
            // bt_Multiply
            // 
            this.bt_Multiply.Location = new System.Drawing.Point(588, 220);
            this.bt_Multiply.Name = "bt_Multiply";
            this.bt_Multiply.Size = new System.Drawing.Size(75, 23);
            this.bt_Multiply.TabIndex = 10;
            this.bt_Multiply.Text = "Multiply";
            this.bt_Multiply.UseVisualStyleBackColor = true;
            this.bt_Multiply.Click += new System.EventHandler(this.bt_Multiply_Click);
            // 
            // bt_Divide
            // 
            this.bt_Divide.Location = new System.Drawing.Point(588, 277);
            this.bt_Divide.Name = "bt_Divide";
            this.bt_Divide.Size = new System.Drawing.Size(75, 23);
            this.bt_Divide.TabIndex = 11;
            this.bt_Divide.Text = "Divide";
            this.bt_Divide.UseVisualStyleBackColor = true;
            this.bt_Divide.Click += new System.EventHandler(this.bt_Divide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Divide);
            this.Controls.Add(this.bt_Multiply);
            this.Controls.Add(this.bt_Substract);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bt_Sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Sum;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Substract;
        private System.Windows.Forms.Button bt_Multiply;
        private System.Windows.Forms.Button bt_Divide;
    }
}

