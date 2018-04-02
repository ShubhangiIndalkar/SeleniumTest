Feature: ContactUsPage

Background:
    Given I open AutomationPractice site	
	And I click on 'Contact us'

@TestCase1
Scenario: Should be able to view Contact Us page when you click on Contact Us
	Then I am able to view the 'Contact Us' page

@TestCase2
Scenario:Should be able to view Contact page title as 'Contact us - My Store' 
	Then I am able to view the Contact Us page title as 'Contact us - My Store' 

@TestCase3
Scenario:Should be able to view Error message when you click on send button without enter email address
   When I click on 'Send' button 
   Then I am able to view the Error message as 'Invalid email address.' on 'Contact us' page

@TestCase4
Scenario:Should be able to view Error message when you click on send button with email id and without enter message
   And I enter 'Email id' as 'abc@g.com'
   When I click on 'Send' button 
   Then I am able to view the Error message as 'The message cannot be blank.' on 'Contact us' page

@TestCase5
Scenario:Should be able to view Error message when you click on send button with email id and message and without select subject
   Given I enter 'Email id' as 'abc@g.com'
   And I enter 'Message' as 'fkjhfh'
   When I click on 'Send' button 
   Then I am able to view the Error message as 'Please select a subject from the list provided.' on 'Contact us' page

@TestCase6
Scenario:Should be able to view success message when you enter all necessary field for send message 
   Given I enter 'Email id' as 'abc@g.com'
   And I enter 'Message' as 'fkjhfh'
   And I select 'Subject' as 'Webmaster'
   When I click on 'Send' button 
   Then I am able to view the success message as 'Your message has been successfully sent to our team.' 

@TestCase7
Scenario:Should be able to view Home button after getting success message of send message 
   Given I enter 'Email id' as 'abc@g.com'
   And I enter 'Message' as 'fkjhfh'
   And I select 'Subject' as 'Webmaster'
   When I click on 'Send' button 
   Then I am able to view the success message as 'Your message has been successfully sent to our team.' 
   And I am able to view the Home button to navigate Home page

@TestCase8
Scenario:Should be able to view Error message when you enter wrong email id 
   Given I enter 'Email id' as 'abc'
   When I click on 'Send' button 
   Then I am able to view the Error message as 'Invalid email address.' on 'Contact us' page

@TestCase9
Scenario:Should be able to view the help comment when select Customer Service subject
	 When I select 'Subject' as 'Customer service'
	 Then I am able to view the Comment as 'For any question about a product, an order' for 'Customer service'

@TestCase10
Scenario:Should be able to view the help comment when select Webmaster subject
	 When I select 'Subject' as 'Webmaster'
	 Then I am able to view the Comment as 'If a technical problem occurs on this website' for 'Webmaster'