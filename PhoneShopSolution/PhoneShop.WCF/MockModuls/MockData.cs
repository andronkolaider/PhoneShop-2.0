using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.WCF.MockModuls {
    public static class MockData {

        public static List<Models.UserDTO> GetUsersDTO() {

            return new List<Models.UserDTO> {

                new Models.UserDTO { Id = 0, Name="Andrii",     Email="gaypornhere@gmail.com"},
                new Models.UserDTO { Id = 1, Name="Vitalii",    Email="fancytoys@gmail.com"},
                new Models.UserDTO { Id = 2, Name="Gabe",       Email="getblowjob@gmail.com"},

            };

        }

        public static List<Models.PhoneDTO> GetPhonesDTO() {

            return new List<Models.PhoneDTO> {

                new Models.PhoneDTO { Id = 0, Brand="Apple",    Model="IPhone 6s"},
                new Models.PhoneDTO { Id = 1, Brand="Google",   Model="Pixel"},
                new Models.PhoneDTO { Id = 2, Brand="Samsung",  Model="Galaxy S9"},

            };

        }


    }
}
