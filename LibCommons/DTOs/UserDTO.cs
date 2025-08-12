using System;
using System.Collections.Generic;
using System.Linq;
using System.Spatial;
using System.Text;
using System.Threading.Tasks;

namespace LibCommons.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;

        public byte[] Password { get; set; } = null!;

        public byte[] Salt { get; set; } = null!;

        public Geometry Coord { get; set; } = null!;
    }
}
