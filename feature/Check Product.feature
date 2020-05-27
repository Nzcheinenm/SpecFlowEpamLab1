Feature: Add product to application
 As a user
 I want to open the application
 So Create New products
 And to check closed window


 Scenario: Add product

 Given Go to url "http://localhost:5000/"
 When the system with credentials login - "user" and password - "user"
 And click to button Create product
 And Add and enter the product data in the fields: name - "1One",unitPrice - "10000", inQuantity - "100", inUnitInStock - "10",inUnitsOnOrder - "10",inReorderLevel - "1"
 Then check that the window Create Product has closed