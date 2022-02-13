using System;
using System.Collections.Generic;
using System.Threading;
using House;



namespace Workers
{
    public interface IWorker
    {
        void Do_Work(IPart part);
    }

    class Worker : IWorker
    {
        public int quant { get; set; } //количество рабочих

        public void Do_Work(IPart part)
        {
            Console.Write($" {part.name} building "); //пишет что строится

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(5000 / quant); //время ожидания в миллисекундах(типо строится)
                Console.Write(". ");
            }

            Thread.Sleep(5000 / quant);
            Console.WriteLine();
        }
    }

    class TeamLeader : IWorker
    {
        public List<IPart> parts = new List<IPart>(); 

        public void Do_Work(IPart part) //печатает результат работы строителей и
                                        //фиксирует результаты в списке
        {
            part.Print_Res();
            parts.Remove(part);
        }
    }
}
