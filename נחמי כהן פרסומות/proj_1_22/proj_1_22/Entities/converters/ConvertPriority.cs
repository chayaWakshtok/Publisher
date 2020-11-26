using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.converters
{
    public class ConvertPriority
    {
        public static DTO.PriorityDto ConvertDALtoDTO(DAL.Priority p)
        {
            return new DTO.PriorityDto()
            {
               PriorityId=p.PriorityId,
               PriorityDescription=p.PriorityDescription,
               PriorityValue=p.PriorityValue,
               Show=p.Show
            };
        }
        public static DAL.Priority ConvertDTOtoDAL(DTO.PriorityDto p)
        {
            return new DAL.Priority()
            {
                PriorityId = p.PriorityId,
                PriorityDescription = p.PriorityDescription,
                PriorityValue = p.PriorityValue,
                Show = p.Show
            };
        }
        public static List<DTO.PriorityDto> ConvertListDALtoDTO(List<DAL.Priority> companiesList)
        {
            List<DTO.PriorityDto> companies = new List<DTO.PriorityDto>();
            foreach (var item in companiesList)
            {
                companies.Add(ConvertDALtoDTO(item));
            }
            return companies;
        }
        public static List<DAL.Priority> ConvertListDTOtoDAL(List<DTO.PriorityDto> companiesList)
        {
            List<DAL.Priority> companies = new List<DAL.Priority>();
            foreach (var item in companiesList)
            {
                companies.Add(ConvertDTOtoDAL(item));
            }
            return companies;
        }
    }
}
