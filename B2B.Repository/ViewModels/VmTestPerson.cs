using B2B.Data.Interfaces;

namespace B2B.Repository.ViewModels
{
    public class VmTestPerson: ITestPerson
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DescriptionMLId { get; set; }
        public string Name { get; set; }
        public int SurnameMLId { get; set; }
        public string Surname { get; set; }
        public int TestSexId { get; set; }
    }
}