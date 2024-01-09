using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // static newlemek istemedigmiz sabit classlarda kulanılır tek örnegi olur,
    // degişkenler kücük harf ile başlar ama Public  degişkenler büyük harf ile başlar 
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = " Ürün ismi geçersiz";
        public static string MaintenanceTime= "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
    }
    
}
