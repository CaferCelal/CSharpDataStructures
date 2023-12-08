// See https://aka.ms/new-console-template for more information

using System.Collections;
using LinearStructures;

public class arrays{
    static void Main(String[] args)
    {
        
        //Array Declaration
        int[] myArray = new int[3];
        myArray[0] = 12;
        myArray[1] = 43;
        myArray[2] = 69;

        int[] myOtherArray = new []{123, 1324, 1014};
        
        // Multi dimension Array declaration

        string[,] district = new string[5,2]
        {
            { "Istanbul", "Kadıkoy" },
            { "Izmır", "Cesme" },
            { "Ankara", "Batıkent" },
            { "Uşak", "Sivaslı" },
            { "Denizli", "Sarayköy" }
        };
        
        
        //Any Type ArrayList
        /*
        ArrayList videoGames = new ArrayList();

        videoGames.Add("Pacman");
        videoGames.Add("Super Mario Bros 2");
        videoGames.Add("The Legend of Zelda:Ocarina of Time");
        videoGames.Add(12);
        videoGames.Add(true); // Int,String and Boolean types Together in same strucutre

        foreach (var myGame in videoGames) {
            Console.WriteLine(myGame);
        }
        */
        
        //List to provide type-safety
        
        /*
        List<int> powersOfTwo= new List<int>();
       
        powersOfTwo.Add(2);
        powersOfTwo.Add(4);
        powersOfTwo.Add(8);
        powersOfTwo.Add(16);
        powersOfTwo.Add(32);
        powersOfTwo.Add(64);
        //powersOfTwo.Add("You cant add a string object");

        foreach (var myInt in powersOfTwo) {
            Console.WriteLine(myInt);
        }
        */
        
        //List with a custom type
        /*
        List<Student> students = new List<Student>();
        students.Add(new Student(340,"Cafer Celal","Evrenüz",true));
        students.Add(new Student(176,"Servet","Yıldırım",false));

        foreach (var student in students) {
            Console.WriteLine(student.firstName+ student.lastName + student.number + student.isSucces);
        }
        */
        

    }
}
