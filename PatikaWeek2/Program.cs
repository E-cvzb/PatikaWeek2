
for (int i=0; i<=20;i++)//for döngüsünü 20 kere tekrar etirmek
{
    Console.WriteLine("Kendime inanıyorum ben bu işi başarabilirim");
}

for (int a=1;a<=20;a++)//20 ye kadar olan sayıları ekrana yazdırma
{
    Console.WriteLine(a);
}

for(int b =0; b <= 20; b += 2)
{
    Console.WriteLine("çift sayılar" +b);
}

int toplam1 = 0;
for (int c = 50; c <= 150; c++)
{
    toplam1 += c;
    Console.WriteLine("50 ile 150 sayıları arasındaki sayıalrın toplamı"+toplam1);
}
 int toplamçift = 0;
int toplamtek = 0;
for (int d=0; d<=120;d+=2)//çift sayıları teker teker toplayan döngü 
{
    toplamçift += d;
    Console.WriteLine("1 ile 120 sayıları arsındaki çift sayıları toplamı" + toplamçift);

}
for(int e = 1; e <= 120; e += 2)//1 ile 120 arası tek sayıların toplamını sırası ile yazan for 
{
    toplamtek += e;
    Console.WriteLine("1 ile 120 sayıları arası tek sayıların toplamı" + toplamtek);
}

