﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity.Relational.Migrations.Operations
{
    public class SqlOperation : MigrationOperation
    {
        public SqlOperation(
            [NotNull] string sql,
            bool suppressTransaction,
            [CanBeNull] IReadOnlyDictionary<string, string> annotations = null)
            : base(annotations)
        {
            Check.NotEmpty(sql, nameof(sql));

            Sql = sql;
            SuppressTransaction = suppressTransaction;
        }

        public virtual string Sql { get; }
        public virtual bool SuppressTransaction { get; }
    }
}
