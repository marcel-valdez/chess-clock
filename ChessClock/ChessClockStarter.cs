using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace ChessClock
{
    class ChessClockStarter
    {
        [STAThread]
        public static void Main(params string[] args)
        {
            var clock = new ChessClock();
            Application.Run(clock);
        }
    }
}
