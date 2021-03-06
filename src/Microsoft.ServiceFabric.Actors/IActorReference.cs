// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors
{
    using System;
    using Microsoft.ServiceFabric.Actors.Client;

    /// <summary>
    /// Interface for ActorReference.
    /// </summary>
    internal interface IActorReference
    {
        /// <summary>
        /// Creates an <see cref="ActorProxy"/> that implements an actor interface for the actor using the
        ///     <see cref="ActorProxyFactory.CreateActorProxy(System.Type,System.Uri, Microsoft.ServiceFabric.Actors.ActorId, string)"/>
        /// method.
        /// </summary>
        /// <param name="actorType">Actor interface for the created <see cref="ActorProxy"/> to implement.</param>
        /// <returns>An actor proxy object that implements <see cref="IActorProxy"/> and TActorInterface.</returns>
        object Bind(Type actorType);
    }
}
