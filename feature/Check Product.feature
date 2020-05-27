Feature: Add product to application
 As a user
 I want to open the application
 So Create New products
 And to check closed window


 Scenario: Add product

 Given Go to url "http://localhost:5000/"
 When Login to application "user","user"
 And click to button Create product
 And Add to product info "1One", "10000", "100", "10", "10", "1"
 Then check that the window Create Product has closed