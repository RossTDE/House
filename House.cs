using System;


namespace House
{
    public interface IPart //части дома, общая функция - печать на экран
    {
        string name { get; }
        void Print_Res();
    }

    class Final : IPart
    {
        public string name { get; } = "Final";

        public void Print_Res()
        {
            Console.WriteLine(" House building ended successful!\n\nCongratilations!!!");
        }
    }

    class Roof : IPart
    {
        public string name { get; } = "Roof";

        public void Print_Res()
        {
            Console.WriteLine(" Roof building ended successful!\n");
        }
    }

    class Window : IPart
    {
        public string name { get; } = "Window";
        private static int i { get; set; } = 1; //статичное поле для отслеживания количества выполненных обьектов

        public void Print_Res()
        {
            Console.WriteLine($" Window {i} building ended successful!\n");
            i += 1;
        }
    }

    class Door : IPart
    {
        public string name { get; } = "Door";

        public void Print_Res()
        {
            Console.WriteLine(" Door building ended successful!\n");
        }
    }

    class Wall : IPart
    {
        public string name { get; } = "Wall";
        private static int i { get; set; } = 1; //статичное поле для отслеживания количества выполненных обьектов

        public void Print_Res()
        {
            Console.WriteLine($" Wall {i} building ended successful!\n");
            i += 1;
        }
    }

    class Basement : IPart
    {
        public string name { get; } = "Basement";

        public void Print_Res()
        {
            Console.WriteLine(" Basement building ended successful!\n");
        }
    }
}
