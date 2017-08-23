using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHoPen.DAL.Models
{
    public class Roomer
    {
        public int RoomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Deposit { get; set; }
        public string Identification { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
    }
}
