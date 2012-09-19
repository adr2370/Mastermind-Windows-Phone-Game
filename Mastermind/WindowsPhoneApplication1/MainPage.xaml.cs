using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WindowsPhoneApplication1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Global Transform used to change the position of the Rectangle.
        private TranslateTransform dragTranslationRed;
        private TranslateTransform dragTranslationBlack;
        private TranslateTransform dragTranslationBlue;
        private TranslateTransform dragTranslationPurple;
        private TranslateTransform dragTranslationYellow;
        private TranslateTransform dragTranslationGreen;
        private int turn;
        private int[] colorAnswer = new int[4];
        private int[] tempAnswer = new int[4];
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                colorAnswer[i] = rand.Next(6) + 1;
                while (invalid(colorAnswer, i))
                    colorAnswer[i] = rand.Next(6) + 1;
            }
            //Red Choice
            RedChoice.ManipulationDelta +=
            new EventHandler<ManipulationDeltaEventArgs>(RedChoice_ManipulationDelta);
            dragTranslationRed = new TranslateTransform();
            RedChoice.RenderTransform = this.dragTranslationRed;
            //Black Choice
            BlackChoice.ManipulationDelta +=
            new EventHandler<ManipulationDeltaEventArgs>(BlackChoice_ManipulationDelta);
            dragTranslationBlack = new TranslateTransform();
            BlackChoice.RenderTransform = this.dragTranslationBlack;
            //Blue Choice
            BlueChoice.ManipulationDelta +=
            new EventHandler<ManipulationDeltaEventArgs>(BlueChoice_ManipulationDelta);
            dragTranslationBlue = new TranslateTransform();
            BlueChoice.RenderTransform = this.dragTranslationBlue;
            //Purple Choice
            PurpleChoice.ManipulationDelta +=
            new EventHandler<ManipulationDeltaEventArgs>(PurpleChoice_ManipulationDelta);
            dragTranslationPurple = new TranslateTransform();
            PurpleChoice.RenderTransform = this.dragTranslationPurple;
            //Yellow Choice
            YellowChoice.ManipulationDelta +=
            new EventHandler<ManipulationDeltaEventArgs>(YellowChoice_ManipulationDelta);
            dragTranslationYellow = new TranslateTransform();
            YellowChoice.RenderTransform = this.dragTranslationYellow;
            //Green Choice
            GreenChoice.ManipulationDelta +=
            new EventHandler<ManipulationDeltaEventArgs>(GreenChoice_ManipulationDelta);
            dragTranslationGreen = new TranslateTransform();
            GreenChoice.RenderTransform = this.dragTranslationGreen;
            turn = 1;
        }

        private bool invalid(int[] x, int i)
        {
            for (int j = 0; j < i; j++)
            {
                if (x[j] == x[i]) return true;
            }
            return false;
        }

        private void RedChoice_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            // Move the rectangle.
            if (WinCanvas.Visibility == Visibility.Collapsed)
            {
                dragTranslationRed.X += e.DeltaManipulation.Translation.X * 24 / 46;
                dragTranslationRed.Y += e.DeltaManipulation.Translation.Y * 24 / 46;
            }
        }

        private void BlackChoice_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            // Move the rectangle.
            if (WinCanvas.Visibility == Visibility.Collapsed)
            {
                dragTranslationBlack.X += e.DeltaManipulation.Translation.X * 24 / 46;
                dragTranslationBlack.Y += e.DeltaManipulation.Translation.Y * 24 / 46;
            }
        }

        private void BlueChoice_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            // Move the rectangle.
            if (WinCanvas.Visibility == Visibility.Collapsed)
            {
                dragTranslationBlue.X += e.DeltaManipulation.Translation.X * 24 / 46;
                dragTranslationBlue.Y += e.DeltaManipulation.Translation.Y * 24 / 46;
            }
        }

        private void PurpleChoice_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            // Move the rectangle.
            if (WinCanvas.Visibility == Visibility.Collapsed)
            {
                dragTranslationPurple.X += e.DeltaManipulation.Translation.X * 24 / 46;
                dragTranslationPurple.Y += e.DeltaManipulation.Translation.Y * 24 / 46;
            }
        }

        private void YellowChoice_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            // Move the rectangle.
            if (WinCanvas.Visibility == Visibility.Collapsed)
            {
                dragTranslationYellow.X += e.DeltaManipulation.Translation.X * 24 / 46;
                dragTranslationYellow.Y += e.DeltaManipulation.Translation.Y * 24 / 46;
            }
        }

        private void GreenChoice_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            // Move the rectangle.
            if (WinCanvas.Visibility == Visibility.Collapsed)
            {
                dragTranslationGreen.X += e.DeltaManipulation.Translation.X * 24 / 46;
                dragTranslationGreen.Y += e.DeltaManipulation.Translation.Y * 24 / 46;
            }
        }

        private void RedChoice_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            double x = dragTranslationRed.X + 412.0 + 30;
            var color = RedChoice.Fill;
            if (x <= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess11.Fill = color;
                        break;
                    case 2:
                        Guess21.Fill = color;
                        break;
                    case 3:
                        Guess31.Fill = color;
                        break;
                    case 4:
                        Guess41.Fill = color;
                        break;
                    case 5:
                        Guess51.Fill = color;
                        break;
                    case 6:
                        Guess61.Fill = color;
                        break;
                    case 7:
                        Guess71.Fill = color;
                        break;
                    case 8:
                        Guess81.Fill = color;
                        break;
                    case 9:
                        Guess91.Fill = color;
                        break;
                    case 10:
                        Guess101.Fill = color;
                        break;
                }
            }
            else if (x <= 147.5 && x >= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess12.Fill = color;
                        break;
                    case 2:
                        Guess22.Fill = color;
                        break;
                    case 3:
                        Guess32.Fill = color;
                        break;
                    case 4:
                        Guess42.Fill = color;
                        break;
                    case 5:
                        Guess52.Fill = color;
                        break;
                    case 6:
                        Guess62.Fill = color;
                        break;
                    case 7:
                        Guess72.Fill = color;
                        break;
                    case 8:
                        Guess82.Fill = color;
                        break;
                    case 9:
                        Guess92.Fill = color;
                        break;
                    case 10:
                        Guess102.Fill = color;
                        break;
                }
            }
            else if (x <= 217.5 && x >= 147.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess13.Fill = color;
                        break;
                    case 2:
                        Guess23.Fill = color;
                        break;
                    case 3:
                        Guess33.Fill = color;
                        break;
                    case 4:
                        Guess43.Fill = color;
                        break;
                    case 5:
                        Guess53.Fill = color;
                        break;
                    case 6:
                        Guess63.Fill = color;
                        break;
                    case 7:
                        Guess73.Fill = color;
                        break;
                    case 8:
                        Guess83.Fill = color;
                        break;
                    case 9:
                        Guess93.Fill = color;
                        break;
                    case 10:
                        Guess103.Fill = color;
                        break;
                }
            }
            else if (x <= 282.5 && x >= 217.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess14.Fill = color;
                        break;
                    case 2:
                        Guess24.Fill = color;
                        break;
                    case 3:
                        Guess34.Fill = color;
                        break;
                    case 4:
                        Guess44.Fill = color;
                        break;
                    case 5:
                        Guess54.Fill = color;
                        break;
                    case 6:
                        Guess64.Fill = color;
                        break;
                    case 7:
                        Guess74.Fill = color;
                        break;
                    case 8:
                        Guess84.Fill = color;
                        break;
                    case 9:
                        Guess94.Fill = color;
                        break;
                    case 10:
                        Guess104.Fill = color;
                        break;
                }
            }
            dragTranslationRed.X = 0;
            dragTranslationRed.Y = 0;
        }

        private void BlackChoice_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            double x = dragTranslationBlack.X + 412.0 + 30; ;
            var color = BlackChoice.Fill;
            if (x <= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess11.Fill = color;
                        break;
                    case 2:
                        Guess21.Fill = color;
                        break;
                    case 3:
                        Guess31.Fill = color;
                        break;
                    case 4:
                        Guess41.Fill = color;
                        break;
                    case 5:
                        Guess51.Fill = color;
                        break;
                    case 6:
                        Guess61.Fill = color;
                        break;
                    case 7:
                        Guess71.Fill = color;
                        break;
                    case 8:
                        Guess81.Fill = color;
                        break;
                    case 9:
                        Guess91.Fill = color;
                        break;
                    case 10:
                        Guess101.Fill = color;
                        break;
                }
            }
            else if (x <= 147.5 && x >= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess12.Fill = color;
                        break;
                    case 2:
                        Guess22.Fill = color;
                        break;
                    case 3:
                        Guess32.Fill = color;
                        break;
                    case 4:
                        Guess42.Fill = color;
                        break;
                    case 5:
                        Guess52.Fill = color;
                        break;
                    case 6:
                        Guess62.Fill = color;
                        break;
                    case 7:
                        Guess72.Fill = color;
                        break;
                    case 8:
                        Guess82.Fill = color;
                        break;
                    case 9:
                        Guess92.Fill = color;
                        break;
                    case 10:
                        Guess102.Fill = color;
                        break;
                }
            }
            else if (x <= 217.5 && x >= 147.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess13.Fill = color;
                        break;
                    case 2:
                        Guess23.Fill = color;
                        break;
                    case 3:
                        Guess33.Fill = color;
                        break;
                    case 4:
                        Guess43.Fill = color;
                        break;
                    case 5:
                        Guess53.Fill = color;
                        break;
                    case 6:
                        Guess63.Fill = color;
                        break;
                    case 7:
                        Guess73.Fill = color;
                        break;
                    case 8:
                        Guess83.Fill = color;
                        break;
                    case 9:
                        Guess93.Fill = color;
                        break;
                    case 10:
                        Guess103.Fill = color;
                        break;
                }
            }
            else if (x <= 282.5 && x >= 217.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess14.Fill = color;
                        break;
                    case 2:
                        Guess24.Fill = color;
                        break;
                    case 3:
                        Guess34.Fill = color;
                        break;
                    case 4:
                        Guess44.Fill = color;
                        break;
                    case 5:
                        Guess54.Fill = color;
                        break;
                    case 6:
                        Guess64.Fill = color;
                        break;
                    case 7:
                        Guess74.Fill = color;
                        break;
                    case 8:
                        Guess84.Fill = color;
                        break;
                    case 9:
                        Guess94.Fill = color;
                        break;
                    case 10:
                        Guess104.Fill = color;
                        break;
                }
            }
            dragTranslationBlack.X = 0;
            dragTranslationBlack.Y = 0;
        }

        private void BlueChoice_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            double x = dragTranslationBlue.X + 412.0 + 30; ;
            var color = BlueChoice.Fill;
            if (x <= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess11.Fill = color;
                        break;
                    case 2:
                        Guess21.Fill = color;
                        break;
                    case 3:
                        Guess31.Fill = color;
                        break;
                    case 4:
                        Guess41.Fill = color;
                        break;
                    case 5:
                        Guess51.Fill = color;
                        break;
                    case 6:
                        Guess61.Fill = color;
                        break;
                    case 7:
                        Guess71.Fill = color;
                        break;
                    case 8:
                        Guess81.Fill = color;
                        break;
                    case 9:
                        Guess91.Fill = color;
                        break;
                    case 10:
                        Guess101.Fill = color;
                        break;
                }
            }
            else if (x <= 147.5 && x >= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess12.Fill = color;
                        break;
                    case 2:
                        Guess22.Fill = color;
                        break;
                    case 3:
                        Guess32.Fill = color;
                        break;
                    case 4:
                        Guess42.Fill = color;
                        break;
                    case 5:
                        Guess52.Fill = color;
                        break;
                    case 6:
                        Guess62.Fill = color;
                        break;
                    case 7:
                        Guess72.Fill = color;
                        break;
                    case 8:
                        Guess82.Fill = color;
                        break;
                    case 9:
                        Guess92.Fill = color;
                        break;
                    case 10:
                        Guess102.Fill = color;
                        break;
                }
            }
            else if (x <= 217.5 && x >= 147.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess13.Fill = color;
                        break;
                    case 2:
                        Guess23.Fill = color;
                        break;
                    case 3:
                        Guess33.Fill = color;
                        break;
                    case 4:
                        Guess43.Fill = color;
                        break;
                    case 5:
                        Guess53.Fill = color;
                        break;
                    case 6:
                        Guess63.Fill = color;
                        break;
                    case 7:
                        Guess73.Fill = color;
                        break;
                    case 8:
                        Guess83.Fill = color;
                        break;
                    case 9:
                        Guess93.Fill = color;
                        break;
                    case 10:
                        Guess103.Fill = color;
                        break;
                }
            }
            else if (x <= 282.5 && x >= 217.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess14.Fill = color;
                        break;
                    case 2:
                        Guess24.Fill = color;
                        break;
                    case 3:
                        Guess34.Fill = color;
                        break;
                    case 4:
                        Guess44.Fill = color;
                        break;
                    case 5:
                        Guess54.Fill = color;
                        break;
                    case 6:
                        Guess64.Fill = color;
                        break;
                    case 7:
                        Guess74.Fill = color;
                        break;
                    case 8:
                        Guess84.Fill = color;
                        break;
                    case 9:
                        Guess94.Fill = color;
                        break;
                    case 10:
                        Guess104.Fill = color;
                        break;
                }
            }
            dragTranslationBlue.X = 0;
            dragTranslationBlue.Y = 0;
        }

        private void PurpleChoice_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            double x = dragTranslationPurple.X + 412.0 + 30; ;
            var color = PurpleChoice.Fill;
            if (x <= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess11.Fill = color;
                        break;
                    case 2:
                        Guess21.Fill = color;
                        break;
                    case 3:
                        Guess31.Fill = color;
                        break;
                    case 4:
                        Guess41.Fill = color;
                        break;
                    case 5:
                        Guess51.Fill = color;
                        break;
                    case 6:
                        Guess61.Fill = color;
                        break;
                    case 7:
                        Guess71.Fill = color;
                        break;
                    case 8:
                        Guess81.Fill = color;
                        break;
                    case 9:
                        Guess91.Fill = color;
                        break;
                    case 10:
                        Guess101.Fill = color;
                        break;
                }
            }
            else if (x <= 147.5 && x >= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess12.Fill = color;
                        break;
                    case 2:
                        Guess22.Fill = color;
                        break;
                    case 3:
                        Guess32.Fill = color;
                        break;
                    case 4:
                        Guess42.Fill = color;
                        break;
                    case 5:
                        Guess52.Fill = color;
                        break;
                    case 6:
                        Guess62.Fill = color;
                        break;
                    case 7:
                        Guess72.Fill = color;
                        break;
                    case 8:
                        Guess82.Fill = color;
                        break;
                    case 9:
                        Guess92.Fill = color;
                        break;
                    case 10:
                        Guess102.Fill = color;
                        break;
                }
            }
            else if (x <= 217.5 && x >= 147.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess13.Fill = color;
                        break;
                    case 2:
                        Guess23.Fill = color;
                        break;
                    case 3:
                        Guess33.Fill = color;
                        break;
                    case 4:
                        Guess43.Fill = color;
                        break;
                    case 5:
                        Guess53.Fill = color;
                        break;
                    case 6:
                        Guess63.Fill = color;
                        break;
                    case 7:
                        Guess73.Fill = color;
                        break;
                    case 8:
                        Guess83.Fill = color;
                        break;
                    case 9:
                        Guess93.Fill = color;
                        break;
                    case 10:
                        Guess103.Fill = color;
                        break;
                }
            }
            else if (x <= 282.5 && x >= 217.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess14.Fill = color;
                        break;
                    case 2:
                        Guess24.Fill = color;
                        break;
                    case 3:
                        Guess34.Fill = color;
                        break;
                    case 4:
                        Guess44.Fill = color;
                        break;
                    case 5:
                        Guess54.Fill = color;
                        break;
                    case 6:
                        Guess64.Fill = color;
                        break;
                    case 7:
                        Guess74.Fill = color;
                        break;
                    case 8:
                        Guess84.Fill = color;
                        break;
                    case 9:
                        Guess94.Fill = color;
                        break;
                    case 10:
                        Guess104.Fill = color;
                        break;
                }
            }
            dragTranslationPurple.X = 0;
            dragTranslationPurple.Y = 0;
        }

        private void YellowChoice_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            double x = dragTranslationYellow.X + 412.0 + 30; ;
            var color = YellowChoice.Fill;
            if (x <= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess11.Fill = color;
                        break;
                    case 2:
                        Guess21.Fill = color;
                        break;
                    case 3:
                        Guess31.Fill = color;
                        break;
                    case 4:
                        Guess41.Fill = color;
                        break;
                    case 5:
                        Guess51.Fill = color;
                        break;
                    case 6:
                        Guess61.Fill = color;
                        break;
                    case 7:
                        Guess71.Fill = color;
                        break;
                    case 8:
                        Guess81.Fill = color;
                        break;
                    case 9:
                        Guess91.Fill = color;
                        break;
                    case 10:
                        Guess101.Fill = color;
                        break;
                }
            }
            else if (x <= 147.5 && x >= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess12.Fill = color;
                        break;
                    case 2:
                        Guess22.Fill = color;
                        break;
                    case 3:
                        Guess32.Fill = color;
                        break;
                    case 4:
                        Guess42.Fill = color;
                        break;
                    case 5:
                        Guess52.Fill = color;
                        break;
                    case 6:
                        Guess62.Fill = color;
                        break;
                    case 7:
                        Guess72.Fill = color;
                        break;
                    case 8:
                        Guess82.Fill = color;
                        break;
                    case 9:
                        Guess92.Fill = color;
                        break;
                    case 10:
                        Guess102.Fill = color;
                        break;
                }
            }
            else if (x <= 217.5 && x >= 147.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess13.Fill = color;
                        break;
                    case 2:
                        Guess23.Fill = color;
                        break;
                    case 3:
                        Guess33.Fill = color;
                        break;
                    case 4:
                        Guess43.Fill = color;
                        break;
                    case 5:
                        Guess53.Fill = color;
                        break;
                    case 6:
                        Guess63.Fill = color;
                        break;
                    case 7:
                        Guess73.Fill = color;
                        break;
                    case 8:
                        Guess83.Fill = color;
                        break;
                    case 9:
                        Guess93.Fill = color;
                        break;
                    case 10:
                        Guess103.Fill = color;
                        break;
                }
            }
            else if (x <= 282.5 && x >= 217.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess14.Fill = color;
                        break;
                    case 2:
                        Guess24.Fill = color;
                        break;
                    case 3:
                        Guess34.Fill = color;
                        break;
                    case 4:
                        Guess44.Fill = color;
                        break;
                    case 5:
                        Guess54.Fill = color;
                        break;
                    case 6:
                        Guess64.Fill = color;
                        break;
                    case 7:
                        Guess74.Fill = color;
                        break;
                    case 8:
                        Guess84.Fill = color;
                        break;
                    case 9:
                        Guess94.Fill = color;
                        break;
                    case 10:
                        Guess104.Fill = color;
                        break;
                }
            }
            dragTranslationYellow.X = 0;
            dragTranslationYellow.Y = 0;
        }

        private void GreenChoice_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            double x = dragTranslationGreen.X + 412.0 + 30; ;
            var color = GreenChoice.Fill;
            if (x <= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess11.Fill = color;
                        break;
                    case 2:
                        Guess21.Fill = color;
                        break;
                    case 3:
                        Guess31.Fill = color;
                        break;
                    case 4:
                        Guess41.Fill = color;
                        break;
                    case 5:
                        Guess51.Fill = color;
                        break;
                    case 6:
                        Guess61.Fill = color;
                        break;
                    case 7:
                        Guess71.Fill = color;
                        break;
                    case 8:
                        Guess81.Fill = color;
                        break;
                    case 9:
                        Guess91.Fill = color;
                        break;
                    case 10:
                        Guess101.Fill = color;
                        break;
                }
            }
            else if (x <= 147.5 && x >= 82.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess12.Fill = color;
                        break;
                    case 2:
                        Guess22.Fill = color;
                        break;
                    case 3:
                        Guess32.Fill = color;
                        break;
                    case 4:
                        Guess42.Fill = color;
                        break;
                    case 5:
                        Guess52.Fill = color;
                        break;
                    case 6:
                        Guess62.Fill = color;
                        break;
                    case 7:
                        Guess72.Fill = color;
                        break;
                    case 8:
                        Guess82.Fill = color;
                        break;
                    case 9:
                        Guess92.Fill = color;
                        break;
                    case 10:
                        Guess102.Fill = color;
                        break;
                }
            }
            else if (x <= 217.5 && x >= 147.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess13.Fill = color;
                        break;
                    case 2:
                        Guess23.Fill = color;
                        break;
                    case 3:
                        Guess33.Fill = color;
                        break;
                    case 4:
                        Guess43.Fill = color;
                        break;
                    case 5:
                        Guess53.Fill = color;
                        break;
                    case 6:
                        Guess63.Fill = color;
                        break;
                    case 7:
                        Guess73.Fill = color;
                        break;
                    case 8:
                        Guess83.Fill = color;
                        break;
                    case 9:
                        Guess93.Fill = color;
                        break;
                    case 10:
                        Guess103.Fill = color;
                        break;
                }
            }
            else if (x <= 282.5 && x >= 217.5)
            {
                switch (turn)
                {
                    case 1:
                        Guess14.Fill = color;
                        break;
                    case 2:
                        Guess24.Fill = color;
                        break;
                    case 3:
                        Guess34.Fill = color;
                        break;
                    case 4:
                        Guess44.Fill = color;
                        break;
                    case 5:
                        Guess54.Fill = color;
                        break;
                    case 6:
                        Guess64.Fill = color;
                        break;
                    case 7:
                        Guess74.Fill = color;
                        break;
                    case 8:
                        Guess84.Fill = color;
                        break;
                    case 9:
                        Guess94.Fill = color;
                        break;
                    case 10:
                        Guess104.Fill = color;
                        break;
                }
            }
            dragTranslationGreen.X = 0;
            dragTranslationGreen.Y = 0;
        }

        private void Guess_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                tempAnswer[i] = colorAnswer[i];
            }
            switch (turn)
            {
                case 1:
                    if (notWhite(Guess11) && notWhite(Guess12) && notWhite(Guess13) && notWhite(Guess14))
                    {
                        int counter = 1;
                        if (correctFill(Guess11, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess12, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess13, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess14, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess11, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess12, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess13, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess14, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 2:
                    if (notWhite(Guess21) && notWhite(Guess22) && notWhite(Guess13) && notWhite(Guess24))
                    {
                        int counter = 1;
                        if (correctFill(Guess21, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess22, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess23, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess24, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess21, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess22, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess23, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess24, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 3:
                    if (notWhite(Guess31) && notWhite(Guess32) && notWhite(Guess33) && notWhite(Guess34))
                    {
                        int counter = 1;
                        if (correctFill(Guess31, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess32, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess33, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess34, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess31, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess32, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess33, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess34, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 4:
                    if (notWhite(Guess41) && notWhite(Guess42) && notWhite(Guess43) && notWhite(Guess44))
                    {
                        int counter = 1;
                        if (correctFill(Guess41, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess42, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess43, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess44, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess41, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess42, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess43, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess44, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 5:
                    if (notWhite(Guess51) && notWhite(Guess52) && notWhite(Guess53) && notWhite(Guess54))
                    {
                        int counter = 1;
                        if (correctFill(Guess51, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess52, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess53, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess54, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess51, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess52, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess53, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess54, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 6:
                    if (notWhite(Guess61) && notWhite(Guess62) && notWhite(Guess63) && notWhite(Guess64))
                    {
                        int counter = 1;
                        if (correctFill(Guess61, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess62, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess63, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess64, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess61, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess62, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess63, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess64, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 7:
                    if (notWhite(Guess71) && notWhite(Guess72) && notWhite(Guess73) && notWhite(Guess74))
                    {
                        int counter = 1;
                        if (correctFill(Guess71, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess72, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess73, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess74, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess71, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess72, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess73, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess74, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 8:
                    if (notWhite(Guess81) && notWhite(Guess82) && notWhite(Guess83) && notWhite(Guess84))
                    {
                        int counter = 1;
                        if (correctFill(Guess81, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess82, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess83, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess84, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess81, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess82, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess83, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess84, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 9:
                    if (notWhite(Guess91) && notWhite(Guess92) && notWhite(Guess93) && notWhite(Guess94))
                    {
                        int counter = 1;
                        if (correctFill(Guess91, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess92, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess93, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess94, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess91, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess92, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess93, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess94, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
                case 10:
                    if (notWhite(Guess101) && notWhite(Guess102) && notWhite(Guess103) && notWhite(Guess104))
                    {
                        int counter = 1;
                        if (correctFill(Guess101, 1))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess102, 2))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess103, 3))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (correctFill(Guess104, 4))
                        {
                            changeToCorrect(counter);
                            counter++;
                        }
                        if (counter == 5)
                        {
                            WinText.Text = "YOU WIN :)";
                            WinCanvas.Visibility = Visibility.Visible;
                            Reset.IsEnabled = false;
                            Guess.IsEnabled = false;
                        }
                        if (anyFill(Guess101, 1))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess102, 2))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess103, 3))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        if (anyFill(Guess104, 4))
                        {
                            changeToAlmost(counter);
                            counter++;
                        }
                        turn++;
                    }
                    break;
            }
            if (turn == 11)
            {
                WinText.Text = "You Lose :(";
                WinCanvas.Visibility = Visibility.Visible;
                Reset.IsEnabled = false;
                Guess.IsEnabled = false;
            }
        }

        private void changeToAlmost(int counter)
        {
            var colorToChangeTo = GrayLittle.Fill;
            switch (turn)
            {
                case 1:
                    switch (counter)
                    {
                        case 1:
                            Answer11.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer12.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer13.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer14.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 2:
                    switch (counter)
                    {
                        case 1:
                            Answer21.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer22.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer23.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer24.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 3:
                    switch (counter)
                    {
                        case 1:
                            Answer31.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer32.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer33.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer34.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 4:
                    switch (counter)
                    {
                        case 1:
                            Answer41.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer42.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer43.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer44.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 5:
                    switch (counter)
                    {
                        case 1:
                            Answer51.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer52.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer53.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer54.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 6:
                    switch (counter)
                    {
                        case 1:
                            Answer61.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer62.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer63.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer64.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 7:
                    switch (counter)
                    {
                        case 1:
                            Answer71.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer72.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer73.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer74.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 8:
                    switch (counter)
                    {
                        case 1:
                            Answer81.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer82.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer83.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer84.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 9:
                    switch (counter)
                    {
                        case 1:
                            Answer91.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer92.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer93.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer94.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 10:
                    switch (counter)
                    {
                        case 1:
                            Answer101.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer102.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer103.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer104.Fill = colorToChangeTo;
                            break;
                    }
                    break;
            }
        }

        private void changeToCorrect(int counter)
        {
            var colorToChangeTo = BlackLittle.Fill;
            switch (turn)
            {
                case 1:
                    switch (counter)
                    {
                        case 1:
                            Answer11.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer12.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer13.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer14.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 2:
                    switch (counter)
                    {
                        case 1:
                            Answer21.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer22.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer23.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer24.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 3:
                    switch (counter)
                    {
                        case 1:
                            Answer31.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer32.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer33.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer34.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 4:
                    switch (counter)
                    {
                        case 1:
                            Answer41.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer42.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer43.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer44.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 5:
                    switch (counter)
                    {
                        case 1:
                            Answer51.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer52.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer53.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer54.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 6:
                    switch (counter)
                    {
                        case 1:
                            Answer61.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer62.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer63.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer64.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 7:
                    switch (counter)
                    {
                        case 1:
                            Answer71.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer72.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer73.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer74.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 8:
                    switch (counter)
                    {
                        case 1:
                            Answer81.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer82.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer83.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer84.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 9:
                    switch (counter)
                    {
                        case 1:
                            Answer91.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer92.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer93.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer94.Fill = colorToChangeTo;
                            break;
                    }
                    break;
                case 10:
                    switch (counter)
                    {
                        case 1:
                            Answer101.Fill = colorToChangeTo;
                            break;
                        case 2:
                            Answer102.Fill = colorToChangeTo;
                            break;
                        case 3:
                            Answer103.Fill = colorToChangeTo;
                            break;
                        case 4:
                            Answer104.Fill = colorToChangeTo;
                            break;
                    }
                    break;
            }
        }

        private bool anyFill(Rectangle a, int i)
        {
            if (tempAnswer.Contains(1) && a.Fill == RedChoice.Fill)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tempAnswer[j] == 1)
                    {
                        tempAnswer[j] = 0; break;
                    }
                }
                return true;
            }
            if (tempAnswer.Contains(2) && a.Fill == BlackChoice.Fill)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tempAnswer[j] == 2)
                    {
                        tempAnswer[j] = 0; break;
                    }
                }
                return true;
            }
            if (tempAnswer.Contains(3) && a.Fill == BlueChoice.Fill)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tempAnswer[j] == 3)
                    {
                        tempAnswer[j] = 0; break;
                    }
                }
                return true;
            }
            if (tempAnswer.Contains(4) && a.Fill == PurpleChoice.Fill)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tempAnswer[j] == 4)
                    {
                        tempAnswer[j] = 0; break;
                    }
                }
                return true;
            }
            if (tempAnswer.Contains(5) && a.Fill == YellowChoice.Fill)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tempAnswer[j] == 5)
                    {
                        tempAnswer[j] = 0; break;
                    }
                }
                return true;
            }
            if (tempAnswer.Contains(6) && a.Fill == GreenChoice.Fill)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tempAnswer[j] == 6)
                    {
                        tempAnswer[j] = 0; break;
                    }
                }
                return true;
            }
            return false;
        }

        private bool correctFill(Rectangle a, int i)
        {
            if (tempAnswer[i - 1] == 1 && a.Fill == RedChoice.Fill)
            {
                tempAnswer[i - 1] = 0;
                return true;
            }
            if (tempAnswer[i - 1] == 2 && a.Fill == BlackChoice.Fill)
            {
                tempAnswer[i - 1] = 0;
                return true;
            }
            if (tempAnswer[i - 1] == 3 && a.Fill == BlueChoice.Fill)
            {
                tempAnswer[i - 1] = 0;
                return true;
            }
            if (tempAnswer[i - 1] == 4 && a.Fill == PurpleChoice.Fill)
            {
                tempAnswer[i - 1] = 0;
                return true;
            }
            if (tempAnswer[i - 1] == 5 && a.Fill == YellowChoice.Fill)
            {
                tempAnswer[i - 1] = 0;
                return true;
            }
            if (tempAnswer[i - 1] == 6 && a.Fill == GreenChoice.Fill)
            {
                tempAnswer[i - 1] = 0;
                return true;
            }
            return false;
        }

        private bool notWhite(Rectangle a)
        {
            if (a.Fill == RedChoice.Fill) return true;
            if (a.Fill == BlackChoice.Fill) return true;
            if (a.Fill == BlueChoice.Fill) return true;
            if (a.Fill == PurpleChoice.Fill) return true;
            if (a.Fill == YellowChoice.Fill) return true;
            if (a.Fill == GreenChoice.Fill) return true;
            return false;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            turn = 1;
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                colorAnswer[i] = rand.Next(6) + 1;
                while (invalid(colorAnswer, i))
                    colorAnswer[i] = rand.Next(6) + 1;
            }
            Guess11.Fill = WhiteExample.Fill;
            Guess12.Fill = WhiteExample.Fill;
            Guess13.Fill = WhiteExample.Fill;
            Guess14.Fill = WhiteExample.Fill;
            Guess21.Fill = WhiteExample.Fill;
            Guess22.Fill = WhiteExample.Fill;
            Guess23.Fill = WhiteExample.Fill;
            Guess24.Fill = WhiteExample.Fill;
            Guess31.Fill = WhiteExample.Fill;
            Guess32.Fill = WhiteExample.Fill;
            Guess33.Fill = WhiteExample.Fill;
            Guess34.Fill = WhiteExample.Fill;
            Guess41.Fill = WhiteExample.Fill;
            Guess42.Fill = WhiteExample.Fill;
            Guess43.Fill = WhiteExample.Fill;
            Guess44.Fill = WhiteExample.Fill;
            Guess51.Fill = WhiteExample.Fill;
            Guess52.Fill = WhiteExample.Fill;
            Guess53.Fill = WhiteExample.Fill;
            Guess54.Fill = WhiteExample.Fill;
            Guess61.Fill = WhiteExample.Fill;
            Guess62.Fill = WhiteExample.Fill;
            Guess63.Fill = WhiteExample.Fill;
            Guess64.Fill = WhiteExample.Fill;
            Guess71.Fill = WhiteExample.Fill;
            Guess72.Fill = WhiteExample.Fill;
            Guess73.Fill = WhiteExample.Fill;
            Guess74.Fill = WhiteExample.Fill;
            Guess81.Fill = WhiteExample.Fill;
            Guess82.Fill = WhiteExample.Fill;
            Guess83.Fill = WhiteExample.Fill;
            Guess84.Fill = WhiteExample.Fill;
            Guess91.Fill = WhiteExample.Fill;
            Guess92.Fill = WhiteExample.Fill;
            Guess93.Fill = WhiteExample.Fill;
            Guess94.Fill = WhiteExample.Fill;
            Guess101.Fill = WhiteExample.Fill;
            Guess102.Fill = WhiteExample.Fill;
            Guess103.Fill = WhiteExample.Fill;
            Guess104.Fill = WhiteExample.Fill;
            Answer11.Fill = WhiteLittle.Fill;
            Answer12.Fill = WhiteLittle.Fill;
            Answer13.Fill = WhiteLittle.Fill;
            Answer14.Fill = WhiteLittle.Fill;
            Answer21.Fill = WhiteLittle.Fill;
            Answer22.Fill = WhiteLittle.Fill;
            Answer23.Fill = WhiteLittle.Fill;
            Answer24.Fill = WhiteLittle.Fill;
            Answer31.Fill = WhiteLittle.Fill;
            Answer32.Fill = WhiteLittle.Fill;
            Answer33.Fill = WhiteLittle.Fill;
            Answer34.Fill = WhiteLittle.Fill;
            Answer41.Fill = WhiteLittle.Fill;
            Answer42.Fill = WhiteLittle.Fill;
            Answer43.Fill = WhiteLittle.Fill;
            Answer44.Fill = WhiteLittle.Fill;
            Answer51.Fill = WhiteLittle.Fill;
            Answer52.Fill = WhiteLittle.Fill;
            Answer53.Fill = WhiteLittle.Fill;
            Answer54.Fill = WhiteLittle.Fill;
            Answer61.Fill = WhiteLittle.Fill;
            Answer62.Fill = WhiteLittle.Fill;
            Answer63.Fill = WhiteLittle.Fill;
            Answer64.Fill = WhiteLittle.Fill;
            Answer71.Fill = WhiteLittle.Fill;
            Answer72.Fill = WhiteLittle.Fill;
            Answer73.Fill = WhiteLittle.Fill;
            Answer74.Fill = WhiteLittle.Fill;
            Answer81.Fill = WhiteLittle.Fill;
            Answer82.Fill = WhiteLittle.Fill;
            Answer83.Fill = WhiteLittle.Fill;
            Answer84.Fill = WhiteLittle.Fill;
            Answer91.Fill = WhiteLittle.Fill;
            Answer92.Fill = WhiteLittle.Fill;
            Answer93.Fill = WhiteLittle.Fill;
            Answer94.Fill = WhiteLittle.Fill;
            Answer101.Fill = WhiteLittle.Fill;
            Answer102.Fill = WhiteLittle.Fill;
            Answer103.Fill = WhiteLittle.Fill;
            Answer104.Fill = WhiteLittle.Fill;
            WinCanvas.Visibility = Visibility.Collapsed;
            canvas1.Visibility = Visibility.Collapsed;
        }

        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            Reset.IsEnabled = true;
            Guess.IsEnabled = true;
            Reset_Click(sender, e);
        }
    }
}