namespace LinearStructures; 

public class Student {
    public int number;
    public string firstName;
    public string lastName;
    public bool isSucces;

    public Student(int stuNum, string stuFirstName, string stuLastName, bool stuIsSucces) {
        this.number = stuNum;
        this.firstName = stuFirstName;
        this.lastName = stuLastName;
        this.isSucces = stuIsSucces;
    }
}