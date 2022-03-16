using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tuan4_Duykien.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masach { get; set; }
        [Display(Name = "Ten Sach")]
        public string tensach { get; set; }
        [Display(Name = "Anh Bia")]
        public string hinh { get; set; }
        [Display(Name = "Gia Ban")]
        public double giaban { get; set; }
        [Display(Name = "So Luong")]
        public int soluong { get; set; }
        [Display(Name = "Thanh Tien")]
        public double thanhtien
        {
            get { return soluong * giaban; }
        }
        public GioHang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            soluong = 1;
        }
    }
}