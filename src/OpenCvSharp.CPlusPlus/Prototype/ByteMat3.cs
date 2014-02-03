﻿using System;
using System.Runtime.InteropServices;

namespace OpenCvSharp.CPlusPlus.Prototype
{
    /// <summary>
    /// 
    /// </summary>
    public class ByteMat3 : Mat
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ptr"></param>
        public ByteMat3(IntPtr ptr)
            : base(ptr)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mat"></param>
        public ByteMat3(Mat mat)
            : base(mat.CvPtr)
        {
            IsEnabledDispose = false;
        }

        #region Indexer
        /// <summary>
        /// 
        /// </summary>
        public sealed unsafe class Indexer : IndexerBase<ByteTuple3>
        {
            private readonly byte* ptr;

            internal Indexer(Mat parent)
                : base(parent)
            {
                this.ptr = (byte*)parent.Data.ToPointer();
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="i0"></param>
            /// <returns></returns>
            public override ByteTuple3 this[int i0]
            {
                get
                {
                    return *(ByteTuple3*)(ptr + (steps[0] * i0));
                }
                set
                {
                    *(ByteTuple3*)(ptr + (steps[0] * i0)) = value;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="i0"></param>
            /// <param name="i1"></param>
            /// <returns></returns>
            public override ByteTuple3 this[int i0, int i1]
            {
                get
                {
                    return *(ByteTuple3*)(ptr + (steps[0] * i0) + (steps[1] * i1));
                }
                set
                {
                    *(ByteTuple3*)(ptr + (steps[0] * i0) + (steps[1] * i1)) = value;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="i0"></param>
            /// <param name="i1"></param>
            /// <param name="i2"></param>
            /// <returns></returns>
            public override ByteTuple3 this[int i0, int i1, int i2]
            {
                get
                {
                    return *(ByteTuple3*)(ptr + (steps[0] * i0) + (steps[1] * i1) + (steps[2] * i2));
                }
                set
                {
                    *(ByteTuple3*)(ptr + (steps[0] * i0) + (steps[1] * i1) + (steps[2] * i2)) = value;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="idx"></param>
            /// <returns></returns>
            public override ByteTuple3 this[params int[] idx]
            {
                get
                {
                    long offset = 0;
                    for (int i = 0; i < idx.Length; i++)
                    {
                        offset += steps[i] * idx[i];
                    }
                    return *(ByteTuple3*)(ptr + offset);
                }
                set
                {
                    long offset = 0;
                    for (int i = 0; i < idx.Length; i++)
                    {
                        offset += steps[i] * idx[i];
                    }
                    *(ByteTuple3*)(ptr + offset) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Indexer GetIndexer() 
        {
            return new Indexer(this);
        }
        #endregion
    }
}
