# CheckoutKata
#Background
This Kata has been set up using the Console solution in C# as to test the solution while problem solving, and for potentially setting up a console application in the future. I have used xUnit and Fluent Assertions for testing purposes. 

# Deliverables
- Create a new solution
- Prove you can Scan an item at checkout
- Prove you can request total price
- Prove you can request total price inclusive of offers

# Approach
In order to tackle this issue I first thought through the logic that would be required for both of the functions, I commented these onto the code after setting up the functions(this took the most time).
I then implemented the logic for first the scan function and then the total function. I then thought about the testing that would be required to test the deliverables, I used the console to mock out some of my hypotheses.
I set up the testing solution, I then set up test data in a separate file, I then decided it probably would be better to have it all within one file for easy reference. 
I ran through the testing each function, first Scan and then Total. 

# Improvements
Potential for improvements are great - I need to refactor my functions to make them more succinct and clearer. In terms of my tests, it would be better to have one approach to setting up test data, but due to time I tried both approaches. 
In terms of git practices I should have branched off my changes for each of the functions, especially if I was bringing more people onto this project

# Future Developments
This has the potential for setting up Api endpoints of product data that would be pulled into the scan and referencing the sku. I have also allowed there to be the potential for 'bulk buying', so thinking in terms of websites being able to add more than one product to your basket. 
As I have set this up as a console app, I could set this up into a console application (which I have not done in C# before) for fun. 
