# IO.Swagger.Api.PublicApi

All URIs are relative to *https://virtserver.swaggerhub.com/jgartee/AnimalRescueCQRS/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteIntakeById**](PublicApi.md#deleteintakebyid) | **DELETE** /intake/{id} | retrieves a Intake by id
[**GetIntakeById**](PublicApi.md#getintakebyid) | **GET** /intake/{id} | retrieves an Intake by id
[**PatchIntakeById**](PublicApi.md#patchintakebyid) | **PATCH** /intake/{id} | updates an Intake by id
[**UpdateIntakeById**](PublicApi.md#updateintakebyid) | **PUT** /intake/{id} | replaces an Intake by id


<a name="deleteintakebyid"></a>
# **DeleteIntakeById**
> void DeleteIntakeById (Guid? id)

retrieves a Intake by id

Deletes an existing Intake by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteIntakeByIdExample
    {
        public void main()
        {
            
            var apiInstance = new PublicApi();
            var id = id_example;  // Guid? | 

            try
            {
                // retrieves a Intake by id
                apiInstance.DeleteIntakeById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.DeleteIntakeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintakebyid"></a>
# **GetIntakeById**
> Intake GetIntakeById (Guid? id)

retrieves an Intake by id

Gets an existing Intake by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIntakeByIdExample
    {
        public void main()
        {
            
            var apiInstance = new PublicApi();
            var id = id_example;  // Guid? | 

            try
            {
                // retrieves an Intake by id
                Intake result = apiInstance.GetIntakeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.GetIntakeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**|  | 

### Return type

[**Intake**](Intake.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchintakebyid"></a>
# **PatchIntakeById**
> void PatchIntakeById (Guid? id, JsonPatch jsonPatch)

updates an Intake by id

Updates an existing Intake by id with only elements that are changing using

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchIntakeByIdExample
    {
        public void main()
        {
            
            var apiInstance = new PublicApi();
            var id = id_example;  // Guid? | unique id of Intake to patch
            var jsonPatch = new JsonPatch(); // JsonPatch | partial json object of Intake with fields to patch

            try
            {
                // updates an Intake by id
                apiInstance.PatchIntakeById(id, jsonPatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.PatchIntakeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**| unique id of Intake to patch | 
 **jsonPatch** | [**JsonPatch**](JsonPatch.md)| partial json object of Intake with fields to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateintakebyid"></a>
# **UpdateIntakeById**
> void UpdateIntakeById (Guid? id, Intake intake)

replaces an Intake by id

Replaces an existing Intake by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateIntakeByIdExample
    {
        public void main()
        {
            
            var apiInstance = new PublicApi();
            var id = id_example;  // Guid? | 
            var intake = new Intake(); // Intake | unique id of Intake to update

            try
            {
                // replaces an Intake by id
                apiInstance.UpdateIntakeById(id, intake);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.UpdateIntakeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**|  | 
 **intake** | [**Intake**](Intake.md)| unique id of Intake to update | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

