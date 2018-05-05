# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://virtserver.swaggerhub.com/jgartee/AnimalRescueCQRS/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIntake**](DefaultApi.md#createintake) | **POST** /intake | Creates a new Intake aggregate
[**GetFilteredIntakes**](DefaultApi.md#getfilteredintakes) | **GET** /intake | Returns a filtered list of all Intakes for the Rescue


<a name="createintake"></a>
# **CreateIntake**
> void CreateIntake (Intake intake)

Creates a new Intake aggregate

Create an Intake with all required components

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateIntakeExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var intake = new Intake(); // Intake | 

            try
            {
                // Creates a new Intake aggregate
                apiInstance.CreateIntake(intake);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateIntake: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **intake** | [**Intake**](Intake.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilteredintakes"></a>
# **GetFilteredIntakes**
> List<IntakeList> GetFilteredIntakes (int? limit, int? offset, string animalType, DateTime? fromDate, string type, string location, string searchString)

Returns a filtered list of all Intakes for the Rescue

Returns an array of IntakeList structures.  Intake serves as the aggregate for the process of bringing animals into the Rescue.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredIntakesExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the items to be displayed (optional) 
            var animalType = animalType_example;  // string | Specifies cat or dog (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first intake date to return (optional) 
            var type = type_example;  // string | Intake type of Surrender, Transfer, or Stray (optional) 
            var location = location_example;  // string | Specifies a search string found in Location, Building, Room, Kennel, or Enclosure name (optional) 
            var searchString = searchString_example;  // string | pass an optional search string for looking up items (optional) 

            try
            {
                // Returns a filtered list of all Intakes for the Rescue
                List&lt;IntakeList&gt; result = apiInstance.GetFilteredIntakes(limit, offset, animalType, fromDate, type, location, searchString);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredIntakes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the items to be displayed | [optional] 
 **animalType** | **string**| Specifies cat or dog | [optional] 
 **fromDate** | **DateTime?**| Specifies the first intake date to return | [optional] 
 **type** | **string**| Intake type of Surrender, Transfer, or Stray | [optional] 
 **location** | **string**| Specifies a search string found in Location, Building, Room, Kennel, or Enclosure name | [optional] 
 **searchString** | **string**| pass an optional search string for looking up items | [optional] 

### Return type

[**List<IntakeList>**](IntakeList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

