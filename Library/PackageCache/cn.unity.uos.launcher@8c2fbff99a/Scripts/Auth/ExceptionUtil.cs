using System;
using Newtonsoft.Json;
using Unity.UOS.Models;
using UnityEngine.Networking;
using System.Collections.Generic;

namespace Unity.UOS.Common.UOSLauncher.Scripts.Auth
{
    public class ExceptionUtil
    {
        private const string NonceTokenExpired = "nonce timestamp expired";
        private const int ErrorCodeUserBanned = 90108;
        private const int ErrorCodePersonaBanned = 90109;

        public static readonly Action<UnityWebRequest> ExceptionHandler = request =>
        {
            var error = JsonConvert.DeserializeObject<UosAuthError>(request.downloadHandler.text);
            if (NonceTokenExpired.Equals(error.message))
            {
                throw new AuthException(ErrorCode.NonceTimestampExpired, error.message);
            }
            if (error.detailCode is ErrorCodeUserBanned or ErrorCodePersonaBanned)
            {
                throw new AuthException(ErrorCode.PlayerBanned, error.message, error.detailInfo);
            }
            throw new AuthException(ErrorCode.GenerateTokenFailed, error.message);
        };
    }

    [Serializable]
    public class UosAuthError : UosServiceError
    {
        [JsonProperty(PropertyName = "passportErrorCode")]
        public int detailCode;
        
        [JsonProperty(PropertyName = "passportErrorDetail")]
        public Dictionary<string, string> detailInfo;
    }
}