# Amazon.SellingPartnerAPI.SDK.Model.pricing.v2022_05_01.FeaturedOfferExpectedPriceRequest
An individual FOEP request for a particular SKU.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The URI associated with an individual request within a batch. For &#x60;FeaturedOfferExpectedPrice&#x60;, this is &#x60;/products/pricing/2022-05-01/offer/featuredOfferExpectedPrice&#x60;. | 
**Method** | **HttpMethod** |  | 
**Body** | **Dictionary&lt;string, Object&gt;** | Additional HTTP body information that is associated with an individual request within a batch. | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | A mapping of additional HTTP headers to send or receive for an individual request within a batch. | [optional] 
**MarketplaceId** | **string** | A marketplace identifier. Specifies the marketplace for which data is returned. | 
**Sku** | **string** | The seller SKU of the item. | 
**Segment** | [**Segment**](Segment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

