Feature: devsimregtcs
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Adding two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


@devsim_regression
Scenario: Verifying the various tabs present on the landing page
Given I am a "Toyota Device Simulator" user
And I click on "Device to cloud" Radio Button  
Then I enter the username into "Username" text field in the "Login" page
And I enter the password into "Password" text field in the "Login" page
And I click on "Login" button simulator
Then I navigate to the "DHU" page if the username and password are valid
And I verify that "Azure DEV" is pre-selected for Environment
And I verify that "Select Existing" is pre-selected for DHU
And I click on "Next" button simulator
And I am navigated to the "Existing DHU" page of the application
Then I select the first available device from the list
And I click on "Next" button simulator
And I am navigated to the "Landing" page of the application
And I see that the following tabs are present on the "Landing" page
| Key                       |
| GENERAL                   |
| CHECKLISTS                |
| IMPACT MANAGEMENT         |
| LOCATION SERVICE          |
| ACCESS CONTROL            |
| VEHICLE LOCKOUT / RELEASE |
| VEHICLE ERRORS            |

@devsim_regression
Scenario: Changing the device selected from the landing page through the Change Device button
Given I am a "Toyota Device Simulator" user
And I click on "Device to cloud" Radio Button  
Then I enter the username into "Username" text field in the "Login" page
And I enter the password into "Password" text field in the "Login" page
And I click on "Login" button simulator
Then I navigate to the "DHU" page if the username and password are valid
And I verify that "Azure DEV" is pre-selected for Environment
And I verify that "Select Existing" is pre-selected for DHU
And I click on "Next" button simulator
And I am navigated to the "Existing DHU" page of the application
Then I select the first available device from the list
And I click on "Next" button simulator
And I am navigated to the "Landing" page of the application
And I verify whether the device is the same as selected before
And I click on "Change Device" button symbol
And I am navigated to the "Existing DHU" page of the application
And I select any other device from the given list
And I am navigated back to the "Landing" page again

@devsim_regression
Scenario: Editing the details of the selected device from the landing page through the Edit Device Details button
Given I am a "Toyota Device Simulator" user
And I click on "Device to cloud" Radio Button  
Then I enter the username into "Username" text field in the "Login" page
And I enter the password into "Password" text field in the "Login" page
And I click on "Login" button simulator
Then I navigate to the "DHU" page if the username and password are valid
And I verify that "Azure DEV" is pre-selected for Environment
And I verify that "Select Existing" is pre-selected for DHU
And I click on "Next" button simulator
And I am navigated to the "Existing DHU" page of the application
Then I select any of the available device from the list
And I click on "Next" button simulator
And I am navigated to the "Landing" page of the application
And I verify whether the device is the same as selected before
And I click on "Editing Device Details" button symbol
And I am navigated to the "Edit Device" page of the application
And I edit the value of "Version Number" to "2.02" 
And I click on "Save" button simulator
And I am navigated back to the "Landing" page again


@devsim_regression
Scenario: Sending a D2C Impact Message
Given I am a "Toyota Device Simulator" user
And I click on "Device to cloud" Radio Button 
Then I enter the username into "Username" text field in the "Login" page
And I enter the password into "Password" text field in the "Login" page
And I click on "Login" button simulator
Then I navigate to the "DHU" page if the username and password are valid
And I verify that "Azure DEV" is pre-selected for Environment
And I verify that "Select Existing" is pre-selected for DHU
And I click on "Next" button simulator
And I am navigated to the "Existing DHU" page of the application
Then I select the first available device from the list
And I click on "Next" button simulator
And I am navigated to the "Landing" page of the application
And I verify whether the device is the same as selected before
And I check that the device selected is not connected by default by checking the "Connect DHU" button
And I click on "Connect DHU" button symbol
And I check the log message generated after connecting the device in the "Logs" window
Then I move to the "CHECKLISTS" tab
And I check all the fields present in that page are already filled or not
Then I click on the "Send" button on that page
And I verify the logs whether the message is sent successfully or not

