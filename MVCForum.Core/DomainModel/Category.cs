﻿using System;
using System.Collections.Generic;
using MVCForum.Utilities;

namespace MVCForum.Domain.DomainModel
{
    public class Category : Entity
    {
        public Category()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLocked { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public string Slug { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual IList<Topic> Topics { get; set; }
        public virtual IList<CategoryNotification> CategoryNotifications { get; set; }

        public string NiceUrl
        {
            get { return UrlTypes.GenerateUrl(UrlType.Category, Slug); }
        }
    }
}
