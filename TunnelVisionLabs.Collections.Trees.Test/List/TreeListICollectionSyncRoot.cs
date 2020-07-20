﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace TunnelVisionLabs.Collections.Trees.Test.List
{
    using System.Collections;
    using System.Collections.Generic;
    using Xunit;

    /// <summary>
    /// Tests for the <see cref="TreeList{T}"/> implementation of <see cref="ICollection.SyncRoot"/>, derived from tests for
    /// <see cref="List{T}"/> in dotnet/coreclr.
    /// </summary>
    public class TreeListICollectionSyncRoot
    {
        [Fact(DisplayName = "PosTest1: this SyncRoot property always returns the current instance.")]
        public void PosTest1()
        {
            int[] iArray = { 1, 9, 3, 6, 5, 8, 7, 2, 4, 0 };
            TreeList<int> listObject = new TreeList<int>(iArray);
            object actualValue = ((ICollection)listObject).SyncRoot;
            Assert.NotNull(actualValue);

            string[] sArray = { "1", "9", "3", "6", "5", "8", "7", "2", "4", "0" };
            TreeList<string> listObject1 = new TreeList<string>(sArray);
            actualValue = ((ICollection)listObject1).SyncRoot;
            Assert.NotNull(actualValue);
        }
    }
}
