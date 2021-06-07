using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ACP.Net_Core.Models.Entity
{
    public class Visitor
    {
        [Key]
        public int Passport_Number { get;set; }
        public  string First_Name { get;set; }
        public string Sekond_Name{get; set; }
        public string Patronymic { get; set; }
        public string Phone_Number { get; set; }
    }
}