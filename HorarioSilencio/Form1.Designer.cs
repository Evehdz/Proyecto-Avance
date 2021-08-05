
namespace HorarioSilencio
{
    partial class FormHorarioSilencio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorarioSilencio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsilencioh1 = new System.Windows.Forms.Button();
            this.btnsilencioh2 = new System.Windows.Forms.Button();
            this.btnsilencioh3 = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.lbNombreSilencio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(194, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SINOPSIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(194, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(194, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(254, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "97 min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(116, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "ESP";
            // 
            // btnsilencioh1
            // 
            this.btnsilencioh1.Location = new System.Drawing.Point(186, 192);
            this.btnsilencioh1.Name = "btnsilencioh1";
            this.btnsilencioh1.Size = new System.Drawing.Size(55, 23);
            this.btnsilencioh1.TabIndex = 2;
            this.btnsilencioh1.Text = "13:30";
            this.btnsilencioh1.UseVisualStyleBackColor = true;
            this.btnsilencioh1.Click += new System.EventHandler(this.btnsilencioh1_Click);
            // 
            // btnsilencioh2
            // 
            this.btnsilencioh2.Location = new System.Drawing.Point(298, 192);
            this.btnsilencioh2.Name = "btnsilencioh2";
            this.btnsilencioh2.Size = new System.Drawing.Size(55, 23);
            this.btnsilencioh2.TabIndex = 2;
            this.btnsilencioh2.Text = "15:30";
            this.btnsilencioh2.UseVisualStyleBackColor = true;
            this.btnsilencioh2.Click += new System.EventHandler(this.btnsilencioh2_Click);
            // 
            // btnsilencioh3
            // 
            this.btnsilencioh3.Location = new System.Drawing.Point(414, 192);
            this.btnsilencioh3.Name = "btnsilencioh3";
            this.btnsilencioh3.Size = new System.Drawing.Size(55, 23);
            this.btnsilencioh3.TabIndex = 2;
            this.btnsilencioh3.Text = "17:30";
            this.btnsilencioh3.UseVisualStyleBackColor = true;
            this.btnsilencioh3.Click += new System.EventHandler(this.btnsilencioh3_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregresar.BackgroundImage")));
            this.btnregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregresar.Location = new System.Drawing.Point(41, 261);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(35, 20);
            this.btnregresar.TabIndex = 2;
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // lbNombreSilencio
            // 
            this.lbNombreSilencio.AutoSize = true;
            this.lbNombreSilencio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreSilencio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombreSilencio.Location = new System.Drawing.Point(41, 21);
            this.lbNombreSilencio.Name = "lbNombreSilencio";
            this.lbNombreSilencio.Size = new System.Drawing.Size(232, 20);
            this.lbNombreSilencio.TabIndex = 3;
            this.lbNombreSilencio.Text = "Un lugar en silencio Parte II";
            // 
            // FormHorarioSilencio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNombreSilencio);
            this.Controls.Add(this.btnsilencioh3);
            this.Controls.Add(this.btnsilencioh2);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnsilencioh1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormHorarioSilencio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsilencioh1;
        private System.Windows.Forms.Button btnsilencioh2;
        private System.Windows.Forms.Button btnsilencioh3;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label lbNombreSilencio;
    }
}

