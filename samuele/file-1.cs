namespace Com.Sesa.TrainingGit;

public class Person
{
  private String name;
  private String surname;
  private uint age;

  public String Name { get; private set; }
  public String Surname { get; private set; }

  public uint Age { get; private set; }

  public Person(
    String name, 
    String surname, 
    uint age
  ) {
    this.Name = name;
    this.Surname = surname;
    this.Age = age;
  }
}