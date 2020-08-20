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

        protected String name;

        public body(String nm) 
        {
            name = nm;
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

        public char getheart() 
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

        //these are all of the set methods
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
    }


    //this is the zombie body stats that are used for enemies. it deteriates upon generation.
    public class zombieBody : body
    {
        private static int deteriation;

        public zombieBody(String nm, int det)
        {
            deteriation = det;
            name = nm;
        }

        private static Random qwe = new Random();
        private int trueDet = qwe.Next(deteriation);
        
        //this is the method that generates the zombie deteriation
        public void deter()
        {
            int targets = 0;
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
                }
            }
        }
    }
}
