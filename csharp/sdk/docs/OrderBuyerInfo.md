# software.amzn.spapi.Model.orders.v0.OrderBuyerInfo
Buyer information for an order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmazonOrderId** | **string** | An Amazon-defined order identifier, in 3-7-7 format. | 
**BuyerEmail** | **string** | The anonymized email address of the buyer. | [optional] 
**BuyerName** | **string** | The buyer name or the recipient name. | [optional] 
**BuyerCounty** | **string** | The county of the buyer.  **Note**: This attribute is only available in the Brazil marketplace. | [optional] 
**BuyerTaxInfo** | [**BuyerTaxInfo**](BuyerTaxInfo.md) |  | [optional] 
**PurchaseOrderNumber** | **string** | The purchase order (PO) number entered by the buyer at checkout. Only returned for orders where the buyer entered a PO number at checkout. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

