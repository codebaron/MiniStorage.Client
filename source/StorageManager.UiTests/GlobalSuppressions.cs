// <copyright file="GlobalSuppressions.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "The component registry will handle disposal", Scope = "member", Target = "~M:StorageManager.UiTests.StorageManagerUiTestRegistrar.RegisterWebDriver(Autofac.ContainerBuilder)")]
