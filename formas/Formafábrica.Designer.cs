
namespace WindowsFormsemir.formas
{
    partial class Formafábrica
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
            this.textBoxaumento = new System.Windows.Forms.TextBox();
            this.textBoxsalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttoncalcularr = new System.Windows.Forms.Button();
            this.textBoxresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxaumento
            // 
            this.textBoxaumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxaumento.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxaumento.Location = new System.Drawing.Point(398, 179);
            this.textBoxaumento.Name = "textBoxaumento";
            this.textBoxaumento.Size = new System.Drawing.Size(334, 40);
            this.textBoxaumento.TabIndex = 21;
            // 
            // textBoxsalario
            // 
            this.textBoxsalario.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsalario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxsalario.Location = new System.Drawing.Point(398, 99);
            this.textBoxsalario.Name = "textBoxsalario";
            this.textBoxsalario.Size = new System.Drawing.Size(334, 43);
            this.textBoxsalario.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "Aumneto del 25%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(313, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "Salario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(181, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 43);
            this.label3.TabIndex = 22;
            this.label3.Text = "Salario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttoncalcularr
            // 
            this.buttoncalcularr.BackColor = System.Drawing.Color.Pink;
            this.buttoncalcularr.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncalcularr.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttoncalcularr.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttoncalcularr.Location = new System.Drawing.Point(398, 238);
            this.buttoncalcularr.Name = "buttoncalcularr";
            this.buttoncalcularr.Size = new System.Drawing.Size(136, 63);
            this.buttoncalcularr.TabIndex = 23;
            this.buttoncalcularr.Text = "Calcular";
            this.buttoncalcularr.UseVisualStyleBackColor = false;
            this.buttoncalcularr.Click += new System.EventHandler(this.buttoncalcularr_Click);
            // 
            // textBoxresultado
            // 
            this.textBoxresultado.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxresultado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxresultado.Location = new System.Drawing.Point(398, 334);
            this.textBoxresultado.Name = "textBoxresultado";
            this.textBoxresultado.Size = new System.Drawing.Size(334, 43);
            this.textBoxresultado.TabIndex = 24;
            // 
            // Formafábrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsemir.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxresultado);
            this.Controls.Add(this.buttoncalcularr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxaumento);
            this.Controls.Add(this.textBoxsalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Formafábrica";
            this.Text = "Formafábrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxaumento;
        private System.Windows.Forms.TextBox textBoxsalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttoncalcularr;
        private System.Windows.Forms.TextBox textBoxresultado;
    }
}