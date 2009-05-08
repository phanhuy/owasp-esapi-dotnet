﻿/// <summary> OWASP .NET Enterprise Security API (.NET ESAPI)
/// 
/// This file is part of the Open Web Application Security Project (OWASP)
/// .NET Enterprise Security API (.NET ESAPI) project. For details, please see
/// http://www.owasp.org/index.php/.NET_ESAPI.
/// 
/// Copyright (c) 2008 - The OWASP Foundation
/// 
/// The .NET ESAPI is published by OWASP under the LGPL. You should read and accept the
/// LICENSE before you use, modify, and/or redistribute this software.
/// 
/// </summary>
/// <author>  Alex Smolen <a href="http://www.foundstone.com">Foundstone</a>
/// </author>
/// <created>  2008 </created>

using System;

namespace Owasp.Esapi.Errors
{

    /// <summary> An AccessControlException should be thrown when a user attempts to access a
    /// resource that they are not authorized for.
    /// 
    /// </summary>
    /// <author>  Alex Smolen (alex.smolen@foundstone.com)
    /// </author>
    [Serializable]
    public class AccessControlException : EnterpriseSecurityException
    {

        /// <summary>The Constant _serialVersionUID. </summary>
        private const long _serialVersionUID = 1L;

        /// <summary> Instantiates a new access control exception.</summary>
        protected internal AccessControlException()
        {
            // hidden
        }

        /// <summary> Creates a new instance of EnterpriseSecurityException.</summary>
        public AccessControlException(string userMessage, string logMessage)
            : base(userMessage, logMessage)
        {
        }

        /// <summary> Instantiates a new access control exception.
        /// 
        /// </summary>
        /// <param name="userMessage">The message for the user.
        /// </param>
        /// <param name="logMessage">The message for the log.
        /// </param>
        /// <param name="cause">The cause.
        /// </param>        
        public AccessControlException(string userMessage, string logMessage, System.Exception cause)
            : base(userMessage, logMessage, cause)
        {
        }
    }
}