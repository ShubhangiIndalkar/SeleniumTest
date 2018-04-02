Feature: PHPTravelHomePage

Background:
    Given I open PHP Travel site

@TestCase1
Scenario: Checked Menu's on Home Page
	Then I am able to view the menu 'WOMEN' , 'DRESSES' and 'T-SHIRTS'
