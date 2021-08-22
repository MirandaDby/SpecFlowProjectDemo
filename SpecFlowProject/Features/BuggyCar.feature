Feature: BuggyCar
	

@mytag
Scenario Outline: Register as a new user
	Given user is in homepage
	When I register as a new user
	Then I see Register Page
	When I fill username as <username>
	And  I fill <firstName> and <lastName> 
	And  I fill Password as <password>
	And  I fill ConfirmPassword as <ConfirmPassword>
	Then I click Register button

Examples: 
  | username | firstName | lastName | password    | ConfirmPassword |
  | w        | test-f    | test-l   | Test2021!@#$| Test2021!@#$    |


@mytag
Scenario Outline: Login as an user
	Given user is in homepage
	When I login with <username> and <password> 
	Then I click Login button
Examples: 
  | username           |   password      | 
  | MirandaTest        |  Test2021!@#$   |



@mytag
Scenario: vote after login through PopularMake
	Given user is in homepage 
	When I register as a new user
	And  I register
	And  I login
	When I navigate to PopularMake Page  
	Then I see the top car maker 
	Then I click the first one
	When I fill the vote comment
	And  I click vote button
	Then I vote successfully
	  

@mytag
Scenario Outline: vote after login through PopularModel
	Given user is in homepage
	When I register as a new user
	And  I register
	And  I login
	When I navigate to PopularModel Page  
	Then I see the top car model 
	When I fill the vote comment
	And  I click vote button
	Then I vote successfully 

@mytag
Scenario Outline: vote after login through OverralRating
	Given user is in homepage
	When I register as a new user
	And  I register
	And  I login
	When I navigate to OverralRating Page  
	Then I see the top car rating
	Then I click the first one
	When I fill the vote comment
	And  I click vote button
	Then I vote successfully
	  


@mytag
Scenario: view the vote result for PopularMake without login
	Given user is in homepage
	When I navigate to PopularMake Page  
	Then I see the top car maker
	 

@mytag
Scenario: view the vote result for PopularModel without login
	Given user is in homepage  
	When I navigate to PopularModel Page  
	Then I see the top car

@mytag
Scenario: view the vote result for OverralRating without login
	Given user is in homepage 
	When I navigate to OverralRating Page  
	Then I see the top car rating
	  