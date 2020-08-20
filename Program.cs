using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace ZombieLand
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    //this class is the body object of enemies and players. f means fine, d means damaged, g means gone.
    public class body
    {

        private String name;
        private int speed = 4;
        private int preception = 6;

        public body(String nm) 
        {
            name = nm;
        }

        public body() 
        {
            name = null;
        }

        public void setName(String set)
        {
            name = set;
        }

        private bool walking = true;

        //head organs
        private char brain = 'f';
        private char eyes = 'f';
        private char ears = 'f';

        //torso organs
        private char heart = 'f';
        private char lungs = 'f';
        private char guts = 'f';

        //left arm parts
        private char leftSholder = 'f';
        private char leftElbow = 'f';
        private char leftForearm = 'f';

        //right arm parts
        private char rightSholder = 'f';
        private char rightElbow = 'f';
        private char rightForearm = 'f';

        //left leg parts
        private char leftThigh = 'f';
        private char leftKnee = 'f';
        private char leftShin = 'f';

        //right leg parts
        private char rightThigh = 'f';
        private char rightKnee = 'f';
        private char rightShin = 'f';

        //this are all of the get methods
        public char getBrain() 
        {
            return brain;
        }

        public char getEyes() 
        {
            return eyes;
        }

        public char getEars() 
        {
            return ears;
        }

        public char getHeart() 
        {
            return heart;
        }

        public char getLungs()
        {
            return lungs;
        }

        public char getGuts()
        {
            return guts;
        }

        public char getLeftThigh()
        {
            return leftThigh;
        }

        public char getLeftKnee()
        {
            return leftKnee;
        }

        public char getLeftShin()
        {
            return leftShin;
        }

        public char getRightThigh()
        {
            return rightThigh;
        }

        public char getRightKnee()
        {
            return rightKnee;
        }

        public char getRightShin()
        {
            return rightShin;
        }

        public char getLeftSholder() 
        {
            return leftSholder;
        }

        public char getLeftElbow()
        {
            return leftElbow;
        }

        public char getLeftForearm()
        {
            return leftForearm;
        }

        public char getRightSholder()
        {
            return rightSholder;
        }

        public char getRightElbow()
        {
            return rightElbow;
        }

        public char getRightForearm()
        {
            return rightForearm;
        }

        //these are all of the set methods
        //head section
        public void setEyes(char set) 
        {
            eyes = set;
        }

        public void setBrain(char set) 
        {
            brain = set;
        }

        public void setEars(char set) 
        {
            ears = set;
        }

        //torso section
        public void setHeart(char set)
        {
            heart = set;
        }

        public void setGuts(char set)
        {
            guts = set;
        }

        public void setLungs(char set)
        {
            lungs = set;
        }

        //leg section(left and knight)
        public void setLeftThigh(char set)
        {
            leftThigh = set;
        }

        public void setLeftKnee(char set)
        {
            leftKnee = set;
        }

        public void setLeftShin(char set)
        {
            leftShin = set;
        }

        public void setRightThigh(char set)
        {
            rightThigh = set;
        }

        public void setRightKnee(char set)
        {
            rightKnee = set;
        }

        public void setRightShin(char set)
        {
            rightShin = set;
        }

        //arms sections, both right and left
        public void setRightSholder(char set)
        {
            rightSholder = set;
        }

        public void setRightElbow(char set)
        {
            rightElbow = set;
        }

        public void setRightForearm(char set)
        {
            rightForearm = set;
        }

        public void setLeftSholder(char set)
        {
            leftSholder = set;
        }

        public void setLeftElbow(char set)
        {
            leftElbow = set;
        }

        public void setLeftForearm(char set)
        {
            leftForearm = set;
        }

        //This is the check damage method of which sees if any body parts need to fall off,
        // if the zombie should be dead or not, and if the speed of the zombie should be changed
        public void checkDamage() 
        {

        }
    }


    //this is the zombie body stats that are used for enemies. it deteriates upon generation.
    public class zombieBody : body
    {
        public zombieBody(String nm, int det)
        {
            setName(nm);
            deter(det);
        }
        
        //this is the method that generates the zombie deteriation. 
        // 'f' means fine and has taken no damage, 'd' means that it's taken considerable damage,
        //and 'g' means that the body part has completely been removed.
        public void deter(int dtr)
        {
            Random qwe = new Random();
            int trueDet = qwe.Next(dtr);

            int targets;
            bool control;
            for (int i = 0; i < trueDet; i++)
            {
                control = true;
                targets = qwe.Next(18);
                while (control) 
                {
                    if (targets == 1)
                    {
                        targets = qwe.Next(18);
                    }
                    else if (targets == 2)
                    {
                        if (getEyes() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setEyes('d');
                            }
                            else
                            {
                                setEyes('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 3) 
                    {
                        if (getEars() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else 
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setEars('d');
                            }
                            else 
                            {
                                setEars('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 4)
                    {
                        if (getHeart() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setHeart('d');
                            }
                            else
                            {
                                setHeart('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 5)
                    {
                        if (getLungs() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setLungs('d');
                            }
                            else
                            {
                                setLungs('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 6)
                    {
                        if (getGuts() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setGuts('d');
                            }
                            else
                            {
                                setGuts('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 7)
                    {
                        if (getLeftSholder() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setLeftSholder('d');
                            }
                            else
                            {
                                setLeftSholder('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 8)
                    {
                        if (getLeftElbow() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setLeftElbow('d');
                            }
                            else
                            {
                                setLeftElbow('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 9)
                    {
                        if (getLeftForearm() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setLeftForearm('d');
                            }
                            else
                            {
                                setLeftForearm('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 10)
                    {
                        if (getRightSholder() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setRightSholder('d');
                            }
                            else
                            {
                                setRightSholder('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 11)
                    {
                        if (getRightElbow() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setRightElbow('d');
                            }
                            else
                            {
                                setRightElbow('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 12)
                    {
                        if (getRightForearm() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setRightForearm('d');
                            }
                            else
                            {
                                setRightForearm('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 13)
                    {
                        if (getLeftThigh() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setLeftThigh('d');
                            }
                            else
                            {
                                setLeftThigh('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 14)
                    {
                        if (getLeftKnee() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setLeftKnee('d');
                            }
                            else
                            {
                                setLeftKnee('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 15)
                    {
                        if (getLeftShin() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setLeftShin('d');
                            }
                            else
                            {
                                setLeftShin('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 16)
                    {
                        if (getRightThigh() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setRightThigh('d');
                            }
                            else
                            {
                                setRightThigh('g');
                            }
                            control = false;
                        }
                    }
                    else if (targets == 17)
                    {
                        if (getRightKnee() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setRightKnee('d');
                            }
                            else
                            {
                                setRightKnee('g');
                            }
                            control = false;
                        }
                    }
                    else
                    {
                        if (getRightShin() == 'g')
                        {
                            targets = qwe.Next(18);
                        }
                        else
                        {
                            targets = qwe.Next(2);
                            if (targets == 1)
                            {
                                setRightShin('d');
                            }
                            else
                            {
                                setRightShin('g');
                            }
                            control = false;
                        }
                    }
                }
            }
            checkDamage();
        }
    }
}
