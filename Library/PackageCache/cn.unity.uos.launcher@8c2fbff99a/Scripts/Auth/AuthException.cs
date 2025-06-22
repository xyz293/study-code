using System.Collections.Generic;
using UnityEngine;

namespace Unity.UOS.Common.UOSLauncher.Scripts.Auth
{
    public enum ErrorCode
    {
        NotInitialized,
        InvalidUosAppID,
        InvalidJwt,
        NeedLogin,
        RefreshFailed,
        GenerateTokenFailed,
        NonceTimestampExpired,
        InvalidOperation,
        PlayerBanned
    }

    public class AuthException : System.Exception
    {
        public ErrorCode ErrorCode { get; }
        
        public Dictionary<string, string> ErrorDetail { get; }

        public AuthException(ErrorCode errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }
        
        public AuthException(ErrorCode errorCode, string message, Dictionary<string, string> detail) : base(message)
        {
            ErrorCode = errorCode;
            ErrorDetail = detail;
        }
    }
}