# Amazon.SellingPartnerAPI.SDK.Model.listings.items.v2021_08_01.IssueExemption
Conveying the status of the listed enforcement actions and, if applicable, provides information about the exemption's expiry date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | This field indicates the current exemption status for the listed enforcement actions. It can take values such as &#x60;EXEMPT&#x60;, signifying permanent exemption, &#x60;EXEMPT_UNTIL_EXPIRY_DATE&#x60; indicating temporary exemption until a specified date, or &#x60;NOT_EXEMPT&#x60; signifying no exemptions, and enforcement actions were already applied. | 
**ExpiryDate** | **DateTime** | This field represents the timestamp, following the ISO 8601 format, which specifies the date when temporary exemptions, if applicable, will expire, and Amazon will begin enforcing the listed actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

