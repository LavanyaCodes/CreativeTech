Feature:Verify customer list
	
@TC_VerifyCustNameEmailPhNum
Scenario: Verify if the customer name, email and phone numbers are displayed

	Given launch "chrome" browser
	When I navigate to "Selenium Test" website
	Then I verify "Selenium Test" page is opened
	Then I verify "<Name>" "<Email>" "<PhoneNum>" are displayed	
	Then close the browser
	Examples:
	| Name         | Email                 | PhoneNum      |
	| John Smith   | jsmith@test.com       | 0208092029    |
	| Jeff Bridges | abcd@test.com         | 0161 225 7632 |
	| Steve Jones  | steven.jones@test.com | 01403 215100  |

@TC_VerifyCorrectCustInfoIsDisplayed
Scenario: Verify if corresponding customer details are displayed when you click on view details button
	
	Given launch "chrome" browser
	When I navigate to "Selenium Test" website
	Then I verify "Selenium Test" page is opened
	When I click on button for customer "<Name>"
	Then I verify details of the customer "<Name>" are displayed
	Then close the browser
	Examples:
	| Name         |
	| John Smith   | 
	| Jeff Bridges | 
	| Steve Jones  | 
	

@TC_ValidateCustDetails
Scenario: Validate all the displayed details of the customer
	
	Given launch "chrome" browser
	When I navigate to "Selenium Test" website
	Then I verify "Selenium Test" page is opened
	When I click on button for customer "<Name>"
	Then I validate "<Name>" "<City>" "<State>" "<Country>" "<Organization>" "<JobProfile>" "<AddInfo>" of the customer
	Then close the browser
	Examples:
	| Name		  |  City      | State            | Country | Organization | JobProfile         | AddInfo                         |
	| John Smith  | London     | Greater London   | England | Company 1    | Software Developer | Bought a lot of products        |
	| Jeff Bridges| Manchester |Greater Manchester| England | Company 2    | Software Developer | Buys Products Rarely            |
	| Steve Jones | Horsham    | West Sussex      | England | Company 3    | Software Developer | Buys Lots of Products in general|
	