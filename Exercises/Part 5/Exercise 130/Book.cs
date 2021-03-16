namespace exercise_130
{


  public class Book
  {

    private string name;
    private int publicationYear;

    public Book(string name, int publicationYear)
    {
      this.name = name;
      this.publicationYear = publicationYear;
    }


    // BEGIN SOLUTION
    public bool Equals(Book compared)
    {
        if(this.name == compared.name & this.publicationYear == compared.publicationYear)
        {
            return true;
        }
        return false;
    }
    // END SOLUTION
  }


}