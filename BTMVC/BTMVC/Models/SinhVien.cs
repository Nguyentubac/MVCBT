using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTMVC.Models
{
    public class SinhVien
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Sex { get; set; }
            [DataType(DataType.DateTime)]
            public string Birth { get; set; }
            public string Class { get; set; }
    }
}