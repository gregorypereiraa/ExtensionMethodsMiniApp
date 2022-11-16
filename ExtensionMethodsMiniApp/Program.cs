// See https://aka.ms/new-console-template for more information

using Spectre.Console;

var person = new PersonModel();
person.FirstName = AnsiConsole.Ask<string>("What is your first name: ");
person.LastName = AnsiConsole.Ask<string>("What is your Last name: ");
person.Age = "What is your age: ".RequestInt(0, 120);