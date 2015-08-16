using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Mines.Core
{
   public class Board
   {
      List<Cell>[][] _cells;
      int _size;
      Window _mainWindow;
      Grid _gridBoard;      

      public Board(int size, Window mainWindow)
      {
         _mainWindow = mainWindow;
         _size = size;
         _cells = new List<Cell>[_size][];
         _gridBoard = GetGrid();

         for (int xCol = 0; xCol < _size; xCol++)
         {
            ColumnDefinition col = new ColumnDefinition();            
            _gridBoard.ColumnDefinitions.Add(col);
            RowDefinition row = new RowDefinition();
            _gridBoard.RowDefinitions.Add(row);
            for (int yRow = 0; yRow < _size; yRow++)
            {               
               Cell cell = new Cell(xCol, yRow);
               Grid.SetColumn(cell.Btn, xCol); 
               Grid.SetRow(cell.Btn, yRow);                    
               _gridBoard.Children.Add(cell.Btn);
            }
         }

         _mainWindow.Content = _gridBoard; 
      }

      private Grid GetGrid()
      {
         Grid gridBoard = new Grid();

         gridBoard.Width = 900;
         gridBoard.Height = 600;
         gridBoard.ShowGridLines = true;
         gridBoard.Background = Brushes.Beige; 

         return gridBoard;
      }
   }
}
