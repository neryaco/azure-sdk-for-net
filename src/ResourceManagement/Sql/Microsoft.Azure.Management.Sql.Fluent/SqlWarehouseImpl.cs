// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Models;

    /// <summary>
    /// Implementation for SqlWarehouse and its parent interfaces.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnNxbC5pbXBsZW1lbnRhdGlvbi5TcWxXYXJlaG91c2VJbXBs
    internal partial class SqlWarehouseImpl :
        SqlDatabaseImpl,
        ISqlWarehouse
    {
        internal  SqlWarehouseImpl(string name, DatabaseInner innerObject, IDatabasesOperations innerCollection)
            : base(name, innerObject, innerCollection)
        {
        }

        ///GENMHASH:638E920B34EB7CDD894A8A261D1A3364:F65A55844E1B000D318C0439E7EDE006
        public void ResumeDataWarehouse()
        {
            this.innerCollection.ResumeDataWarehouse(this.ResourceGroupName, this.SqlServerName(), this.Name);
        }

        ///GENMHASH:CC45B434E5AD72F7D764B575FE4DBBB0:BA80FAB6E26489720ABD292F74B22257
        public void PauseDataWarehouse()
        {
            this.innerCollection.PauseDataWarehouse(this.ResourceGroupName, this.SqlServerName(), this.Name);
        }
    }
}
