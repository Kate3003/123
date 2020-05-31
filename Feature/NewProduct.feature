Feature: Add New Product
As a user 
I want to create a new product in the database
So I can create product

Scenario: Add product

Given I open "http://localhost:5000/" url
When I type in the fields Name "user", Password "user"
And I click the login button
Then The phrase should be "Home page"
When I click on the link All Products
And I click the Create new button
Then I should be at the "Product editing" page
When I type the value "Pie" ProductName
When I select "Confections" Category 
When I select "Pavlova, Ltd." Supplier
When I type the value "12" UnitPrice
When I type the value "231-450 g boxes" QuantityPerUnit	
When I type the value "28" UnitsInStock
When I type the value "0" UnitsOnOrder
When I type the value "11" ReorderLevel
When I click the Send button 
Then Product Name schould be "Pie"