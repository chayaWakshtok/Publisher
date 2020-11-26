using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ConvertCompany
    {
        public static DTO.CompanyDto ConvertDALtoDTO(DAL.Company company)
        {
            if (company == null)
                return null;
            return new DTO.CompanyDto()
            {
                CompanyId = company.CompanyId,
                CompanyName = company.CompanyName,
                Address = company.Address,
                Mail = company.Mail,
                Publishes= company.Publishes != null ? DTO.converters.ConvertPublish.ConvertListDALtoDTO(company.Publishes.ToList()):null
            };
        }
        public static DAL.Company ConvertDTOtoDAL(DTO.CompanyDto company)
        {
            if (company == null)
                return null;
            return new DAL.Company()
            {
                CompanyId = company.CompanyId,
                CompanyName = company.CompanyName,
                Address = company.Address,
                Mail = company.Mail,
                Publishes = company.Publishes!=null? DTO.converters.ConvertPublish.ConvertListDTOtoDAL(company.Publishes.ToList()):null
            };
        }
        public static List<DTO.CompanyDto> ConvertListDALtoDTO(List<DAL.Company> companiesList)
        {
            List <DTO.CompanyDto> companies = new List<DTO.CompanyDto>();
            foreach(var item in companiesList)
            {
                companies.Add(ConvertDALtoDTO(item));
            }
            return companies;
        }
        public static List<DAL.Company> ConvertListDTOtoDAL(List<DTO.CompanyDto> companiesList)
        {
            List<DAL.Company> companies = new List<DAL.Company>();
            foreach (var item in companiesList)
            {
                companies.Add(ConvertDTOtoDAL(item));
            }
            return companies;
        }
    }
}
