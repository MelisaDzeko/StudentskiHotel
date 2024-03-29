﻿using StudentskiDom.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Web.Areas.ManagerModul.ViewModels
{
    public class SobeIndexVM
    {
        public List<Row> Rows { get; set; }
        public class Row
        {
            public int Id { get; set; }
            public string Naziv { get; set; }
            public int PopunjenoKreveta { get; set; }
            public string TipSobe { get; set; }
            public int? IdTipSobe { get; set; }

            public int Sprat { get; set; }
            public List<Student> Studenti { get; set; }
            public List<StudentSoba> Lista { get; set; }
        }
    }
}
