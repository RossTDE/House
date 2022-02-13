using System;
using Workers;
using House;

namespace Teams
{
    class Team //решил сделать его главным циклом
    {
        Worker worker = new Worker();
        TeamLeader brigadir = new TeamLeader();

        public Team(int value = 1) //количество строителей(от этого зависит скорость строительства)
        {
            if (value > 0)
            {
                worker.quant = value;
            }

            brigadir.parts.Add(new Basement()); //наверное можно красивее сделать его заполнение, но пока просто пробую
            brigadir.parts.Add(new Wall());     //думаю можно сделать например требования к дому в конструкторе или
            brigadir.parts.Add(new Wall());     //вообще чтение тз из файла, тут уже можно фантазировать, пока так для примера
            brigadir.parts.Add(new Wall());
            brigadir.parts.Add(new Wall());
            brigadir.parts.Add(new Door());
            brigadir.parts.Add(new Window());
            brigadir.parts.Add(new Window());
            brigadir.parts.Add(new Window());
            brigadir.parts.Add(new Window());
            brigadir.parts.Add(new Roof());
            brigadir.parts.Add(new Final());
        }

        public void Start()
        {
            while (brigadir.parts.Count > 0) //пока есть задачи
            {
                worker.Do_Work(brigadir.parts[0]); //работает работу работника

                brigadir.Do_Work(brigadir.parts[0]); //работает работу бригадира
            }
        }
    }
}
