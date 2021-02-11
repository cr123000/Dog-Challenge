using System;

namespace Dog_Challenge
{
    class Program
    {
        public enum Gender{
            male,
            female,
        }
        public class Dog{
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
                return(str);
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
