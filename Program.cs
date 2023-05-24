using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] ucgen=new int[3];
            int[] dortlu=new int[2];
            int[] daire=new int[1];
            int[] besgen=new int[1];
            int[] kenarlar=new int[4];

            Console.WriteLine("Hangi şekil hesapalanacak ? ");
            Console.WriteLine("1.Ucgen /2.Kare /3.Dikdortgen /4.Daire /5.Besgen");
            Console.WriteLine("Tercihi giriniz :");
            int x=Convert.ToInt32(Console.ReadLine());
            switch(x){
                case 1:
                    Console.WriteLine("Ucgen kenarlarını giriniz...");
                    for(int i=0;i<ucgen.Length;i++){
                        Console.Write("{0} nci kenar :",i+1);
                        try{
                            ucgen[i]=Convert.ToInt32(Console.ReadLine());
                            kenarlar[i]=ucgen[i];
                        }catch(FormatException e){
                            Console.WriteLine("Hatalı giriş ! Sayi girmelisiniz.");
                        }                       

                    }
                   
                    break;
                case 2:
                 Console.WriteLine("Kare kenarını giriniz...");
                    
                        
                        try{
                            dortlu[0]=Convert.ToInt32(Console.ReadLine());
                            kenarlar[0]=dortlu[0];
                        }catch(FormatException e){
                            Console.WriteLine("Hatalı giriş ! Sayi girmelisiniz.");
                        }                       

                    
                    break;
                case 3:
                 Console.WriteLine("Dortgen kenarlarını giriniz...");
                    for(int i=0;i<dortlu.Length;i++){
                        Console.Write("{0} nci kenar :",i+1);
                        try{
                            dortlu[i]=Convert.ToInt32(Console.ReadLine());
                            kenarlar[i]=dortlu[i];
                        }catch(FormatException e){
                            Console.WriteLine("Hatalı giriş ! Sayi girmelisiniz.");
                        }                       

                    }
                    break;
                case 4:
                 Console.WriteLine("Daire yarıcap giriniz...");
                    for(int i=0;i<daire.Length;i++){
                        Console.Write("Yaricap:");
                        try{
                            daire[i]=Convert.ToInt32(Console.ReadLine());
                            kenarlar[i]=daire[i];
                        }catch(FormatException e){
                            Console.WriteLine("Hatalı giriş ! Sayi girmelisiniz.");
                        }                       

                    }
                    break;
                case 5:
                 Console.WriteLine("Besgen kenarlarını giriniz...");
                    for(int i=0;i<besgen.Length;i++){
                        Console.Write("{0} nci kenar :",i+1);
                        try{
                            besgen[i]=Convert.ToInt32(Console.ReadLine());
                            kenarlar[i]=besgen[i];
                        }catch(FormatException e){
                            Console.WriteLine("Hatalı giriş ! Sayi girmelisiniz.");
                        }                       

                    }
                    break;
            }


            Console.WriteLine("Hesaplanacak ozellik seciniz");
            Console.Write("1.Cevre /2.Alan  :");
            int y=Convert.ToInt32(Console.ReadLine());
            switch(y){
                case 1:
                    CevreHesapla(x,kenarlar);
                    break;
                case 2:
                    AlanHesapla(x,kenarlar);
                    break;
               /* case 3:
                    break;*/

            }

        
    }

     public  enum sekiller
     {
        Ucgen=1,Kare=2,Dikdortgen=3,Daire,Besgen
     }

   
    public static void CevreHesapla(int x,int[] kenar){
        //"1.Ucgen /2.Kare /3.Dikdortgen /4.Daire /5.Besgen"
        double cevre=0;
        switch(x){
                case 1:
                    for(int i=0;i<kenar.Length;i++){
                        cevre+=kenar[i];
                    }
                    break;
                case 2:
                    cevre=kenar[0]*4;
                    break;
                case 3:
                    for(int i=0;i<kenar.Length;i++){
                            cevre+=kenar[i]*2;
                        }
                    break;
                case 4:
                    cevre=2*Math.PI*kenar[0];
                    break;
                case 5:
                    for(int i=0;i<kenar.Length;i++){
                            cevre+=kenar[i]*2;
                        }
                    break;

            }

            Console.WriteLine("{0} seklinin cevresi={1} br",Enum.GetName(typeof(sekiller),x),cevre);



    }
    public static void AlanHesapla(int x,int[] kenar){
        //"1.Ucgen /2.Kare /3.Dikdortgen /4.Daire /5.Besgen"
        double alan=0,cevre=0,u=0;
        switch(x){
                case 1:
                    
                    for(int i=0;i<kenar.Length;i++){
                        cevre+=kenar[i];
                    }
                    u=cevre/2;
                    alan=Math.Sqrt(u*(u-kenar[0])*(u-kenar[1])*(u-kenar[2]));
                    
                    break;
                case 2:
                    alan=kenar[0]*kenar[0];
                    break;
                case 3:
                    alan=kenar[0]*kenar[1];
                    break;
                case 4:
                    alan=Math.PI*kenar[0]*kenar[0];
                    break;
                case 5:
                    alan=Math.Sqrt(Math.Sqrt(25+10*Math.Sqrt(5)))*kenar[0]/4;
                    break;

            }

            Console.WriteLine("{0} seklinin alanı={1} br^2",Enum.GetName(typeof(sekiller),x),alan);
    }
    }
}