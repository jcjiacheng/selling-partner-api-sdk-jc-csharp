/*
 * Selling Partner API for Replenishment
 * The Selling Partner API for Replenishment (Replenishment API) provides programmatic access to replenishment program metrics and offers. These programs provide recurring delivery of any replenishable item at a frequency chosen by the customer.  The Replenishment API is available worldwide wherever Amazon Subscribe & Save is available or is supported. The API is available to vendors and FBA selling partners.
 *
 * OpenAPI spec version: 2022-11-07
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.api;

import com.amazon.SellingPartnerAPI.ApiException;
import com.amazon.SellingPartnerAPI.models.ErrorList;
import com.amazon.SellingPartnerAPI.models.GetSellingPartnerMetricsRequest;
import com.amazon.SellingPartnerAPI.models.GetSellingPartnerMetricsResponse;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import com.amazon.SellingPartnerAPIAA.LWAException;

/**
* API tests for SellingpartnersApi
*/
@Ignore
public class SellingpartnersApiTest {

private final SellingpartnersApi api = new SellingpartnersApi();

/**
* 
*
* Returns aggregated replenishment program metrics for a selling partner.   **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 1 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
*
* @throws ApiException if the Api call fails
* @throws LWAException If calls to fetch LWA access token fails
*/
@Test
public void getSellingPartnerMetricsTest() throws ApiException, LWAException {
    GetSellingPartnerMetricsRequest body = null;
GetSellingPartnerMetricsResponse response = api.getSellingPartnerMetrics(body);

// TODO: test validations
}
}