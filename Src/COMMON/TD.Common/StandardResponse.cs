using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TD.Common
{
    public class StandardResponse<T>
    {
        private Int32 _statusCode = 200;
        private Int32 _status = 200;
        private HttpStatusCode _httpStatusCode = HttpStatusCode.OK;
        private List<string> _logs = new List<string>();

        /// <summary>
        /// HTTP Status converted to string
        /// </summary>
        [JsonProperty("status")]
        public Int32 Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        /// <summary>
        /// HTTP Status converted to string
        /// </summary>
        [JsonProperty("httpStatusCode")]
        public HttpStatusCode HttpStatusCode
        {
            get
            {
                return _httpStatusCode;
            }
            set
            {
                _httpStatusCode = value;
            }
        }

        /// <summary>
        /// Result of operation
        /// </summary>
        public string Message { get; set; }

        public bool IsSuccess { get; set; }

        [JsonProperty("statusCode")]
        public Int32 StatusCode
        {
            get
            {
                return _statusCode;
            }
            set
            {
                _statusCode = value;
            }
        }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("exception")]
        public string ExceptionType { get; set; }

        [JsonProperty("exceptionMessage")]
        public string ExceptionMessage { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        public List<string> Logs
        {
            get
            {
                return _logs;
            }
            set
            {
                _logs = value;
            }
        }

        public string Code { get; set; }

        /// <summary>
        /// Data requested
        /// </summary>
        public T Data { get; set; }

        public StandardResponse()
        {

        }

        /// <summary>
        /// Envelope for API replies
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <param name="logs">The logs.</param>
        public StandardResponse(HttpStatusCode status, T data = default, string message = null)
        {
            HttpStatusCode = status;
            Data = data;
            Message = message;

            if (status == HttpStatusCode.OK)
            {
                IsSuccess = true;
            }
            else
            {
                IsSuccess = false;
            }
        }

        public StandardResponse(T data = default, string message = null)
        {
            if (data == null)
            {
                HttpStatusCode = HttpStatusCode.InternalServerError;
                IsSuccess = false;
            }
            else
            {
                HttpStatusCode = HttpStatusCode.OK;
                IsSuccess = true;
            }

            Data = data;
            Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardResponse{T}"/> class.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <param name="data">The data.</param>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="logs">The logs.</param>
        public StandardResponse(HttpStatusCode status, string message, params object[] args)
        {
            HttpStatusCode = status;
            Message = string.Format(message, args);

            if (status == HttpStatusCode.OK)
            {
                IsSuccess = true;
            }
            else
            {
                IsSuccess = false;
            }
        }
    }
}
