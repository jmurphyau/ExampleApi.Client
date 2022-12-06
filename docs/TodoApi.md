# ExampleApi.Client.Api.TodoApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiTodoGet**](TodoApi.md#apitodoget) | **GET** /api/Todo |  |
| [**ApiTodoIdDelete**](TodoApi.md#apitodoiddelete) | **DELETE** /api/Todo/{id} | Deletes a specific TodoItem. |
| [**ApiTodoIdGet**](TodoApi.md#apitodoidget) | **GET** /api/Todo/{id} |  |
| [**ApiTodoPost**](TodoApi.md#apitodopost) | **POST** /api/Todo | Creates a TodoItem. |

<a name="apitodoget"></a>
# **ApiTodoGet**
> List&lt;TodoItem&gt; ApiTodoGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ExampleApi.Client.Api;
using ExampleApi.Client.Client;
using ExampleApi.Client.Model;

namespace Example
{
    public class ApiTodoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TodoApi(config);

            try
            {
                List<TodoItem> result = apiInstance.ApiTodoGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoApi.ApiTodoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTodoGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TodoItem>> response = apiInstance.ApiTodoGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoApi.ApiTodoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TodoItem&gt;**](TodoItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitodoiddelete"></a>
# **ApiTodoIdDelete**
> void ApiTodoIdDelete (long id)

Deletes a specific TodoItem.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ExampleApi.Client.Api;
using ExampleApi.Client.Client;
using ExampleApi.Client.Model;

namespace Example
{
    public class ApiTodoIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TodoApi(config);
            var id = 789L;  // long | 

            try
            {
                // Deletes a specific TodoItem.
                apiInstance.ApiTodoIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoApi.ApiTodoIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTodoIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific TodoItem.
    apiInstance.ApiTodoIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoApi.ApiTodoIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitodoidget"></a>
# **ApiTodoIdGet**
> TodoItem ApiTodoIdGet (long id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ExampleApi.Client.Api;
using ExampleApi.Client.Client;
using ExampleApi.Client.Model;

namespace Example
{
    public class ApiTodoIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TodoApi(config);
            var id = 789L;  // long | 

            try
            {
                TodoItem result = apiInstance.ApiTodoIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoApi.ApiTodoIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTodoIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TodoItem> response = apiInstance.ApiTodoIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoApi.ApiTodoIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |

### Return type

[**TodoItem**](TodoItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitodopost"></a>
# **ApiTodoPost**
> void ApiTodoPost (TodoItem? todoItem = null)

Creates a TodoItem.

Sample request:                    POST /Todo      {         \"id\": 1,         \"name\": \"Item #1\",         \"isComplete\": true      }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ExampleApi.Client.Api;
using ExampleApi.Client.Client;
using ExampleApi.Client.Model;

namespace Example
{
    public class ApiTodoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TodoApi(config);
            var todoItem = new TodoItem?(); // TodoItem? |  (optional) 

            try
            {
                // Creates a TodoItem.
                apiInstance.ApiTodoPost(todoItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoApi.ApiTodoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTodoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a TodoItem.
    apiInstance.ApiTodoPostWithHttpInfo(todoItem);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoApi.ApiTodoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **todoItem** | [**TodoItem?**](TodoItem?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created item |  -  |
| **400** | If the item is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

