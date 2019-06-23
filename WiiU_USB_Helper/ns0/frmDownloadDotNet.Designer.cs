namespace ns0
{
	// Token: 0x02000176 RID: 374
	public partial class frmDownloadDotNet : global::System.Windows.Forms.Form
	{
		// Token: 0x06000AE0 RID: 2784 RVA: 0x00017B02 File Offset: 0x00015D02
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0003D678 File Offset: 0x0003B878
		private void InitializeComponent()
		{
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = global::ns0.Class121.error;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(131, 134);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(152, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(316, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "An error has occured.";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Black;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(155, 61);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(302, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "The application was unable to find some required components.";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Black;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(155, 85);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(311, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Please make sure you have installed the required dependencies.";
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.button1.Location = new global::System.Drawing.Point(217, 122);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(179, 24);
			this.button1.TabIndex = 4;
			this.button1.Text = "Install .NET";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(502, 162);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmDownloadDotNet";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "An error has occured";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000627 RID: 1575
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000628 RID: 1576
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000629 RID: 1577
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400062A RID: 1578
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400062B RID: 1579
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400062C RID: 1580
		private global::System.Windows.Forms.Button button1;
	}
}
