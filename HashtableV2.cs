using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static Hashtable TABLE = new Hashtable();
        static void Main(string[] args)
        {
            Main:
            Console.Write("[1] Kayıt Ol / [2] Giriş Yap");
            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                string kAdı = propmtUserName();
                string Şifre = propmtPassword();
                
                if (checkUser(kAdı) != true)
                {
                    add(kAdı, Şifre);
                    Console.WriteLine($"Kayıt İşlemi Başarılı {checkUser(kAdı)}");
                    Thread.Sleep(msHesapla(1));
                    Console.Clear();
                    goto Main;
                }
                else
                {
                    Console.WriteLine("Bu kullanıcı adı önceden alınmış");
                    Thread.Sleep(msHesapla(1));
                    Console.Clear();
                    goto Main;
                }
            }
            else if(x == 2)
            {
                string kAdı = propmtUserName();
                string Şifre = propmtPassword();

                if (checkUser(kAdı))
                {
                    if (Şifre == TABLE[kAdı].ToString())
                    {
                        LoginMain:
                        Console.Clear();
                        Console.WriteLine($"Hoş geldin {kAdı}");
                        Console.WriteLine($"[1] Üyeleri Görüntüle [2] Çıkış");
                        Console.WriteLine();
                        int Y = int.Parse(Console.ReadLine());

                        if (Y == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Üye listes | -1 Ana sayfa");
                            listele();
                            Console.ReadKey();
                            goto LoginMain;
                        }else if( Y == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Çıkış yapılıyor");
                            Thread.Sleep(msHesapla(2));
                            Console.Clear();
                            goto Main;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adı yada şifre yanlış");
                        Thread.Sleep(msHesapla(1));
                        Console.Clear();
                        goto Main;
                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı yada şifre yanlış");
                    Thread.Sleep(msHesapla(1));
                    Console.Clear();
                    goto Main;
                }

            }

        }

        static void add(string key, string value)
        {
            TABLE.Add(key, value);
        }

        static void listele()
        {
            foreach (DictionaryEntry item in TABLE)
            {
                Console.WriteLine(item.Key);
            }
        }

        static bool checkUser(string username)
        {
            if (TABLE.ContainsKey(username))
            {
                return true;
            }
            return false;
        }
        static int msHesapla(int ms)
        {
            return ms * 1000;
        }

        static string propmtUserName()
        {
            Console.Clear();
            Console.Write("Kullanıcı adı > ");
            string kAdı = Console.ReadLine();

            return kAdı;
        }
        static string propmtPassword()
        {
            Console.Write("Şifre > ");
            string Şifre = Console.ReadLine();

            return Şifre;
        }
    }
}
