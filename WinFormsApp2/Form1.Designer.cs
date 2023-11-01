namespace WinFormsApp2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAddFile = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRegExFilter = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnMorp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAddFile
			// 
			this.btnAddFile.Location = new System.Drawing.Point(22, 21);
			this.btnAddFile.Name = "btnAddFile";
			this.btnAddFile.Size = new System.Drawing.Size(94, 37);
			this.btnAddFile.TabIndex = 0;
			this.btnAddFile.Text = "Dosya Ekle";
			this.btnAddFile.UseVisualStyleBackColor = true;
			this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(122, 58);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(125, 27);
			this.txtName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dosya Adı:";
			// 
			// txtRegExFilter
			// 
			this.txtRegExFilter.Location = new System.Drawing.Point(183, 242);
			this.txtRegExFilter.Name = "txtRegExFilter";
			this.txtRegExFilter.Size = new System.Drawing.Size(125, 27);
			this.txtRegExFilter.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(36, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "RegEx komutu girin:";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(196, 275);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(94, 29);
			this.btnFind.TabIndex = 7;
			this.btnFind.Text = "ara";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnMorp
			// 
			this.btnMorp.Location = new System.Drawing.Point(490, 173);
			this.btnMorp.Name = "btnMorp";
			this.btnMorp.Size = new System.Drawing.Size(154, 77);
			this.btnMorp.TabIndex = 8;
			this.btnMorp.Text = "Morfoloji Analizi Getir";
			this.btnMorp.UseVisualStyleBackColor = true;
			this.btnMorp.Click += new System.EventHandler(this.btnMorp_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 508);
			this.Controls.Add(this.btnMorp);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRegExFilter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnAddFile);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnAddFile;
		private TextBox txtName;
		private Label label1;
		private TextBox txtRegExFilter;
		private Label label2;
		private Button btnFind;
		private Button btnMorp;
	}
}