// Decompiled with JetBrains decompiler
// Type: ParaBirimi
// Assembly: Pdf Oku, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A7538F97-A8FD-4FD5-A302-1BAA71D1B68D
// Assembly location: C:\Users\Veysel\Downloads\PdfOku\Pdf Oku.exe

using System;
using System.Threading;

public static class ParaBirimi
{
  public static double PBCevir(string Tutar)
  {
    Tutar = Tutar.Trim();
    if (Tutar == "")
      Tutar = "0";
    string decimalSeparator1 = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
    string decimalSeparator2 = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
    if (decimalSeparator1 == ",")
    {
      if (Tutar.ToString().IndexOf(".") != -1)
        return Convert.ToDouble(Tutar.Replace(".", ","));
      return Convert.ToDouble(Tutar);
    }
    if (decimalSeparator2 == ".")
    {
      if (Tutar.ToString().IndexOf(",") != -1)
        return Convert.ToDouble(Tutar.Replace(",", "."));
      return Convert.ToDouble(Tutar);
    }
    if (Tutar.ToString().IndexOf(".") != -1)
      return Convert.ToDouble(Tutar.Replace(".", ","));
    return Convert.ToDouble(Tutar);
  }
}
