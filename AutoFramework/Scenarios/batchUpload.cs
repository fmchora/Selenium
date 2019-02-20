using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoFramework
{
    class batchUpload
    {
        List<string> story = new List<string>();
        string text;
        [OneTimeSetUp]
        public void Initialize()
        {
            //Actions.InitializeDriver("https://www.google.com/");
            text = "This is the story of how I learned to use lambda functions. This is just text in a string and it will be converted into a list";
        }

        [TestCase]
        public void readFile()
        {
            string[] test = text.Split(' ');
            story = test.Where((t) => t.Equals("is")).ToList();
            var containsWord = test.Count(t => t.Equals("is")) != 0;

            story = test.ToList();
            //story = story.Where(t => t.Equals("is")).Select(s => { s = "Felipe"; return s; }).ToList();
            //story = story.Select(s => { if(s == "is") s = "Felipe"; return s; }).ToList();
            story = story.Select(s => { s = s == "is" ? s = "Felipe" : s; return s; }).ToList();
        }


        [TestCase]
        public void writeFile()
        {

        }

        [TestCase]
        public void saveFile()
        {
             
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
           // Driver.driver.Quit();
        }
    }
}
