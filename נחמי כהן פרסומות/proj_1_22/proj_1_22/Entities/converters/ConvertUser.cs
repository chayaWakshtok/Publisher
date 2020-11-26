using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.converters
{
    public class ConvertUser
    {
        public static DTO.UserDto ConvertDALtoDTO(DAL.User u)
        {
            return new DTO.UserDto()
            {
               IsAdmin=u.IsAdmin,
               UserID=u.UserID,
               UserPassword=u.UserPassword,
               CompanyId=u.CompanyId,
               Company= ConvertCompany.ConvertDALtoDTO(u.Company),
               Username=u.Username
            };
        }
        public static DAL.User ConvertDTOtoDAL(DTO.UserDto u)
        {
            return new DAL.User()
            {
                IsAdmin = u.IsAdmin,
                UserID = u.UserID,
                UserPassword = u.UserPassword,
                CompanyId = u.CompanyId,
                Company = ConvertCompany.ConvertDTOtoDAL(u.Company),
                Username = u.Username
            };
        }
        public static List<DTO.UserDto> ConvertListDALtoDTO(List<DAL.User> companiesList)
        {
            List<DTO.UserDto> companies = new List<DTO.UserDto>();
            foreach (var item in companiesList)
            {
                companies.Add(ConvertDALtoDTO(item));
            }
            return companies;
        }
        public static List<DAL.User> ConvertListDTOtoDAL(List<DTO.UserDto> companiesList)
        {
            List<DAL.User> companies = new List<DAL.User>();
            foreach (var item in companiesList)
            {
                companies.Add(ConvertDTOtoDAL(item));
            }
            return companies;
        }
    }
}
