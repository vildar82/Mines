using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Mines.Core
{
   public class Cell
   {      
      int _xCol;
      int _yRow;
      Button _btn;

      public Button Btn
      {
         get { return _btn; }
      }

      public Cell(int xCol, int yRow)
      {         
         _xCol = xCol;
         _yRow = yRow;
         CreateButton();
      }

      private void CreateButton ()
      {
         _btn = new Button();         
         _btn.HorizontalAlignment = HorizontalAlignment.Stretch;
         _btn.VerticalAlignment = VerticalAlignment.Stretch;
         _btn.Content = "x=" + _xCol.ToString() + " y=" + _yRow.ToString();
         _btn.Click += _btn_Click;         
      }

      private void _btn_Click(object sender, RoutedEventArgs e)
      {
         int x = _xCol;
      }
   }
}
