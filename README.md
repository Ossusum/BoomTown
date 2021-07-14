# BoomTown

## Task
Make a Notes API that will implements the following:
  * Get a list of notes
  * Get a specific note
  * Add, Delete, Update a note
  
 ## Notes
 *  Tested with Postman application for JSON reponses and requests.
 Link: https://www.postman.com/
 * Notes will be saved in a file called 'note.txt'. The API will create this file in the same folder the project folder is located.
 
 ## API Documentation
 
 ### Get A list of Notes
 **HTTP Method** : GET
 **Route**: {BaseURL}/Note
 **Returns**: JSON string of all the notes in txt file.
 
 Example of result:
 >[{"id":0,"body":"Something","createdBy":"Benny Pena","creationDate":"0001-01-01T00:00:00","lastUpdated":"0001-01-01T00:00:00"},{"id":2,"body":"Something22","createdBy":"Benny Pena","creationDate":"0001-01-01T00:00:00","lastUpdated":"0001-01-01T00:00:00"}]
 
  ### Add a Note
 **HTTP Method** : POST
 **Route**: {BaseURL}/Note/AddNote/
 **Params**:
 > - **Required** Body | String
 > - **Optional** CreatedBy | String 
 > - **Optional** CreationDate | DateTime
 > - **Optional** LastUpdated | DateTime
 
 **Returns**: 200 OK (no value returned)

  ### Get a Note
 **HTTP Method** : Get
 **Route**: {BaseURL}/Note/{id}
 **Params**:
 > - **Required** ID | Integer
 
 **Returns**: 200 OK; JSON string of the requested Note object.
 
 Example of result:
 >{"id":0,"body":"Something","createdBy":"Benny Pena","creationDate":"0001-01-01T00:00:00","lastUpdated":"0001-01-01T00:00:00"}
 
   ### Edit a Note
 **HTTP Method** : POST
 **Route**: {BaseURL}/Note/EditNote/
 **Params**:
 > - **Required** ID | Integer
 > - **Required** Body | String
 > - **Optional** CreatedBy | String 
 > - **Optional** CreationDate | DateTime
 > - **Optional** LastUpdated | DateTime
 
 **Returns**: 200 OK (no value returned)
 
   ### Delete a Note
 **HTTP Method** : Get
 **Route**: {BaseURL}/Note/DeleteNote/{id}
 **Params**:
 > - **Required** ID | Integer
 
 **Returns**: 200 OK; JSON string of the deleted Note object.
 
 Example of result:
 >{"id":0,"body":"Something","createdBy":"Benny Pena","creationDate":"0001-01-01T00:00:00","lastUpdated":"0001-01-01T00:00:00"}
 
 
 
