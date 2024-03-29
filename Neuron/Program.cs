﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace Neuron
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form2 container = new Form2();
            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new Form1
                    {
                        Text = "New Tab"
                    }
                }
            );
            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            Form1 main = new Form1();

            // --------------------------------------------------

            // IMPORTANT: Enable Experimental Tabs
            bool EnableTabs = false;

            // Enable Experimental Proxies
            bool UseProxies = true;

            // --------------------------------------------------

            if (UseProxies)
            {

            }
            else
            {

            }

            if (EnableTabs)
            {
                applicationContext.Start(container);
            }
            else
            {
                Application.Run(main);
            }
        }
    }
}
