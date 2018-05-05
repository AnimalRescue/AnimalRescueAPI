using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        /// <summary>
        /// Creates a new Intake aggregate Create an Intake with all required components
        /// </summary>
        /// <param name="intake"></param>
        /// <returns></returns>
        void CreateIntake (Intake intake);
        /// <summary>
        /// Returns a filtered list of all Intakes for the Rescue Returns an array of IntakeList structures.  Intake serves as the aggregate for the process of bringing animals into the Rescue.
        /// </summary>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the items to be displayed</param>
        /// <param name="animalType">Specifies cat or dog</param>
        /// <param name="fromDate">Specifies the first intake date to return</param>
        /// <param name="type">Intake type of Surrender, Transfer, or Stray</param>
        /// <param name="location">Specifies a search string found in Location, Building, Room, Kennel, or Enclosure name</param>
        /// <param name="searchString">pass an optional search string for looking up items</param>
        /// <returns>List&lt;IntakeList&gt;</returns>
        List<IntakeList> GetFilteredIntakes (int? limit, int? offset, string animalType, DateTime? fromDate, string type, string location, string searchString);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Creates a new Intake aggregate Create an Intake with all required components
        /// </summary>
        /// <param name="intake"></param> 
        /// <returns></returns>            
        public void CreateIntake (Intake intake)
        {
            
            // verify the required parameter 'intake' is set
            if (intake == null) throw new ApiException(400, "Missing required parameter 'intake' when calling CreateIntake");
            
    
            var path = "/intake";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(intake); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateIntake: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateIntake: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns a filtered list of all Intakes for the Rescue Returns an array of IntakeList structures.  Intake serves as the aggregate for the process of bringing animals into the Rescue.
        /// </summary>
        /// <param name="limit">Limits the number of items on a page</param> 
        /// <param name="offset">Specifies the page number of the items to be displayed</param> 
        /// <param name="animalType">Specifies cat or dog</param> 
        /// <param name="fromDate">Specifies the first intake date to return</param> 
        /// <param name="type">Intake type of Surrender, Transfer, or Stray</param> 
        /// <param name="location">Specifies a search string found in Location, Building, Room, Kennel, or Enclosure name</param> 
        /// <param name="searchString">pass an optional search string for looking up items</param> 
        /// <returns>List&lt;IntakeList&gt;</returns>            
        public List<IntakeList> GetFilteredIntakes (int? limit, int? offset, string animalType, DateTime? fromDate, string type, string location, string searchString)
        {
            
    
            var path = "/intake";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (animalType != null) queryParams.Add("animalType", ApiClient.ParameterToString(animalType)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (searchString != null) queryParams.Add("searchString", ApiClient.ParameterToString(searchString)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFilteredIntakes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFilteredIntakes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<IntakeList>) ApiClient.Deserialize(response.Content, typeof(List<IntakeList>), response.Headers);
        }
    
    }
}
