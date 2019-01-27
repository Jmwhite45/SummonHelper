using SummonHelper_windows_.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonHelper_windows_.PresetData
{
    public class ConjureAnimal : IPreset
    {
           public Preset[] getList()
           {
            List<Preset> ret = new List<Preset>();

            Special none = new Special("None", "None", new Atk(0, 0,0,0));
            Special PackTactics = new Special("Pack Tactics", "advantage", null);

            ret.Add(new Preset("allosaurus(Bite)",1,6,2,10,4));
            ret.Add(new Preset("allosaurus(Claw)", 1, 6, 1, 8, 4));
            ret.Add(new Preset("Ankylosaurus", 0, 7, 4, 6, 4));
            ret.Add(new Preset("Ape(Fist)",4,5,1,6,3,none));//Multiattack
            ret.Add(new Preset("Ape(Rock)",4,5,1,6,3,none));//Multiattack
            ret.Add(new Preset("Axe Beak",8,4,1,8,2,none));
            ret.Add(new Preset("Baboon",8,1,1,4,-1,PackTactics));
            ret.Add(new Preset("Badger",8,2,1,1,0));
            ret.Add(new Preset("Bat",8,0,1,1,0));
            ret.Add(new Preset("Black Bear(Bite)",4,4,1,6,2));
            ret.Add(new Preset("Black Bear(Claws)",4,4,2,4,2));
            ret.Add(new Preset("Blood Hawk",8,4,1,4,2, PackTactics));
            ret.Add(new Preset("Boar",8,3,1,6,1, new Special("Charge", "Must move 20, str DC 11", new Atk(0,0,0,0))));
            ret.Add(new Preset("Brown Bear(Bite)",2,6,1,8,4));
            ret.Add(new Preset("Brown Bear(Claw)",2,6,2,6,4));
            ret.Add(new Preset("Camel",8,5,1,4,0));
            ret.Add(new Preset("Cat",8,0,1,1,0));
            ret.Add(new Preset("Constrictor Snake",8,4,1,6,2));
            ret.Add(new Preset("Crab",8,0,1,1,0));
            ret.Add(new Preset("Crocodile",4,4,1,10,2));
            ret.Add(new Preset("Deer",8,2,1,4,0));
            ret.Add(new Preset("Direwolf", 2, 5, 2, 6, 3));
            ret.Add(new Preset("Draft Horse",4,6,2,4,4));
            ret.Add(new Preset("Eagle",8,4,1,4,2));
            ret.Add(new Preset("Elephant(Gore)",0,8,3,8,6));
            ret.Add(new Preset("Elephant(Stomp)", 0, 8, 3, 10, 6));
            ret.Add(new Preset("Elk(Ram)",8,5,1,6,3));
            ret.Add(new Preset("Elk(Hooves)", 8,5,2,4,3));
            ret.Add(new Preset("flying snake", 8, 6, 3, 4, 1));
            ret.Add(new Preset("Giant Ape(Fist)",0,9,3,10,6));
            ret.Add(new Preset("Giant Ape(Rock)",0,9,7,6,6));
            ret.Add(new Preset("Giant badger(Bite)",8,3,1,6,1));
            ret.Add(new Preset("Giant badger(Claws)", 8, 3, 2, 4, 1));
            ret.Add(new Preset("Giant Bat",8,4,1,6,2));
            ret.Add(new Preset("Giant Boar",1,5,2,6,3));
            ret.Add(new Preset("Giant Centipede",8,4,1,4,2));
            ret.Add(new Preset("Giant Constrictor Snake",1,6,2,6,4));
            ret.Add(new Preset("Giant Crab",8,3,1,6,1));
            ret.Add(new Preset("Giant Crocodile(Bite)",0,8,3,10,5));
            ret.Add(new Preset("Giant Crocodile(Tail)",0,8,2,8,5));
            ret.Add(new Preset("Giant Eagle(beak)",2,5,1,6,3));
            ret.Add(new Preset("Giant Eagle(Talons)",2,5,2,6,3));
            ret.Add(new Preset("Giant Elk(Ram)",1,6,2,6,4));
            ret.Add(new Preset("Giant Elk(Hooves)", 1, 6, 4, 8, 4));
            ret.Add(new Preset("Giant Fire beetle",8,1,1,6,-1));
            ret.Add(new Preset("Giant Frog",8,3,1,6,1));
            ret.Add(new Preset("Giant Goat", 4, 5, 2, 4, 3));
            ret.Add(new Preset("Giant Hyena",2,5,2,6,3));
            ret.Add(new Preset("Giant Lizard",8,4,1,8,2));
            ret.Add(new Preset("Giant Octopus", 2, 5, 2, 6, 3));
            ret.Add(new Preset("Giant Owl",8,3,2,6,1));
            ret.Add(new Preset("Giant Poisonous Snake",8,6,1,4,4));
            ret.Add(new Preset("Giant Rat",8,4,1,4,2));
            ret.Add(new Preset("Giant scorpion(Claw)",0,4,1,8,2));
            ret.Add(new Preset("Giant scorpion(sting)", 0, 4, 1, 10, 2));
            ret.Add(new Preset("Giant sea horse",4,3,1,6,1));
            ret.Add(new Preset("Giant Shark",0,9,3,10,6));
            ret.Add(new Preset("Giant Spider",2,5,1,8,3));
            ret.Add(new Preset("Giant Toad",2,4,1,10,2));
            ret.Add(new Preset("Giant Vulture(beak)",2,4,2,4,2));
            ret.Add(new Preset("Giant Vulture(Talons)", 2, 4, 2, 6, 2));
            ret.Add(new Preset("Giant wasp",4,4,1,6,2));
            ret.Add(new Preset("Giant Weasel",8,5,1,4,3));
            ret.Add(new Preset("Giant Wolf Spider",8,3,1,6,1));
            ret.Add(new Preset("Goat",8,3,1,4,1));
            ret.Add(new Preset("Hawk",8,5,1,1,0));
            ret.Add(new Preset("Hunter Shark",1,6,2,8,4));
            ret.Add(new Preset("Hyena",8,2,1,6,0));
            ret.Add(new Preset("Jackel",8,1,1,4,-1));
            ret.Add(new Preset("Killer Whale",0,6,5,6,4));
            ret.Add(new Preset("Lion(Bite)",2,5,1,8,3));
            ret.Add(new Preset("Lion(claw)",2,5,1,6,3));
            ret.Add(new Preset("lizard",8,0,1,1,0));
            ret.Add(new Preset("Mammoth(Gore)",0,10,4,8,7));
            ret.Add(new Preset("Mammoth(Stomp", 0, 10, 4, 10, 7));
            ret.Add(new Preset("Mastiff", 8, 3, 1, 6, 1));
            ret.Add(new Preset("Mule", 8, 2, 1, 4, 2));
            ret.Add(new Preset("Octopus", 8, 4, 1, 1, 0));
            ret.Add(new Preset("Owl", 8, 3, 1, 1, 0));
            ret.Add(new Preset("Panther(Bite)",8,4,1,6,2));
            ret.Add(new Preset("Panther(claw)",8,4,1,4,2));
            ret.Add(new Preset("Plesiosaurus",1,6,3,6,4));
            ret.Add(new Preset("Pteranodon",8,3,2,4,1));
            ret.Add(new Preset("Poisonous Snake",8,5,1,1,0));
            ret.Add(new Preset("Polar Bear(Bite)",1,7,1,8,5));
            ret.Add(new Preset("Polar Bear(Claws)",1,7,2,6,5));
            ret.Add(new Preset("Pony",8,4,2,4,2));
            ret.Add(new Preset("Quipper",8,5,1,1,0));
            ret.Add(new Preset("Rat",8,0,1,1,0));
            ret.Add(new Preset("Raven",8,4,1,1,0));
            ret.Add(new Preset("Reef Shark",4,4,1,8,2));
            ret.Add(new Preset("Rhinoseros",1,7,2,8,5));
            ret.Add(new Preset("Riding Horse",8,5,2,4,3));
            ret.Add(new Preset("Saber-Tooth(Bite)",1,6,1,10,5));
            ret.Add(new Preset("Saber-Tooth(claw)",1,6,2,6,5));
            ret.Add(new Preset("Scorpion",8,2,1,1,0));
            ret.Add(new Preset("Spider",8,4,1,1,0));
            ret.Add(new Preset("Stirge", 8, 5, 1, 4, 3));
            ret.Add(new Preset("Tiger(Bite)",2,5,1,10,3));
            ret.Add(new Preset("Tiger(Claw)", 2, 5, 1, 8, 3));
            ret.Add(new Preset("Triceratops",0,9,4,8,6));
            ret.Add(new Preset("Tyrannosaurus Rex(Bite)",0,10,4,12,7));
            ret.Add(new Preset("Tyrannosaurus Rex(Tail)", 0, 10, 3, 8, 7));
            ret.Add(new Preset("Vulture",8,2,1,4,0));
            ret.Add(new Preset("Warhorse",4,6,2,6,4));
            ret.Add(new Preset("Weasel",8,5,1,1,0));
            ret.Add(new Preset("Winter Wolf",0,6,2,6,4));
            ret.Add(new Preset("Wolf",8,4,2,4,2));
            ret.Add(new Preset("Worg",4,5,2,6,3));
            return ret.ToArray();
           }

        public string[] getNames()
        {
            List<string> ret = new List<string>();
            Preset[] presets = getList();

            foreach(Preset preset in presets)
            {
                ret.Add(preset.ToString());
            }

            return ret.ToArray();
        }

        public string getTitle()
        {
            return "Conjure Animals";
        }
    }
}
