using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TD.Common.Results;
using TD.Common;

namespace Tijera.API.Shared.Results
{
    /// <summary>
    /// Response Builder.
    /// </summary>
    public class ResponseBuilder : IResponseBuilder
    {
        private IMapper mapper;
        private HttpStatusCode statusCode;
        private string message;
        private object data;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBuilder"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        public ResponseBuilder(IMapper mapper)
        {
            this.mapper = mapper;
        }

        private ResponseBuilder(HttpStatusCode statusCode, string message, object data)
        {
            this.statusCode = statusCode;
            this.message = message;
            this.data = data;
        }

        private ResponseBuilder(HttpStatusCode statusCode)
        {
            this.statusCode = statusCode;
        }

        /// <summary>Creates this instance.</summary>
        /// <returns>ResponseBuilder.</returns>
        public static ResponseBuilder Create()
        {
            return new ResponseBuilder(HttpStatusCode.OK);
        }

        /// <summary>Creates the specified status code.</summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="message">The message.</param>
        /// <param name="data">The data.</param>
        /// <returns>ResponseBuilder.</returns>
        public static ResponseBuilder Create(HttpStatusCode statusCode, string message, object data)
        {
            return new ResponseBuilder(statusCode, message, data);
        }

        /// <summary>Withes the status code.</summary>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        /// <returns>ResponseBuilder.</returns>
        public ResponseBuilder WithStatusCode(HttpStatusCode httpStatusCode)
        {
            this.statusCode = httpStatusCode;
            return this;
        }

        /// <summary>Withes the message.</summary>
        /// <param name="message">The message.</param>
        /// <returns>ResponseBuilder.</returns>
        public ResponseBuilder WithMessage(string message)
        {
            this.message = message;
            return this;
        }

        /// <summary>
        /// Withes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ResponseBuilder.</returns>
        public ResponseBuilder WithData(object data)
        {
            return this.WithData(data, this.message);
        }

        /// <summary>
        /// Withes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="message">The message.</param>
        /// <param name="statusCode">The statusCode.</param>
        /// <returns>ResponseBuilder.</returns>
        public ResponseBuilder WithData(object data, string message, HttpStatusCode statusCode)
        {
            this.message = message;
            this.data = data;
            this.statusCode = statusCode;
            return this;
        }

        /// <summary>
        /// Withes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="message">The message.</param>
        /// <returns>ResponseBuilder.</returns>
        public ResponseBuilder WithData(object data, string message)
        {
            this.message = message;
            this.data = data;
            return this;
        }

        /// <summary>
        /// With the data.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="data">The data.</param>
        /// <returns>ResponseBuilder</returns>
        public ResponseBuilder WithDataMapping<TSource, TDestination>(TSource data)
           where TSource : class
           where TDestination : class, new()
        {
            if (this.mapper == null)
            {
                throw new InvalidOperationException();
            }

            var mappedData = this.mapper.Map<TSource, TDestination>(data);
            return WithData(mappedData);
        }

        /// <summary>
        /// With the data.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="message">The message.</param>
        /// <param name="statusCode">The statusCode.</param>
        /// <returns>ResponseBuilder</returns>
        public ResponseBuilder WithDataMapping<TSource, TDestination>(TSource data, string message, HttpStatusCode statusCode)
           where TSource : class
           where TDestination : class, new()
        {
            if (this.mapper == null)
            {
                throw new InvalidOperationException();
            }

            var mappedData = this.mapper.Map<TSource, TDestination>(data);
            return WithData(mappedData, message, statusCode);
        }

        /// <summary>
        /// With the data.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="data">The data.</param>
        /// <returns>
        /// ResponseBuilder
        /// </returns>
        public ResponseBuilder WithDataMapping<TSource, TDestination>(IMapper mapper, TSource data)
           where TSource : class
           where TDestination : class, new()
        {
            this.mapper = mapper;
            return WithDataMapping<TSource, TDestination>(data);
        }

        /// <summary>
        /// With the data.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="dataCollection">The data collection.</param>
        /// <returns>
        /// ResponseBuilder
        /// </returns>
        public ResponseBuilder WithDataMapping<TSource, TDestination>(IEnumerable<TSource> dataCollection)
           where TSource : class
           where TDestination : class, new()
        {
            if (this.mapper == null)
            {
                throw new InvalidOperationException();
            }

            var mappedData = this.mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(dataCollection);
            return WithData(mappedData);
        }

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>ResponseBuilder</returns>
        public ResponseBuilder WithError(Exception exception)
        {
            return this.WithError(HttpStatusCode.InternalServerError, exception);
        }

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        /// <param name="exception">The exception.</param>
        /// <returns>ResponseBuilder.</returns>
        public ResponseBuilder WithError(HttpStatusCode httpStatusCode, Exception exception)
        {
            return this.WithError(httpStatusCode, exception?.Message, null);
        }

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns>ResponseBuilder</returns>
        public ResponseBuilder WithError(string error)
        {
            return this.WithError(HttpStatusCode.BadRequest, error, null);
        }

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="data">The data.</param>
        /// <returns>ResponseBuilder</returns>
        public ResponseBuilder WithError(string error, object data)
        {
            return this.WithError(HttpStatusCode.BadRequest, error, data);
        }

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        /// <param name="error">The error.</param>
        /// <param name="data">The Data returned.</param>
        /// <returns>ResponseBuilder.</returns>
        public ResponseBuilder WithError(HttpStatusCode httpStatusCode, string error, object data)
        {
            this.statusCode = httpStatusCode;
            this.message = error;
            this.data = data;

            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult Build()
        {
            var reply = BuildStandardResult();

            var result = new ObjectResult(reply)
            {
                StatusCode = (int)this.statusCode
            };

            return result;
        }

        /// <summary>
        /// Builds the asynchronous.
        /// </summary>
        /// <returns>IActionResult</returns>
        public async Task<IActionResult> BuildAsync()
        {
            return await Task.FromResult(Build()).ConfigureAwait(false);
        }

        /// <summary>
        /// Builds the standard result.
        /// </summary>
        /// <returns>StandardResult</returns>
        public StandardResult<object> BuildStandardResult()
        {
            return new StandardResult<object>()
            {
                Status = statusCode.ToString(),
                Message = string.IsNullOrEmpty(this.message) ? this.statusCode.ToString() : this.message,
                Data = this.data
            };
        }

        /// <summary>
        /// Withes the data mapping.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="standardResponse">The standard result.</param>
        /// <returns>ResponseBuilder</returns>
        public ResponseBuilder WithDataMapping<TSource, TDestination>(StandardResponse<TSource> standardResponse)
            where TSource : class
            where TDestination : class, new()
        {
            if (this.mapper == null)
            {
                throw new InvalidOperationException();
            }

            var mappedData = standardResponse?.Data == null ? null : this.mapper.Map<TSource, TDestination>(standardResponse?.Data);
            return WithData(mappedData, standardResponse.Message, standardResponse.HttpStatusCode);
        }
    }
}
