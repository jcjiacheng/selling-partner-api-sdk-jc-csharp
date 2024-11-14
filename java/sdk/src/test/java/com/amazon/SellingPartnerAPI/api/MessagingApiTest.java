/*
 * Selling Partner API for Messaging
 * With the Messaging API you can build applications that send messages to buyers. You can get a list of message types that are available for an order that you specify, then call an operation that sends a message to the buyer for that order. The Messaging API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.api;

import com.amazon.SellingPartnerAPI.ApiException;
import com.amazon.SellingPartnerAPI.models.CreateAmazonMotorsRequest;
import com.amazon.SellingPartnerAPI.models.CreateAmazonMotorsResponse;
import com.amazon.SellingPartnerAPI.models.CreateConfirmCustomizationDetailsRequest;
import com.amazon.SellingPartnerAPI.models.CreateConfirmCustomizationDetailsResponse;
import com.amazon.SellingPartnerAPI.models.CreateConfirmDeliveryDetailsRequest;
import com.amazon.SellingPartnerAPI.models.CreateConfirmDeliveryDetailsResponse;
import com.amazon.SellingPartnerAPI.models.CreateConfirmOrderDetailsRequest;
import com.amazon.SellingPartnerAPI.models.CreateConfirmOrderDetailsResponse;
import com.amazon.SellingPartnerAPI.models.CreateConfirmServiceDetailsRequest;
import com.amazon.SellingPartnerAPI.models.CreateConfirmServiceDetailsResponse;
import com.amazon.SellingPartnerAPI.models.CreateDigitalAccessKeyRequest;
import com.amazon.SellingPartnerAPI.models.CreateDigitalAccessKeyResponse;
import com.amazon.SellingPartnerAPI.models.CreateLegalDisclosureRequest;
import com.amazon.SellingPartnerAPI.models.CreateLegalDisclosureResponse;
import com.amazon.SellingPartnerAPI.models.CreateNegativeFeedbackRemovalResponse;
import com.amazon.SellingPartnerAPI.models.CreateUnexpectedProblemRequest;
import com.amazon.SellingPartnerAPI.models.CreateUnexpectedProblemResponse;
import com.amazon.SellingPartnerAPI.models.CreateWarrantyRequest;
import com.amazon.SellingPartnerAPI.models.CreateWarrantyResponse;
import com.amazon.SellingPartnerAPI.models.GetAttributesResponse;
import com.amazon.SellingPartnerAPI.models.GetMessagingActionsForOrderResponse;
import com.amazon.SellingPartnerAPI.models.InvoiceRequest;
import com.amazon.SellingPartnerAPI.models.InvoiceResponse;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import com.amazon.SellingPartnerAPIAA.LWAException;

/**
* API tests for MessagingApi
*/
@Ignore
public class MessagingApiTest {

private final MessagingApi api = new MessagingApi();

/**
* 
*
* Sends a message asking a buyer to provide or verify customization details such as name spelling, images, initials, etc.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void confirmCustomizationDetailsTest() throws ApiException, LWAException {
    CreateConfirmCustomizationDetailsRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateConfirmCustomizationDetailsResponse response = api.confirmCustomizationDetails(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a message to a buyer to provide details about an Amazon Motors order. This message can only be sent by Amazon Motors sellers.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createAmazonMotorsTest() throws ApiException, LWAException {
    CreateAmazonMotorsRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateAmazonMotorsResponse response = api.createAmazonMotors(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a message to a buyer to arrange a delivery or to confirm contact information for making a delivery.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createConfirmDeliveryDetailsTest() throws ApiException, LWAException {
    CreateConfirmDeliveryDetailsRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateConfirmDeliveryDetailsResponse response = api.createConfirmDeliveryDetails(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a message to ask a buyer an order-related question prior to shipping their order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createConfirmOrderDetailsTest() throws ApiException, LWAException {
    CreateConfirmOrderDetailsRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateConfirmOrderDetailsResponse response = api.createConfirmOrderDetails(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a message to contact a Home Service customer to arrange a service call or to gather information prior to a service call.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createConfirmServiceDetailsTest() throws ApiException, LWAException {
    CreateConfirmServiceDetailsRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateConfirmServiceDetailsResponse response = api.createConfirmServiceDetails(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a message to a buyer to share a digital access key needed to utilize digital content in their order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createDigitalAccessKeyTest() throws ApiException, LWAException {
    CreateDigitalAccessKeyRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateDigitalAccessKeyResponse response = api.createDigitalAccessKey(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a critical message that contains documents that a seller is legally obligated to provide to the buyer. This message should only be used to deliver documents that are required by law.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createLegalDisclosureTest() throws ApiException, LWAException {
    CreateLegalDisclosureRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateLegalDisclosureResponse response = api.createLegalDisclosure(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a non-critical message that asks a buyer to remove their negative feedback. This message should only be sent after the seller has resolved the buyer&#x27;s problem.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createNegativeFeedbackRemovalTest() throws ApiException, LWAException {
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateNegativeFeedbackRemovalResponse response = api.createNegativeFeedbackRemoval(amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a critical message to a buyer that an unexpected problem was encountered affecting the completion of the order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createUnexpectedProblemTest() throws ApiException, LWAException {
    CreateUnexpectedProblemRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateUnexpectedProblemResponse response = api.createUnexpectedProblem(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a message to a buyer to provide details about warranty information on a purchase in their order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void createWarrantyTest() throws ApiException, LWAException {
    CreateWarrantyRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
CreateWarrantyResponse response = api.createWarranty(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Returns a response containing attributes related to an order. This includes buyer preferences.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void getAttributesTest() throws ApiException, LWAException {
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
GetAttributesResponse response = api.getAttributes(amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Returns a list of message types that are available for an order that you specify. A message type is represented by an actions object, which contains a path and query parameter(s). You can use the path and parameter(s) to call an operation that sends a message.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void getMessagingActionsForOrderTest() throws ApiException, LWAException {
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
GetMessagingActionsForOrderResponse response = api.getMessagingActionsForOrder(amazonOrderId, marketplaceIds);

// TODO: test validations
}
/**
* 
*
* Sends a message providing the buyer an invoice
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void sendInvoiceTest() throws ApiException, LWAException {
    InvoiceRequest body = null;
    String amazonOrderId = null;
    List<String> marketplaceIds = null;
InvoiceResponse response = api.sendInvoice(body, amazonOrderId, marketplaceIds);

// TODO: test validations
}
}