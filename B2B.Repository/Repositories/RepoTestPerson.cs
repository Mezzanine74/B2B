using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using B2B.Data.Db;
using B2B.Repository.ViewModels;
using B2B.SharedKernel;

namespace B2B.Repository.Repositories
{
    public class RepoTestPerson: RepositoryBase<VmTestPerson, TestPerson>
    {
        public override IEnumerable<VmTestPerson> List()
        {
            //var query = from testPerson in db.TestPersons
            //    join subTestPersonDescription in db.SubTestPersonDescriptions
            //        on testPerson.Id equals subTestPersonDescription.BaseId
            //         where subTestPersonDescription.Lang == SessionClass.Session
            //        into gj
            //    from subtestPerson in gj.DefaultIfEmpty()
            //    select new VmTestPerson
            //    {
            //        Name = testPerson.Name,
            //        Description = subtestPerson.Description ?? String.Empty,
            //        Id = testPerson.Id,
            //        DescriptionMLId = testPerson.DescriptionMLId,
            //        Surname = testPerson.Surname,
            //        SurnameMLId = testPerson.SurnameMLId,
            //        TestSexId = testPerson.TestSexId
            //    };

            return base.List();
        }
    }
}