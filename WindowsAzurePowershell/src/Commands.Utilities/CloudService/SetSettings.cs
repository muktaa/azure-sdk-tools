﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.Utilities.CloudService
{
    using System.Management.Automation;
    using Common;

    public class SetSettings : CmdletBase
    {
        // Uncomment this to enable global set for settings
        //[Parameter(Position = 1, Mandatory = false)]
        //[Alias("g")]
        public SwitchParameter Global { get; set; }

        internal string GetServiceSettingsPath(bool global)
        {
            return new CloudServiceProject(GeneralUtilities.GetServiceRootPath(CurrentPath()), null).Paths.Settings;
        }
    }
}