# IO.Swagger.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Order ID | [optional] 
**InfoEmail** | **string** | Customer email | [optional] 
**InfoFirst** | **string** | Customer first name | [optional] 
**InfoLast** | **string** | Customer last name | [optional] 
**Phone** | **string** | Customer phone number | [optional] 
**Shipset** | **bool?** | Customer billing address matches shipping address | [optional] 
**InfoAdr1** | **string** | Customer billing address line &#39;1&#39; | [optional] 
**InfoAdr2** | **string** | Customer billing address line &#39;2&#39; | [optional] 
**InfoCty** | **string** | Customer billing city | [optional] 
**InfoZip** | **string** | Customer billing zip code | [optional] 
**State** | **string** | Customer billing state | [optional] 
**InfoSadr1** | **string** | Customer shipping address line &#39;1&#39; | [optional] 
**InfoSadr2** | **string** | Customer shipping address line &#39;2&#39; | [optional] 
**InfoScty** | **string** | Customer shipping city | [optional] 
**InfoSzip** | **string** | Customer shipping zip code | [optional] 
**Sstate** | **string** | Customer shipping state | [optional] 
**TaxAmount** | **float?** | Tax amount in hundreds. Must divide by &#39;100&#39; for USD value | [optional] 
**ShippingAmount** | **float?** | Shipping total in USD | [optional] 
**AmountTotal** | **float?** | Checkout total in USD | [optional] 
**ItemIDs** | **List&lt;string&gt;** | Array of items purchased at checkout | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

