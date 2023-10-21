namespace ValidacionPatentesCuit
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.itemVieja = new System.Windows.Forms.RadioButton();
			this.irenNueva = new System.Windows.Forms.RadioButton();
			this.patVieja = new System.Windows.Forms.MaskedTextBox();
			this.patNueva = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btRegistrar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblRes = new System.Windows.Forms.Label();
			this.txtCuit = new System.Windows.Forms.TextBox();
			this.btCargar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblCuit = new System.Windows.Forms.Label();
			this.lblDNI = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblDNI);
			this.groupBox1.Controls.Add(this.lblCuit);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btCargar);
			this.groupBox1.Controls.Add(this.txtCuit);
			this.groupBox1.Controls.Add(this.lblRes);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btRegistrar);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.patNueva);
			this.groupBox1.Controls.Add(this.patVieja);
			this.groupBox1.Controls.Add(this.irenNueva);
			this.groupBox1.Controls.Add(this.itemVieja);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(60, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 380);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Seleciona el tipo de patente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(519, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ingresa CUIT";
			// 
			// itemVieja
			// 
			this.itemVieja.AutoSize = true;
			this.itemVieja.Location = new System.Drawing.Point(34, 60);
			this.itemVieja.Name = "itemVieja";
			this.itemVieja.Size = new System.Drawing.Size(88, 17);
			this.itemVieja.TabIndex = 2;
			this.itemVieja.TabStop = true;
			this.itemVieja.Text = "Patente Vieja";
			this.itemVieja.UseVisualStyleBackColor = true;
			// 
			// irenNueva
			// 
			this.irenNueva.AutoSize = true;
			this.irenNueva.Location = new System.Drawing.Point(202, 60);
			this.irenNueva.Name = "irenNueva";
			this.irenNueva.Size = new System.Drawing.Size(97, 17);
			this.irenNueva.TabIndex = 3;
			this.irenNueva.TabStop = true;
			this.irenNueva.Text = "Patente Nueva";
			this.irenNueva.UseVisualStyleBackColor = true;
			// 
			// patVieja
			// 
			this.patVieja.BackColor = System.Drawing.SystemColors.Window;
			this.patVieja.Location = new System.Drawing.Point(34, 139);
			this.patVieja.Mask = "LLL-000";
			this.patVieja.Name = "patVieja";
			this.patVieja.Size = new System.Drawing.Size(94, 20);
			this.patVieja.TabIndex = 4;
			// 
			// patNueva
			// 
			this.patNueva.Location = new System.Drawing.Point(202, 139);
			this.patNueva.Mask = "LL-000-LL";
			this.patNueva.Name = "patNueva";
			this.patNueva.Size = new System.Drawing.Size(94, 20);
			this.patNueva.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ingrese letra y numero.";
			// 
			// btRegistrar
			// 
			this.btRegistrar.Location = new System.Drawing.Point(115, 188);
			this.btRegistrar.Name = "btRegistrar";
			this.btRegistrar.Size = new System.Drawing.Size(99, 25);
			this.btRegistrar.TabIndex = 7;
			this.btRegistrar.Text = "Registrar";
			this.btRegistrar.UseVisualStyleBackColor = true;
			this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "La patente ingresada es:";
			// 
			// lblRes
			// 
			this.lblRes.AutoSize = true;
			this.lblRes.Location = new System.Drawing.Point(161, 264);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(35, 13);
			this.lblRes.TabIndex = 9;
			this.lblRes.Text = "label5";
			// 
			// txtCuit
			// 
			this.txtCuit.Location = new System.Drawing.Point(494, 74);
			this.txtCuit.Name = "txtCuit";
			this.txtCuit.Size = new System.Drawing.Size(110, 20);
			this.txtCuit.TabIndex = 10;
			// 
			// btCargar
			// 
			this.btCargar.Location = new System.Drawing.Point(494, 134);
			this.btCargar.Name = "btCargar";
			this.btCargar.Size = new System.Drawing.Size(102, 25);
			this.btCargar.TabIndex = 11;
			this.btCargar.Text = "Cargar";
			this.btCargar.UseVisualStyleBackColor = true;
			this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(491, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "el CUIT es :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(491, 235);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "el DNI es:";
			// 
			// lblCuit
			// 
			this.lblCuit.AutoSize = true;
			this.lblCuit.Location = new System.Drawing.Point(561, 200);
			this.lblCuit.Name = "lblCuit";
			this.lblCuit.Size = new System.Drawing.Size(0, 13);
			this.lblCuit.TabIndex = 14;
			// 
			// lblDNI
			// 
			this.lblDNI.AutoSize = true;
			this.lblDNI.Location = new System.Drawing.Point(561, 235);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(0, 13);
			this.lblDNI.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblRes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btRegistrar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox patNueva;
		private System.Windows.Forms.MaskedTextBox patVieja;
		private System.Windows.Forms.RadioButton irenNueva;
		private System.Windows.Forms.RadioButton itemVieja;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDNI;
		private System.Windows.Forms.Label lblCuit;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btCargar;
		private System.Windows.Forms.TextBox txtCuit;
	}
}

