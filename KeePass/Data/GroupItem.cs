﻿using System;
using KeePass.IO;
using KeePass.Utils;

namespace KeePass.Data
{
    public class GroupItem : ListItemInfo
    {
        private readonly Uri _targetUri;

        public Uri TargetUri
        {
            get { return _targetUri; }
        }

        public GroupItem(Group group)
        {
            if (group == null)
                throw new ArgumentNullException("group");

            Title = group.Name;
            Icon = ThemeData.GetImage("folder");

            _targetUri = Navigation.GetPathTo<GroupDetails>(
                "id={0}", group.ID);
        }

        public GroupItem(Entry entry)
        {
            if (entry == null)
                throw new ArgumentNullException("entry");

            Title = entry.Title;
            Notes = entry.Notes;
            Icon = ThemeData.GetImage("entry");

            // TODO: _targetUri
        }
    }
}