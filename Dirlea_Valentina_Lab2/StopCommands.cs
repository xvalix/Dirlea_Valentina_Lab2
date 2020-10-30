﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dirlea_Valentina_Lab2.CustomCommands


{
    class StopCommands
    {
    
   
   
            private static RoutedUICommand launch_command;
            static StopCommands()
            {
                InputGestureCollection myInputGestures = new InputGestureCollection();
                myInputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
                launch_command = new RoutedUICommand("Launch", "Launch",
               typeof(StopCommands), myInputGestures);
            }
            public static RoutedUICommand Launch
            {
                get
                {
                    return launch_command;
                }
            }
        
    }
}
