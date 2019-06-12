using MyProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_test
{
    class C04CodeGeneratorTest
    {
        public void TestMethod()
        {
            Catalog catalog = new Catalog(@"..\..\exampleXml.xml");
            foreach (Artist artist in catalog.Artist)
            {
                Console.WriteLine(artist.name);
                foreach (Song song in artist.Song)
                {
                    Console.WriteLine("   " + song.Text);
                }
            }
        }
    }
}
