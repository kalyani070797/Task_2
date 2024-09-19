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
    public class MappingCreator : IMappingCreator
    {
        public readonly UserDbContext _userDbContext;

        public MappingCreator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void CreateMapping(MappingResponseModel mappingResponse)
        {
            //Insert the MappingTable with CustomerId-1 but productid-1,2,3...       
            var mappings = mappingResponse.ProductIds.Select(productId => new Mapping()
            {
                CustomerId = mappingResponse.CustomerId,
                ProductId = productId
            }).ToList();


            // Add all mappings to the context
            _userDbContext.Mapping.AddRange(mappings);

            _userDbContext.SaveChanges();

        }
    }
}
