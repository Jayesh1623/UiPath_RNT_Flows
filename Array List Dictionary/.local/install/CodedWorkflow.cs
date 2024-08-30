using System;
using System.Activities;
using System.Collections.Generic;
using System.Data;
using System.Security;
using System.Text.RegularExpressions;
using UiPath.Activities.Contracts;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using UiPath.Core;
using UiPath.Core.Activities;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Platform.ResourceHandling;
using UiPath.Testing;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;

namespace ArrayListDictionary
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.SystemAPI.ISystemService), typeof(UiPath.Testing.Activities.ITestingService)};
        }

        protected UiPath.SystemAPI.ISystemService systemService { get => serviceContainer.Resolve<UiPath.SystemAPI.ISystemService>() ; }

        protected UiPath.Testing.Activities.ITestingService testingService { get => serviceContainer.Resolve<UiPath.Testing.Activities.ITestingService>() ; }
    }
}