// ******************************************************************************************************************
//  Shape Calculator - to calculate attributes of a shape to determine its type
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace TestLab
{
    /// <summary>
    /// LocaleTests Class - to assist in generating localization files.
    /// </summary>
    [TestClass]
    public class LocaleTests
    {
        [TestMethod]
        public void LocaleToXML()
        {
            //NOTE: I STARTED TO IMPLEMENT FUNCTIONALITY FOR INTERNATIONALIZATION, BUT RAN OUT OF TIME.
            //THIS WAS A FEATURE NOT LISTED IN THE REQURIEMENTS, SO MAYBE IT COULD BE INCLUDED IN THE NEXT RELEASE ;)

            //Save startup project path
            string solutiondir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //Save path to Localization directory
            string path = solutiondir + @"\Calculator\bin\Debug\Localization\";

            //Create xml root element
            XElement root = new XElement("root");

            //LICENSE - read data from text file and add to xml
            String[] data = File.ReadAllLines(path + "License.txt");
            XElement License = new XElement("License",
                                        from item in data
                                        select new XElement("Line", item));
            root.Add(License);

            //Save xml to file
            root.Save(path + "License.Xml");
        } // end method LocaleToXML()
    } // end class LocaleTests
} // end namespace TestLab
