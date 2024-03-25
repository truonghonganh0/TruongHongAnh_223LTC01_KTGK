using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_223LTC01_KTGK
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNewItems();

            Console.WriteLine("Nhap loai muon tim (Sach - Bao - TapChi)");
            var searchName303 = Console.ReadLine();

            SearchByName(searchName303);

            FindInMarch2024();

            Console.ReadKey();
        }

        private static void AddNewItems()
        {
            tailieus303.AddRange(sachs303);
            tailieus303.AddRange(baos303);
            tailieus303.AddRange(tapchis303);
        }

        private static void SearchByName(string searchName303)
        {
            var result = tailieus303.Where(tailieu => tailieu.GetType().Name == searchName303).ToList();
            if (result.Any())
            {
                Console.WriteLine($"Danh sach {searchName303}: ");
                foreach (var item in result)
                {
                    Console.WriteLine($"- {item.TenTL}");
                }
            }
            else
                Console.WriteLine($"Khong co {searchName303} trong danh sach!!!");
        }

        private static void FindInMarch2024()
        {
            var findInMarch2024 = baos303.Where(bao => bao.NgayPH.Year == 2024 && bao.NgayPH.Month == 3);
            Console.WriteLine("\n Cac bao phat hanh trong T3/2024: ");
            foreach (var bao in findInMarch2024)
                Console.WriteLine($"- {bao.TenTL}");
        }


        private static List<TaiLieu> tailieus303 = new List<TaiLieu> { };

        //danh sách Sách
        private static List<Sach> sachs303 = new List<Sach>
        {
            new Sach(1, "Tin Hoc", "NXB Giao Duc", 1, "Tac gia A", 50),
            new Sach(2, "Ngu Van", "NXB Giao Duc", 1, "Tac gia B", 60),
            new Sach(3, "Toan Hoc", "NXB Giao Duc", 1, "Tac Gia C", 55),
        };

        //danh sách Báo
        private static List<Bao> baos303 = new List<Bao>
        {
            new Bao(1, "Tuoi Tre", "NXB Viet Nam", 2, new DateTime(2024, 2, 20)),
            new Bao(2, "Thanh Nien", "NXB Viet Nam", 2, new DateTime(2024, 3, 21)),
            new Bao(3, "Lao Dong", "NXB Viet Nam", 2, new DateTime(2024, 4, 22)),
        };

        //danh sách Tạp Chí
        private static List<TapChi> tapchis303 = new List<TapChi>
        {
            new TapChi(1, "The Times", "John Walter", 3, 2022, 2022),
            new TapChi(2, "The Suns", "John Hank", 3, 2023, 2023),
            new TapChi(3, "The Global", "Phil Jones", 3, 2024, 2024),
        };

        //danh sách Danh Mục
        private static List<DanhMuc> danhMucs303 = new List<DanhMuc>
        {
            new DanhMuc(1, "Sach", 1, 1, 1),
            new DanhMuc(2, "Bao", 2, 2, 2),
            new DanhMuc(3, "Tap chi",3, 3, 3),
        };
    }
}
