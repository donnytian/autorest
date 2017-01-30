// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AzureCompositeModelClient.
    /// </summary>
    public static partial class AzureCompositeModelClientExtensions
    {
            /// <summary>
            /// Product Types
            /// </summary>
            /// <remarks>
            /// The Products endpoint returns information about the Uber products offered
            /// at a given location. The response includes the display name and other
            /// details about each product, and lists the products in the proper display
            /// order.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group ID.
            /// </param>
            public static CatalogArray List(this IAzureCompositeModelClient operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <remarks>
            /// The Products endpoint returns information about the Uber products offered
            /// at a given location. The response includes the display name and other
            /// details about each product, and lists the products in the proper display
            /// order.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CatalogArray> ListAsync(this IAzureCompositeModelClient operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create products
            /// </summary>
            /// <remarks>
            /// Resets products.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group ID.
            /// </param>
            /// <param name='productDictionaryOfArray'>
            /// Dictionary of Array of product
            /// </param>
            public static CatalogDictionary Create(this IAzureCompositeModelClient operations, string subscriptionId, string resourceGroupName, IDictionary<string, IList<Product>> productDictionaryOfArray = default(IDictionary<string, IList<Product>>))
            {
                return operations.CreateAsync(subscriptionId, resourceGroupName, productDictionaryOfArray).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create products
            /// </summary>
            /// <remarks>
            /// Resets products.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group ID.
            /// </param>
            /// <param name='productDictionaryOfArray'>
            /// Dictionary of Array of product
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CatalogDictionary> CreateAsync(this IAzureCompositeModelClient operations, string subscriptionId, string resourceGroupName, IDictionary<string, IList<Product>> productDictionaryOfArray = default(IDictionary<string, IList<Product>>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(subscriptionId, resourceGroupName, productDictionaryOfArray, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update products
            /// </summary>
            /// <remarks>
            /// Resets products.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group ID.
            /// </param>
            /// <param name='productArrayOfDictionary'>
            /// Array of dictionary of products
            /// </param>
            public static CatalogArray Update(this IAzureCompositeModelClient operations, string subscriptionId, string resourceGroupName, IList<IDictionary<string, Product>> productArrayOfDictionary = default(IList<IDictionary<string, Product>>))
            {
                return operations.UpdateAsync(subscriptionId, resourceGroupName, productArrayOfDictionary).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update products
            /// </summary>
            /// <remarks>
            /// Resets products.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group ID.
            /// </param>
            /// <param name='productArrayOfDictionary'>
            /// Array of dictionary of products
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CatalogArray> UpdateAsync(this IAzureCompositeModelClient operations, string subscriptionId, string resourceGroupName, IList<IDictionary<string, Product>> productArrayOfDictionary = default(IList<IDictionary<string, Product>>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(subscriptionId, resourceGroupName, productArrayOfDictionary, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
