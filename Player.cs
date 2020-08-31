using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZombieLand
{
    class Player : Body
    {
        private int strength;
        private int dextarity;
        private int constatution;
        private int endurance;
        private int wisdom;
        private int intelligence;

        private int skillAxe;
        private int skillHammer;
        private int skillMachete;
        private int skillHandgun;
        private int skillRifle;
        private int skillShotgun;
        private int skillFist;

        private int skillCraft;
        private int skillBuild;
        private int skillRun;
        private int skillStealth;
        private int skillSearch;
        private int skillScrounge;
        private int skillMedical;
        private int skillCarry;

        private bool hasAxe = false;
        private bool hasHammer = false;
        private bool hasMachete = false;
        private bool hasHandgun = false;
        private bool hasRifle = false;
        private bool hasShotgun = false;
        private bool hasFist = true;

        private List<String> inventory = new List<String>();

        private int points = 60;

        //this function allows for the player to enter their name and values for their character's stats,
        //however the skill of the player class will be asighned based on the input.
        public void createCharacter() 
        {
            //name decided here
            Console.WriteLine("Please enter a name for your character.");
            String nm = Console.ReadLine();
            setName(nm);

            //stats decided here.
            int answer;
            bool control = true;
            String ans;
            Console.WriteLine("You have " + points + " to spend on your Strength, Dextarity, Constitution, Endurance" +
                ", intelligence, and wisdom. You can only spend up to eighteen on each.");
            Console.ReadKey();

            while (control) {
                Console.WriteLine("How many points would you like to spend on Strength?");
                ans = Console.ReadLine();
                if (Int32.TryParse(ans, out answer))
                {
                    if (points - answer < 0)
                    {
                        Console.WriteLine("You do not have that many points, please enter a lower number.");
                    }
                    else 
                    {
                        if (answer > 18)
                        {
                            control = false;
                            points -= 18;
                            strength = 18;
                            Console.WriteLine("Your strength is now " + strength + ", and you have " + points + " points remaining.");
                        }
                        else
                        {
                            control = false;
                            points -= answer;
                            strength = answer;
                            Console.WriteLine("Your strength is now " + strength + ", and you have " + points + " points remaining.");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
            control = true;
            while (control)
            {
                Console.WriteLine("How many points would you like to spend on Dextarity?");
                ans = Console.ReadLine();
                if (Int32.TryParse(ans, out answer))
                {
                    if (points - answer < 0)
                    {
                        Console.WriteLine("You do not have that many points, please enter a lower number.");
                    }
                    else
                    {
                        if (answer > 18)
                        {
                            control = false;
                            points -= 18;
                            dextarity = 18;
                            Console.WriteLine("Your dextarity is now " + dextarity + ", and you have " + points + " points remaining.");
                        }
                        else
                        {
                            control = false;
                            points -= answer;
                            dextarity = answer;
                            Console.WriteLine("Your dextarity is now " + dextarity + ", and you have " + points + " points remaining.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
            control = true;
            while (control)
            {
                Console.WriteLine("How many points would you like to spend on Constitution?");
                ans = Console.ReadLine();
                if (Int32.TryParse(ans, out answer))
                {
                    if (points - answer < 0)
                    {
                        Console.WriteLine("You do not have that many points, please enter a lower number.");
                    }
                    else
                    {
                        if (answer > 18)
                        {
                            control = false;
                            points -= 18;
                            constatution = 18;
                            Console.WriteLine("Your constitution is now " + constatution + ", and you have " + points + " points remaining.");
                        }
                        else
                        {
                            control = false;
                            points -= answer;
                            constatution = answer;
                            Console.WriteLine("Your constitution is now " + constatution + ", and you have " + points + " points remaining.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
            control = true;
            while (control)
            {
                Console.WriteLine("How many points would you like to spend on Endurance?");
                ans = Console.ReadLine();
                if (Int32.TryParse(ans, out answer))
                {
                    if (points - answer < 0)
                    {
                        Console.WriteLine("You do not have that many points, please enter a lower number.");
                    }
                    else
                    {
                        if (answer > 18)
                        {
                            control = false;
                            points -= 18;
                            endurance = 18;
                            Console.WriteLine("Your endurance is now " + endurance + ", and you have " + points + " points remaining.");
                        }
                        else
                        {
                            control = false;
                            points -= answer;
                            endurance = answer;
                            Console.WriteLine("Your endurance is now " + endurance + ", and you have " + points + " points remaining.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
            control = true;
            while (control)
            {
                Console.WriteLine("How many points would you like to spend on Intelligence?");
                ans = Console.ReadLine();
                if (Int32.TryParse(ans, out answer))
                {
                    if (points - answer < 0)
                    {
                        Console.WriteLine("You do not have that many points, please enter a lower number.");
                    }
                    else
                    {
                        if (answer > 18)
                        {
                            control = false;
                            points -= 18;
                            intelligence = 18;
                            Console.WriteLine("Your intelligence is now " + intelligence + ", and you have " + points + " points remaining.");
                        }
                        else
                        {
                            control = false;
                            points -= answer;
                            intelligence = answer;
                            Console.WriteLine("Your intelligence is now " + intelligence + ", and you have " + points + " points remaining.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
            if (points > 18)
            {
                Console.WriteLine("18 of your remaining points will be spent on wisdom.");
                points -= 18;
                wisdom = 18;
            }
            else 
            {
                Console.WriteLine("Your remaining points will be spent on wisdom.");
                wisdom = points;
                points = 0;
            }
            Console.ReadKey();

            //this is where the stats are finalized
            Console.WriteLine("Would you like to review your stats? <yes/no>");
            control = true;
            while (control)
            {
                ans = Console.ReadLine();
                ans.ToLower();
                if (ans == "yes")
                {
                    printStats();
                    control = false;
                }
                else if (ans == "no")
                {
                    control = false;
                }
                else 
                {
                    Console.WriteLine("Please enter 'yes' or 'no.' ");
                }

            }
            Console.WriteLine("Would you like to change your stats? <yes/no>");
            control = true;
            while (control)
            {
                ans = Console.ReadLine();
                ans.ToLower();
                if (ans == "yes")
                {
                    control = false;
                    requestStatChange();
                }
                else if (ans == "no")
                {
                    control = false;
                }
                else 
                {
                    Console.WriteLine("please enter either 'yes' or 'no.' ");
                }
            }
            

            //this is where the skills are set. * skills are based off of precentage of happening
            skillAxe = strength * 5;
            skillHammer = strength * 5;
            skillMachete = ((strength + dextarity) / 2) * 5;
            skillHandgun = dextarity * 5;
            skillRifle = dextarity * 5;
            skillShotgun = ((strength + dextarity) / 2) * 5;
            skillFist = strength * 5;

            skillCraft = intelligence / 3;
            skillBuild = ((strength + endurance) / 2) * 5;
            skillRun = ((dextarity + endurance) / 2) * 5;
            skillStealth = dextarity * 5;
            skillSearch = wisdom * 5;
            skillScrounge = ((wisdom + intelligence) / 2) * 5;
            skillMedical = intelligence * 5;
            skillCarry = (endurance + constatution)/2;

            Console.WriteLine("Would you like to see your finished character? <yes/no>");
            control = true;
            while (control) 
            {
                ans = Console.ReadLine();
                ans.ToLower();
                if (ans == "yes")
                {
                    printCharacter();
                    control = false;
                }
                else if (ans == "no")
                {
                    control = false;
                }
                else 
                {
                    Console.WriteLine("Please enter either 'yes' or 'no.' ");
                }
            }
        }

        //this prints out all the stats of the player
        public void printStats()
        {
            Console.WriteLine("STR: " + strength);
            Console.WriteLine("DEX: " + dextarity);
            Console.WriteLine("CON: " + constatution);
            Console.WriteLine("END: " + endurance);
            Console.WriteLine("INT: " + intelligence);
            Console.WriteLine("WIS: " + wisdom);
        }

        //this is where the stats are changed in the character creation portion. answer is string answers, asd is the number
        //version of answer, cnt is the first layer control, and zxc is the second layer control.
        public void requestStatChange() 
        {
            String answer;
            int asd;
            bool cnt = true;
            bool zxc = true;
            while (cnt) 
            {
                printStats();
                Console.WriteLine("You currently have " + points + " left. Which of the stats would you like to change?");
                Console.WriteLine("<STR/DEX/CON/END/INT/WIS>");
                answer = Console.ReadLine();
                answer.ToLower();
                
                //here it checks to see if you actually entered a possible answer or not.
                if (answer == "str" || answer == "dex" || answer == "con" || answer == "end" || answer == "int" || answer == "wis")
                {
                    //once inside it then goes based off of which stat you chose to alter. the reason for this is for the 
                    //section below all the stats inside this if statement that check to see if the player want to continue
                    //editing their stats or not.
                    if (answer == "str") {
                        Console.WriteLine("How much would you like to change your strength by? <x/-x>");
                        while (cnt) 
                        {
                            answer = Console.ReadLine();
                            if (Int32.TryParse(answer, out asd))
                            {
                                if (points - asd < 0)
                                {
                                    Console.WriteLine("You don't have enough points for that");
                                }
                                else if (strength + asd < 0)
                                {
                                    Console.WriteLine("Strength cannot go below 0.");
                                }
                                else
                                {
                                    points -= asd;
                                    strength += asd;
                                    Console.WriteLine("Your strength stat has been changed.");
                                    Console.ReadKey();
                                    cnt = false;
                                }
                            }
                            else 
                            {
                                Console.WriteLine("Please enter a number, positive or negative.");
                            }
                        }
                    }
                    if (answer == "dex")
                    {
                        Console.WriteLine("How much would you like to change your dextarity by? <x/-x>");
                        while (cnt)
                        {
                            answer = Console.ReadLine();
                            if (Int32.TryParse(answer, out asd))
                            {
                                if (points - asd < 0)
                                {
                                    Console.WriteLine("You don't have enough points for that");
                                }
                                else if (dextarity + asd < 0)
                                {
                                    Console.WriteLine("Dextaroty cannot go below 0.");
                                }
                                else
                                {
                                    points -= asd;
                                    dextarity += asd;
                                    Console.WriteLine("Your dextarity stat has been changed.");
                                    Console.ReadKey();
                                    cnt = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number, positive or negative.");
                            }
                        }
                    }
                    if (answer == "con")
                    {
                        Console.WriteLine("How much would you like to change your constitution by? <x/-x>");
                        while (cnt)
                        {
                            answer = Console.ReadLine();
                            if (Int32.TryParse(answer, out asd))
                            {
                                if (points - asd < 0)
                                {
                                    Console.WriteLine("You don't have enough points for that");
                                }
                                else if (constatution + asd < 0)
                                {
                                    Console.WriteLine("Constitution cannot go below 0.");
                                }
                                else
                                {
                                    points -= asd;
                                    constatution += asd;
                                    Console.WriteLine("Your constitution stat has been changed.");
                                    Console.ReadKey();
                                    cnt = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number, positive or negative.");
                            }
                        }
                    }
                    if (answer == "end")
                    {
                        Console.WriteLine("How much would you like to change your endurance by? <x/-x>");
                        while (cnt)
                        {
                            answer = Console.ReadLine();
                            if (Int32.TryParse(answer, out asd))
                            {
                                if (points - asd < 0)
                                {
                                    Console.WriteLine("You don't have enough points for that");
                                }
                                else if (endurance + asd < 0)
                                {
                                    Console.WriteLine("Endurance cannot go below 0.");
                                }
                                else
                                {
                                    points -= asd;
                                    endurance += asd;
                                    Console.WriteLine("Your endurance stat has been changed.");
                                    Console.ReadKey();
                                    cnt = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number, positive or negative.");
                            }
                        }
                    }
                    if (answer == "int")
                    {
                        Console.WriteLine("How much would you like to change your intelligence by? <x/-x>");
                        while (cnt)
                        {
                            answer = Console.ReadLine();
                            if (Int32.TryParse(answer, out asd))
                            {
                                if (points - asd < 0)
                                {
                                    Console.WriteLine("You don't have enough points for that");
                                }
                                else if (intelligence + asd < 0)
                                {
                                    Console.WriteLine("Intelligence cannot go below 0.");
                                }
                                else
                                {
                                    points -= asd;
                                    strength += asd;
                                    Console.WriteLine("Your Intelligence stat has been changed.");
                                    Console.ReadKey();
                                    cnt = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number, positive or negative.");
                            }
                        }
                    }
                    if (answer == "wis")
                    {
                        Console.WriteLine("How much would you like to change your wisdom by? <x/-x>");
                        while (cnt)
                        {
                            answer = Console.ReadLine();
                            if (Int32.TryParse(answer, out asd))
                            {
                                if (points - asd < 0)
                                {
                                    Console.WriteLine("You don't have enough points for that");
                                }
                                else if (wisdom + asd < 0)
                                {
                                    Console.WriteLine("Wisdom cannot go below 0.");
                                }
                                else
                                {
                                    points -= asd;
                                    wisdom += asd;
                                    Console.WriteLine("Your wisdom stat has been changed.");
                                    Console.ReadKey();
                                    cnt = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number, positive or negative.");
                            }
                        }
                    }

                    //in this section the control variable keeps the player in the request change sectoin while
                    //the zxc variable is used to force the player to enter yes or no.
                    Console.WriteLine("Are you done with changing your stats around? <yes/no>");
                    zxc = true;
                    while (zxc)
                    {
                        answer = Console.ReadLine();
                        answer.ToLower();
                        if (answer == "yes")
                        {
                            zxc = false;
                            cnt = false;
                            printStats();
                        }
                        else if (answer == "no")
                        {
                            zxc = false;
                            cnt = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 'yes' or 'no.' ");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("You did not enter one of the options, please do so.");
                    Console.ReadKey();
                }
            }
        }

        //this prints out all of the skills
        public void printSkills() 
        {
            Console.WriteLine("AXE:  " + skillAxe);
            Console.WriteLine("HMR:  " + skillHammer);
            Console.WriteLine("MCHT: " + skillMachete);
            Console.WriteLine("HNDG: " + skillHandgun);
            Console.WriteLine("RFL:  " + skillRifle);
            Console.WriteLine("SHTG: " + skillShotgun);
            Console.WriteLine("FST:  " + skillFist);
            Console.WriteLine(" ");
            Console.WriteLine("CRFT: " + skillCraft);
            Console.WriteLine("BLD:  " + skillBuild);
            Console.WriteLine("RUN:  " + skillRun);
            Console.WriteLine("STLH: " + skillStealth);
            Console.WriteLine("SRCH: " + skillSearch);
            Console.WriteLine("SCRN: " + skillScrounge);
            Console.WriteLine("MED:  " + skillMedical);
            Console.WriteLine("CRRY: " + skillCarry);
        }

        public void printInventory() 
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine(inventory[i]);
                }
            }
        }

        public void printCharacter() 
        {
            Console.WriteLine(getName());
            printStatus();
            Console.WriteLine(" ");
            printStats();
            Console.WriteLine("");
            printSkills();
            Console.WriteLine("");
            Console.WriteLine("inventory");
            printInventory();
        }
    }
}
