Feature: CartPage

Background:
    Given I open AutomationPractice site
	#And I click on 'Cart' button

@TestCase01
Scenario:Should be able to view product which is added in cart
	Given I mouse over on product 'Faded Short Sleeve T-shirts'
	And I click on 'Add to cart' button
	Then I am able to view product 'Faded Short Sleeve T-shirts' in cart
	
