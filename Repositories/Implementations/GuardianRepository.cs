using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMgtApp.Models.Entities;
using StudMgtApp.Context;
using StudMgtApp.Repositories.Interfaces;

namespace StudentMgtApp.Repositories.Implementations
{
    public class GuardianRepository : IGuardianRepository
    {
        public void AddToDb(Guardian guardian)
        {
            StudContext.guardians.Add(guardian);
        }

        public int GenerateId()
        {
            return StudContext.guardians.Count + 1;
        }

        public Guardian? GetGuardian(int id)
        {
            return StudContext.guardians.Find(guardian => guardian.Id == id);
        }

        public ICollection<Guardian> GetGuardians()
        {
            return StudContext.guardians;
        }
    }
}