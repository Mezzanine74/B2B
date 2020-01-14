using B2B.SharedKernel;

namespace B2B.Data.Interfaces
{
    public interface ISubTestPersonDescription: IEntity
    {
        int BaseId { get; set; }

        string Lang { get; set; }
    }
}