using System;

/*1.	Create a class called Artist
a.	Create the following properties:
i.	First Name (text)
•	Auto-implemented property
ii.	Last Name (text)
•	Auto-implemented property
iii.	Email (text)
•	Auto-implemented property
b.	Create a constructor that takes first name, last name as input.
i.	Set Email to “unknown”
c.	Create method
i.	Display()
•	Display artist first name, last name
*/

class Artist {

  //properties
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }

  public Artist(string fname, string lname) {
    FirstName = fname;
    LastName = lname;
    Email = "Unknown";
  }
  public void Display() {
    Console.WriteLine("FirstName: " + FirstName + " LastName: " + LastName);
  }
}

