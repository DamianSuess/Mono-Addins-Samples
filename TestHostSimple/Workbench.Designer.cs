namespace TestHostSimple
{
  partial class Workbench
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
      this.MainMenu = new System.Windows.Forms.MenuStrip();
      this.ToolMenu = new System.Windows.Forms.MenuStrip();
      this.SuspendLayout();
      // 
      // MainMenu
      // 
      this.MainMenu.Location = new System.Drawing.Point(0, 0);
      this.MainMenu.Name = "MainMenu";
      this.MainMenu.Size = new System.Drawing.Size(399, 24);
      this.MainMenu.TabIndex = 1;
      this.MainMenu.Text = "menuStrip1";
      // 
      // ToolMenu
      // 
      this.ToolMenu.Location = new System.Drawing.Point(0, 24);
      this.ToolMenu.Name = "ToolMenu";
      this.ToolMenu.Size = new System.Drawing.Size(399, 24);
      this.ToolMenu.TabIndex = 2;
      this.ToolMenu.Text = "menuStrip2";
      // 
      // Workbench
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(399, 167);
      this.Controls.Add(this.ToolMenu);
      this.Controls.Add(this.MainMenu);
      this.Name = "Workbench";
      this.Text = "Main Workbench";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.MenuStrip ToolMenu;
  }
}

