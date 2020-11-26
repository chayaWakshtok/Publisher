using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.converters
{
    public class ConvertPublish
    {
        public static DTO.PublishDto ConvertDALtoDTO(DAL.Publish pub)
        {
            return new DTO.PublishDto()
            {
                Id = pub.Id,
                CompanyId = pub.CompanyId,
                Priority = pub.Priority,
                StartDate = pub.StartDate,
                EndDate = pub.EndDate,
                Video = pub.Video,
                TotalShow=pub.TotalShow,
                CompanyName=pub.Company.CompanyName,
                PriorityName =pub.Priority1.PriorityDescription
            };
        }
        public static DAL.Publish ConvertDTOtoDAL(DTO.PublishDto pub)
        {
            return new DAL.Publish()
            {
                Id = pub.Id,
                CompanyId = pub.CompanyId,
                Priority = pub.Priority,
                StartDate = pub.StartDate,
                EndDate = pub.EndDate,
                Video = pub.Video,
                TotalShow = pub.TotalShow
            };
        }
        public static List<DTO.PublishDto> ConvertListDALtoDTO(List<DAL.Publish> publishList)
        {
            List<DTO.PublishDto> publishers = new List<DTO.PublishDto>();
            if (publishList == null)
                return new List<PublishDto>();
            foreach (var item in publishList)
            {
                publishers.Add(ConvertDALtoDTO(item));
            }
            return publishers;
        }
        public static List<DAL.Publish> ConvertListDTOtoDAL(List<DTO.PublishDto> publishList)
        {
            List<DAL.Publish> publishes = new List<DAL.Publish>();
            if (publishList == null)
                return new List<DAL.Publish>();
            foreach (var item in publishList)
            {
                publishes.Add(ConvertDTOtoDAL(item));
            }
            return publishes;
        }
    }
}

