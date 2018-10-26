using Championship.Domain.Entities;

namespace Championship.Domain.Interfaces.Services
{
    public interface IKeyService :IServiceBase<Key>
    {
        void Generate(Key obj);

    }
}
