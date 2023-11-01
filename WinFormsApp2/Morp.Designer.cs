namespace WinFormsApp2
{
	partial class Morp
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
			this.txtMorp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtResultFull = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.txtBeforeAnalyze = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAfterAnalyze = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMorp
			// 
			this.txtMorp.Location = new System.Drawing.Point(34, 26);
			this.txtMorp.Multiline = true;
			this.txtMorp.Name = "txtMorp";
			this.txtMorp.ReadOnly = true;
			this.txtMorp.Size = new System.Drawing.Size(430, 372);
			this.txtMorp.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(390, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Morfoloji Analizi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(34, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 28);
			this.label2.TabIndex = 2;
			this.label2.Text = "Eşsiz Kökler";
			// 
			// txtResultFull
			// 
			this.txtResultFull.Location = new System.Drawing.Point(6, 6);
			this.txtResultFull.Multiline = true;
			this.txtResultFull.Name = "txtResultFull";
			this.txtResultFull.ReadOnly = true;
			this.txtResultFull.Size = new System.Drawing.Size(926, 441);
			this.txtResultFull.TabIndex = 3;
			this.txtResultFull.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 44);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(946, 486);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.txtMorp);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(938, 453);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtResultFull);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(938, 453);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.txtAfterAnalyze);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.txtBeforeAnalyze);
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(938, 453);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// txtBeforeAnalyze
			// 
			this.txtBeforeAnalyze.Location = new System.Drawing.Point(362, 74);
			this.txtBeforeAnalyze.Name = "txtBeforeAnalyze";
			this.txtBeforeAnalyze.ReadOnly = true;
			this.txtBeforeAnalyze.Size = new System.Drawing.Size(105, 27);
			this.txtBeforeAnalyze.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(21, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(335, 28);
			this.label3.TabIndex = 1;
			this.label3.Text = "Kök almadan önce eşsiz kelime sayısı:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(21, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(336, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kök aldıktan sonra eşsiz kelime sayısı:";
			// 
			// txtAfterAnalyze
			// 
			this.txtAfterAnalyze.Location = new System.Drawing.Point(362, 153);
			this.txtAfterAnalyze.Name = "txtAfterAnalyze";
			this.txtAfterAnalyze.ReadOnly = true;
			this.txtAfterAnalyze.Size = new System.Drawing.Size(105, 27);
			this.txtAfterAnalyze.TabIndex = 2;
			// 
			// Morp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 559);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.Name = "Morp";
			this.Text = "Morp";
			this.Load += new System.EventHandler(this.Morp_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public TextBox txtMorp;
		private Label label1;
		private Label label2;
		public TextBox txtResultFull;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private Label label4;
		private Label label3;
		public TextBox txtBeforeAnalyze;
		public TextBox txtAfterAnalyze;
	}
}