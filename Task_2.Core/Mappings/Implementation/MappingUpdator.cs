using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Mappings.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;
using Task_2.Model.Response;

namespace Task_2.Core.Mappings.Implementation
{
    public class MappingUpdator : IMappingUpdator
    {
        public readonly UserDbContext _userDbContext;
        public MappingUpdator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        //With Deleting the previous data
        public void UpdateMapping(MappingResponseModel mappingResponse)
        {
            var storing = _userDbContext.Mapping
                         .Where(a => a.CustomerId == mappingResponse.CustomerId)
                         .ToList();

            _userDbContext.Mapping.RemoveRange(storing);

            var update = mappingResponse.ProductIds.Select(productId => new Mapping()
            {
                CustomerId = mappingResponse.CustomerId,
                ProductId = productId
            }).ToList();

            _userDbContext.Mapping.AddRange(update);
            _userDbContext.SaveChanges();


        }
        //WithOut Deleting the previous data
        public void UpdateMapping1(MappingResponseModel mappingResponse)
        {
            var storing = _userDbContext.Mapping
                        .Where(a => a.CustomerId == mappingResponse.CustomerId)
                        .ToList();

            for (int i = 0; i < storing.Count && i < mappingResponse.ProductIds.Count; i++)
            {
                storing[i].ProductId = mappingResponse.ProductIds[i];
            }

            if (mappingResponse.ProductIds.Count > storing.Count)
            {
                var mappings = mappingResponse.ProductIds.Skip(storing.Count)
                              .Select(a => new Mapping()
                              {
                                  CustomerId = mappingResponse.CustomerId,
                                  ProductId = a,
                              });
                _userDbContext.Mapping.AddRange(mappings);
            }
            if (mappingResponse.ProductIds.Count < storing.Count)
            {
                _userDbContext.Mapping.RemoveRange(storing.Skip(mappingResponse.ProductIds.Count));
            }
            _userDbContext.SaveChanges();

        }
    }
}
