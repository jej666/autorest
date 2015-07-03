namespace Fixtures.SwaggerBatUrl
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial interface IPathItems
    {
        /// <summary>
        /// send globalStringPath='globalStringPath',
        /// pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath',
        /// globalStringQuery='globalStringQuery',
        /// pathItemStringQuery='pathItemStringQuery',
        /// localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query
        /// parameter
        /// </param>
        /// <param name='globalStringPath'>
        /// A string value 'globalItemStringPath' that appears in the path
        /// </param>
        /// <param name='globalStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse> GetAllWithValuesWithOperationResponseAsync(string localStringPath, string pathItemStringPath, string globalStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), string globalStringQuery = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// send globalStringPath='globalStringPath',
        /// pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery=null,
        /// pathItemStringQuery='pathItemStringQuery',
        /// localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query
        /// parameter
        /// </param>
        /// <param name='globalStringPath'>
        /// A string value 'globalItemStringPath' that appears in the path
        /// </param>
        /// <param name='globalStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse> GetGlobalQueryNullWithOperationResponseAsync(string localStringPath, string pathItemStringPath, string globalStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), string globalStringQuery = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// send globalStringPath=globalStringPath,
        /// pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery=null,
        /// pathItemStringQuery='pathItemStringQuery', localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain null value
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query
        /// parameter
        /// </param>
        /// <param name='globalStringPath'>
        /// A string value 'globalItemStringPath' that appears in the path
        /// </param>
        /// <param name='globalStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse> GetGlobalAndLocalQueryNullWithOperationResponseAsync(string localStringPath, string pathItemStringPath, string globalStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), string globalStringQuery = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// send globalStringPath='globalStringPath',
        /// pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath',
        /// globalStringQuery='globalStringQuery', pathItemStringQuery=null,
        /// localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='globalStringPath'>
        /// A string value 'globalItemStringPath' that appears in the path
        /// </param>
        /// <param name='globalStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse> GetLocalPathItemQueryNullWithOperationResponseAsync(string localStringPath, string pathItemStringPath, string globalStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), string globalStringQuery = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}