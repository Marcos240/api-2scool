using System;
using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Scool.Domain.Common
{
    public class Regulation : Entity<Guid>, ICreationAuditedObject, ISoftDelete
    {
        public string Name { get; set; }
        public string DisplayName  { get; set; }
        public int Point { get; set; }
        public string Type { get; set; }
        public Guid CriteriaId { get; set; }
        public Criteria Criteria { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set;}
        public Guid? CreatorId { get; set;}
        public bool IsDeleted { get; set; }

        public Regulation()
        {
            IsActive = true;
        }
    }
}