Feature: SignInPage

Background:
    Given I open AutomationPractice site
	And I click on 'Sign in' button
	
@TestCase1
Scenario: Should be able to view Login page when you click on Contact Us
	Then I am able to view the 'Sign in' page

@TestCase2
Scenario:Should be able to view Sign in title as "Login - My Store" 
	Then I am able to view the Sign in page title as 'Login - My Store' 

@TestCase3
Scenario:Should be able to view Error message when you click on Create an account button without enter email address
   When I click on 'Create an account' button 
   Then I am able to view the Error message as 'Invalid email address.' on 'Create an account' form of Sign in page

@TestCase4
Scenario:Should be able to view Error message when you click on Sign in button without enter email address
   When I click on 'Sign in for already register user' button
   Then I am able to view the Error message as 'An email address required.' on 'Sign in' page

@TestCase5
Scenario:Should be able to view Error message when you enter email id which is already exist 
   When I enter 'email id' as 'abc@g.com'
   And I click on 'Create an account' button 
   Then I am able to view the Error message as 'An account using this email address has already been registered. Please enter a valid password or request a new one.' on 'Create an account' form of Sign in page

@TestCase6
Scenario:Should be able to view Error message when you enter only email id not password
   Given I enter 'Email Id' as 'abc@g.com'
    When I click on 'Sign in for already register user' button
   Then I am able to view the Error message as 'Password is required.' on 'Sign in' page

@TestCase7
Scenario:Should be able to view Success message when you enter all necessary field for creating a new account
	Given I enter 'email id' as 'abc278@g.com'
	And I click on 'Create an account' button 
	#And I select radio button 'title' as 'Mrs.'
	And I enter 'First Name' as 'John' 
	And I enter 'Last Name' as 'Evans'
	And I enter 'Password' as 'abc@123' 
	And I enter 'Address of First Name' as 'John' 
	And I enter 'Address of Last Name' as 'Evans'
	And I enter 'Address' as 'Los angels'
	And I enter 'City' as 'Los angels'
	And I select 'State' as 'Indiana'
	And I enter 'Post code' as '00045'
	And I select 'Country' as 'United States'
	And I enter 'Mobile Number' as '123456789'
	And I enter 'Alias Address' as 'Los angels'
	And I click on 'Register' button 
	Then I am able to view successful message 'Welcome to your account. Here you can manage all of your personal information and orders.' for creating account

#@TestCase8
#Scenario:Should be able to view dashboard after login
#   Given I enter 'Email Id' as ''
#   And I enter 'Password' as '' 
#   When I click on 'Sign in for already register user' button
#
#@TestCase9
#Scenario:Successfully login
#    Given I enter 'email id' as 'tom12324@g.com'
#	And I click on 'Create an account' button 
#	And I read the excel file 'SignInForm.xlsx'
#	And I fill the form with data from excel
#	And I click on 'Register' button
#	Then I am able to view successful message 'Welcome to your account. Here you can manage all of your personal information and orders.' for creating account
   
