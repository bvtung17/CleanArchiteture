using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Common
{
    public interface IAuditableEntity
    {
        DateTime Created { get; set; }
        string CreatedBy { get; set; }
        DateTime? LastModified { get; set; }
        string LastModifiedBy { get; set; }
    }

    public abstract class AuditableEntity : IAuditableEntity
    {
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
