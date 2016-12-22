/*
* Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
*
* Licensed under the Apache License, Version 2.0 (the License);
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an AS IS BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;

namespace Tizen.Multimedia.MediaController
{

    /// <summary>
    /// ServerUpdated event arguments
    /// </summary>
    /// <remarks>
    /// ServerUpdated event arguments
    /// </remarks>
    public class ServerUpdatedEventArgs : EventArgs
    {
        internal ServerInformation _serverInfo;

        internal ServerUpdatedEventArgs(string name, MediaControllerServerState state)
        {
            _serverInfo = new ServerInformation (name, state);
        }

        /// <summary>
        /// Get the Server Information.
        /// </summary>
        public ServerInformation ServerInfo
        {
            get
            {
                return _serverInfo;
            }
        }
    }
}

