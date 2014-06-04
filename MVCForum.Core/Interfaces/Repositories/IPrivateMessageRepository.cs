﻿using System;
using System.Collections.Generic;
using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Interfaces.Repositories
{
    public interface IPrivateMessageRepository
    {
        IPagedList<PrivateMessage> GetPagedSentMessagesByUser(int pageIndex, int pageSize, MembershipUser user);
        IPagedList<PrivateMessage> GetPagedReceivedMessagesByUser(int pageIndex, int pageSize, MembershipUser user);
        PrivateMessage GetLastSentPrivateMessage(Guid Id);
        IList<PrivateMessage> GetAllSentByUser(Guid Id);
        IList<PrivateMessage> GetAllReceivedByUser(Guid Id);
        IList<PrivateMessage> GetAllByUserToAnotherUser(Guid senderId, Guid receiverId);
        int NewPrivateMessageCount(Guid userId);
        PrivateMessage Add(PrivateMessage item);
        PrivateMessage Get(Guid id);
        void Delete(PrivateMessage item);
        void Update(PrivateMessage item);
    }
}
