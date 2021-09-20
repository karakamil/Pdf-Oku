// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp3.Program
// Assembly: Pdf Oku, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A7538F97-A8FD-4FD5-A302-1BAA71D1B68D
// Assembly location: C:\Users\Veysel\Downloads\PdfOku\Pdf Oku.exe

using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  internal static class Program
  {
    public static string PdfGuvenlikKodu = "";
    public static string ResimDosyaAdi = "";

    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
