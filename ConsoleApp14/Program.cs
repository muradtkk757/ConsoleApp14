#region Tapsiriq 1
//Console.WriteLine("Ededi Daxil edin ");
//int eded = int.Parse(Console.ReadLine());
//if (eded % 2 == 0)
//{
//Console.WriteLine("Cutdur");
//}


//else
//{
//    Console.WriteLine("Tekdir");
//}
#endregion
#region Tapsiriq 2
//Console.WriteLine("Ededi Daxil Edin");
//int eded1 = int.Parse(Console.ReadLine()!);


//Console.WriteLine("2 ci Ededi Daxil Edin");
//int eded2 = int.Parse(Console.ReadLine()!);
//if (eded1 > eded2)
//{
//    Console.WriteLine("eded1 Boyukdur");
//}
//else
//{
//    Console.WriteLine("eded2 Boyukdur");
//}

#endregion
#region Tapsiriq 3
//Console.WriteLine("Ededi Daxil Edin");
//int eded1 = int.Parse(Console.ReadLine()!);

//if (eded1 > 0)
//{
//    Console.WriteLine("Eded Musbetdir");
//}
//else if (eded1 < 0)
//{
//    Console.WriteLine("Eded Musbetdir");
//}
//else
//{
//    Console.WriteLine("Sifirdir");
//}
#endregion
#region Tapsiriq 4
//Console.WriteLine("n ededini daxil edin:");
//int n = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("n ededini daxil edin:");
//int n = int.Parse(Console.ReadLine()!);

//int sum = 0;

//for (int i = 1; i <= n; i++)
//{
//    sum += i;
//}
#endregion
#region Tapsiriq 5
//Console.WriteLine($"Cem = {sum}");

//Console.Write("Ededi daxil edin: ");
//int n = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{n} x {i} = {n * i}");
//}

//
//Console.Write("Ededi daxil edin: ");
//int n = int.Parse(Console.ReadLine()!);

//int say = 0;
//int temp = Math.Abs(n);

//for (; temp > 0; temp /= 10)
//{
//    say++;
//}

//Console.WriteLine($"Eded {say} reqemlidir");
#endregion
#region  Tapsiriq 6
//Console.WriteLine("ededi daxil edin ");
//int n = int.Parse(Console.ReadLine()!);
//int reverse = 0;

//while (n > 0)
//{
//    int qaliq = n % 10;
//    reverse = reverse * 10 + qaliq;
//    n = n / 10;
//}

//Console.WriteLine(reverse);
#endregion
#region Tapsiriq 7
//Console.Write("n ededini daxil edin: ");
//int n = int.Parse(Console.ReadLine()!);

//int result = 1;

//for (int i = 1; i <= n; i++)
//{
//    result = result * i;
//}

//Console.WriteLine($"{n} = {result}");
#endregion
#region Tapsiriq 8
//Console.WriteLine("Ededleri Daxil Edin");
//int n = int.Parse(Console.ReadLine());
//int reversed = 0;

//while (n != 0)
//{
//    reversed = reversed * 10 + n % 10;
//    n /= 10;
//}

//Console.WriteLine(reversed);

#endregion
#region Tapsiriq 9
//Console.WriteLine("Faktorialını hesablamaq istədiyiniz tam ədədi daxil edin");
//int n = int.Parse(Console.ReadLine()!);
//long fakt = 1;

//if (n < 0)
//{
//    Console.WriteLine("Negatif sayilarin faktoriyeli olmaz.");
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        fakt *= i;
//    }

//    Console.WriteLine("{0}! = {1}", n, fakt);
//}
#endregion
#region Tapsiriq 10
//Console.WriteLine("Ededi daxil et");
//int N = int.Parse(Console.ReadLine()!);

//if (N > 0)
//{
//    long tekCem = 0;
//    long cutCem = 0;

//    for (int i = 1; i <= N; i++)
//    {
//        if (i % 2 == 0)
//        {
//            // Cütdür
//            cutCem += i;
//        }
//        else
//        {
//            // Təkdir
//            tekCem += i;
//        }
//    }

//    // Nəticənin çapı
//    Console.WriteLine($"\nNetice ({N}-e qeder) ");
//    Console.WriteLine($"Cüt ededlerin cemi: {cutCem}");
//    Console.WriteLine($"Tek ededlerin cemi: {tekCem}");
//}
//else
//{
//    Console.WriteLine("Verilmis eded duzgun deyil");
//}
#endregion
#region Tapsiriq 11
//Console.WriteLine("Reqemlerin tersini muqayise et");
//    Console.Write("Ededi Daxil et:");
//    int originaleded = int.Parse(Console.ReadLine());

//    int eded = originaleded;
//    long tersEded = 0;
//    while (eded != 0)
//{

//}

#endregion
#region Tapsiriq 12

//{
//    Console.Write("Metn daxil edin: ");
//    string metn = Console.ReadLine()!;
//    string saitHerfler = "aeiou";

//    int saitSayi = 0;
//    int samitSayi = 0;

//    for (int i = 0; i < metn.Length; i++)
//    {
//        char simvol = char.ToLower(metn[i]);


//        if (char.IsLetter(simvol))
//        {

//            if (saitHerfler.Contains(simvol))
//                saitSayi++;
//            else

//                samitSayi++;
//        }
//    }

//    Console.WriteLine($"\nDaxil edilən metn: {metn}");
//    Console.WriteLine($"Saitlerin sayı: {saitSayi}");
//    Console.WriteLine($"Samitlerin sayı: {samitSayi}");
//}
#endregion
#region Tapsiriq 13
//Console.WriteLine("3 e ve 5 e bolunen ededler");
//Console.Write("Daxil et ");
//int n=int.Parse(Console.ReadLine()!);
//for (int i = 1; i <= n; i++)
//{

//    if (i % 3 == 0 && i % 5 == 0)
//    {

//        Console.Write(i + " ");
//    }
//}
//Console.WriteLine("");

#endregion
#region Tapsiriq 14
//{
//    Console.WriteLine("İlk ve Son Rəqemlerin Yerini Deyişme");
//    Console.Write("En azı iki reqemli eded daxil edin");
//    string giris = Console.ReadLine()!;
//    if (giris.Length < 2 || !int.TryParse(giris, out _))
//     {
//        Console.WriteLine("XƏTA: Zəhmət olmasa, ən azı iki rəqəmli tam ədəd daxil edin.");
//        return;
//    }


//    char[] simvollar = giris.ToCharArray();


//    int ilkIndex = 0;
//    int sonIndex = simvollar.Length - 1;


//    char ilkSimvol = simvollar[ilkIndex];

//    // Birbaşa dəyişmə
//    simvollar[ilkIndex] = simvollar[sonIndex];
//    simvollar[sonIndex] = ilkSimvol;          

//    // 4. Yeni massivdən sətir yaradın.
//    string cixisSətir = new string(simvollar);

//    // 5. Yeni sətiri ədədə çevirin.
//    long cixisEded = long.Parse(cixisSətir);

//    Console.WriteLine($"\nGiriş: {giris}");
//    Console.WriteLine($"Çıxış: {cixisEded}");
//}

#endregion
#region Tapsiriq 15
//{
//    Console.WriteLine("15. Sadə Parol Yoxlamaq");
//    Console.Write("Parolu daxil edin: ");

//    // İstifadəçinin daxil etdiyi dəyəri alırıq.
//    string daxilEdilenParol = Console.ReadLine()!;


//    string dogruParol = "secret123";

//    // Parolların müqayisəsi
//    if (daxilEdilenParol == dogruParol)
//    {
//        Console.WriteLine("Girişe icaze verildi");
//    }
//    else
//    {
//        Console.WriteLine("Yanlış parol!");
//    }
//}
#endregion
#region Tapsiriq 16
//{
//    Console.WriteLine("Eded Tapma Oyunu (1-20 arası)");


//    Random random = new Random();
//    int gizliEded = random.Next(1, 21);
//    int texmin = 0;
//    int cehdSayi = 0;

//    Console.WriteLine("1-den 20-ye qeder bir eded tutdum.");

//    while (texmin != gizliEded)
//{
//        Console.Write("Texmininizi daxil edin: ");


//        texmin = int.Parse(Console.ReadLine()!);
//        cehdSayi++;


//        if (texmin < gizliEded)
//        {
//            Console.WriteLine("Çox kiçikdir. Daha böyük eded yoxla.");
//        }
//        else if (texmin > gizliEded)
//        {
//            Console.WriteLine("Çox böyükdür. Daha kiçik eded yoxla.");
//        }

//        }
//           Console.WriteLine($"\nEdedi {cehdSayi} cehddə tapdınız. Gizli eded {gizliEded} idi.");
// }
#endregion
#region Tapsiriq 17 
//Console.WriteLine("Sade Eded Yoxlama");
//Console.Write("Eded daxil edin");
//int eded =int.Parse(Console.ReadLine()!);
//bool sadeEdeddir = true;
//if (eded <= 1)
//{
// sadeEdeddir = false;
//}
//else
//{
//    for (int i = 2; i < eded; i++)
//    {

//        if (eded % i == 0)
//        {
//            sadeEdeddir = false;
//            break;             
//        }
//    }
//}

//// 3. Nəticə
//if (sadeEdeddir)
//{
//    Console.WriteLine($"{eded} sadə ədəddir.");
//}
//else
//{
//    Console.WriteLine($"{eded} sadə ədəd deyil.");
//}
#endregion
#region Tapsiriq 18
//{
//    Console.WriteLine("Üçbucaqlı Şəkilli Ulduz Patterni");
//    Console.Write("Üçbucağın ölçüsünü daxil edin ");
//    int N = int.Parse(Console.ReadLine()!);

//    for (int i = 1; i <= N; i++)
//    {

//        for (int j = 1; j <= i; j++)
//        {
//            // Ulduzun yan-yana çap edilməsi
//            Console.Write("*");
//        }
//            Console.WriteLine();
//    }
//}
#endregion