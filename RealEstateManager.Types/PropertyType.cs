using GraphQL.Types;
using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database.Models;

namespace RealEstateManager.Types
{
    public class PropertyType : ObjectGraphType<Property>
    {
        public PropertyType(IPaymentRepository paymentRepository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.City);
            Field(x => x.Family);
            Field(x => x.Street);
            Field(x => x.Value);

            Field<ListGraphType<PaymentType>>("payments",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context => 
                {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return lastItemsFilter.HasValue
                        ? paymentRepository.GetAllForProperty(context.Source.Id, lastItemsFilter.Value)
                        : paymentRepository.GetAllForProperty(context.Source.Id);
                });
        }
    }
}
