using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var kategoriler = new List<Category>() {

        new Category(){ Name="Okuma", Description="Okuma marka ürünler"},
        new Category(){ Name="Savage Gear", Description="Savage Gear marka ürünler"},
        new Category(){ Name="Lineaeffe", Description="Lineaeffe marka ürünler"},
        new Category(){ Name="Nomura", Description="Nomura marka ürünler"},
        new Category(){ Name="Prologıc", Description="Prologıc marka ürünler"}


        };
            foreach (var kategori in kategoriler) 
            { 
            context.Categories.Add(kategori);
            
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="Cavalla Speed Jigging Spin 159cm MH 150-250GR 1 Parça",Description="avalla Speed Jigging Spin 159cm MH 150-250GR 1 Parça marka ürünün detayı",Price=25,Stok=5, IsApproved=false,CategoryId=1,IsHome=true
                },
                new Product(){Name="Cavalla Slow Jigging Cast 6'8'' 203cm M 50-150GR 1+1 Parça",Description="Cavalla Slow Jigging Cast 6'8'' 203cm M 50-150GR 1+1 Parça marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=1,IsHome=true,Image="2.jpeg"
                },
                new Product(){Name="Okuma Classic UFR Tele Boat 5' 150cm 120G Bot Kamışı",Description="OOkuma Classic UFR Tele Boat 5' 150cm 120G Bot Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=1,IsHome=true,Image="3.jpeg"
                },
                new Product(){Name="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=1,IsHome=true,Image="4.png"
                },
                new Product(){Name="Okuma ITX-2500 7+1 bb Olta Makinesi",Description="Okuma ITX-2500 7+1 bb Olta Makinesi marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=1,IsHome=true,Image="5.png"
                },




                new Product(){Name="Okuma ITX-4000H 7+1 bb Olta Makinesi Parça",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=2,Image="1.png"
                },
                new Product(){Name="Okuma ITX-1000 H 7+1 bb Olta Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=2,Image="2.jpeg"
                },
                new Product(){Name="Okuma Azores ZXP-4000 (High Speed ) 6+1 bb Olta Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=2,IsHome=true,Image="3.jpeg"
                },
                new Product(){Name="Okuma Cavalla Blue CAVB-5II Çıkrık Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=2,IsHome=true,Image="4.png"
                },
                new Product(){Name="Okuma Cavalla Blue CAVB-5IILX Çıkrık Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=2,IsHome=true,Image="5.png"
                },




                      new Product(){Name="Okuma ITX-1000 H 7+1 bb Olta Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=3,IsHome=true,Image="1.png"
                },
                new Product(){Name="Okuma Azores ZXP-4000 (High Speed ) 6+1 bb Olta Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=3,IsHome=true,Image="5.png"
                },
                new Product(){Name="Okuma Cavalla Blue CAVB-5II Çıkrık Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=3,Image="2.jpeg"
                },
                new Product(){Name="Okuma Cavalla Blue CAVB-5IILX Çıkrık Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=3,Image="3.jpeg"
                },

                      new Product(){Name="Okuma ITX-1000 H 7+1 bb Olta Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=4,Image="2.jpeg"
                },
                new Product(){Name="Okuma Azores ZXP-4000 (High Speed ) 6+1 bb Olta Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=4,Image="1.png"
                },
                new Product(){Name="Okuma Cavalla Blue CAVB-5II Çıkrık Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=4,Image="2.jpeg"
                },
                new Product(){Name="Okuma Cavalla Blue CAVB-5IILX Çıkrık Makinesi",Description="Okuma Magda Air 2,00 mt 30-170 gr 2 Parça Taırubber Kamışı marka ürünün detayı",Price=25,Stok=5, IsApproved=true,CategoryId=4,Image="1.png"
                }





            };
            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges(); 
            base.Seed(context);
            }
        }
    }
