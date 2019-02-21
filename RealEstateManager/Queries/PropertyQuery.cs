using GraphQL.Types;
using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database.Models;
using RealEstateManager.Types;

namespace RealEstateManager.Queries
{
    public class PropertyQuery : ObjectGraphType
    {
        public PropertyQuery(IPropertyRepository propertyRepository, IPaymentRepository paymentRepository, IOwnerRepository ownerRepository)
        {
            Field<ListGraphType<PropertyType>>(
                "properties",
                resolve: context => propertyRepository.GetAll()
                );

            Field<ListGraphType<PaymentType>>(
                "payments",
                resolve: context => paymentRepository.GetAll()
                );

            Field<PropertyType>("property",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => propertyRepository.GetById(context.GetArgument<int>("id")));

            Field<OwnerType>("owner",
                arguments: new QueryArguments(new QueryArgument<OwnerKeyInputType> { Name = "id" }),
                resolve: context => ownerRepository.GetById(context.GetArgument<OwnerKey>("id")));

            Field<ListGraphType<OwnerType>>(
                "owners",
                resolve: context => ownerRepository.GetAll()
                );
        }
    }
}
