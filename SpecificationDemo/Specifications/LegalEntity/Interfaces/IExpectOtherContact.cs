using SpecificationDemo.Interfaces;

namespace SpecificationDemo.Specifications.LegalEntity.Interfaces
{
    public interface IExpectOtherContact
    {
        IExpectOtherContact WithOtherContact<T>(IBuildingSpecification<T> contactSpec)
            where T : IContactInfo;
        IBuildingSpecification<Models.LegalEntity> AndNoMoreContacts();
    }
}