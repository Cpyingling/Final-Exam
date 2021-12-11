using System;
/*Testing:
Create one artist.
Call “Display()” method for the above artist.
Create 3 songs and add the artist to all 3 songs.
Call “Display()” method for each song
*/
class Program {
  public static void Main (string[] args) {
    Artist a1 = new Artist("James", "Brown");
    a1.Display();
    Song s1 = new Song(1, "Song 1");
    Song s2 = new Song(2, "Song 2");
    Song s3 = new Song(3, "Song 3");
    s1.AddArtistInfo(a1);
    s2.AddArtistInfo(a1);
    s3.AddArtistInfo(a1);
    s1.Display();
    s2.Display();
    s3.Display();
  }
}