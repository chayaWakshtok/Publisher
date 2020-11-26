using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PublishBl
    {
        public static DAL.publishersEntities1 db = new DAL.publishersEntities1();
        public static List<PublishDto> GetPublishAll()
        {
            var list = db.Publishes.ToList();
            return DTO.converters.ConvertPublish.ConvertListDALtoDTO(list);
        }

        public static List<PublishDto> GetPublishByCompany(int companyId)
        {
            var list = db.Publishes.Where(p=>p.CompanyId==companyId).ToList();
            return DTO.converters.ConvertPublish.ConvertListDALtoDTO(list);
        }
    } 
}
