Feature: HomePage
	
Background:
    Given I open AutomationPractice site

@TestCase1
Scenario: Checked Menu's on Home Page
	Then I am able to view the menu 'WOMEN' , 'DRESSES' and 'T-SHIRTS'

#not completed
#@TestCase2
#Scenario: Displayed Women's category when click on Women Menu
#    Given I click on 'WOMEN'
#	Then I am able to view the woman category 'Top' and 'DRESSES' 

@TestCase11
Scenario:Should be able to see "Contact Us" tooltip on Contact us button 
	Then I am able to view tooltip 'Contact Us' on 'Contact us' button

@TestCase12
Scenario:Should be able to see "Women" tooltip on Women menu 
	Then I am able to view tooltip 'Women' on 'WOMEN' menu

@TestCase13
Scenario:Should be able to see "Dresses" tooltip on Dresses menu 
	Then I am able to view tooltip 'Dresses' on 'Dresses' menu

@TestCase13
Scenario:Should be able to see "T-shirts" tooltip on T-shirts menu 
	Then I am able to view tooltip 'T-shirts' on 'T-shirts' menu

@TestCase14
Scenario:Should be able to see "Log in to your customer account" tooltip on Sign in button 
	Then I am able to view tooltip 'Log in to your customer account' on 'Sign in' button

@TestCase15
Scenario:Should be able to see "View my shopping cart" tooltip on Cart button 
	Then I am able to view tooltip 'View my shopping cart' on 'Cart' button
     
@TestCase16
Scenario:Should be able to view 'Add to Cart' and 'More' button when mouse over on product
	When I mouse over on product 'Faded Short Sleeve T-shirts'
	Then I am able to view 'Add to cart' and 'More' button on product 'Faded Short Sleeve T-shirts'
	
