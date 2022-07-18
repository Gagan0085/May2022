Feature: Language

	As a Seller
I want the feature to add,Edit and delete my Language Details
So that The people seeking for some skills can look into my details.

Scenario: [Create new language record with valid detail]
	Given I logged  to localhost  sucessfully
	When I create a New language Record
	Then New language record should be created successfully
	

Scenario: [Edit new language record with valid detail]
    Given I logged  to localhost  sucessfully
	When I edit a New language Record
	Then New edited language record should be edited successfully


Scenario: [Delete new language record with valid detail]
    Given I logged  to localhost  sucessfully
	When I delete a New language Record
	Then New editedlanguage record should be deleted successfully
	