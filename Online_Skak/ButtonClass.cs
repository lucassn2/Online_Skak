﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Online_Skak
{
    public abstract class ButtonClass
    {
 
        protected MainWindow Form = Application.Current.Windows[0] as MainWindow;

        protected bool KnightMove(int row, int col, int desiredRow, int desiredCol)
        {
            int tempRow = (Math.Abs(desiredRow - row));
            int tempCol = (Math.Abs(desiredCol - col));
            if (tempRow == 2 && tempCol == 1)
            {
                return true;
            }
            else if (tempCol == 2 && tempRow == 1)
            {
                return true;
            }
            return false;
        }

        protected bool KingMove(int row, int col, int desiredRow, int desiredCol)
        {
            int tempRow = (Math.Abs(desiredRow - row));
            int tempCol = (Math.Abs(desiredCol - col));
            if (tempRow == tempCol && tempRow < 2)
            {
                return true;
            }
            else if ((desiredCol == col || desiredRow == row) && (tempRow < 2 && tempCol < 2))
            {
                return true;
            }

             return false;
        }

        //Sets the button in the grid according to the desired position.
        protected void SetButtonPosition(Button button, int row, int column)
        {
            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);
        }

        //Sets the name of a button.
        protected void SetButtonName(Button button, string s)
        {
            button.Name = s;
        }

        //Sets the content of a button.
        protected void SetButtonContent(Button button, int counter)
        {
            string counterString = counter.ToString();
            button.Content = counterString;
        }

        //Sets the fore- and background color of a button.
        protected void SetColor(Button button, Color colorFG, Color colorBG)
        {
            button.Background = new SolidColorBrush(colorBG);
            button.Foreground = new SolidColorBrush(colorFG);
        }

        //Sets the fore- and background color of a button that is created at the start of the game.
        protected void SetDefaultButtonColor(Button button, int i, int j)
        {
            bool defaultButtonIsWhite = (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);
            if (defaultButtonIsWhite)
            {
                SetColor(button, Colors.White, Colors.Black);
            }
            else
            {
                SetColor(button, Colors.Black, Colors.White);
            }
        }
    }
}
