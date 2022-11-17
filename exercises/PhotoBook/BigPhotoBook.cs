using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBook
{
    public class BigPhotoBook
    {
        private int numPages { get; set; }

        public BigPhotoBook()
        {
            this.numPages = 64;
        }

        public int getNumberOfPages()
        {
            return this.numPages;
        }
    }
}
