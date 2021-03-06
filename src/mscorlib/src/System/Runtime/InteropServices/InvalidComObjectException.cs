// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
** Purpose: This exception is thrown when an invalid COM object is used. This
**            happens when a the __ComObject type is used directly without
**            having a backing class factory.
**
=============================================================================*/


using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    [Serializable]
    [System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public class InvalidComObjectException : SystemException
    {
        public InvalidComObjectException()
            : base(SR.Arg_InvalidComObjectException)
        {
            HResult = HResults.COR_E_INVALIDCOMOBJECT;
        }

        public InvalidComObjectException(String message)
            : base(message)
        {
            HResult = HResults.COR_E_INVALIDCOMOBJECT;
        }

        public InvalidComObjectException(String message, Exception inner)
            : base(message, inner)
        {
            HResult = HResults.COR_E_INVALIDCOMOBJECT;
        }

        protected InvalidComObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
