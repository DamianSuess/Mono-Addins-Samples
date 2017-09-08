namespace TestMonoAddin
{
  partial class Form1
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
      this.btnPullData = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnPullData
      // 
      this.btnPullData.Location = new System.Drawing.Point(12, 64);
      this.btnPullData.Name = "btnPullData";
      this.btnPullData.Size = new System.Drawing.Size(75, 23);
      this.btnPullData.TabIndex = 0;
      this.btnPullData.Text = "Pull Data";
      this.btnPullData.UseVisualStyleBackColor = true;
      this.btnPullData.Click += new System.EventHandler(this.btnPullData_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(399, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // menuStrip2
      // 
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
      this.menuStrip2.Location = new System.Drawing.Point(0, 24);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(399, 24);
      this.menuStrip2.TabIndex = 2;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
      this.toolStripMenuItem1.Text = "File";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.copyToolStripMenuItem.Text = "Copy";
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.pasteToolStripMenuItem.Text = "Paste";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(399, 167);
      this.Controls.Add(this.menuStrip2);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.btnPullData);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnPullData;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
  }
}

