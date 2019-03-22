using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulaması
{

    public class Hesap
    {
        public Kullanıcı Kullanıcı;
        private string _hesapNo;
        public string HesapNo
        {

            get { return _hesapNo;}
            set
            {
                int x = 0;

                if (int.TryParse(value, out x)&& value.Length==6)
                {
                    _hesapNo = value;

                }
                else
                    throw new Exception("Tam sayi girmediniz..");

            }

        }
 
        private decimal _bakiye;

        public decimal Bakiye
        {

            get { return _bakiye; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Bakiyeniz 0 dan büyük olmalıdır..");
                else
                _bakiye = value;
            }

        }

    }



}
