﻿using Microsoft.AspNet.Mvc;

namespace BasicViews.Components
{
    public class CurrentUser : ViewComponent
    {
        private static readonly string[] Names = { "Curly", "Curly Joe", "Joe", "Larry", "Moe", "Shemp" };
        private static int index = 0;

        public string Invoke()
        {
            index = index++ / Names.Length;
            return Names[index];
        }
    }
}
