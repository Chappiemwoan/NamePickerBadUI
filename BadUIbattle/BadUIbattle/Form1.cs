using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadUIbattle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            float loopCount = trackBar1.Value + trackBar2.Value * 100 + trackBar3.Value * 10000 + trackBar4.Value * 1000000;
            string name = "a";
            char firstCharacter = 'a';char secondCharacter = 'a';char thirdCharacter = 'a';char fourthCharacter = 'a';char fifthCharacter = 'f';

            for (float i = 0; i < loopCount; i++)
            {
                //firstCharacter
                if (firstCharacter == 'z')
                {
                    //secondCharacter
                    if (name.Length < 2)
                    {
                        name = "aa";
                        secondCharacter = 'a';
                        firstCharacter = 'a';
                    }
                    else if (secondCharacter == 'z' && firstCharacter == 'z')
                    {
                        //thirdCharacter
                        if (name.Length < 3)
                        {
                            name = "aaa";
                            thirdCharacter = 'a';
                            secondCharacter = 'a';
                            firstCharacter = 'a';
                        }
                        else if (thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                        {
                            //fourthCharacter
                            if (name.Length < 4)
                            {
                                name = "aaaa";
                                fourthCharacter = 'a';
                                thirdCharacter = 'a';
                                secondCharacter = 'a';
                                firstCharacter = 'a';
                            }
                            else if (fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                            {
                                //fifthCharacter
                                if (name.Length < 5)
                                {
                                    name = "aaaaa";
                                    fifthCharacter = 'a';
                                    fourthCharacter = 'a';
                                    thirdCharacter = 'a';
                                    secondCharacter = 'a';
                                    firstCharacter = 'a';
                                }
                                else if (fifthCharacter == 'z' && fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                                {

                                }
                                else if (fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                                {
                                    fifthCharacter = (char)(((int)fifthCharacter) + 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name + fifthCharacter + "aaaa";
                                    fifthCharacter = name[name.Length - 5];
                                    fourthCharacter = name[name.Length - 4];
                                    thirdCharacter = name[name.Length - 3];
                                    secondCharacter = name[name.Length - 2];
                                    firstCharacter = name[name.Length - 1];
                                }
                            }
                            else if (thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                            {
                                fourthCharacter = (char)(((int)fourthCharacter) + 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name + fourthCharacter + "aaa";
                                fourthCharacter = name[name.Length - 4];
                                thirdCharacter = name[name.Length - 3];
                                secondCharacter = name[name.Length - 2];
                                firstCharacter = name[name.Length - 1];
                            }
                        }
                        else if (secondCharacter == 'z' && firstCharacter == 'z')
                        {
                            thirdCharacter = (char)(((int)thirdCharacter) + 1);
                            name = name.Remove(name.Length - 1);
                            name = name.Remove(name.Length - 1);
                            name = name.Remove(name.Length - 1);
                            name = name + thirdCharacter + "aa";
                            thirdCharacter = name[name.Length - 3];
                            secondCharacter = name[name.Length - 2];
                            firstCharacter = name[name.Length - 1];
                        }
                    }
                    else if (firstCharacter == 'z')
                    {
                        secondCharacter = (char)(((int)secondCharacter) + 1);
                        name = name.Remove(name.Length - 1);
                        name = name.Remove(name.Length - 1);
                        name = name + secondCharacter + "a";
                        secondCharacter = name[name.Length - 2];
                        firstCharacter = name[name.Length - 1];
                    }
                }
                else
                {
                    firstCharacter = (char)(((int)firstCharacter) + 1);
                    name = name.Remove(name.Length - 1);
                    name = name + firstCharacter;
                    firstCharacter = name[name.Length - 1];
                }
            }
            txtName.Text = name;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            float loopCount = trackBar1.Value + trackBar2.Value * 100 + trackBar3.Value * 10000 + trackBar4.Value * 1000000;
            string name = "a";
            char firstCharacter = 'a'; char secondCharacter = 'a'; char thirdCharacter = 'a'; char fourthCharacter = 'a'; char fifthCharacter = 'f';

            for (float i = 0; i < loopCount; i++)
            {
                //firstCharacter
                if (firstCharacter == 'z')
                {
                    //secondCharacter
                    if (name.Length < 2)
                    {
                        name = "aa";
                        secondCharacter = 'a';
                        firstCharacter = 'a';
                    }
                    else if (secondCharacter == 'z' && firstCharacter == 'z')
                    {
                        //thirdCharacter
                        if (name.Length < 3)
                        {
                            name = "aaa";
                            thirdCharacter = 'a';
                            secondCharacter = 'a';
                            firstCharacter = 'a';
                        }
                        else if (thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                        {
                            //fourthCharacter
                            if (name.Length < 4)
                            {
                                name = "aaaa";
                                fourthCharacter = 'a';
                                thirdCharacter = 'a';
                                secondCharacter = 'a';
                                firstCharacter = 'a';
                            }
                            else if (fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                            {
                                //fifthCharacter
                                if (name.Length < 5)
                                {
                                    name = "aaaaa";
                                    fifthCharacter = 'a';
                                    fourthCharacter = 'a';
                                    thirdCharacter = 'a';
                                    secondCharacter = 'a';
                                    firstCharacter = 'a';
                                }
                                else if (fifthCharacter == 'z' && fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                                {

                                }
                                else if (fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                                {
                                    fifthCharacter = (char)(((int)fifthCharacter) + 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name + fifthCharacter + "aaaa";
                                    fifthCharacter = name[name.Length - 5];
                                    fourthCharacter = name[name.Length - 4];
                                    thirdCharacter = name[name.Length - 3];
                                    secondCharacter = name[name.Length - 2];
                                    firstCharacter = name[name.Length - 1];
                                }
                            }
                            else if (thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                            {
                                fourthCharacter = (char)(((int)fourthCharacter) + 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name + fourthCharacter + "aaa";
                                fourthCharacter = name[name.Length - 4];
                                thirdCharacter = name[name.Length - 3];
                                secondCharacter = name[name.Length - 2];
                                firstCharacter = name[name.Length - 1];
                            }
                        }
                        else if (secondCharacter == 'z' && firstCharacter == 'z')
                        {
                            thirdCharacter = (char)(((int)thirdCharacter) + 1);
                            name = name.Remove(name.Length - 1);
                            name = name.Remove(name.Length - 1);
                            name = name.Remove(name.Length - 1);
                            name = name + thirdCharacter + "aa";
                            thirdCharacter = name[name.Length - 3];
                            secondCharacter = name[name.Length - 2];
                            firstCharacter = name[name.Length - 1];
                        }
                    }
                    else if (firstCharacter == 'z')
                    {
                        secondCharacter = (char)(((int)secondCharacter) + 1);
                        name = name.Remove(name.Length - 1);
                        name = name.Remove(name.Length - 1);
                        name = name + secondCharacter + "a";
                        secondCharacter = name[name.Length - 2];
                        firstCharacter = name[name.Length - 1];
                    }
                }
                else
                {
                    firstCharacter = (char)(((int)firstCharacter) + 1);
                    name = name.Remove(name.Length - 1);
                    name = name + firstCharacter;
                    firstCharacter = name[name.Length - 1];
                }
            }
            txtName.Text = name;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            float loopCount = trackBar1.Value + trackBar2.Value * 100 + trackBar3.Value * 10000 + trackBar4.Value * 1000000;
            string name = "a";
            char firstCharacter = 'a'; char secondCharacter = 'a'; char thirdCharacter = 'a'; char fourthCharacter = 'a'; char fifthCharacter = 'f';

            for (float i = 0; i < loopCount; i++)
            {
                //firstCharacter
                if (firstCharacter == 'z')
                {
                    //secondCharacter
                    if (name.Length < 2)
                    {
                        name = "aa";
                        secondCharacter = 'a';
                        firstCharacter = 'a';
                    }
                    else if (secondCharacter == 'z' && firstCharacter == 'z')
                    {
                        //thirdCharacter
                        if (name.Length < 3)
                        {
                            name = "aaa";
                            thirdCharacter = 'a';
                            secondCharacter = 'a';
                            firstCharacter = 'a';
                        }
                        else if (thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                        {
                            //fourthCharacter
                            if (name.Length < 4)
                            {
                                name = "aaaa";
                                fourthCharacter = 'a';
                                thirdCharacter = 'a';
                                secondCharacter = 'a';
                                firstCharacter = 'a';
                            }
                            else if (fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                            {
                                //fifthCharacter
                                if (name.Length < 5)
                                {
                                    name = "aaaaa";
                                    fifthCharacter = 'a';
                                    fourthCharacter = 'a';
                                    thirdCharacter = 'a';
                                    secondCharacter = 'a';
                                    firstCharacter = 'a';
                                }
                                else if (fifthCharacter == 'z' && fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                                {

                                }
                                else if (fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                                {
                                    fifthCharacter = (char)(((int)fifthCharacter) + 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name + fifthCharacter + "aaaa";
                                    fifthCharacter = name[name.Length - 5];
                                    fourthCharacter = name[name.Length - 4];
                                    thirdCharacter = name[name.Length - 3];
                                    secondCharacter = name[name.Length - 2];
                                    firstCharacter = name[name.Length - 1];
                                }
                            }
                            else if (thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                            {
                                fourthCharacter = (char)(((int)fourthCharacter) + 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name + fourthCharacter + "aaa";
                                fourthCharacter = name[name.Length - 4];
                                thirdCharacter = name[name.Length - 3];
                                secondCharacter = name[name.Length - 2];
                                firstCharacter = name[name.Length - 1];
                            }
                        }
                        else if (secondCharacter == 'z' && firstCharacter == 'z')
                        {
                            thirdCharacter = (char)(((int)thirdCharacter) + 1);
                            name = name.Remove(name.Length - 1);
                            name = name.Remove(name.Length - 1);
                            name = name.Remove(name.Length - 1);
                            name = name + thirdCharacter + "aa";
                            thirdCharacter = name[name.Length - 3];
                            secondCharacter = name[name.Length - 2];
                            firstCharacter = name[name.Length - 1];
                        }
                    }
                    else if (firstCharacter == 'z')
                    {
                        secondCharacter = (char)(((int)secondCharacter) + 1);
                        name = name.Remove(name.Length - 1);
                        name = name.Remove(name.Length - 1);
                        name = name + secondCharacter + "a";
                        secondCharacter = name[name.Length - 2];
                        firstCharacter = name[name.Length - 1];
                    }
                }
                else
                {
                    firstCharacter = (char)(((int)firstCharacter) + 1);
                    name = name.Remove(name.Length - 1);
                    name = name + firstCharacter;
                    firstCharacter = name[name.Length - 1];
                }
            }
            txtName.Text = name;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            float loopCount = trackBar1.Value + trackBar2.Value * 100 + trackBar3.Value * 10000 + trackBar4.Value * 1000000;
            string name = "a";
            char firstCharacter = 'a'; char secondCharacter = 'a'; char thirdCharacter = 'a'; char fourthCharacter = 'a'; char fifthCharacter = 'f';

            for (float i = 0; i < loopCount; i++)
            {
                //firstCharacter
                if (firstCharacter == 'z')
                {
                    //secondCharacter
                    if (name.Length < 2)
                    {
                        name = "aa";
                        secondCharacter = 'a';
                        firstCharacter = 'a';
                    }
                    else if (secondCharacter == 'z' && firstCharacter == 'z')
                    {
                        //thirdCharacter
                        if (name.Length < 3)
                        {
                            name = "aaa";
                            thirdCharacter = 'a';
                            secondCharacter = 'a';
                            firstCharacter = 'a';
                        }
                        else if (thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                        {
                            //fourthCharacter
                            if (name.Length < 4)
                            {
                                name = "aaaa";
                                fourthCharacter = 'a';
                                thirdCharacter = 'a';
                                secondCharacter = 'a';
                                firstCharacter = 'a';
                            }
                            else if (fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                            {
                                //fifthCharacter
                                if (name.Length < 5)
                                {
                                    name = "aaaaa";
                                    fifthCharacter = 'a';
                                    fourthCharacter = 'a';
                                    thirdCharacter = 'a';
                                    secondCharacter = 'a';
                                    firstCharacter = 'a';
                                }
                                else if (fifthCharacter == 'z' && fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                                {

                                }
                                else if (fourthCharacter == 'z' && thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                                {
                                    fifthCharacter = (char)(((int)fifthCharacter) + 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name.Remove(name.Length - 1);
                                    name = name + fifthCharacter + "aaaa";
                                    fifthCharacter = name[name.Length - 5];
                                    fourthCharacter = name[name.Length - 4];
                                    thirdCharacter = name[name.Length - 3];
                                    secondCharacter = name[name.Length - 2];
                                    firstCharacter = name[name.Length - 1];
                                }
                            }
                            else if (thirdCharacter == 'z' && secondCharacter == 'z' && firstCharacter == 'z')
                            {
                                fourthCharacter = (char)(((int)fourthCharacter) + 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name.Remove(name.Length - 1);
                                name = name + fourthCharacter + "aaa";
                                fourthCharacter = name[name.Length - 4];
                                thirdCharacter = name[name.Length - 3];
                                secondCharacter = name[name.Length - 2];
                                firstCharacter = name[name.Length - 1];
                            }
                        }
                        else if (secondCharacter == 'z' && firstCharacter == 'z')
                        {
                            thirdCharacter = (char)(((int)thirdCharacter) + 1);
                            name = name.Remove(name.Length - 1);
                            name = name.Remove(name.Length - 1);
                            name = name.Remove(name.Length - 1);
                            name = name + thirdCharacter + "aa";
                            thirdCharacter = name[name.Length - 3];
                            secondCharacter = name[name.Length - 2];
                            firstCharacter = name[name.Length - 1];
                        }
                    }
                    else if (firstCharacter == 'z')
                    {
                        secondCharacter = (char)(((int)secondCharacter) + 1);
                        name = name.Remove(name.Length - 1);
                        name = name.Remove(name.Length - 1);
                        name = name + secondCharacter + "a";
                        secondCharacter = name[name.Length - 2];
                        firstCharacter = name[name.Length - 1];
                    }
                }
                else
                {
                    firstCharacter = (char)(((int)firstCharacter) + 1);
                    name = name.Remove(name.Length - 1);
                    name = name + firstCharacter;
                    firstCharacter = name[name.Length - 1];
                }
            }
            txtName.Text = name;
        }
    }
}
