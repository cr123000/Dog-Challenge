using System;

namespace Dog_Challenge
{
    class Program
    { 
         public enum Gender{
            Male,
            Female,
         }
        class Dog{
                public string name;
                public string owner;
                public int age;
                public Gender gender;
                public Dog(string DName,string OName,int Age,Gender genda){
                    name=DName;
                    owner=OName;
                    age=Age;
                    gender= genda;
                }
                public void Bark(int barks){
                    for(;barks>0;barks--){
                        Console.WriteLine("Woof!");
                    }
                }
                public string GetTag(){
                    string str;
                    str=$"If lost call{owner}.";
                    if((int)gender==0){
                            str=str+$" His name is {name} and he is {age}";
                    }
                    else{
                            str=str+$" Her name is {name} and she is {age}";
                    }
                    if(age==1){
                        str=str+ " year old.";
                    }
                    else{
                        str=str+" years old.";
                    }
                    return(str);
                }
            }
            
             static void Main(string[] args)
            {
                Dog puppy = Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
                puppy.Bark(3); // output: Woof!Woof!Woof!
                Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.
                Dog myDog = Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
                myDog.Bark(1); // output: Woof!
                Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
            }
    }
}