// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties for the task that validates connection to Azure SQL Database
    /// Managed Instance
    /// </summary>
    [Newtonsoft.Json.JsonObject("ConnectToTarget.AzureSqlDbMI")]
    public partial class ConnectToTargetSqlMITaskProperties : ProjectTaskProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetSqlMITaskProperties class.
        /// </summary>
        public ConnectToTargetSqlMITaskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetSqlMITaskProperties class.
        /// </summary>
        /// <param name="errors">Array of errors. This is ignored if
        /// submitted.</param>
        /// <param name="state">The state of the task. This is ignored if
        /// submitted. Possible values include: 'Unknown', 'Queued', 'Running',
        /// 'Canceled', 'Succeeded', 'Failed', 'FailedInputValidation',
        /// 'Faulted'</param>
        /// <param name="commands">Array of command properties.</param>
        /// <param name="input">Task input</param>
        /// <param name="output">Task output. This is ignored if
        /// submitted.</param>
        public ConnectToTargetSqlMITaskProperties(IList<ODataError> errors = default(IList<ODataError>), string state = default(string), IList<CommandProperties> commands = default(IList<CommandProperties>), ConnectToTargetSqlMITaskInput input = default(ConnectToTargetSqlMITaskInput), IList<ConnectToTargetSqlMITaskOutput> output = default(IList<ConnectToTargetSqlMITaskOutput>))
            : base(errors, state, commands)
        {
            Input = input;
            Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets task input
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public ConnectToTargetSqlMITaskInput Input { get; set; }

        /// <summary>
        /// Gets task output. This is ignored if submitted.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public IList<ConnectToTargetSqlMITaskOutput> Output { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Input != null)
            {
                Input.Validate();
            }
        }
    }
}
