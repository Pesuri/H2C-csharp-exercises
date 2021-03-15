namespace exercise_119
{
  public class Timer
  {
    public int value1 { get; set; }
    public int value2 { get; set; }
    public int limit1 { get; set; }
    public int limit2 { get; set; }

    public Timer()
    {
        this.limit1 = 100;
        this.limit2 = 60;
        this.value1 = 0;
        this.value2 = 0;
    }

    public void Advance()
    {
        this.value1 = this.value1 + 1;

        if (this.value1 >= this.limit1)
        {
            this.value1 = 0;
            this.value2++;
            if (this.value2 >= this.limit2)
                {
                    this.value2 = 0;
                }
        }
    }

    public override string ToString()
    {
        string seconds;
        string hundredths;
        if (this.value2 < 10)
        {
            seconds = "0" + this.value2;
        }
        else 
        {
            seconds = "" + this.value2;
        }

        if (this.value1 < 10)
        {
            hundredths = "0" + this.value1;
        }
        else 
        {
            hundredths = "" + this.value1;
        }

        return seconds + ":" + hundredths;
    }
  }
}