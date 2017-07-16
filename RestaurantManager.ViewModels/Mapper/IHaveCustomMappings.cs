namespace RestaurantManager.ViewAndBindingModels.Mapper
{
    using AutoMapper;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configExpr);
    }
}