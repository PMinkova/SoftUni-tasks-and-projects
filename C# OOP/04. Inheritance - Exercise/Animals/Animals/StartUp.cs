﻿using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main()
        {
            try
            {
                Engine engine = new Engine();
                engine.Run();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
