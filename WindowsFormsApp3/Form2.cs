// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp3.Form2
// Assembly: Pdf Oku, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A7538F97-A8FD-4FD5-A302-1BAA71D1B68D
// Assembly location: C:\Users\Veysel\Downloads\PdfOku\Pdf Oku.exe

using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public class Form2 : Form
  {
    private IContainer components;
    private TextBox txtBaglanti;
    private Button button1;

    public Form2()
    {
      this.InitializeComponent();
    }

    public static void AppSettingsWrite(string key, string value)
    {
      System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      configuration.AppSettings.Settings[key].Value = value;
      configuration.Save(ConfigurationSaveMode.Modified);
      ConfigurationManager.RefreshSection("appSettings");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Form2.AppSettingsWrite("Baglanti", this.txtBaglanti.Text);
      Application.Restart();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      this.txtBaglanti.Text = ConfigurationManager.AppSettings["Baglanti"];
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.txtBaglanti = new TextBox();
      this.button1 = new Button();
      this.SuspendLayout();
      this.txtBaglanti.Location = new Point(12, 12);
      this.txtBaglanti.Name = "txtBaglanti";
      this.txtBaglanti.Size = new Size(602, 20);
      this.txtBaglanti.TabIndex = 0;
      this.button1.Location = new Point(225, 38);
      this.button1.Name = "button1";
      this.button1.Size = new Size(189, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Kaydet";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(626, 76);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.txtBaglanti);
     // this.Name = nameof (Form2);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Connection String";
      this.Load += new EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
