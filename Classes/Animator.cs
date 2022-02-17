using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System.Classes
{
    class Animator
    {
        public enum Speed { x1 = 50, x2 = 100 };
        public enum ColorTransitionSpeed { x1 = 1, x2 = 5 };

        /// <summary>
        /// Animate a control to smoothly travel from its current Left value to a finalLeft value Decreasingly
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="finalLeft">final Left value which need to be less than the control current Left value</param>
        /// <param name="speed">specify the speed which the control will travel</param>
        public static void SlideLeft(Control control, int finalLeft, Speed speed)
        {
            int x = (int)speed;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);

            if ((control.Left - finalLeft) > x)
            {
                timer.Start();
            }

            void timer_Tick(object sender, EventArgs e)
            {
                control.Left -= x;
                if ((control.Left - finalLeft) <= 300)
                {
                    x = 25;
                }
                if ((control.Left - finalLeft) <= 100)
                {
                    x = 10;
                }
                if ((control.Left - finalLeft) <= 20)
                {
                    x = 1;
                }
                if (control.Left == finalLeft)
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Animate a control to smoothly travel from its current Left value to a finalLeft value Incrementally
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="finalLeft">final Left value which need to be greater than the control current Left value</param>
        /// <param name="speed">specify the speed which the control will travel</param>
        public static void SlideRight(Control control, int finalLeft, Speed speed)
        {
            int x = (int)speed;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);

            if ((finalLeft - control.Left) > x)
            {
                timer.Start();
            }

            void timer_Tick(object sender, EventArgs e)
            {
                control.Left += x;
                if ((finalLeft - control.Left) <= 300)
                {
                    x = 25;
                }
                if ((finalLeft - control.Left) <= 100)
                {
                    x = 10;
                }
                if ((finalLeft - control.Left) <= 20)
                {
                    x = 1;
                }
                if (finalLeft == control.Left)
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Animate a control to smoothly travel from its current Top value to a nextTopValue value Decreasingly
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="nextTopValue">final Top value which need to be less than the control current Top value</param>
        /// <param name="speed">specify the speed which the control will travel</param>
        public static void SlideUp(Control control, int nextTopValue, Speed speed)
        {
            int x = (int)speed;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);

            if ((control.Top - nextTopValue) > x)
            {
                timer.Start();
            }

            void timer_Tick(object sender, EventArgs e)
            {
                control.Top -= x;
                if ((control.Top - nextTopValue) <= 300)
                {
                    x = 25;
                }
                if ((control.Top - nextTopValue) <= 100)
                {
                    x = 10;
                }
                if ((control.Top - nextTopValue) <= 20)
                {
                    x = 1;
                }
                if (control.Top == nextTopValue)
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Animate a control to smoothly travel from its current Top value to a nextTopValue value Incrementally
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="nextTopValue">final Top value which need to be greater than the control current Top value</param>
        /// <param name="speed">specify the speed which the control will travel</param>
        public static void SlideDown(Control control, int nextTopValue, Speed speed)
        {
            int x = (int)speed;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);

            if ((nextTopValue - control.Top) > x)
            {
                timer.Start();
            }

            void timer_Tick(object sender, EventArgs e)
            {
                control.Top += x;
                if ((nextTopValue - control.Top) <= 300)
                {
                    x = 25;
                }
                if ((nextTopValue - control.Top) <= 100)
                {
                    x = 10;
                }
                if ((nextTopValue - control.Top) <= 20)
                {
                    x = 1;
                }
                if (nextTopValue == control.Top)
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Expends the control to certain Width
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="finalWidth">final Width value which need to be greater than the control current Width value</param>
        /// <param name="speed">specify the speed which the control will extend</param>
        public static void ExpandToCurtainWidth(Control control, int finalWidth, Speed speed)
        {
            int x = (int)speed;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);

            if ((finalWidth - control.Width) > x)
            {
                timer.Start();
            }

            void timer_Tick(object sender, EventArgs e)
            {
                control.Width += x;
                if ((finalWidth - control.Width) <= 300)
                {
                    x = 25;
                }
                if ((finalWidth - control.Width) <= 100)
                {
                    x = 10;
                }
                if ((finalWidth - control.Width) <= 20)
                {
                    x = 1;
                }
                if (finalWidth == control.Width)
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Expends the control to certain Height
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="finalWidth">final Height value which need to be greater than the control current Height value</param>
        /// <param name="speed">specify the speed which the control will extend</param>
        public static void ExpandToCurtainHeight(Control control, int finalHeight, Speed speed)
        {
            int x = (int)speed;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);

            if ((finalHeight - control.Height) > x)
            {
                timer.Start();
            }

            void timer_Tick(object sender, EventArgs e)
            {
                control.Height += x;
                if ((finalHeight - control.Height) <= 300)
                {
                    x = 25;
                }
                if ((finalHeight - control.Height) <= 100)
                {
                    x = 10;
                }
                if ((finalHeight - control.Height) <= 20)
                {
                    x = 1;
                }
                if (finalHeight == control.Height)
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Shrinks the control to certain Width
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="finalWidth">final Width value which need to be less than the control current Width value</param>
        /// <param name="speed">specify the speed which the control will shrink</param>
        public static void ShrinkToCertainWidth(Control control, int finalWidth, Speed speed)
        {
            int x = (int)speed;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);

            if ((control.Width - finalWidth) > x)
            {
                timer.Start();
            }

            void timer_Tick(object sender, EventArgs e)
            {
                control.Width -= x;
                if ((control.Width - finalWidth) <= 300)
                {
                    x = 25;
                }
                if ((control.Width - finalWidth) <= 100)
                {
                    x = 10;
                }
                if ((control.Width - finalWidth) <= 20)
                {
                    x = 1;
                }
                if (control.Width == finalWidth)
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Shrinks the control to certain Height
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="finalWidth">final Height value which need to be less than the control current Height value</param>
        /// <param name="speed">specify the speed which the control will shrink</param>
        public static void ShrinkToCertainHeight(Control control, int finalHeight, Speed speed)
        {
            int x = (int)speed;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);

            if ((control.Height - finalHeight) > x)
            {
                timer.Start();
            }

            void timer_Tick(object sender, EventArgs e)
            {
                control.Height -= x;
                if ((control.Height - finalHeight) <= 300)
                {
                    x = 25;
                }
                if ((control.Height - finalHeight) <= 100)
                {
                    x = 10;
                }
                if ((control.Height - finalHeight) <= 20)
                {
                    x = 1;
                }
                if (control.Height == finalHeight)
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Animate a collection of controls to smoothly travel from its current Left value to a finalLeft value Decreasingly one at a time
        /// </summary>
        /// <param name="controls">the specified collection of controls which the animation should apply on</param>
        /// <param name="finalLeft">final Left value which need to be less than the controls current Left value</param>
        /// <param name="timerSleepInterval">the small time period between each control to animate</param>
        /// <param name="speed">specify the speed which the control will travel</param>
        public static void SlideLeftCollection(List<Control> controls, int finalLeft, int timerSleepInterval, Speed speed)
        {
            int x = 0;
            Timer timer = new Timer();
            timer.Interval = timerSleepInterval;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            void timer_Tick(object sender, EventArgs e)
            {
                if (x < controls.Count)
                {
                    SlideLeft(controls[x], finalLeft, speed);
                    x++;
                }
                else
                {
                    timer.Stop();
                }
            }

        }

        /// <summary>
        /// Animate a collection of controls to smoothly travel from its current Left value to a finalLeft value Incrementally one at a time
        /// </summary>
        /// <param name="controls">the specified collection of controls which the animation should apply on</param>
        /// <param name="finalLeft">final Left value which need to be greater than the controls current Left value</param>
        /// <param name="timerSleepInterval">the small time period between each control to animate</param>
        /// <param name="speed">specify the speed which the control will travel</param>
        public static void SlideRightCollection(List<Control> controls, int finalLeft, int timerSleepInterval, Speed speed)
        {
            int x = 0;
            Timer timer = new Timer();
            timer.Interval = timerSleepInterval;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();


            void timer_Tick(object sender, EventArgs e)
            {
                if (x < controls.Count)
                {
                    SlideRight(controls[x], finalLeft, speed);
                    x++;
                }
                else
                {
                    timer.Stop();
                }
            }
        }

        /// <summary>
        /// Auto color transition animation applied to a certain control.
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="duration">the duration of the animition to stop, given in seconds</param>
        public static void ColorTransitionAutomatic(Control control, int duration = 0)
        {
            int r = 244;
            int g = 65;
            int b = 65;

            Timer timerR = new Timer();
            Timer timerG = new Timer();
            Timer timerB = new Timer();
            Timer timerDuration = new Timer();

            timerR.Interval = 25;
            timerG.Interval = 25;
            timerB.Interval = 25;
            if (duration != 0) { timerDuration.Interval = 1000 * duration; }


            timerR.Tick += new EventHandler(timerR_Tick);
            timerG.Tick += new EventHandler(timerG_Tick);
            timerB.Tick += new EventHandler(timerB_Tick);
            timerDuration.Tick += new EventHandler(timerDuration_Tick);

            timerB.Start();
            if (duration != 0) { timerDuration.Start(); }


            void timerR_Tick(object sender, EventArgs e)
            {
                if (b >= 244)
                {
                    r -= 1;
                    control.BackColor = Color.FromArgb(r, g, b);
                    if (r <= 65)
                    {
                        timerR.Stop();
                        timerG.Start();
                    }
                }

                if (b <= 65)
                {
                    r += 1;
                    control.BackColor = Color.FromArgb(r, g, b);
                    if (r >= 244)
                    {
                        timerR.Stop();
                        timerG.Start();
                    }
                }
            }

            void timerG_Tick(object sender, EventArgs e)
            {
                if (r <= 65)
                {
                    g += 1;
                    control.BackColor = Color.FromArgb(r, g, b);
                    if (g >= 244)
                    {
                        timerG.Stop();
                        timerB.Start();
                    }
                }

                if (r >= 244)
                {
                    g -= 1;
                    control.BackColor = Color.FromArgb(r, g, b);
                    if (g <= 65)
                    {
                        timerG.Stop();
                        timerB.Start();
                    }
                }
            }

            void timerB_Tick(object sender, EventArgs e)
            {
                if (g <= 65)
                {
                    b += 1;
                    control.BackColor = Color.FromArgb(r, g, b);
                    if (b >= 244)
                    {
                        timerB.Stop();
                        timerR.Start();
                    }
                }

                if (g >= 244)
                {
                    b -= 1;
                    control.BackColor = Color.FromArgb(r, g, b);
                    if (b <= 65)
                    {
                        timerB.Stop();
                        timerR.Start();
                    }
                }
            }

            void timerDuration_Tick(object sender, EventArgs e)
            {
                timerR.Stop();
                timerG.Stop();
                timerB.Stop();
                timerDuration.Stop();
            }
        }

        /// <summary>
        /// Triggers a transition BackColor animation between two different colors.
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="firstColor">the first Color in the transition</param>
        /// <param name="secondColor">the second Color in the transition</param>
        /// <param name="speed">specify the speed which the control will transit</param>
        /// <param name="duration">the duration of the animition to stop, given in seconds</param>
        public static void BackColorTransition(Control control, Color firstColor, Color secondColor, ColorTransitionSpeed speed, int duration = 0)
        {
            //Initialize Variables
            int x = 1;
            int r = firstColor.R;
            int g = firstColor.G;
            int b = firstColor.B;
            bool isStopped = false;

            //Initialize Timers
            Timer timerDuration = new Timer();
            Timer timerSwitch = new Timer();
            Timer timer1 = new Timer();
            Timer timer2 = new Timer();
            Timer timer3 = new Timer();

            //Add Events
            timerDuration.Tick += new EventHandler(timerDuration_Tick);
            if (duration != 0) { timerDuration.Interval = 1000 * duration; }

            timerSwitch.Tick += new EventHandler(timerSwitch_Tick);
            timer1.Tick += new EventHandler(timer1_Tick); //The timer that changes the R value
            timer2.Tick += new EventHandler(timer2_Tick); //The timer that changes the G value
            timer3.Tick += new EventHandler(timer3_Tick); //The timer that changes the B value
            timerSwitch.Interval = timer1.Interval = timer2.Interval = timer3.Interval = 1;

            //In case duration is triggered
            if (duration != 0) { timerDuration.Start(); }

            //Start Timers
            timerSwitch.Start();
            if (firstColor.R != secondColor.R) { timer1.Start(); }
            if (firstColor.G != secondColor.G) { timer2.Start(); }
            if (firstColor.B != secondColor.B) { timer3.Start(); }

            void timerDuration_Tick(object sender, EventArgs e)
            {
                isStopped = true;
            }

            void timerSwitch_Tick(object sender, EventArgs e)
            {
                control.BackColor = Color.FromArgb(r, g, b);
                if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false)
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    if (x == 1)
                    {
                        if (isStopped) // In case stopping is triggered
                        {
                            timerSwitch.Stop();
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timerDuration.Stop();
                        }
                        x = 2;
                    }
                    else
                    {
                        if (isStopped) // In case stopping is triggered
                        {
                            timerSwitch.Stop();
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timerDuration.Stop();
                        }
                        x = 1;
                    }
                }
            }

            void timer1_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (r < secondColor.R)
                    {
                        if (secondColor.R - r <= 10)
                        {
                            r++;
                        }
                        else
                        {
                            r += (int)speed;
                        }

                    }
                    else if (r > secondColor.R)
                    {
                        if (r - secondColor.R <= 10)
                        {
                            r--;
                        }
                        else
                        {
                            r -= (int)speed;
                        }

                    }
                    else
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    if (r < firstColor.R)
                    {
                        if (firstColor.R - r <= 10)
                        {
                            r++;
                        }
                        else
                        {
                            r += (int)speed;
                        }
                    }
                    else if (r > firstColor.R)
                    {
                        if (r - firstColor.R <= 10)
                        {
                            r--;
                        }
                        else
                        {
                            r -= (int)speed;
                        }
                    }
                    else
                    {
                        timer1.Stop();
                    }
                }

            }

            void timer2_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (g < secondColor.G)
                    {
                        if (secondColor.G - g <= 10)
                        {
                            g++;
                        }
                        else
                        {
                            g += (int)speed;
                        }
                    }
                    else if (g > secondColor.G)
                    {
                        if (g - secondColor.G <= 10)
                        {
                            g--;
                        }
                        else
                        {
                            g -= (int)speed;
                        }
                    }
                    else
                    {
                        timer2.Stop();
                    }
                }
                else
                {
                    if (g < firstColor.G)
                    {

                        if (firstColor.G - g <= 10)
                        {
                            g++;
                        }
                        else
                        {
                            g += (int)speed;
                        }
                    }
                    else if (g > firstColor.G)
                    {
                        if (g - firstColor.G <= 10)
                        {
                            g--;
                        }
                        else
                        {
                            g -= (int)speed;
                        }
                    }
                    else
                    {
                        timer2.Stop();
                    }
                }
            }

            void timer3_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (b < secondColor.B)
                    {
                        if (secondColor.B - b <= 10)
                        {
                            b++;
                        }
                        else
                        {
                            b += (int)speed;
                        }
                    }
                    else if (b > secondColor.B)
                    {
                        if (b - secondColor.B <= 10)
                        {
                            b--;
                        }
                        else
                        {
                            b -= (int)speed;
                        }
                    }
                    else
                    {
                        timer3.Stop();
                    }
                }
                else
                {
                    if (b < firstColor.B)
                    {
                        if (firstColor.B - b <= 10)
                        {
                            b++;
                        }
                        else
                        {
                            b += (int)speed;
                        }
                    }
                    else if (b > firstColor.B)
                    {
                        if (b - firstColor.B <= 10)
                        {
                            b--;
                        }
                        else
                        {
                            b -= (int)speed;
                        }
                    }
                    else
                    {
                        timer3.Stop();
                    }
                }
            }

        }

        /// <summary>
        /// Triggers a transition ForeColor animation between two different colors.
        /// </summary>
        /// <param name="control">the specified control which the animation should apply on</param>
        /// <param name="firstColor">the first Color in the transition</param>
        /// <param name="secondColor">the second Color in the transition</param>
        /// <param name="speed">specify the speed which the control will transit</param>
        /// <param name="duration">the duration of the animition to stop, given in seconds</param>
        public static void ForeColorTransition(Control control, Color firstColor, Color secondColor, ColorTransitionSpeed speed, int duration = 0)
        {
            //Initialize Variables
            int x = 1;
            int r = firstColor.R;
            int g = firstColor.G;
            int b = firstColor.B;
            bool isStopped = false;

            //Initialize Timers
            Timer timerDuration = new Timer();
            Timer timerSwitch = new Timer();
            Timer timer1 = new Timer();
            Timer timer2 = new Timer();
            Timer timer3 = new Timer();

            //Add Events
            timerDuration.Tick += new EventHandler(timerDuration_Tick);
            if (duration != 0) { timerDuration.Interval = 1000 * duration; }

            timerSwitch.Tick += new EventHandler(timerSwitch_Tick);
            timer1.Tick += new EventHandler(timer1_Tick); //The timer that changes the R value
            timer2.Tick += new EventHandler(timer2_Tick); //The timer that changes the G value
            timer3.Tick += new EventHandler(timer3_Tick); //The timer that changes the B value
            timerSwitch.Interval = timer1.Interval = timer2.Interval = timer3.Interval = 1;

            //In case duration is triggered
            if (duration != 0) { timerDuration.Start(); }

            //Start Timers
            timerSwitch.Start();
            if (firstColor.R != secondColor.R) { timer1.Start(); }
            if (firstColor.G != secondColor.G) { timer2.Start(); }
            if (firstColor.B != secondColor.B) { timer3.Start(); }

            void timerDuration_Tick(object sender, EventArgs e)
            {
                isStopped = true;
            }

            void timerSwitch_Tick(object sender, EventArgs e)
            {
                control.ForeColor = Color.FromArgb(r, g, b);
                if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false)
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    if (x == 1)
                    {
                        if (isStopped) // In case stopping is triggered
                        {
                            timerSwitch.Stop();
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timerDuration.Stop();
                        }
                        x = 2;
                    }
                    else
                    {
                        if (isStopped) // In case stopping is triggered
                        {
                            timerSwitch.Stop();
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timerDuration.Stop();
                        }
                        x = 1;
                    }
                }
            }

            void timer1_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (r < secondColor.R)
                    {
                        if (secondColor.R - r <= 10)
                        {
                            r++;
                        }
                        else
                        {
                            r += (int)speed;
                        }

                    }
                    else if (r > secondColor.R)
                    {
                        if (r - secondColor.R <= 10)
                        {
                            r--;
                        }
                        else
                        {
                            r -= (int)speed;
                        }

                    }
                    else
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    if (r < firstColor.R)
                    {
                        if (firstColor.R - r <= 10)
                        {
                            r++;
                        }
                        else
                        {
                            r += (int)speed;
                        }
                    }
                    else if (r > firstColor.R)
                    {
                        if (r - firstColor.R <= 10)
                        {
                            r--;
                        }
                        else
                        {
                            r -= (int)speed;
                        }
                    }
                    else
                    {
                        timer1.Stop();
                    }
                }

            }

            void timer2_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (g < secondColor.G)
                    {
                        if (secondColor.G - g <= 10)
                        {
                            g++;
                        }
                        else
                        {
                            g += (int)speed;
                        }
                    }
                    else if (g > secondColor.G)
                    {
                        if (g - secondColor.G <= 10)
                        {
                            g--;
                        }
                        else
                        {
                            g -= (int)speed;
                        }
                    }
                    else
                    {
                        timer2.Stop();
                    }
                }
                else
                {
                    if (g < firstColor.G)
                    {

                        if (firstColor.G - g <= 10)
                        {
                            g++;
                        }
                        else
                        {
                            g += (int)speed;
                        }
                    }
                    else if (g > firstColor.G)
                    {
                        if (g - firstColor.G <= 10)
                        {
                            g--;
                        }
                        else
                        {
                            g -= (int)speed;
                        }
                    }
                    else
                    {
                        timer2.Stop();
                    }
                }
            }

            void timer3_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (b < secondColor.B)
                    {
                        if (secondColor.B - b <= 10)
                        {
                            b++;
                        }
                        else
                        {
                            b += (int)speed;
                        }
                    }
                    else if (b > secondColor.B)
                    {
                        if (b - secondColor.B <= 10)
                        {
                            b--;
                        }
                        else
                        {
                            b -= (int)speed;
                        }
                    }
                    else
                    {
                        timer3.Stop();
                    }
                }
                else
                {
                    if (b < firstColor.B)
                    {
                        if (firstColor.B - b <= 10)
                        {
                            b++;
                        }
                        else
                        {
                            b += (int)speed;
                        }
                    }
                    else if (b > firstColor.B)
                    {
                        if (b - firstColor.B <= 10)
                        {
                            b--;
                        }
                        else
                        {
                            b -= (int)speed;
                        }
                    }
                    else
                    {
                        timer3.Stop();
                    }
                }
            }

        }

        public static void ButtonBorderColorTransition(Button button, Color firstColor, Color secondColor, ColorTransitionSpeed speed, int duration = 0)
        {
            //Initialize Variables
            int x = 1;
            int r = firstColor.R;
            int g = firstColor.G;
            int b = firstColor.B;
            bool isStopped = false;

            //Initialize Timers
            Timer timerDuration = new Timer();
            Timer timerSwitch = new Timer();
            Timer timer1 = new Timer();
            Timer timer2 = new Timer();
            Timer timer3 = new Timer();

            //Add Events
            timerDuration.Tick += new EventHandler(timerDuration_Tick);
            if (duration != 0) { timerDuration.Interval = 1000 * duration; }

            timerSwitch.Tick += new EventHandler(timerSwitch_Tick);
            timer1.Tick += new EventHandler(timer1_Tick); //The timer that changes the R value
            timer2.Tick += new EventHandler(timer2_Tick); //The timer that changes the G value
            timer3.Tick += new EventHandler(timer3_Tick); //The timer that changes the B value
            timerSwitch.Interval = timer1.Interval = timer2.Interval = timer3.Interval = 1;

            //In case duration is triggered
            if (duration != 0) { timerDuration.Start(); }

            //Start Timers
            timerSwitch.Start();
            if (firstColor.R != secondColor.R) { timer1.Start(); }
            if (firstColor.G != secondColor.G) { timer2.Start(); }
            if (firstColor.B != secondColor.B) { timer3.Start(); }

            void timerDuration_Tick(object sender, EventArgs e)
            {
                isStopped = true;
            }

            void timerSwitch_Tick(object sender, EventArgs e)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(r, g, b);
                if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false)
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    if (x == 1)
                    {
                        if (isStopped) // In case stopping is triggered
                        {
                            timerSwitch.Stop();
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timerDuration.Stop();
                        }
                        x = 2;
                    }
                    else
                    {
                        if (isStopped) // In case stopping is triggered
                        {
                            timerSwitch.Stop();
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timerDuration.Stop();
                        }
                        x = 1;
                    }
                }
            }

            void timer1_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (r < secondColor.R)
                    {
                        if (secondColor.R - r <= 10)
                        {
                            r++;
                        }
                        else
                        {
                            r += (int)speed;
                        }

                    }
                    else if (r > secondColor.R)
                    {
                        if (r - secondColor.R <= 10)
                        {
                            r--;
                        }
                        else
                        {
                            r -= (int)speed;
                        }

                    }
                    else
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    if (r < firstColor.R)
                    {
                        if (firstColor.R - r <= 10)
                        {
                            r++;
                        }
                        else
                        {
                            r += (int)speed;
                        }
                    }
                    else if (r > firstColor.R)
                    {
                        if (r - firstColor.R <= 10)
                        {
                            r--;
                        }
                        else
                        {
                            r -= (int)speed;
                        }
                    }
                    else
                    {
                        timer1.Stop();
                    }
                }

            }

            void timer2_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (g < secondColor.G)
                    {
                        if (secondColor.G - g <= 10)
                        {
                            g++;
                        }
                        else
                        {
                            g += (int)speed;
                        }
                    }
                    else if (g > secondColor.G)
                    {
                        if (g - secondColor.G <= 10)
                        {
                            g--;
                        }
                        else
                        {
                            g -= (int)speed;
                        }
                    }
                    else
                    {
                        timer2.Stop();
                    }
                }
                else
                {
                    if (g < firstColor.G)
                    {

                        if (firstColor.G - g <= 10)
                        {
                            g++;
                        }
                        else
                        {
                            g += (int)speed;
                        }
                    }
                    else if (g > firstColor.G)
                    {
                        if (g - firstColor.G <= 10)
                        {
                            g--;
                        }
                        else
                        {
                            g -= (int)speed;
                        }
                    }
                    else
                    {
                        timer2.Stop();
                    }
                }
            }

            void timer3_Tick(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    if (b < secondColor.B)
                    {
                        if (secondColor.B - b <= 10)
                        {
                            b++;
                        }
                        else
                        {
                            b += (int)speed;
                        }
                    }
                    else if (b > secondColor.B)
                    {
                        if (b - secondColor.B <= 10)
                        {
                            b--;
                        }
                        else
                        {
                            b -= (int)speed;
                        }
                    }
                    else
                    {
                        timer3.Stop();
                    }
                }
                else
                {
                    if (b < firstColor.B)
                    {
                        if (firstColor.B - b <= 10)
                        {
                            b++;
                        }
                        else
                        {
                            b += (int)speed;
                        }
                    }
                    else if (b > firstColor.B)
                    {
                        if (b - firstColor.B <= 10)
                        {
                            b--;
                        }
                        else
                        {
                            b -= (int)speed;
                        }
                    }
                    else
                    {
                        timer3.Stop();
                    }
                }
            }

        }
    }
}
