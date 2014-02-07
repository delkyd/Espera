﻿using System;

namespace Espera.Core.Management
{
    public interface IRemoteAccessControl
    {
        IObservable<AccessPermission> ObserveAccessPermission(Guid accessToken);

        IObservable<int> ObserveRemainingVotes(Guid accessToken);

        Guid RegisterRemoteAccessToken();

        void RegisterVote(Guid accessToken, PlaylistEntry entry);

        void SetRemotePassword(Guid accessToken, string password);

        void UpgradeRemoteAccess(Guid accessToken, string password);
    }
}