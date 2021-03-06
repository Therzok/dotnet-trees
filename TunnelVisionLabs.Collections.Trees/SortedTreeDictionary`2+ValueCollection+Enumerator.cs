﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace TunnelVisionLabs.Collections.Trees
{
    using System.Collections;
    using System.Collections.Generic;

    public partial class SortedTreeDictionary<TKey, TValue>
    {
        public partial struct ValueCollection
        {
            public struct Enumerator : IEnumerator<TValue>
            {
                private SortedTreeDictionary<TKey, TValue>.Enumerator _enumerator;

                internal Enumerator(SortedTreeDictionary<TKey, TValue>.Enumerator enumerator)
                {
                    _enumerator = enumerator;
                }

                public TValue Current => _enumerator.Current.Value;

                object? IEnumerator.Current => Current;

                public void Dispose() => _enumerator.Dispose();

                public bool MoveNext() => _enumerator.MoveNext();

                void IEnumerator.Reset() => InternalReset();

                internal void InternalReset() => _enumerator.InternalReset();
            }
        }
    }
}
