using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireWise.Application.Dto
{
    public class EmployeeImageFileDto
    {
        // File'dan miras alınan özellikler
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Storage { get; set; }

        // Employee ile ilişkilendirme
        public int EmployeeId { get; set; } // Dosyanın hangi çalışana ait olduğu

        // İhtiyaca bağlı diğer özellikler veya bilgiler eklenebilir
        // Örneğin, dosyanın yüklenme tarihi gibi meta veriler
    }
}
