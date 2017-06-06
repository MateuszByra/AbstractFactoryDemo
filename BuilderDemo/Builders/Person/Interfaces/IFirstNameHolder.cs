
namespace BuilderDemo.Builders.Person.Interfaces
{
    public interface IFirstNameHolder
    {
        ILastNameHolder WithFirstName(string name);
    }
}
