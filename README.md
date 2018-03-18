# Validator Manager
A project is .NET library for validating user input.
## Getting Started
The project was created in Visual Studio Community 2015 using .NET Framework 4.6.1
## Running the tests
A code includes series of unit tests created in Visual Studio.
## Versioning
Release sequence, release time and version number are defined by author. 
## Author
Andriy Shyrokoryadov.
## License
This project is licensed under the MIT License - see the LICENSE.md file for details.
## Hints
### Validators namespace
A namespace where a valdiator logic is defined. All classes are derived from Validator class. A "template" design pattern has been used.
### Intefaces namespace
Several interfaces were defined, so objects implementing these interfaces could be validated by certain validators defined in Validators namespace.
### StaticClasses namespace
The logic defined in Validators namespace were incapsulated as static classes. There are 3 static classes divided by data validation type.
### Attributes namespace
A namespace where validation attributes are defined. The validation attributes can be used in your own classes to ease validation process and make validation more transparent.
### ModelState namespace
A logic that analyses applied validation attributes and performs required logic.
