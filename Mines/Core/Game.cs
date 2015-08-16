using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mines.Core
{
   public class Game
   {
      Window _mainWindow;
      public Game (Window mainWindow)
      {
         _mainWindow = mainWindow;
      }

      public void New()
      {
         Options opt = new Options();
         Board board = new Board(opt.Size, _mainWindow);
      }
   }
}
