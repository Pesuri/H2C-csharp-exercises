namespace exercise_131
{
  public class Item
  {

    private string identifier;
    private string name;

    public Item(string identifier, string name)
    {
      this.identifier = identifier;
      this.name = name;
    }
    public override string ToString()
    {
      return this.identifier + ": " + this.name;
    }

    public bool Equals(Item compared)
    {
      //compare with Item.identifier
      if(this.identifier == compared.identifier) {return true;}
      return false;
    }

  }
}
