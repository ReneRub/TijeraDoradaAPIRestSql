using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TD.Common.Results;
using TD.Common;

namespace Tijera.API.Shared.Results
{
    /// <summary>
    /// Response builder
    /// </summary>
    public interface IResponseBuilder
    {
        /// <summary>Withes the status code.</summary>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        /// <returns>ResponseBuilder.</returns>
        ResponseBuilder WithStatusCode(HttpStatusCode httpStatusCode);

        /// <summary>Withes the message.</summary>
        /// <param name="message">The message.</param>
        /// <returns>ResponseBuilder.</returns>
        ResponseBuilder WithMessage(string message);

        /// <summary>
        /// Withes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ResponseBuilder.</returns>
        ResponseBuilder WithData(object data);

        /// <summary>
        /// Withes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="message">The message.</param>
        /// <returns>ResponseBuilder.</returns>
        ResponseBuilder WithData(object data, string message);

        /// <summary>
        /// With the data.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="data">The data.</param>
        /// <returns>ResponseBuilder</returns>
        ResponseBuilder WithDataMapping<TSource, TDestination>(TSource data)
           where TSource : class
           where TDestination : class, new();

        /// <summary>
        /// With the data.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="message">The message.</param>
        /// <param name="statusCode">The statusCode.</param>
        /// <returns>ResponseBuilder</returns>
        ResponseBuilder WithDataMapping<TSource, TDestination>(TSource data, string message, HttpStatusCode statusCode)
           where TSource : class
           where TDestination : class, new();

        /// <summary>
        /// Withes the data mapping.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="standardResponse">The standard result.</param>
        /// <returns>ResponseBuilder</returns>
        ResponseBuilder WithDataMapping<TSource, TDestination>(StandardResponse<TSource> standardResponse)
          where TSource : class
          where TDestination : class, new();

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
        ResponseBuilder WithDataMapping<TSource, TDestination>(IMapper mapper, TSource data)
           where TSource : class
           where TDestination : class, new();

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>ResponseBuilder</returns>
        ResponseBuilder WithError(Exception exception);

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        /// <param name="exception">The exception.</param>
        /// <returns>ResponseBuilder.</returns>
        ResponseBuilder WithError(HttpStatusCode httpStatusCode, Exception exception);

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns>ResponseBuilder</returns>
        ResponseBuilder WithError(string error);

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="data">The data.</param>
        /// <returns>ResponseBuilder</returns>
        ResponseBuilder WithError(string error, object data);

        /// <summary>
        /// Withes the error.
        /// </summary>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        /// <param name="error">The error.</param>
        /// <param name="data">The Data returned.</param>
        /// <returns>ResponseBuilder.</returns>
        ResponseBuilder WithError(HttpStatusCode httpStatusCode, string error, object data);
     

        

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>IActionResult</returns>
        IActionResult Build();

        /// <summary>
        /// Builds the asynchronous.
        /// </summary>
        /// <returns>IActionResult</returns>
        Task<IActionResult> BuildAsync();

        /// <summary>
        /// Builds the standard result.
        /// </summary>
        /// <returns>StandardResult</returns>
        StandardResult<object> BuildStandardResult();

        /// <summary>
        /// Withes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="message">The message.</param>
        /// <param name="statusCode">The HTTP status code.</param>
        /// <returns>ResponseBuilder.</returns>
        ResponseBuilder WithData(object data, string message, HttpStatusCode statusCode);
    }
}
