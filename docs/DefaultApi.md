# IO.InventoryClient.Api.DefaultApi

All URIs are relative to *https://www.orkiv.com/i/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AllGet**](DefaultApi.md#allget) | **GET** /all/ | 
[**CategoriesDelete**](DefaultApi.md#categoriesdelete) | **DELETE** /categories/ | 
[**CategoriesPost**](DefaultApi.md#categoriespost) | **POST** /categories/ | 
[**CategoriesPut**](DefaultApi.md#categoriesput) | **PUT** /categories/ | 
[**ItemAddPost**](DefaultApi.md#itemaddpost) | **POST** /item/add/ | 
[**ItemAddbulkPost**](DefaultApi.md#itemaddbulkpost) | **POST** /item/addbulk/ | 
[**ItemDelete**](DefaultApi.md#itemdelete) | **DELETE** /item/ | 
[**ItemPut**](DefaultApi.md#itemput) | **PUT** /item/ | 
[**ItemsCountPost**](DefaultApi.md#itemscountpost) | **POST** /items/count/ | 
[**ItemsPost**](DefaultApi.md#itemspost) | **POST** /items/ | 
[**ItemsallfieldsPost**](DefaultApi.md#itemsallfieldspost) | **POST** /items/?allfields | 
[**OrdersPost**](DefaultApi.md#orderspost) | **POST** /orders/ | 
[**QueryPost**](DefaultApi.md#querypost) | **POST** /query/ | 
[**QueryallfieldsPost**](DefaultApi.md#queryallfieldspost) | **POST** /query/?allfields | 
[**ServicesDelete**](DefaultApi.md#servicesdelete) | **DELETE** /services/ | 
[**ServicesGet**](DefaultApi.md#servicesget) | **GET** /services/ | 
[**ServicesPost**](DefaultApi.md#servicespost) | **POST** /services/ | 
[**ServicesPut**](DefaultApi.md#servicesput) | **PUT** /services/ | 
[**WriteDelete**](DefaultApi.md#writedelete) | **DELETE** /write/ | 
[**WritePost**](DefaultApi.md#writepost) | **POST** /write/ | 


<a name="allget"></a>
# **AllGet**
> List<InventoryGroup> AllGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class AllGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;InventoryGroup&gt; result = apiInstance.AllGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AllGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InventoryGroup>**](InventoryGroup.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriesdelete"></a>
# **CategoriesDelete**
> Response CategoriesDelete (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class CategoriesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | Id of category to remove

            try
            {
                Response result = apiInstance.CategoriesDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CategoriesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of category to remove | 

### Return type

[**Response**](Response.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriespost"></a>
# **CategoriesPost**
> List<Category> CategoriesPost (Dictionary query = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class CategoriesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var query = new Dictionary(); // Dictionary | Category to query against system (optional) 

            try
            {
                List&lt;Category&gt; result = apiInstance.CategoriesPost(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CategoriesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Dictionary**](Dictionary.md)| Category to query against system | [optional] 

### Return type

[**List<Category>**](Category.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriesput"></a>
# **CategoriesPut**
> Category CategoriesPut (string id, Category category)



If no ID is specified a new category will be created!

### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class CategoriesPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | category id to update.
            var category = new Category(); // Category | New category information.

            try
            {
                Category result = apiInstance.CategoriesPut(id, category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CategoriesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| category id to update. | 
 **category** | [**Category**](Category.md)| New category information. | 

### Return type

[**Category**](Category.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemaddpost"></a>
# **ItemAddPost**
> Item ItemAddPost (Item item)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ItemAddPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var item = new Item(); // Item | Item to create.

            try
            {
                Item result = apiInstance.ItemAddPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ItemAddPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item**](Item.md)| Item to create. | 

### Return type

[**Item**](Item.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemaddbulkpost"></a>
# **ItemAddbulkPost**
> Response ItemAddbulkPost (List<Item> items)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ItemAddbulkPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var items = new List<Item>(); // List<Item> | Items to create.

            try
            {
                Response result = apiInstance.ItemAddbulkPost(items);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ItemAddbulkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **items** | [**List<Item>**](Item.md)| Items to create. | 

### Return type

[**Response**](Response.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemdelete"></a>
# **ItemDelete**
> Response ItemDelete (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ItemDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | item id to remove

            try
            {
                Response result = apiInstance.ItemDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ItemDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| item id to remove | 

### Return type

[**Response**](Response.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemput"></a>
# **ItemPut**
> Response ItemPut (string id, Dictionary item)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ItemPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | item id to update.
            var item = new Dictionary(); // Dictionary | New item information.

            try
            {
                Response result = apiInstance.ItemPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ItemPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| item id to update. | 
 **item** | [**Dictionary**](Dictionary.md)| New item information. | 

### Return type

[**Response**](Response.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemscountpost"></a>
# **ItemsCountPost**
> decimal? ItemsCountPost (Dictionary query = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ItemsCountPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var query = new Dictionary(); // Dictionary | Item to query against system. (optional) 

            try
            {
                decimal? result = apiInstance.ItemsCountPost(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ItemsCountPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Dictionary**](Dictionary.md)| Item to query against system. | [optional] 

### Return type

**decimal?**

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemspost"></a>
# **ItemsPost**
> List<Item> ItemsPost (Dictionary query = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ItemsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var query = new Dictionary(); // Dictionary | Item to query against system. (optional) 

            try
            {
                List&lt;Item&gt; result = apiInstance.ItemsPost(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ItemsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Dictionary**](Dictionary.md)| Item to query against system. | [optional] 

### Return type

[**List<Item>**](Item.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemsallfieldspost"></a>
# **ItemsallfieldsPost**
> List<Dictionary> ItemsallfieldsPost (Dictionary query = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ItemsallfieldsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var query = new Dictionary(); // Dictionary | Item to query against system. (optional) 

            try
            {
                List&lt;Dictionary&gt; result = apiInstance.ItemsallfieldsPost(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ItemsallfieldsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Dictionary**](Dictionary.md)| Item to query against system. | [optional] 

### Return type

**List<Dictionary>**

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderspost"></a>
# **OrdersPost**
> List<Order> OrdersPost (Dictionary query = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class OrdersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var query = new Dictionary(); // Dictionary | Order to query against system. (optional) 

            try
            {
                List&lt;Order&gt; result = apiInstance.OrdersPost(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.OrdersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Dictionary**](Dictionary.md)| Order to query against system. | [optional] 

### Return type

[**List<Order>**](Order.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querypost"></a>
# **QueryPost**
> List<Item> QueryPost (decimal? page = null, string categoryid = null, string sort = null, string search = null, decimal? minprice = null, decimal? maxprice = null, Dictionary query = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class QueryPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var page = 3.4;  // decimal? | Current page index. (optional) 
            var categoryid = categoryid_example;  // string | Get items under specified category id. (optional) 
            var sort = sort_example;  // string | Comma delimited Sort string. ie ; +ordprice. Please use number based fields only (optional) 
            var search = search_example;  // string | Performs a regex pattern match against the items within your account (optional) 
            var minprice = 3.4;  // decimal? | Min price in hundreds. (optional) 
            var maxprice = 3.4;  // decimal? | Max price in hudreds. (optional) 
            var query = new Dictionary(); // Dictionary | Custom parameters to query against system. (optional) 

            try
            {
                List&lt;Item&gt; result = apiInstance.QueryPost(page, categoryid, sort, search, minprice, maxprice, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.QueryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **decimal?**| Current page index. | [optional] 
 **categoryid** | **string**| Get items under specified category id. | [optional] 
 **sort** | **string**| Comma delimited Sort string. ie ; +ordprice. Please use number based fields only | [optional] 
 **search** | **string**| Performs a regex pattern match against the items within your account | [optional] 
 **minprice** | **decimal?**| Min price in hundreds. | [optional] 
 **maxprice** | **decimal?**| Max price in hudreds. | [optional] 
 **query** | [**Dictionary**](Dictionary.md)| Custom parameters to query against system. | [optional] 

### Return type

[**List<Item>**](Item.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryallfieldspost"></a>
# **QueryallfieldsPost**
> List<Dictionary> QueryallfieldsPost (decimal? page = null, string categoryid = null, string sort = null, string search = null, decimal? minprice = null, decimal? maxprice = null, Dictionary query = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class QueryallfieldsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var page = 3.4;  // decimal? | Current page index. (optional) 
            var categoryid = categoryid_example;  // string | Get items under specified category id. (optional) 
            var sort = sort_example;  // string | Comma delimited Sort string. ie ; +ordprice. Please use number based fields only (optional) 
            var search = search_example;  // string | Performs a regex pattern match against the items within your account (optional) 
            var minprice = 3.4;  // decimal? | Min price in hundreds. (optional) 
            var maxprice = 3.4;  // decimal? | Max price in hudreds. (optional) 
            var query = new Dictionary(); // Dictionary | Custom parameters to query against system. (optional) 

            try
            {
                List&lt;Dictionary&gt; result = apiInstance.QueryallfieldsPost(page, categoryid, sort, search, minprice, maxprice, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.QueryallfieldsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **decimal?**| Current page index. | [optional] 
 **categoryid** | **string**| Get items under specified category id. | [optional] 
 **sort** | **string**| Comma delimited Sort string. ie ; +ordprice. Please use number based fields only | [optional] 
 **search** | **string**| Performs a regex pattern match against the items within your account | [optional] 
 **minprice** | **decimal?**| Min price in hundreds. | [optional] 
 **maxprice** | **decimal?**| Max price in hudreds. | [optional] 
 **query** | [**Dictionary**](Dictionary.md)| Custom parameters to query against system. | [optional] 

### Return type

**List<Dictionary>**

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicesdelete"></a>
# **ServicesDelete**
> Response ServicesDelete (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ServicesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | ID of the service to update

            try
            {
                Response result = apiInstance.ServicesDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the service to update | 

### Return type

[**Response**](Response.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicesget"></a>
# **ServicesGet**
> List<Service> ServicesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ServicesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;Service&gt; result = apiInstance.ServicesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Service>**](Service.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicespost"></a>
# **ServicesPost**
> Service ServicesPost (Service service)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ServicesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var service = new Service(); // Service | Service to create.

            try
            {
                Service result = apiInstance.ServicesPost(service);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | [**Service**](Service.md)| Service to create. | 

### Return type

[**Service**](Service.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicesput"></a>
# **ServicesPut**
> Response ServicesPut (string id, Service service)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class ServicesPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | ID of the service to update
            var service = new Service(); // Service | New service data to set.

            try
            {
                Response result = apiInstance.ServicesPut(id, service);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServicesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the service to update | 
 **service** | [**Service**](Service.md)| New service data to set. | 

### Return type

[**Response**](Response.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writedelete"></a>
# **WriteDelete**
> Response WriteDelete (string id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class WriteDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | Will delete event attached to this serviceid (optional) 

            try
            {
                Response result = apiInstance.WriteDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.WriteDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Will delete event attached to this serviceid | [optional] 

### Return type

[**Response**](Response.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writepost"></a>
# **WritePost**
> Response WritePost (EventRequest eventRequest)



Will ovveride the current event of the specified service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.InventoryClient.Api;
using IO.InventoryClient.Client;
using IO.InventoryClient.Model;

namespace Example
{
    public class WritePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKey
            Configuration.Default.ApiKey.Add("APIKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKey", "Bearer");
            // Configure API key authorization: AccountID
            Configuration.Default.ApiKey.Add("accountid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("accountid", "Bearer");

            var apiInstance = new DefaultApi();
            var eventRequest = new EventRequest(); // EventRequest | Event to upload

            try
            {
                Response result = apiInstance.WritePost(eventRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.WritePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventRequest** | [**EventRequest**](EventRequest.md)| Event to upload | 

### Return type

[**Response**](Response.md)

### Authorization

[APIKey](../README.md#APIKey), [AccountID](../README.md#AccountID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

