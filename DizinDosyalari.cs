// Decompiled with JetBrains decompiler
// Type: DizinDosyalari
// Assembly: Pdf Oku, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A7538F97-A8FD-4FD5-A302-1BAA71D1B68D
// Assembly location: C:\Users\Veysel\Downloads\PdfOku\Pdf Oku.exe

using System.Collections.Generic;

public static class DizinDosyalari
{
  public static List<DizindekiDosyalar> DosyaList = new List<DizindekiDosyalar>();
  public static DizindekiDosyalar DD;

  public static void DosyaAdiEkle(string DosyaAdi)
  {
    DizinDosyalari.DD = new DizindekiDosyalar();
    DizinDosyalari.DD.DosyaAdi = DosyaAdi;
    DizinDosyalari.DosyaList.Add(DizinDosyalari.DD);
  }

  public static List<DizindekiDosyalar> DosyalariGetir()
  {
    return DizinDosyalari.DosyaList;
  }
}
