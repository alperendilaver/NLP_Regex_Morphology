namespace WinFormsApp2
{
	partial class Result
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
			this.txtResult = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(12, 57);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(812, 425);
			this.txtResult.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(369, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "SONUÇLAR";
			// 
			// Result
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 494);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtResult);
			this.Name = "Result";
			this.Text = "Result";
			this.Load += new System.EventHandler(this.Result_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public TextBox txtResult;
		private Label label1;
	}
}