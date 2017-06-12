
namespace SpecificationDemo
{
    public interface IBuildingSpecification<out T>
    {
        T Build();
    }
}
