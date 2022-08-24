using SpyDuh_Robin.Models;

namespace SpyDuh_Robin.Interfaces
{
    public interface ISpyRepository
    {
        void Post(Spy spy);

        List<Spy> GetAll();
    }
}
