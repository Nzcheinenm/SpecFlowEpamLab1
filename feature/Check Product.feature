Feature: Check product to application
 As a user
 I want to open the application
 So add products


 Scenario: Check product

 Given Go to url "http://localhost:5000/"
 When Login to application "user","user"
 And click to checkProduct allProduct
 And check to product info "1One", "10000", "100", "10", "10", "1"
 Then name product should be name,inQuality and inUnitStock- "1One", "100", "10"