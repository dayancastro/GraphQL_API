using GraphQL.Types;
using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database.Models;
using RealEstateManager.Types;

namespace RealEstateManager.Mutations
{
    public class PropertyMutation : ObjectGraphType
    {
        public PropertyMutation(IPropertyRepository propertyRepository, IOwnerRepository ownerRepository)
        {
            Field<PropertyType>(
                "addProperty",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PropertyInputType>> { Name="property"}),
                resolve: context =>
                {
                    var property = context.GetArgument<Property>("property");
                    return propertyRepository.Add(property);
                });

            Field<OwnerType>(
                "addOwner",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<OwnerInputType>> { Name = "owner" }),
                resolve: context =>
                {
                    var owner = context.GetArgument<Owner>("owner");
                    return ownerRepository.Add(owner);
                });

            Field<BooleanGraphType>(
                "removeProperty",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name="id"}),
                resolve: context => propertyRepository.Remove(context.GetArgument<int>("id")));
        }
    }
}
