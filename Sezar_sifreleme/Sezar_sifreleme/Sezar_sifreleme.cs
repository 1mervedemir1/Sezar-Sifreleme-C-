using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sezar_sifreleme
{
    public class Sezar_sifreleme
    {
        private byte anahtar_sayi;
        private string kullanici_yazi;
        private string sifre_yazi;
        
        public Sezar_sifreleme(byte anahtar_sayi, string sifre_yazi)
        {
            this.anahtar_sayi = anahtar_sayi;
            this.kullanici_yazi = sifre_yazi;
        }

        //Türkçe karakterleri kontrol ediyoruz burada
        private bool TurkceMi(char karakter)
        {
            if (karakter == 'ç' || karakter == 'Ç' || karakter == 'ğ' || karakter == 'Ğ' || karakter == 'ı' || karakter == 'İ' || karakter == 'ö' || karakter == 'Ö' || karakter == 'ş' || karakter == 'Ş' || karakter == 'ü' || karakter == 'Ü')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string Sifrele()
        {
            sifre_yazi = "";

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceMi(kullanici_yazi[i]))
                {
                    int formul;
                    
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) + anahtar_sayi) % 26;
                        sifre_yazi += (char)(formul + 65);
                    }
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) + anahtar_sayi) % 26;
                        sifre_yazi += (char)(formul + 97);
                    }
                }
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }
            
            return sifre_yazi;
        }

        
        public string DesifreEt()
        {
            sifre_yazi = "";

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceMi(kullanici_yazi[i]))
                {
                    int formul;
                    
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) - anahtar_sayi) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 65);
                    }
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) - anahtar_sayi) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 97);
                    }
                }
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }
            
            return sifre_yazi;
        }
    }
}
