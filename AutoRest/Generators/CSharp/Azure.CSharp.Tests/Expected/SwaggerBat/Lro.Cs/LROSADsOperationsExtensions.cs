namespace Fixtures.Azure.SwaggerBatLro
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    public static partial class LROSADsOperationsExtensions
    {
            /// <summary>
            /// Long running put request, service returns a 400 to the initial request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutNonRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).PutNonRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 400 to the initial request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PutNonRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutNonRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 400 to the initial request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutNonRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPutNonRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 400 to the initial request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPutNonRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutNonRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// DO NOT CALL THIS METHOD. For completion only
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetNonRetry400(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).GetNonRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// DO NOT CALL THIS METHOD. For completion only
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetNonRetry400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetNonRetry400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a Product with
            /// 'ProvisioningState' = 'Creating' and 201 response code
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutNonRetry201Creating400(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).PutNonRetry201Creating400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a Product with
            /// 'ProvisioningState' = 'Creating' and 201 response code
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PutNonRetry201Creating400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutNonRetry201Creating400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a Product with
            /// 'ProvisioningState' = 'Creating' and 201 response code
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutNonRetry201Creating400(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPutNonRetry201Creating400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a Product with
            /// 'ProvisioningState' = 'Creating' and 201 response code
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPutNonRetry201Creating400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutNonRetry201Creating400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running opeartion polling returns a 400 with no error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetNonRetry201Creating400(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).GetNonRetry201Creating400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running opeartion polling returns a 400 with no error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetNonRetry201Creating400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetNonRetry201Creating400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 with
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutAsyncRelativeRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).PutAsyncRelativeRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 with
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PutAsyncRelativeRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutAsyncRelativeRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 with
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutAsyncRelativeRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPutAsyncRelativeRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 with
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPutAsyncRelativeRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutAsyncRelativeRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// DO NOT CALL THIS METHOD. For completion only
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetAsyncRelativeRetry400(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).GetAsyncRelativeRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// DO NOT CALL THIS METHOD. For completion only
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetAsyncRelativeRetry400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetAsyncRelativeRetry400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running delete request, service returns a 400 with an error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void DeleteNonRetry400(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).DeleteNonRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 400 with an error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteNonRetry400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteNonRetry400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 400 with an error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void BeginDeleteNonRetry400(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginDeleteNonRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 400 with an error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteNonRetry400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteNonRetry400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 with a location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void Delete202NonRetry400(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).Delete202NonRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 with a location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task Delete202NonRetry400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Delete202NonRetry400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 with a location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void BeginDelete202NonRetry400(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginDelete202NonRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 with a location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDelete202NonRetry400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDelete202NonRetry400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void DeleteAsyncRelativeRetry400(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).DeleteAsyncRelativeRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsyncRelativeRetry400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAsyncRelativeRetry400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void BeginDeleteAsyncRelativeRetry400(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginDeleteAsyncRelativeRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteAsyncRelativeRetry400Async( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteAsyncRelativeRetry400WithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 400 with no error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void PostNonRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).PostNonRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 400 with no error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PostNonRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostNonRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 400 with no error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPostNonRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPostNonRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 400 with no error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPostNonRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPostNonRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 with a location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void Post202NonRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).Post202NonRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 with a location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task Post202NonRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Post202NonRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 with a location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPost202NonRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPost202NonRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 with a location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPost202NonRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPost202NonRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void PostAsyncRelativeRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).PostAsyncRelativeRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PostAsyncRelativeRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostAsyncRelativeRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPostAsyncRelativeRetry400(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPostAsyncRelativeRetry400Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPostAsyncRelativeRetry400Async( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPostAsyncRelativeRetry400WithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running put request, service returns a 201 to the initial request
            /// with no payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutError201NoProvisioningStatePayload(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).PutError201NoProvisioningStatePayloadAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 201 to the initial request
            /// with no payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PutError201NoProvisioningStatePayloadAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutError201NoProvisioningStatePayloadWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 201 to the initial request
            /// with no payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutError201NoProvisioningStatePayload(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPutError201NoProvisioningStatePayloadAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 201 to the initial request
            /// with no payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPutError201NoProvisioningStatePayloadAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutError201NoProvisioningStatePayloadWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// DO NOT CALL THIS METHOD. For completion only
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetError201NoProvisioningStatePayload(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).GetError201NoProvisioningStatePayloadAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// DO NOT CALL THIS METHOD. For completion only
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetError201NoProvisioningStatePayloadAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetError201NoProvisioningStatePayloadWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutAsyncRelativeRetryNoStatus(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).PutAsyncRelativeRetryNoStatusAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PutAsyncRelativeRetryNoStatusAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutAsyncRelativeRetryNoStatusWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutAsyncRelativeRetryNoStatus(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPutAsyncRelativeRetryNoStatusAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPutAsyncRelativeRetryNoStatusAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutAsyncRelativeRetryNoStatusWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetAsyncRelativeRetryNoStatus(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).GetAsyncRelativeRetryNoStatusAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetAsyncRelativeRetryNoStatusAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetAsyncRelativeRetryNoStatusWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutAsyncRelativeRetryNoStatusPayload(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).PutAsyncRelativeRetryNoStatusPayloadAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PutAsyncRelativeRetryNoStatusPayloadAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutAsyncRelativeRetryNoStatusPayloadWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutAsyncRelativeRetryNoStatusPayload(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPutAsyncRelativeRetryNoStatusPayloadAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPutAsyncRelativeRetryNoStatusPayloadAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutAsyncRelativeRetryNoStatusPayloadWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetAsyncRelativeRetryNoStatusPayload(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).GetAsyncRelativeRetryNoStatusPayloadAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetAsyncRelativeRetryNoStatusPayloadAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetAsyncRelativeRetryNoStatusPayloadWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running delete request, service returns a 204 to the initial request,
            /// indicating success.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void Delete204Succeeded(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).Delete204SucceededAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 204 to the initial request,
            /// indicating success.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task Delete204SucceededAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Delete204SucceededWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 204 to the initial request,
            /// indicating success.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void BeginDelete204Succeeded(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginDelete204SucceededAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 204 to the initial request,
            /// indicating success.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDelete204SucceededAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDelete204SucceededWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void DeleteAsyncRelativeRetryNoStatus(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).DeleteAsyncRelativeRetryNoStatusAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsyncRelativeRetryNoStatusAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAsyncRelativeRetryNoStatusWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void BeginDeleteAsyncRelativeRetryNoStatus(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginDeleteAsyncRelativeRetryNoStatusAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteAsyncRelativeRetryNoStatusAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteAsyncRelativeRetryNoStatusWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// without a location header.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void Post202NoLocation(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).Post202NoLocationAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// without a location header.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task Post202NoLocationAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Post202NoLocationWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// without a location header.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPost202NoLocation(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPost202NoLocationAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// without a location header.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPost202NoLocationAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPost202NoLocationWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void PostAsyncRelativeRetryNoPayload(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).PostAsyncRelativeRetryNoPayloadAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PostAsyncRelativeRetryNoPayloadAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostAsyncRelativeRetryNoPayloadWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPostAsyncRelativeRetryNoPayload(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPostAsyncRelativeRetryNoPayloadAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPostAsyncRelativeRetryNoPayloadAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPostAsyncRelativeRetryNoPayloadWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that is not a valid json
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product Put200InvalidJson(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).Put200InvalidJsonAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that is not a valid json
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> Put200InvalidJsonAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.Put200InvalidJsonWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that is not a valid json
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPut200InvalidJson(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPut200InvalidJsonAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that is not a valid json
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPut200InvalidJsonAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPut200InvalidJsonWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// SHOUD NOT BE CALLED
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product Get200Succeeded(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).Get200SucceededAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// SHOUD NOT BE CALLED
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> Get200SucceededAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.Get200SucceededWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. The endpoint
            /// indicated in the Azure-AsyncOperation header is invalid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutAsyncRelativeRetryInvalidHeader(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).PutAsyncRelativeRetryInvalidHeaderAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. The endpoint
            /// indicated in the Azure-AsyncOperation header is invalid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PutAsyncRelativeRetryInvalidHeaderAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutAsyncRelativeRetryInvalidHeaderWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. The endpoint
            /// indicated in the Azure-AsyncOperation header is invalid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutAsyncRelativeRetryInvalidHeader(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPutAsyncRelativeRetryInvalidHeaderAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. The endpoint
            /// indicated in the Azure-AsyncOperation header is invalid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPutAsyncRelativeRetryInvalidHeaderAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutAsyncRelativeRetryInvalidHeaderWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// SHOULD NOT BE CALLED
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetAsyncRelativeRetryInvalidHeader(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).GetAsyncRelativeRetryInvalidHeaderAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// SHOULD NOT BE CALLED
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetAsyncRelativeRetryInvalidHeaderAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetAsyncRelativeRetryInvalidHeaderWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutAsyncRelativeRetryInvalidJsonPolling(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).PutAsyncRelativeRetryInvalidJsonPollingAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PutAsyncRelativeRetryInvalidJsonPollingAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutAsyncRelativeRetryInvalidJsonPollingWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutAsyncRelativeRetryInvalidJsonPolling(this ILROSADsOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPutAsyncRelativeRetryInvalidJsonPollingAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> BeginPutAsyncRelativeRetryInvalidJsonPollingAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutAsyncRelativeRetryInvalidJsonPollingWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetAsyncRelativeRetryInvalidJsonPolling(this ILROSADsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILROSADsOperations)s).GetAsyncRelativeRetryInvalidJsonPollingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 200 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetAsyncRelativeRetryInvalidJsonPollingAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetAsyncRelativeRetryInvalidJsonPollingWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request
            /// receing a reponse with an invalid 'Location' and 'Retry-After' headers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void Delete202RetryInvalidHeader(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).Delete202RetryInvalidHeaderAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request
            /// receing a reponse with an invalid 'Location' and 'Retry-After' headers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task Delete202RetryInvalidHeaderAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Delete202RetryInvalidHeaderWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request
            /// receing a reponse with an invalid 'Location' and 'Retry-After' headers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void BeginDelete202RetryInvalidHeader(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginDelete202RetryInvalidHeaderAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request
            /// receing a reponse with an invalid 'Location' and 'Retry-After' headers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDelete202RetryInvalidHeaderAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDelete202RetryInvalidHeaderWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// The endpoint indicated in the Azure-AsyncOperation header is invalid
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void DeleteAsyncRelativeRetryInvalidHeader(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).DeleteAsyncRelativeRetryInvalidHeaderAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// The endpoint indicated in the Azure-AsyncOperation header is invalid
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsyncRelativeRetryInvalidHeaderAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAsyncRelativeRetryInvalidHeaderWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// The endpoint indicated in the Azure-AsyncOperation header is invalid
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void BeginDeleteAsyncRelativeRetryInvalidHeader(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginDeleteAsyncRelativeRetryInvalidHeaderAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// The endpoint indicated in the Azure-AsyncOperation header is invalid
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteAsyncRelativeRetryInvalidHeaderAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteAsyncRelativeRetryInvalidHeaderWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void DeleteAsyncRelativeRetryInvalidJsonPolling(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).DeleteAsyncRelativeRetryInvalidJsonPollingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsyncRelativeRetryInvalidJsonPollingAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAsyncRelativeRetryInvalidJsonPollingWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void BeginDeleteAsyncRelativeRetryInvalidJsonPolling(this ILROSADsOperations operations)
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginDeleteAsyncRelativeRetryInvalidJsonPollingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 202 to the initial request.
            /// Poll the endpoint indicated in the Azure-AsyncOperation header for
            /// operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteAsyncRelativeRetryInvalidJsonPollingAsync( this ILROSADsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteAsyncRelativeRetryInvalidJsonPollingWithOperationResponseAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with invalid 'Location' and 'Retry-After' headers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void Post202RetryInvalidHeader(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).Post202RetryInvalidHeaderAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with invalid 'Location' and 'Retry-After' headers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task Post202RetryInvalidHeaderAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Post202RetryInvalidHeaderWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with invalid 'Location' and 'Retry-After' headers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPost202RetryInvalidHeader(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPost202RetryInvalidHeaderAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with invalid 'Location' and 'Retry-After' headers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPost202RetryInvalidHeaderAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPost202RetryInvalidHeaderWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. The endpoint
            /// indicated in the Azure-AsyncOperation header is invalid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void PostAsyncRelativeRetryInvalidHeader(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).PostAsyncRelativeRetryInvalidHeaderAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. The endpoint
            /// indicated in the Azure-AsyncOperation header is invalid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PostAsyncRelativeRetryInvalidHeaderAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostAsyncRelativeRetryInvalidHeaderWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. The endpoint
            /// indicated in the Azure-AsyncOperation header is invalid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPostAsyncRelativeRetryInvalidHeader(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPostAsyncRelativeRetryInvalidHeaderAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. The endpoint
            /// indicated in the Azure-AsyncOperation header is invalid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPostAsyncRelativeRetryInvalidHeaderAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPostAsyncRelativeRetryInvalidHeaderWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void PostAsyncRelativeRetryInvalidJsonPolling(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).PostAsyncRelativeRetryInvalidJsonPollingAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PostAsyncRelativeRetryInvalidJsonPollingAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostAsyncRelativeRetryInvalidJsonPollingWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPostAsyncRelativeRetryInvalidJsonPolling(this ILROSADsOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROSADsOperations)s).BeginPostAsyncRelativeRetryInvalidJsonPollingAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 202 to the initial request,
            /// with an entity that contains ProvisioningState=’Creating’. Poll the
            /// endpoint indicated in the Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPostAsyncRelativeRetryInvalidJsonPollingAsync( this ILROSADsOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPostAsyncRelativeRetryInvalidJsonPollingWithOperationResponseAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

    }
}