﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace TunnelVisionLabs.Collections.Trees.Test.List
{
    using System.Collections.Generic;
    using Xunit;

    /// <summary>
    /// Tests for <see cref="TreeList{T}.ToArray()"/>, derived from tests for
    /// <see cref="List{T}.ToArray()"/> in dotnet/coreclr.
    /// </summary>
    public class TreeListToArray
    {
        [Fact(DisplayName = "PosTest1: Calling ToArray method of List,T is Value type.")]
        public void PosTest1()
        {
            TreeList<int> myList = new TreeList<int>();
            int count = 10;

            int element = 0;
            for (int i = 1; i <= count; i++)
            {
                element = i * count;
                myList.Add(element);
            }

            int[] actualArray = myList.ToArray();
            for (int j = 0; j < myList.Count; j++)
            {
                int current = myList[j];
                Assert.Equal(actualArray[j], current);
            }
        }

        [Fact(DisplayName = "PosTest2: Calling ToArray method of List,T is reference type.")]
        public void PosTest2()
        {
            TreeList<string> myList = new TreeList<string>();
            int count = 10;
            string element = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                element = i.ToString();
                myList.Add(element);
            }

            string[] actualArray = myList.ToArray();
            for (int j = 0; j < myList.Count; j++)
            {
                string current = myList[j];
                Assert.Equal(actualArray[j], current);
            }
        }
    }
}
