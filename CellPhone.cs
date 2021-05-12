using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Dialer
{
    class CellPhone : Phone
    {
        public CellPhone(string phoneNumber, string companyName, string phoneType)
        {

        }

        public override string Dial(string phone)
        {
            return 1 + phone;
        }

    }
}
