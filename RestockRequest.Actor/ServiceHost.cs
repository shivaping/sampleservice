﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace RestockRequest.Actor
{
    using System;
    using System.Threading;
    using Microsoft.ServiceFabric.Actors.Runtime;

    public class ServiceHost
    {
        public static void Main(string[] args)
        {
            try
            {
                ActorRuntime.RegisterActorAsync<RestockRequestActor>().GetAwaiter().GetResult();

                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                ActorEventSource.Current.ActorHostInitializationFailed(e.ToString());
                throw;
            }
        }
    }
}