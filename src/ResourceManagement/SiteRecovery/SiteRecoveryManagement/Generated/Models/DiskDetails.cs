// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Onprem disk details data.
    /// </summary>
    public partial class DiskDetails
    {
        private ulong _maxSizeMB;
        
        /// <summary>
        /// Optional. Gets or sets the hard disk max size in MB.
        /// </summary>
        public ulong MaxSizeMB
        {
            get { return this._maxSizeMB; }
            set { this._maxSizeMB = value; }
        }
        
        private string _vHDId;
        
        /// <summary>
        /// Optional. Gets or sets the VHD Id.
        /// </summary>
        public string VHDId
        {
            get { return this._vHDId; }
            set { this._vHDId = value; }
        }
        
        private string _vHDName;
        
        /// <summary>
        /// Optional. Gets or sets the VHD name.
        /// </summary>
        public string VHDName
        {
            get { return this._vHDName; }
            set { this._vHDName = value; }
        }
        
        private string _vHDStatus;
        
        /// <summary>
        /// Optional. Gets or sets the type of the volume.
        /// </summary>
        public string VHDStatus
        {
            get { return this._vHDStatus; }
            set { this._vHDStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DiskDetails class.
        /// </summary>
        public DiskDetails()
        {
        }
    }
}
