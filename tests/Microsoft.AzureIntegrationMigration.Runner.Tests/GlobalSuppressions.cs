﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "This is test project.", Scope = "namespaceanddescendants", Target = "Microsoft.AzureIntegrationMigration.Runner.Tests")]
[assembly: SuppressMessage("Reliability", "CA2007:Consider calling ConfigureAwait on the awaited task", Justification = "This is test project.", Scope = "namespaceanddescendants", Target = "Microsoft.AzureIntegrationMigration.Runner.Tests")]
[assembly: SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = "This is test project.", Scope = "namespaceanddescendants", Target = "Microsoft.AzureIntegrationMigration.Runner.Tests")]
[assembly: SuppressMessage("Style", "IDE0073:The file header does not match the required text", Justification = "<Pending>")]
