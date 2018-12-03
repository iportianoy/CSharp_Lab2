using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Component symphonyOrchestra = new Orchestra("Симфонiчний оркестр");

            Component stringsInstruments = new GroupOfMusicalInstruments("Струннi iнструменти");
            Component woodenOvensInstruments = new GroupOfMusicalInstruments("Дерев'янi духовi iнструменти");
            Component copperOvensInstruments = new GroupOfMusicalInstruments("Мiднi духовi iнструменти");
            Component drumssInstruments = new GroupOfMusicalInstruments("Ударнi iнструменти");

            Component viola = new MusicalInstrument("Альта");
            Component cello = new MusicalInstrument("Вiолончель");
            Component firstViolin = new MusicalInstrument("Перша скрипка");
            Component secondViolin = new MusicalInstrument("Друга скрипка");

            Component flute = new MusicalInstrument("Флейта");
            Component clarinet = new MusicalInstrument("Кларнет");
            Component bassoon = new MusicalInstrument("Фагот");

            Component pipe = new MusicalInstrument("Труба");
            Component trombone = new MusicalInstrument("Тромбон");

            Component drum = new MusicalInstrument("Ударнi");
            Component litavrs = new MusicalInstrument("Литаври");


            symphonyOrchestra.Add(stringsInstruments);
            symphonyOrchestra.Add(woodenOvensInstruments);
            symphonyOrchestra.Add(copperOvensInstruments);
            symphonyOrchestra.Add(drumssInstruments);

            stringsInstruments.Add(cello);
            stringsInstruments.Add(viola);
            stringsInstruments.Add(firstViolin);
            stringsInstruments.Add(secondViolin);

            woodenOvensInstruments.Add(flute);
            woodenOvensInstruments.Add(clarinet);
            woodenOvensInstruments.Add(bassoon);

            copperOvensInstruments.Add(pipe);
            copperOvensInstruments.Add(trombone);

            drumssInstruments.Add(drum);
            drumssInstruments.Add(litavrs);

            symphonyOrchestra.Print();

            Console.Read();

        }
    }
}
