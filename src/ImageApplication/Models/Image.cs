using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageApplication.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] ImageData { get; set; }
        public int UserId { get; set; }
    }
}
