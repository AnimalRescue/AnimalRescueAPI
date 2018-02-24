/*
 * AnimalRescue API
 *
 * API for OSS AnimalRescue
 *
 * OpenAPI spec version: 1.0.0
 * Contact: jlgartee@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class VetsApiController : Controller
    { 
        /// <summary>
        /// creates a new Cat
        /// </summary>
        /// <remarks>adds a Cat with a unique id</remarks>
        /// <param name="catToCreate">full Cat object with new id</param>
        /// <response code="200">ok</response>
        /// <response code="201">create successful</response>
        /// <response code="400">bad request</response>
        /// <response code="409">unable to apply valid change to a valid Cat</response>
        [HttpPost]
        [Route("/jgartee/AnimalRescue/1.0.0/cat")]
        [ValidateModelState]
        [SwaggerOperation("CreateCat")]
        public virtual void CreateCat([FromBody]Cat catToCreate)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// creates new Contact with a unique id
        /// </summary>
        /// <remarks>creates a new, unique Contact</remarks>
        /// <param name="createContact">new Contact object</param>
        /// <response code="200">ok</response>
        /// <response code="400">invalid content on Contact info</response>
        /// <response code="401">unauthorized request</response>
        [HttpPost]
        [Route("/jgartee/AnimalRescue/1.0.0/contact")]
        [ValidateModelState]
        [SwaggerOperation("CreateContact")]
        public virtual void CreateContact([FromBody]Contact createContact)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// creates a new Dog
        /// </summary>
        /// <remarks>adds a Dog with a unique id</remarks>
        /// <param name="dogToCreate">full Dog object with new id</param>
        /// <response code="200">ok</response>
        /// <response code="201">create successful</response>
        /// <response code="400">bad request</response>
        /// <response code="409">unable to apply valid change to a valid Dog</response>
        [HttpPost]
        [Route("/jgartee/AnimalRescue/1.0.0/dog")]
        [ValidateModelState]
        [SwaggerOperation("CreateDog")]
        public virtual void CreateDog([FromBody]Dog dogToCreate)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// creates new Donor with a unique id
        /// </summary>
        /// <remarks>creates a new, unique Donor</remarks>
        /// <param name="createDonor">new Donor object</param>
        /// <response code="200">ok</response>
        /// <response code="400">invalid content on Donor info</response>
        /// <response code="401">unauthorized request</response>
        [HttpPost]
        [Route("/jgartee/AnimalRescue/1.0.0/donor")]
        [ValidateModelState]
        [SwaggerOperation("CreateDonor")]
        public virtual void CreateDonor([FromBody]Donor createDonor)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// creates new Foster with a unique id
        /// </summary>
        /// <remarks>creates a new, unique Foster</remarks>
        /// <param name="createFoster">new Foster object</param>
        /// <response code="200">ok</response>
        /// <response code="400">invalid content on Foster info</response>
        /// <response code="401">unauthorized request</response>
        [HttpPost]
        [Route("/jgartee/AnimalRescue/1.0.0/foster")]
        [ValidateModelState]
        [SwaggerOperation("CreateFoster")]
        public virtual void CreateFoster([FromBody]Foster createFoster)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// deletes an existing Cat by id
        /// </summary>
        /// <remarks>deletes a cat</remarks>
        /// <param name="id">Specifies the unique id of an existing Cat </param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        [HttpDelete]
        [Route("/jgartee/AnimalRescue/1.0.0/cat")]
        [ValidateModelState]
        [SwaggerOperation("DeleteCat")]
        public virtual void DeleteCat([FromQuery]Guid? id)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// retrieves a Cat by id
        /// </summary>
        /// <remarks>Deletes an existing Cat by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        [HttpDelete]
        [Route("/jgartee/AnimalRescue/1.0.0/cat/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteCatById")]
        public virtual void DeleteCatById([FromRoute]Guid? id)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// deletes an existing Dog by id
        /// </summary>
        /// <remarks>deletes a dog</remarks>
        /// <param name="id">Specifies the unique id of an existing Dog </param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        [HttpDelete]
        [Route("/jgartee/AnimalRescue/1.0.0/dog")]
        [ValidateModelState]
        [SwaggerOperation("DeleteDog")]
        public virtual void DeleteDog([FromQuery]Guid? id)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// retrieves a Dog by id
        /// </summary>
        /// <remarks>Deletes an existing Dog by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        [HttpDelete]
        [Route("/jgartee/AnimalRescue/1.0.0/dog/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteDogById")]
        public virtual void DeleteDogById([FromRoute]Guid? id)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// reports whether the API is up and running
        /// </summary>
        /// <remarks>used to check on the api status</remarks>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/health")]
        [ValidateModelState]
        [SwaggerOperation("GetApiHealth")]
        public virtual void GetApiHealth()
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// retrieves a Cat by id
        /// </summary>
        /// <remarks>Gets an existing Cat by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/cat/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetCatById")]
        [SwaggerResponse(200, typeof(Cat), "ok")]
        [SwaggerResponse(400, typeof(Cat), "bad request")]
        [SwaggerResponse(401, typeof(Cat), "unauthorized request")]
        public virtual IActionResult GetCatById([FromRoute]Guid? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Cat>(exampleJson)
            : default(Cat);
            return new ObjectResult(example);
        }

        /// <summary>
        /// retrieves counties for the provided state
        /// </summary>
        /// <remarks>Given a state, return an alpha list of counties in that state</remarks>
        /// <param name="state">state to retrieve counties for</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/county")]
        [ValidateModelState]
        [SwaggerOperation("GetCountiesByState")]
        [SwaggerResponse(200, typeof(List<string>), "OK")]
        public virtual IActionResult GetCountiesByState([FromQuery]string state)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
            : default(List<string>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// retrieves a Dog by id
        /// </summary>
        /// <remarks>Gets an existing Dog by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/dog/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetDogById")]
        [SwaggerResponse(200, typeof(Dog), "ok")]
        [SwaggerResponse(400, typeof(Dog), "bad request")]
        [SwaggerResponse(401, typeof(Dog), "unauthorized request")]
        public virtual IActionResult GetDogById([FromRoute]Guid? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Dog>(exampleJson)
            : default(Dog);
            return new ObjectResult(example);
        }

        /// <summary>
        /// updates a Cat
        /// </summary>
        /// <remarks>sends a partial JSON Cat structure for an existing Cat id</remarks>
        /// <param name="updateInfo">json object containing specific values to update for an existing Cat id</param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="409">unable to apply valid change to a valid Cat</response>
        /// <response code="415">invalid document type</response>
        [HttpPatch]
        [Route("/jgartee/AnimalRescue/1.0.0/cat")]
        [ValidateModelState]
        [SwaggerOperation("PatchCat")]
        public virtual void PatchCat([FromQuery]string updateInfo)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// updates a Cat by id
        /// </summary>
        /// <remarks>Updates an existing Cat by id with only elements that are changing</remarks>
        /// <param name="id">unique id of Cat to patch</param>
        /// <param name="patchCat">partial json object of Cat with fields to patch</param>
        /// <response code="200">ok</response>
        [HttpPatch]
        [Route("/jgartee/AnimalRescue/1.0.0/cat/{id}")]
        [ValidateModelState]
        [SwaggerOperation("PatchCatById")]
        public virtual void PatchCatById([FromRoute]Guid? id, [FromBody]Cat patchCat)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// updates a Dog
        /// </summary>
        /// <remarks>sends a partial JSON Dog structure for an existing Dog id</remarks>
        /// <param name="updateInfo">json object containing specific values to update for an existing Dog id</param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="409">unable to apply valid change to a valid Dog</response>
        /// <response code="415">invalid document type</response>
        [HttpPatch]
        [Route("/jgartee/AnimalRescue/1.0.0/dog")]
        [ValidateModelState]
        [SwaggerOperation("PatchDog")]
        public virtual void PatchDog([FromQuery]string updateInfo)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// updates a Dog by id
        /// </summary>
        /// <remarks>Updates an existing Dog by id with only elements that are changing</remarks>
        /// <param name="id">unique id of Dog to patch</param>
        /// <param name="patchDog">partial json object of Dog with fields to patch</param>
        /// <response code="200">ok</response>
        [HttpPatch]
        [Route("/jgartee/AnimalRescue/1.0.0/dog/{id}")]
        [ValidateModelState]
        [SwaggerOperation("PatchDogById")]
        public virtual void PatchDogById([FromRoute]Guid? id, [FromBody]Dog patchDog)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// searches all buildings at the Rescue
        /// </summary>
        /// <remarks>With no parameters, returns all Buildings at the Rescue </remarks>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/adoption")]
        [ValidateModelState]
        [SwaggerOperation("SearchAdoptions")]
        [SwaggerResponse(200, typeof(List<Building>), "ok")]
        [SwaggerResponse(204, typeof(List<Building>), "no results found")]
        [SwaggerResponse(400, typeof(List<Building>), "bad request - check parameter format")]
        [SwaggerResponse(401, typeof(List<Building>), "unauthorized request for this user")]
        public virtual IActionResult SearchAdoptions()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Building>>(exampleJson)
            : default(List<Building>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// returns all buildings at a Rescue Location
        /// </summary>
        /// <remarks>With no parameters, returns all Buildings at the Rescue </remarks>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/building")]
        [ValidateModelState]
        [SwaggerOperation("SearchBuildings")]
        [SwaggerResponse(200, typeof(List<Building>), "ok")]
        [SwaggerResponse(204, typeof(List<Building>), "no results found")]
        [SwaggerResponse(400, typeof(List<Building>), "bad request - check parameter format")]
        [SwaggerResponse(401, typeof(List<Building>), "unauthorized request for this user")]
        public virtual IActionResult SearchBuildings()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Building>>(exampleJson)
            : default(List<Building>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// searches cats
        /// </summary>
        /// <remarks>With no parameters, returns all cats currently in the shelter. Allows filters. </remarks>
        /// <param name="fromDate">Specifies the first intake date to return</param>
        /// <param name="toDate">Specifies the last intake date to return</param>
        /// <param name="name">Specifies a matching pattern for the name</param>
        /// <param name="adoptionStatus">Specifies one of the valid AdoptionStatus values</param>
        /// <param name="breed">breed of cat to retrieve</param>
        /// <param name="color">Specifies one of the valid CatColors</param>
        /// <param name="gender">Specifies on of the valid Gender</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/cat")]
        [ValidateModelState]
        [SwaggerOperation("SearchCats")]
        [SwaggerResponse(200, typeof(List<Cat>), "ok")]
        [SwaggerResponse(204, typeof(List<Cat>), "no results found")]
        [SwaggerResponse(400, typeof(List<Cat>), "bad request - check parameter format")]
        [SwaggerResponse(401, typeof(List<Cat>), "unauthorized request for this user")]
        public virtual IActionResult SearchCats([FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate, [FromQuery]DateTime? name, [FromQuery]string adoptionStatus, [FromQuery]string breed, [FromQuery]string color, [FromQuery]string gender)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Cat>>(exampleJson)
            : default(List<Cat>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// searches contacts
        /// </summary>
        /// <remarks>With no parameters, returns all contacts. Allows filters. </remarks>
        /// <param name="searchString">pass an optional search string for looking up contacts </param>
        /// <param name="skip">number of records to skip for pagination</param>
        /// <param name="limit">maximum number of records to return</param>
        /// <response code="200">search results matching specified criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/contact")]
        [ValidateModelState]
        [SwaggerOperation("SearchContacts")]
        [SwaggerResponse(200, typeof(List<Contact>), "search results matching specified criteria")]
        [SwaggerResponse(400, typeof(List<Contact>), "bad input parameter")]
        public virtual IActionResult SearchContacts([FromQuery]string searchString, [FromQuery]int? skip, [FromQuery]int? limit)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Contact>>(exampleJson)
            : default(List<Contact>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// searches dogs
        /// </summary>
        /// <remarks>With no parameters, returns all dogss currently in the shelter. Allows filters. </remarks>
        /// <param name="fromDate">Specifies the first intake date to return</param>
        /// <param name="toDate">Specifies the last intake date to return</param>
        /// <param name="name">Specifies a matching pattern for the name</param>
        /// <param name="adoptionStatus">Specifies one of the valid AdoptionStatus values</param>
        /// <param name="breed">breed of dog to retrieve</param>
        /// <param name="color">Specifies one of the valid DogColors</param>
        /// <param name="gender">Specifies on of the valid Gender</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/dog")]
        [ValidateModelState]
        [SwaggerOperation("SearchDobs")]
        [SwaggerResponse(200, typeof(List<Dog>), "ok")]
        [SwaggerResponse(204, typeof(List<Dog>), "no results found")]
        [SwaggerResponse(400, typeof(List<Dog>), "bad request - check parameter format")]
        [SwaggerResponse(401, typeof(List<Dog>), "unauthorized request for this user")]
        public virtual IActionResult SearchDobs([FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate, [FromQuery]DateTime? name, [FromQuery]string adoptionStatus, [FromQuery]string breed, [FromQuery]string color, [FromQuery]string gender)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Dog>>(exampleJson)
            : default(List<Dog>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// searches animal rescue doners
        /// </summary>
        /// <remarks>With no parameters, returns all Donors. Allows filters. </remarks>
        /// <param name="searchString">pass an optional search string for looking up Donors </param>
        /// <param name="skip">number of records to skip for pagination</param>
        /// <param name="limit">maximum number of records to return</param>
        /// <response code="200">search results matching specified criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/donor")]
        [ValidateModelState]
        [SwaggerOperation("SearchDonors")]
        [SwaggerResponse(200, typeof(List<Donor>), "search results matching specified criteria")]
        [SwaggerResponse(400, typeof(List<Donor>), "bad input parameter")]
        public virtual IActionResult SearchDonors([FromQuery]string searchString, [FromQuery]int? skip, [FromQuery]int? limit)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Donor>>(exampleJson)
            : default(List<Donor>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// searches animal fosters
        /// </summary>
        /// <remarks>With no parameters, returns all registered Fosters. Allows filters. </remarks>
        /// <param name="searchString">pass an optional search string for looking up Fosters </param>
        /// <param name="skip">number of records to skip for pagination</param>
        /// <param name="limit">maximum number of records to return</param>
        /// <response code="200">search results matching specified criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/foster")]
        [ValidateModelState]
        [SwaggerOperation("SearchFosters")]
        [SwaggerResponse(200, typeof(List<Foster>), "search results matching specified criteria")]
        [SwaggerResponse(400, typeof(List<Foster>), "bad input parameter")]
        public virtual IActionResult SearchFosters([FromQuery]string searchString, [FromQuery]int? skip, [FromQuery]int? limit)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Foster>>(exampleJson)
            : default(List<Foster>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// searches inventory
        /// </summary>
        /// <remarks>By passing in the appropriate options, you can search for available inventory in the system </remarks>
        /// <param name="searchString">pass an optional search string for looking up inventory</param>
        /// <param name="skip">number of records to skip for pagination</param>
        /// <param name="limit">maximum number of records to return</param>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/inventory")]
        [ValidateModelState]
        [SwaggerOperation("SearchInventory")]
        [SwaggerResponse(200, typeof(List<InventoryItem>), "search results matching criteria")]
        [SwaggerResponse(400, typeof(List<InventoryItem>), "bad input parameter")]
        public virtual IActionResult SearchInventory([FromQuery]string searchString, [FromQuery]int? skip, [FromQuery]int? limit)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InventoryItem>>(exampleJson)
            : default(List<InventoryItem>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// returns all kennels in a Room
        /// </summary>
        /// <remarks>With no parameters, returns all berths at the Rescue </remarks>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/kennel")]
        [ValidateModelState]
        [SwaggerOperation("SearchKennels")]
        [SwaggerResponse(200, typeof(List<Kennel>), "ok")]
        [SwaggerResponse(204, typeof(List<Kennel>), "no results found")]
        [SwaggerResponse(400, typeof(List<Kennel>), "bad request - check parameter format")]
        [SwaggerResponse(401, typeof(List<Kennel>), "unauthorized request for this user")]
        public virtual IActionResult SearchKennels()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Kennel>>(exampleJson)
            : default(List<Kennel>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// searches all locations for the Rescue
        /// </summary>
        /// <remarks>With no parameters, returns all Locations for the Rescue </remarks>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/location")]
        [ValidateModelState]
        [SwaggerOperation("SearchLocations")]
        [SwaggerResponse(200, typeof(List<Location>), "ok")]
        [SwaggerResponse(204, typeof(List<Location>), "no results found")]
        [SwaggerResponse(400, typeof(List<Location>), "bad request - check parameter format")]
        [SwaggerResponse(401, typeof(List<Location>), "unauthorized request for this user")]
        public virtual IActionResult SearchLocations()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Location>>(exampleJson)
            : default(List<Location>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// searches all buildings at the Rescue
        /// </summary>
        /// <remarks>With no parameters, returns all Rooms at the Rescue </remarks>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        [HttpGet]
        [Route("/jgartee/AnimalRescue/1.0.0/room")]
        [ValidateModelState]
        [SwaggerOperation("SearchRoomss")]
        [SwaggerResponse(200, typeof(List<Room>), "ok")]
        [SwaggerResponse(204, typeof(List<Room>), "no results found")]
        [SwaggerResponse(400, typeof(List<Room>), "bad request - check parameter format")]
        [SwaggerResponse(401, typeof(List<Room>), "unauthorized request for this user")]
        public virtual IActionResult SearchRoomss()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Room>>(exampleJson)
            : default(List<Room>);
            return new ObjectResult(example);
        }

        /// <summary>
        /// updates an existing Cat by id
        /// </summary>
        /// <remarks>updates a Cat with a unique id</remarks>
        /// <param name="catToUpdate">full Cat object with id of an existing Cat</param>
        /// <response code="200">ok</response>
        /// <response code="201">create successful</response>
        /// <response code="400">bad request</response>
        [HttpPut]
        [Route("/jgartee/AnimalRescue/1.0.0/cat")]
        [ValidateModelState]
        [SwaggerOperation("UpdateCat")]
        public virtual void UpdateCat([FromBody]Cat catToUpdate)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// updates a Cat by id
        /// </summary>
        /// <remarks>Updates an existing Cat by id</remarks>
        /// <param name="id"></param>
        /// <param name="updateCat">unique id of Cat to update</param>
        /// <response code="200">ok</response>
        /// <response code="401">unauthorized request</response>
        [HttpPut]
        [Route("/jgartee/AnimalRescue/1.0.0/cat/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateCatById")]
        public virtual void UpdateCatById([FromRoute]Guid? id, [FromBody]Cat updateCat)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// updates an existing Dog by id
        /// </summary>
        /// <remarks>updates a Dog with a unique id</remarks>
        /// <param name="dogToUpdate">full Dog object with id of an existing Dog</param>
        /// <response code="200">ok</response>
        /// <response code="201">create successful</response>
        /// <response code="400">bad request</response>
        [HttpPut]
        [Route("/jgartee/AnimalRescue/1.0.0/dog")]
        [ValidateModelState]
        [SwaggerOperation("UpdateDog")]
        public virtual void UpdateDog([FromBody]Dog dogToUpdate)
        { 
            throw new NotImplementedException();
        }

        /// <summary>
        /// updates a Dog by id
        /// </summary>
        /// <remarks>Updates an existing Dog by id</remarks>
        /// <param name="id"></param>
        /// <param name="updateCat">unique id of Dog to update</param>
        /// <response code="200">ok</response>
        /// <response code="401">unauthorized request</response>
        [HttpPut]
        [Route("/jgartee/AnimalRescue/1.0.0/dog/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateDogById")]
        public virtual void UpdateDogById([FromRoute]Guid? id, [FromBody]Dog updateCat)
        { 
            throw new NotImplementedException();
        }
    }
}
