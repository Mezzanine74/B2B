using B2B.SharedKernel;

namespace B2B.Data.Interfaces
{
    public interface ITestPerson: IEntity
    {
        int DescriptionMLId { get; set; }
        string Name { get; set; }
        int SurnameMLId { get; set; }
        string Surname { get; set; }
        int TestSexId { get; set; }
    }
}