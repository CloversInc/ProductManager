namespace RestaurantManager.BindingViewModels.Mapper
{
    using AutoMapper;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configExpr);
    }
}