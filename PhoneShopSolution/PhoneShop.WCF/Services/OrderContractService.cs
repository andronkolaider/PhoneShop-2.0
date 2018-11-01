using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneShop.WCF.Models;

namespace PhoneShop.WCF.Services {
    public class OrderContractService : Contracts.IOrderContract {

        public OrderDTO MakeOrder(UserDTO user, PhoneDTO phone) {

            List <UserDTO> MockUsers = MockModuls.MockData.GetUsersDTO();
            List <PhoneDTO> MockPhones = MockModuls.MockData.GetPhonesDTO();

            foreach (var eachuser in MockUsers) {
                if (eachuser.Id != user.Id) {
                    throw new Exception("User doesn't exist");
                }
                else {
                    foreach (var eachphone in MockPhones) {
                        if (eachphone.Id != phone.Id) {
                            throw new Exception("Phone doesn't exist");
                        }
                        else {
                            return new OrderDTO { Id = 1, Phone=phone, dateTime = DateTime.Now };
                        }
                       
                    }
                }
                return null;
            }
            return null;
        }

    }
}
