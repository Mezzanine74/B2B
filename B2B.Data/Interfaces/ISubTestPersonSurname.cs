using B2B.SharedKernel;

namespace B2B.Data.Interfaces
{
    public interface ISubTestPersonSurname: IEntity
    {
        int BaseId { get; set; }

        string Lang { get; set; }
    }
}