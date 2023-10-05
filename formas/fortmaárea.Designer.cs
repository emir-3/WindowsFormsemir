
namespace WindowsFormsemir.formas
{
    partial class formaárea
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBase = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.Label();
            this.textBoxbase = new System.Windows.Forms.TextBox();
            this.textBoxaltura = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(131, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de área del triángulo";
            // 
            // textBase
            // 
            this.textBase.AutoSize = true;
            this.textBase.BackColor = System.Drawing.Color.Pink;
            this.textBase.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBase.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBase.Location = new System.Drawing.Point(180, 128);
            this.textBase.Name = "textBase";
            this.textBase.Size = new System.Drawing.Size(126, 39);
            this.textBase.TabIndex = 1;
            this.textBase.Text = "Base:";
            this.textBase.Click += new System.EventHandler(this.label2_Click);
            // 
            // textAltura
            // 
            this.textAltura.AutoSize = true;
            this.textAltura.BackColor = System.Drawing.Color.Pink;
            this.textAltura.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAltura.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textAltura.Location = new System.Drawing.Point(138, 204);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(168, 39);
            this.textAltura.TabIndex = 2;
            this.textAltura.Text = "Altura:";
            // 
            // textBoxbase
            // 
            this.textBoxbase.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbase.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxbase.Location = new System.Drawing.Point(350, 128);
            this.textBoxbase.Name = "textBoxbase";
            this.textBoxbase.Size = new System.Drawing.Size(436, 43);
            this.textBoxbase.TabIndex = 3;
            // 
            // textBoxaltura
            // 
            this.textBoxaltura.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxaltura.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxaltura.Location = new System.Drawing.Point(350, 204);
            this.textBoxaltura.Multiline = true;
            this.textBoxaltura.Name = "textBoxaltura";
            this.textBoxaltura.Size = new System.Drawing.Size(436, 37);
            this.textBoxaltura.TabIndex = 4;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.Pink;
            this.buttonCalcular.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCalcular.Location = new System.Drawing.Point(360, 256);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(192, 59);
            this.buttonCalcular.TabIndex = 14;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(131, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Area";
            // 
            // textBoxarea
            // 
            this.textBoxarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxarea.Location = new System.Drawing.Point(350, 382);
            this.textBoxarea.Name = "textBoxarea";
            this.textBoxarea.Size = new System.Drawing.Size(436, 40);
            this.textBoxarea.TabIndex = 16;
            this.textBoxarea.TextChanged += new System.EventHandler(this.textBoxarea_TextChanged);
            // 
            // formaárea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsemir.Properties.Resources.fondo21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 466);
            this.Controls.Add(this.textBoxarea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxaltura);
            this.Controls.Add(this.textBoxbase);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.textBase);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formaárea";
            this.Text = "fortmaárea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textBase;
        private System.Windows.Forms.Label textAltura;
        private System.Windows.Forms.TextBox textBoxbase;
        private System.Windows.Forms.TextBox textBoxaltura;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxarea;
    }
}