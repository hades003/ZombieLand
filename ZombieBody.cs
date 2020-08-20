using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieLand
{
    class ZombieBody : Body
    {
        public ZombieBody(String nm, int det)
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
