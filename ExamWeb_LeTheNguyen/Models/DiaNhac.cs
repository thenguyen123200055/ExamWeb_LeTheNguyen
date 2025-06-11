﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiaNhacManagerWeb.Models
{
    public class DiaNhac
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string TuaCD { get; set; }
        [StringLength(50)]
        public string TheLoai { get; set; }
        public bool TrongNuoc { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        
    }
}
