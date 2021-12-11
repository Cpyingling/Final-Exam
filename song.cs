using System;
/*2.	Create a class called Song.
a.	Create the following properties:
i.	Id (number)
•	Length should be exactly 10.
ii.	Title (text)
•	Auto-implemented property
iii.	ArtistInfo (Artist)
•	Auto-implemented property


c.	Create the following methods:
i.	AddArtistInfo
•	Method gets Artist as input parameter
•	Method adds Artist to ArtistInfo and will display a message to console 
•	Method does not return a value
ii.	Display()
•	Display id, title and artist’s first name, last name 
*/

class Song : Artist {

  //properties
  public int Id {
  get { return this.Id; }
  set { if(value.Length > 10) 
           this.Id = value.Substring(0, Math.Min(value.Length, MAXLEN));
        else this.Id = value; }
}
  public string Title { get; set; }
  public Artist ArtistInfo { get; set; }

  public Song():base(fname, lname) {
  }
  public Song(double Id, string Title):base (fname, lname) {
  }
/*Method gets Artist as input parameter
•	Method adds Artist to ArtistInfo and will display a message to console 
•	Method does not return a value*/
  public void AddArtistInfo(Artist artistInfo) {
    ArtistInfo = artistInfo;
    Console.WriteLine("Artist {0} {1} added to the song titled {2}", ArtistInfo.fname,ArtistInfo.lname, Title);
  }
  //•	Display id, title and artist’s first name, last name 
  public void Display() {
    Console.WriteLine("Song Info: " +Id + "Title: " + Title + + FirstName + + LastName);
  }
}

