using PhoneShop.WCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.WCF.Contracts {
    public interface IOrderContract {

        Models.OrderDTO MakeOrder(UserDTO user, PhoneDTO phone);

    }
}
