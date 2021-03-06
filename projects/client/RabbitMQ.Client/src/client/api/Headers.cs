// This source code is dual-licensed under the Apache License, version
// 2.0, and the Mozilla Public License, version 1.1.
//
// The APL v2.0:
//
//---------------------------------------------------------------------------
//   Copyright (c) 2007-2016 Pivotal Software, Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       https://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//---------------------------------------------------------------------------
//
// The MPL v1.1:
//
//---------------------------------------------------------------------------
//  The contents of this file are subject to the Mozilla Public License
//  Version 1.1 (the "License"); you may not use this file except in
//  compliance with the License. You may obtain a copy of the License
//  at https://www.mozilla.org/MPL/
//
//  Software distributed under the License is distributed on an "AS IS"
//  basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
//  the License for the specific language governing rights and
//  limitations under the License.
//
//  The Original Code is RabbitMQ.
//
//  The Initial Developer of the Original Code is Pivotal Software, Inc.
//  Copyright (c) 2007-2016 Pivotal Software, Inc.  All rights reserved.
//---------------------------------------------------------------------------

namespace RabbitMQ.Client
{
    /// <summary>
    /// Convenience class providing compile-time names for standard headers.
    /// </summary>
    /// <remarks>
    /// Use the static members of this class as headers for the
    /// arguments for Queue and Exchange declaration or Consumer creation. 
    /// The broker may be extended with additional
    /// headers that do not appear in this class.
    /// </remarks>
    public static class Headers
    {
        /// <summary>
        /// x-max-priority header
        /// </summary>
        public const string XMaxPriority = "x-max-priority";

        /// <summary>
        /// x-max-length header
        /// </summary>
        public const string XMaxLength = "x-max-length";

        /// <summary>
        /// x-max-length-bytes header
        /// </summary>
        public const string XMaxLengthInBytes = "x-max-length-bytes";
        
        /// <summary>
        /// x-dead-letter-exchange header
        /// </summary>
        public const string XDeadLetterExchange = "x-dead-letter-exchange";
        
        /// <summary>
        /// x-dead-letter-routing-key header
        /// </summary>
        public const string XDeadLetterRoutingKey = "x-dead-letter-routing-key";

        /// <summary>
        /// x-message-ttl header
        /// </summary>
        public const string XMessageTTL = "x-message-ttl";

        /// <summary>
        /// x-expires header
        /// </summary>
        public const string XExpires = "x-expires";

        /// <summary>
        /// alternate-exchange header
        /// </summary>
        public const string AlternateExchange = "alternate-exchange";

        /// <summary>
        /// x-priority header
        /// </summary>
        public const string XPriority = "x-priority";

        /// <summary>
        /// x-queue-mode header.
        /// Available modes: "default" and "lazy"
        /// </summary>
        public const string XQueueMode = "x-queue-mode";

        // quorum
        /// <summary>
        /// x-queue-type header.
        /// Available types: "quorum" and "classic"(default)
        /// </summary>
        public const string XQueueType = "x-queue-type";

        /// <summary>
        /// x-quorum-initial-group-size header.
        /// Use to control the number of quorum queue members
        /// </summary>
        public const string XQuorumInitialGroupSize = "x-quorum-initial-group-size";

        // true/false
        /// <summary>
        /// x-single-active-consumer header.
        /// Available modes: true and false(default).
        /// Allows to have only one consumer at a time consuming from a queue
        /// and to fail over to another registered consumer in case the active one is cancelled or dies
        ///  </summary>
        public const string XSingleActiveConsumer = "x-single-active-consumer";

        /// <summary>
        /// x-overflow header.
        /// Available strategies: "reject-publish" and "drop-head"(default).
        /// Allows to configure strategy when <see cref="XMaxLength"/> or <see cref="XMaxLengthInBytes"/> hits limits
        /// </summary>
        public const string XOverflow = "x-overflow";
    }
}
