namespace exercise_103 {
  public class Agent {
    private string firstName;
    private string lastName;

    public Agent(string firstName, string lastName) {
      this.firstName = firstName;
      this.lastName = lastName;
    }

    public override string ToString() 
    {
      return "My name is " + firstName + ". " + firstName + " " + lastName + ".";
    }
  }
}