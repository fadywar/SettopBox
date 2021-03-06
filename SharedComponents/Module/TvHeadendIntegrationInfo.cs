﻿using System;
using System.Collections.Generic;

namespace SharedComponents.Module
{
    public class TvHeadendIntegrationInfo : ModuleInfo, ICloneable
    {
        public DateTime? LastEpgUpdate;
        public bool LastEpgUpdateSuccessfull;
        public bool AuthenticationSuccessfull;
        public IList<TvHeadendChannelInfo> Channels;
        public object Clone()
        {
            return new TvHeadendIntegrationInfo
            {
                LastEpgUpdate = LastEpgUpdate,
                LastEpgUpdateSuccessfull = LastEpgUpdateSuccessfull,
                Channels = Channels.Clone()
            };
        }
    }
}