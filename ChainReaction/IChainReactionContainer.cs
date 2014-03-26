﻿using System;
using ChainReaction.Model;
namespace ChainReaction
{
    public interface IChainReactionContainer
    {
        bool TryResolve(string groupName, out GroupInfo group);

        void Add(GroupInfo group);

        T Invoke<T>(string groupName = "", Action<object> afterLoad = null);
    }
}