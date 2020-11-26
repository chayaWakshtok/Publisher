using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserBl
    {
        public static DAL.publishersEntities1 db = new DAL.publishersEntities1();
        public static UserDto AddUser(UserDto userDto )
        {
            try
            {
                User user = DTO.converters.ConvertUser.ConvertDTOtoDAL(userDto);
                var userInsert = db.Users.Add(user);
                db.SaveChanges();
                return DTO.converters.ConvertUser.ConvertDALtoDTO(userInsert);
            }
            catch (Exception ex)
            {
                return null;
            }
         
        }

        public static UserDto CheckUser(string username,string password)
        {
            try
            {
                var user = db.Users.FirstOrDefault(p => p.Username == username && p.UserPassword == password);
                if (user == null)
                    return null;
                return DTO.converters.ConvertUser.ConvertDALtoDTO(user);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
