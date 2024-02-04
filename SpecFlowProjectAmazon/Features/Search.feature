Feature: Search

Scenario Outline: Search with Product Name
	Given User Navigates to Amazon
	When User search with Product Name <productName>
	Then Verify the Search item with the Product Name <productName>
	Examples: 
			| productName |
			| Toys        |
			| Phone       |


Scenario Outline: Add To Cart
	Given User Navigates to Amazon
	When User search with Product Name <productName>
	And User selects the Product
	And Clicks on Add to Cart Button
	And Navigate to Cart
	Then Verify for the Amazon Logo with Text <CompanyLogoName>
	And Verify the Items added with Product Name <productName>
	Examples: 
			| productName | CompanyLogoName |
			| Earphones   | Amazon          |

Scenario Outline: Verify Image Logo
	Given User Navigates to Amazon
	When Select Hamberger Menu Icon
	And User selects options in categories <productName> 
	And User selects <option> options
	Then Verify the Search Top Categories Logo with the Product Name <productName>
	Examples: 
			| productName | option   |
			| Mobile      | Software |
			| Computers   | Software |
	

