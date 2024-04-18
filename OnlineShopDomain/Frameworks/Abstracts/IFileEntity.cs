﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopDomain.Frameworks.Abstracts
{
    public interface IFileEntity : IEntity<Guid>, ITitledEntity, IDescribedEntity, ICodedEntity<long>, ISoftDeletedEntity, IDbSetEntity
    {

    }
}
