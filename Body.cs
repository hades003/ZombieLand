using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieLand
{
    class Body
    {
        private String name;
        private int speed = 6;
        private int preception = 6;
        private bool alive = true;

        public Body(String nm)
        {
            name = nm;
        }

        public Body()
        {
            name = null;
        }

        public void setName(String set)
        {
            name = set;
        }

        public String getName() 
        {
            return name;
        }

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
        // if the zombie should be dead or not, if the speed of the zombie should be changed,
        //and how the zombie's precepetive ability changes; in that order.
        public void updateDamage()
        {
            //check for fall off
            if (heart == 'g' && lungs == 'g')
            {
                brain = 'g';
            }
            if (lungs == 'g' && guts == 'g')
            {
                rightThigh = 'g';
                leftThigh = 'g';
            }
            if (leftThigh == 'g')
            {
                leftKnee = 'g';
            }
            if (leftKnee == 'g')
            {
                leftShin = 'g';
            }
            if (rightThigh == 'g')
            {
                rightKnee = 'g';
            }
            if (rightKnee == 'g')
            {
                rightShin = 'g';
            }
            if (rightSholder == 'g')
            {
                rightElbow = 'g';
            }
            if (rightElbow == 'g')
            {
                rightForearm = 'g';
            }
            if (leftSholder == 'g')
            {
                leftElbow = 'g';
            }
            if (leftElbow == 'g')
            {
                leftForearm = 'g';
            }

            //this part determines the zombie's new speed
            speed = 6;
            if (lungs == 'g') 
            {
                speed--;
            }
            if (rightKnee != 'f') 
            {
                if (rightKnee == 'd')
                {
                    speed--;
                }
                else 
                {
                    speed -= 2;
                }
            }
            if (leftKnee != 'f')
            {
                if (rightKnee == 'd')
                {
                    speed--;
                }
                else 
                {
                    speed -= 2;
                }
            }
            if (leftShin == 'g' && leftKnee == 'f') 
            {
                speed--;
            }
            if (rightShin == 'g' && rightKnee == 'f')
            {
                speed--;
            }
            if (rightKnee == 'g' && rightSholder == 'g') 
            {
                speed--;
            }
            if (leftKnee == 'g' && leftSholder == 'g')
            {
                speed--;
            }

            //this part checks to see if the zombie is still alive
            if (brain == 'g' || speed < 0)
            {
                alive = false;
            }

            //this part updates the preception value
            int pre1;
            int pre2;

            Random ass = new Random();

            if (ears == 'f')
            {
                pre1 = 3;
            }
            else if (ears == 'd')
            {
                pre1 = ass.Next(2);
            }
            else 
            {
                pre1 = 0;
            }
            if (eyes == 'f')
            {
                pre2 = 3;
            }
            else if (eyes == 'd')
            {
                pre2 = ass.Next(2);
            }
            else
            {
                pre2 = 0;
            }

            preception = pre1 + pre2;
        }

        public void printStatus() 
        {
            if (alive)
            {
                Console.WriteLine(name + ", alive");
            }
            else 
            {
                Console.WriteLine(name + ", dead");
            }
            Console.WriteLine("Pre: " + preception + "  Spd: " + speed);
            Console.WriteLine("Brn: " + brain + "   Eye: " + eyes + "   Ear: " + ears);
            Console.WriteLine("Hrt: " + heart + "   Lng: " + lungs + "  Gut: " + guts);
            Console.WriteLine("LShd: " + leftSholder + "    LElb: " + leftElbow + "     LFor: " + leftForearm);
            Console.WriteLine("RShd: " + rightSholder + "   RElb: " + rightElbow + "    RFor: " + rightForearm);
            Console.WriteLine("LThi: " + leftThigh + "   LKne: " + leftKnee + "    LShn: " + leftShin);
            Console.WriteLine("RThi: " + rightThigh + "    RKne: " + rightKnee + "    RShn: " + rightShin);
        }
    }
}
