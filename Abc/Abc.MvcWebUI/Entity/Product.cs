using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [DisplayName("Stok Adet")]
        public int Stok { get; set; }
        [DisplayName("Görsel")]

        public string Image {  get; set; }
        [DisplayName("Anasayfa")]
        public bool IsHome { get; set; }
        [DisplayName("Onaylandı")]
        public bool IsApproved { get; set; }

        [DisplayName("Kategor Seç")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}