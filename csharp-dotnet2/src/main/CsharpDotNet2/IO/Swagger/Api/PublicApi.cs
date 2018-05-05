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
    public interface IPublicApi
    {
        /// <summary>
        /// retrieves a Intake by id Deletes an existing Intake by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteIntakeById (Guid? id);
        /// <summary>
        /// retrieves an Intake by id Gets an existing Intake by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Intake</returns>
        Intake GetIntakeById (Guid? id);
        /// <summary>
        /// updates an Intake by id Updates an existing Intake by id with only elements that are changing using
        /// </summary>
        /// <param name="id">unique id of Intake to patch</param>
        /// <param name="jsonPatch">partial json object of Intake with fields to patch</param>
        /// <returns></returns>
        void PatchIntakeById (Guid? id, JsonPatch jsonPatch);
        /// <summary>
        /// replaces an Intake by id Replaces an existing Intake by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="intake">unique id of Intake to update</param>
        /// <returns></returns>
        void UpdateIntakeById (Guid? id, Intake intake);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PublicApi : IPublicApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PublicApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicApi(String basePath)
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
        /// retrieves a Intake by id Deletes an existing Intake by id
        /// </summary>
        /// <param name="id"></param> 
        /// <returns></returns>            
        public void DeleteIntakeById (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteIntakeById");
            
    
            var path = "/intake/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteIntakeById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteIntakeById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// retrieves an Intake by id Gets an existing Intake by id
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>Intake</returns>            
        public Intake GetIntakeById (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetIntakeById");
            
    
            var path = "/intake/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIntakeById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIntakeById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Intake) ApiClient.Deserialize(response.Content, typeof(Intake), response.Headers);
        }
    
        /// <summary>
        /// updates an Intake by id Updates an existing Intake by id with only elements that are changing using
        /// </summary>
        /// <param name="id">unique id of Intake to patch</param> 
        /// <param name="jsonPatch">partial json object of Intake with fields to patch</param> 
        /// <returns></returns>            
        public void PatchIntakeById (Guid? id, JsonPatch jsonPatch)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PatchIntakeById");
            
            // verify the required parameter 'jsonPatch' is set
            if (jsonPatch == null) throw new ApiException(400, "Missing required parameter 'jsonPatch' when calling PatchIntakeById");
            
    
            var path = "/intake/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(jsonPatch); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchIntakeById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchIntakeById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// replaces an Intake by id Replaces an existing Intake by id
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="intake">unique id of Intake to update</param> 
        /// <returns></returns>            
        public void UpdateIntakeById (Guid? id, Intake intake)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateIntakeById");
            
            // verify the required parameter 'intake' is set
            if (intake == null) throw new ApiException(400, "Missing required parameter 'intake' when calling UpdateIntakeById");
            
    
            var path = "/intake/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(intake); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateIntakeById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateIntakeById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
