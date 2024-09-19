using Task_2.Model.Response;

namespace Task_2.Core.Mappings.Interface
{
    public interface IMappingCreator
    {
        void CreateMapping(MappingResponseModel mappingResponse);
    }
}