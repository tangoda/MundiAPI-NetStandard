/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundiAPI.Standard;
using MundiAPI.Standard.Utilities;
using MundiAPI.Standard.Http.Request;
using MundiAPI.Standard.Http.Response;
using MundiAPI.Standard.Http.Client;

namespace MundiAPI.Standard.Controllers
{
    public partial interface ISubscriptionsController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id</param>
        /// <param name="incrementId">Required parameter: The increment Id</param>
        /// <return>Returns the Models.GetIncrementResponse response from the API call</return>
        Models.GetIncrementResponse GetIncrementById(string subscriptionId, string incrementId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id</param>
        /// <param name="incrementId">Required parameter: The increment Id</param>
        /// <return>Returns the Models.GetIncrementResponse response from the API call</return>
        Task<Models.GetIncrementResponse> GetIncrementByIdAsync(string subscriptionId, string incrementId);

        /// <summary>
        /// Updates the billing date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse UpdateSubscriptionBillingDate(string subscriptionId, Models.UpdateSubscriptionBillingDateRequest request);

        /// <summary>
        /// Updates the billing date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionBillingDateAsync(string subscriptionId, Models.UpdateSubscriptionBillingDateRequest request);

        /// <summary>
        /// Updates the credit card from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse UpdateSubscriptionCard(string subscriptionId, Models.UpdateSubscriptionCardRequest request);

        /// <summary>
        /// Updates the credit card from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionCardAsync(string subscriptionId, Models.UpdateSubscriptionCardRequest request);

        /// <summary>
        /// Updates a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for updating a subscription item</param>
        /// <return>Returns the Models.GetSubscriptionItemResponse response from the API call</return>
        Models.GetSubscriptionItemResponse UpdateSubscriptionItem(string subscriptionId, string itemId, Models.UpdateSubscriptionItemRequest body);

        /// <summary>
        /// Updates a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for updating a subscription item</param>
        /// <return>Returns the Models.GetSubscriptionItemResponse response from the API call</return>
        Task<Models.GetSubscriptionItemResponse> UpdateSubscriptionItemAsync(string subscriptionId, string itemId, Models.UpdateSubscriptionItemRequest body);

        /// <summary>
        /// Creates a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for creating a usage</param>
        /// <return>Returns the Models.GetUsageResponse response from the API call</return>
        Models.GetUsageResponse CreateUsage(string subscriptionId, string itemId, Models.CreateUsageRequest body);

        /// <summary>
        /// Creates a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for creating a usage</param>
        /// <return>Returns the Models.GetUsageResponse response from the API call</return>
        Task<Models.GetUsageResponse> CreateUsageAsync(string subscriptionId, string itemId, Models.CreateUsageRequest body);

        /// <summary>
        /// Gets a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse GetSubscription(string subscriptionId);

        /// <summary>
        /// Gets a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> GetSubscriptionAsync(string subscriptionId);

        /// <summary>
        /// Updates the payment method from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse UpdateSubscriptionPaymentMethod(string subscriptionId, Models.UpdateSubscriptionPaymentMethodRequest request);

        /// <summary>
        /// Updates the payment method from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionPaymentMethodAsync(string subscriptionId, Models.UpdateSubscriptionPaymentMethodRequest request);

        /// <summary>
        /// Creates a new subscription
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse CreateSubscription(Models.CreateSubscriptionRequest body);

        /// <summary>
        /// Creates a new subscription
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> CreateSubscriptionAsync(Models.CreateSubscriptionRequest body);

        /// <summary>
        /// Creates a new Subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a subscription item</param>
        /// <return>Returns the Models.GetSubscriptionItemResponse response from the API call</return>
        Models.GetSubscriptionItemResponse CreateSubscriptionItem(string subscriptionId, Models.CreateSubscriptionItemRequest request);

        /// <summary>
        /// Creates a new Subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a subscription item</param>
        /// <return>Returns the Models.GetSubscriptionItemResponse response from the API call</return>
        Task<Models.GetSubscriptionItemResponse> CreateSubscriptionItemAsync(string subscriptionId, Models.CreateSubscriptionItemRequest request);

        /// <summary>
        /// Creates a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a discount</param>
        /// <return>Returns the Models.GetDiscountResponse response from the API call</return>
        Models.GetDiscountResponse CreateDiscount(string subscriptionId, Models.CreateDiscountRequest request);

        /// <summary>
        /// Creates a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a discount</param>
        /// <return>Returns the Models.GetDiscountResponse response from the API call</return>
        Task<Models.GetDiscountResponse> CreateDiscountAsync(string subscriptionId, Models.CreateDiscountRequest request);

        /// <summary>
        /// Get Subscription Item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns the Models.GetSubscriptionItemResponse response from the API call</return>
        Models.GetSubscriptionItemResponse GetSubscriptionItem(string subscriptionId, string itemId);

        /// <summary>
        /// Get Subscription Item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns the Models.GetSubscriptionItemResponse response from the API call</return>
        Task<Models.GetSubscriptionItemResponse> GetSubscriptionItemAsync(string subscriptionId, string itemId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse UpdateSubscriptionAffiliationId(string subscriptionId, Models.UpdateSubscriptionAffiliationIdRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionAffiliationIdAsync(string subscriptionId, Models.UpdateSubscriptionAffiliationIdRequest request);

        /// <summary>
        /// Create Usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns the Models.GetUsageResponse response from the API call</return>
        Models.GetUsageResponse CreateAnUsage(string subscriptionId, string itemId);

        /// <summary>
        /// Create Usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns the Models.GetUsageResponse response from the API call</return>
        Task<Models.GetUsageResponse> CreateAnUsageAsync(string subscriptionId, string itemId);

        /// <summary>
        /// Gets all subscriptions
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for subscription's code</param>
        /// <param name="billingType">Optional parameter: Filter for subscription's billing type</param>
        /// <param name="customerId">Optional parameter: Filter for subscription's customer id</param>
        /// <param name="planId">Optional parameter: Filter for subscription's plan id</param>
        /// <param name="cardId">Optional parameter: Filter for subscription's card id</param>
        /// <param name="status">Optional parameter: Filter for subscription's status</param>
        /// <param name="nextBillingSince">Optional parameter: Filter for subscription's next billing date start range</param>
        /// <param name="nextBillingUntil">Optional parameter: Filter for subscription's next billing date end range</param>
        /// <param name="createdSince">Optional parameter: Filter for subscription's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for subscriptions creation date end range</param>
        /// <return>Returns the Models.ListSubscriptionsResponse response from the API call</return>
        Models.ListSubscriptionsResponse GetSubscriptions(
                int? page = null,
                int? size = null,
                string code = null,
                string billingType = null,
                string customerId = null,
                string planId = null,
                string cardId = null,
                string status = null,
                DateTime? nextBillingSince = null,
                DateTime? nextBillingUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Gets all subscriptions
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for subscription's code</param>
        /// <param name="billingType">Optional parameter: Filter for subscription's billing type</param>
        /// <param name="customerId">Optional parameter: Filter for subscription's customer id</param>
        /// <param name="planId">Optional parameter: Filter for subscription's plan id</param>
        /// <param name="cardId">Optional parameter: Filter for subscription's card id</param>
        /// <param name="status">Optional parameter: Filter for subscription's status</param>
        /// <param name="nextBillingSince">Optional parameter: Filter for subscription's next billing date start range</param>
        /// <param name="nextBillingUntil">Optional parameter: Filter for subscription's next billing date end range</param>
        /// <param name="createdSince">Optional parameter: Filter for subscription's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for subscriptions creation date end range</param>
        /// <return>Returns the Models.ListSubscriptionsResponse response from the API call</return>
        Task<Models.ListSubscriptionsResponse> GetSubscriptionsAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string billingType = null,
                string customerId = null,
                string planId = null,
                string cardId = null,
                string status = null,
                DateTime? nextBillingSince = null,
                DateTime? nextBillingUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Updates the metadata from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse UpdateSubscriptionMetadata(string subscriptionId, Models.UpdateMetadataRequest request);

        /// <summary>
        /// Updates the metadata from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionMetadataAsync(string subscriptionId, Models.UpdateMetadataRequest request);

        /// <summary>
        /// Deletes a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id</param>
        /// <return>Returns the Models.GetSubscriptionItemResponse response from the API call</return>
        Models.GetSubscriptionItemResponse DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId);

        /// <summary>
        /// Deletes a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id</param>
        /// <return>Returns the Models.GetSubscriptionItemResponse response from the API call</return>
        Task<Models.GetSubscriptionItemResponse> DeleteSubscriptionItemAsync(string subscriptionId, string subscriptionItemId);

        /// <summary>
        /// Deletes a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="usageId">Required parameter: The usage id</param>
        /// <return>Returns the Models.GetUsageResponse response from the API call</return>
        Models.GetUsageResponse DeleteUsage(string subscriptionId, string itemId, string usageId);

        /// <summary>
        /// Deletes a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="usageId">Required parameter: The usage id</param>
        /// <return>Returns the Models.GetUsageResponse response from the API call</return>
        Task<Models.GetUsageResponse> DeleteUsageAsync(string subscriptionId, string itemId, string usageId);

        /// <summary>
        /// Deletes a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="discountId">Required parameter: Discount Id</param>
        /// <return>Returns the Models.GetDiscountResponse response from the API call</return>
        Models.GetDiscountResponse DeleteDiscount(string subscriptionId, string discountId);

        /// <summary>
        /// Deletes a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="discountId">Required parameter: Discount Id</param>
        /// <return>Returns the Models.GetDiscountResponse response from the API call</return>
        Task<Models.GetDiscountResponse> DeleteDiscountAsync(string subscriptionId, string discountId);

        /// <summary>
        /// Cancels a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse CancelSubscription(string subscriptionId, Models.CreateCancelSubscriptionRequest request = null);

        /// <summary>
        /// Cancels a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> CancelSubscriptionAsync(string subscriptionId, Models.CreateCancelSubscriptionRequest request = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="discountId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetDiscountResponse response from the API call</return>
        Models.GetDiscountResponse GetDiscountById(string subscriptionId, string discountId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="discountId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetDiscountResponse response from the API call</return>
        Task<Models.GetDiscountResponse> GetDiscountByIdAsync(string subscriptionId, string discountId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="page">Required parameter: Page number</param>
        /// <param name="size">Required parameter: Page size</param>
        /// <return>Returns the Models.ListDiscountsResponse response from the API call</return>
        Models.ListDiscountsResponse GetDiscounts(string subscriptionId, int page, int size);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="page">Required parameter: Page number</param>
        /// <param name="size">Required parameter: Page size</param>
        /// <return>Returns the Models.ListDiscountsResponse response from the API call</return>
        Task<Models.ListDiscountsResponse> GetDiscountsAsync(string subscriptionId, int page, int size);

        /// <summary>
        /// Creates a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a increment</param>
        /// <return>Returns the Models.GetIncrementResponse response from the API call</return>
        Models.GetIncrementResponse CreateIncrement(string subscriptionId, Models.CreateIncrementRequest request);

        /// <summary>
        /// Creates a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a increment</param>
        /// <return>Returns the Models.GetIncrementResponse response from the API call</return>
        Task<Models.GetIncrementResponse> CreateIncrementAsync(string subscriptionId, Models.CreateIncrementRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListIncrementsResponse response from the API call</return>
        Models.ListIncrementsResponse GetIncrements(string subscriptionId, int? page = null, int? size = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListIncrementsResponse response from the API call</return>
        Task<Models.ListIncrementsResponse> GetIncrementsAsync(string subscriptionId, int? page = null, int? size = null);

        /// <summary>
        /// Deletes a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="incrementId">Required parameter: Increment id</param>
        /// <return>Returns the Models.GetIncrementResponse response from the API call</return>
        Models.GetIncrementResponse DeleteIncrement(string subscriptionId, string incrementId);

        /// <summary>
        /// Deletes a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="incrementId">Required parameter: Increment id</param>
        /// <return>Returns the Models.GetIncrementResponse response from the API call</return>
        Task<Models.GetIncrementResponse> DeleteIncrementAsync(string subscriptionId, string incrementId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Identifier</param>
        /// <param name="cycleId">Optional parameter: Cycle id</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="itemId">Optional parameter: Identificador do item</param>
        /// <param name="mgroup">Optional parameter: identificador da loja (account) de cada item</param>
        /// <return>Returns the Models.GetUsagesDetailsResponse response from the API call</return>
        Models.GetUsagesDetailsResponse GetUsagesDetails(
                string subscriptionId,
                string cycleId = null,
                int? size = null,
                int? page = null,
                string itemId = null,
                string mgroup = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Identifier</param>
        /// <param name="cycleId">Optional parameter: Cycle id</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="itemId">Optional parameter: Identificador do item</param>
        /// <param name="mgroup">Optional parameter: identificador da loja (account) de cada item</param>
        /// <return>Returns the Models.GetUsagesDetailsResponse response from the API call</return>
        Task<Models.GetUsagesDetailsResponse> GetUsagesDetailsAsync(
                string subscriptionId,
                string cycleId = null,
                int? size = null,
                int? page = null,
                string itemId = null,
                string mgroup = null);

        /// <summary>
        /// Lists all usages from a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Identification code in the client system</param>
        /// <param name="mgroup">Optional parameter: Identification group in the client system</param>
        /// <return>Returns the Models.ListUsagesResponse response from the API call</return>
        Models.ListUsagesResponse GetUsages(
                string subscriptionId,
                string itemId,
                int? page = null,
                int? size = null,
                string code = null,
                string mgroup = null);

        /// <summary>
        /// Lists all usages from a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Identification code in the client system</param>
        /// <param name="mgroup">Optional parameter: Identification group in the client system</param>
        /// <return>Returns the Models.ListUsagesResponse response from the API call</return>
        Task<Models.ListUsagesResponse> GetUsagesAsync(
                string subscriptionId,
                string itemId,
                int? page = null,
                int? size = null,
                string code = null,
                string mgroup = null);

        /// <summary>
        /// Get Subscription Items
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="name">Optional parameter: The item name</param>
        /// <param name="code">Optional parameter: Identification code in the client system</param>
        /// <param name="status">Optional parameter: The item statis</param>
        /// <param name="description">Optional parameter: The item description</param>
        /// <param name="createdSince">Optional parameter: Filter for item's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for item's creation date end range</param>
        /// <return>Returns the Models.ListSubscriptionItemsResponse response from the API call</return>
        Models.ListSubscriptionItemsResponse GetSubscriptionItems(
                string subscriptionId,
                int? page = null,
                int? size = null,
                string name = null,
                string code = null,
                string status = null,
                string description = null,
                string createdSince = null,
                string createdUntil = null);

        /// <summary>
        /// Get Subscription Items
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="name">Optional parameter: The item name</param>
        /// <param name="code">Optional parameter: Identification code in the client system</param>
        /// <param name="status">Optional parameter: The item statis</param>
        /// <param name="description">Optional parameter: The item description</param>
        /// <param name="createdSince">Optional parameter: Filter for item's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for item's creation date end range</param>
        /// <return>Returns the Models.ListSubscriptionItemsResponse response from the API call</return>
        Task<Models.ListSubscriptionItemsResponse> GetSubscriptionItemsAsync(
                string subscriptionId,
                int? page = null,
                int? size = null,
                string name = null,
                string code = null,
                string status = null,
                string description = null,
                string createdSince = null,
                string createdUntil = null);

        /// <summary>
        /// Updates the boleto due days from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse UpdateSubscriptionDueDays(string subscriptionId, Models.UpdateSubscriptionDueDaysRequest request);

        /// <summary>
        /// Updates the boleto due days from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionDueDaysAsync(string subscriptionId, Models.UpdateSubscriptionDueDaysRequest request);

        /// <summary>
        /// Atualização do valor mínimo da assinatura
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Models.GetSubscriptionResponse UpdateSubscriptionMiniumPrice(string subscriptionId, Models.UpdateSubscriptionMinimumPriceRequest request);

        /// <summary>
        /// Atualização do valor mínimo da assinatura
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado</param>
        /// <return>Returns the Models.GetSubscriptionResponse response from the API call</return>
        Task<Models.GetSubscriptionResponse> UpdateSubscriptionMiniumPriceAsync(string subscriptionId, Models.UpdateSubscriptionMinimumPriceRequest request);

    }
} 