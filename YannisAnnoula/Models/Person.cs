using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YannisAnnoula.Business_Logic;

namespace YannisAnnoula.Models
{
    class Person : IHumanActions, IInteractionWithPerson, IInteractionWithObject
    {
        private string _hair;
        private string _eyes;
        private string _height;
        private string _age;
        private string _name;

        public string Hair
        {
            get { return (_hair); }
            set { _hair = value; }
        }
        public string Eyes
        {
            get { return (_eyes); }
            set { _eyes = value; }
        }
        public string Height
        {
            get { return (_height); }
            set { _height = value; }
        }
        public string Age
        {
            get { return (_age); }
            set { _age = value; }
        }
        public string Name
        {
            get { return (_name); }
            set { _name = value; }
        }

        public Person()
        {
            this.Name = "Someone";
            this.Age = "Average Age";
            this.Height = "Average Height";
            this.Hair = "Average Hair";
            this.Eyes = "Plain Eyes";
        }

        public Person(string name, string age, string height, string hair, string eyes)
        {
            name = this.Name;
            age = this.Age;
            height = this.Height;
            hair = this.Hair;
            eyes = this.Eyes;

        }

        public void MoveHand(string nameOfPerson)
        {
            
            Console.WriteLine($"{nameOfPerson} moves their hand");
        }

        public void Walk(string nameOfPerson)
        {
            
            Console.WriteLine($"{nameOfPerson} walks");
        }

        public void Talk(string nameOfPerson, string speach)
        {
            
            Console.WriteLine($"{nameOfPerson} says " + $"{speach}");
        }

        public void HoldsHand(string nameOfPersonHolding, string nameOfPersonsHand)
        {
            Console.WriteLine($"{nameOfPersonHolding} holds {nameOfPersonsHand} hand");
        }

        public void OpensDoor(string personOpening)
        {
            Console.WriteLine($"{personOpening} opens the door!");
        }

        public void ClosesDoor(string personClosing)
        {
            Console.WriteLine($"{personClosing} closes the door!");
        }

    }
}
