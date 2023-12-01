# Library Management System

This C# console application represents a management system for a library, designed to manage books, members, and borrowing processes.

## Requirements

### Class Definitions

#### Book Class

- **Name:** Represents the title of the book.
- **Author:** Represents the author of the book.
- **Publication Year:** Represents the publication year of the book.
- **ID:** Contains a unique identifier for the book.
- **Status:** Avtive or Passive information of boook.

#### Member Class

- **First Name:** Represents the first name of the member.
- **Last Name:** Represents the last name of the member.
- **Membership Number:** Represents the membership number of the member.
- **Borrowed Book List:** Contains a list of books borrowed by the member.

#### Library Class

- Has books and members.

### Library Managment Service Class

- Includes functions for adding, deleting, borrowing, and returning books.

### Encapsulation

- All class fields are appropriately encapsulated.

### Inheritance

- There is a superclass named `LiteraryWork` that shares common properties.
- The `Book` class is derived from this superclass.

### Interfaces

- An interface named `IPrintable` is created.
- This interface is used to print member information to the console.

## Usage

When you run the project, a console application simulating the library management system will be initiated. You can add books, manage members, and perform borrowing processes.

![image](https://github.com/Fimple-Net-Bootcamp/izel-ozarslan-homework-1/assets/47329661/1d0c8474-6267-49f5-8a88-8bc6c93ae604)



