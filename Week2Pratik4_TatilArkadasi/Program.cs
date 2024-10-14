bool devamMi = true; // programin basa donup donmeyecegine karar vermek icin bool degerini basta atadik
int toplam = 0; // tatil maliyeti basta sifir olarak atanmistir 

while (devamMi)
{
    lokasyonYanlissa: //girilen lokasyon 3 secenek arasinda degilse tekrar soru sorulacak
    Console.WriteLine("Gitmek istediginiz lokasyonu giriniz (Bodrum/Marmaris/Cesme): ");
    string Lokasyon = Console.ReadLine().ToLower().Trim();
    
    if (Lokasyon == "marmaris")
        toplam += 3000; //cevaba gore paket baslangic fiyatlari maliyete ekleniyor
    else if (Lokasyon == "bodrum")
        toplam += 4000;
    else if (Lokasyon == "cesme")
        toplam += 5000;
    else
    {
        Console.WriteLine("yanlis lokasyon girdiniz tekrar deneyiniz: ");
        goto lokasyonYanlissa;
    }

    Console.WriteLine("Kac kisilik bir tatil dusunuyorsunuz: ");
    int KisiSayisi = Convert.ToInt32(Console.ReadLine());

YolYanlissa: // 1 veya 2 dfegeri disinda deger girilirse yol icin tekrar basa doner

    Console.WriteLine("1 - Kara yolu \n2- Hava yolu \nLütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1/2): ");
    int Yol = Convert.ToInt32 (Console.ReadLine());
    
    switch (Yol)
    {
        case 1:
            toplam += KisiSayisi * 1500;  //girilen yol tercihine gore maliyete ekleme yapilir
            break;
        case 2:
            toplam += KisiSayisi * 4000;
            break;
        default:
            {
                Console.WriteLine("Yanlis veri girdiniz bastan deneyiniz");
                goto YolYanlissa;
            }
    }
    Console.WriteLine("Gitmek istediginiz tatil maliyeti = " + toplam);
    Console.WriteLine("Tekrar tatil planlamak istiyor musunuz? (Evet/Hayir)");
    string Cevap = Console.ReadLine().ToLower().Trim();

    if (Cevap == "evet") 
        devamMi = true; // evet cevabinda while dongusu tekrar baslar ve hayir cevabinda while dongusu sonlanir
    else if (Cevap == "hayir")
    {
        Console.WriteLine ("Iyi gunler");
        devamMi = false;
    }
}
