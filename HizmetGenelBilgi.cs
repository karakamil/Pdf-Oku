// Decompiled with JetBrains decompiler
// Type: HizmetGenelBilgi
// Assembly: Pdf Oku, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A7538F97-A8FD-4FD5-A302-1BAA71D1B68D
// Assembly location: C:\Users\Veysel\Downloads\PdfOku\Pdf Oku.exe

public class HizmetGenelBilgi
{
    public string Donem { get; set; }

    public string BelgeTuru { get; set; }

    public string Mahiyet { get; set; }

    public string KanunNo { get; set; }
}

public class Deneme
{
    public void Hesapla(HizmetGenelBilgi bilgi)
    {
        
    }
}

public class IslemYap
{
    public IslemYap()
    {
        HizmetGenelBilgi bilgi = new HizmetGenelBilgi();
        Deneme den = new Deneme();
        den.Hesapla(bilgi);
    }

}