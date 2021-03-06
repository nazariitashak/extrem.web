﻿using System;
using System.Collections.Generic;
using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Interfaces.Repositories
{
    public interface IVoteRepository
    {
        Vote Add(Vote item);
        Vote Get(Guid id);
        void Delete(Vote item);
        void Update(Vote item);
        IList<Vote> GetAllVotesByUser(Guid membershipId);
    }
}
