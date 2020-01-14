using B2B.Data.Interfaces;

namespace B2B.Repository.ViewModels
{
    public class VmTestSex: ITestSex
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}