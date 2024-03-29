﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Domain.Common
{
    public class EntityBase<TKey> : ICreatedOn, IDeletedOn, IModifiedOn
    {
        public TKey Id { get; set; }

        public string? CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }

        public string? ModifiedByUserId { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
