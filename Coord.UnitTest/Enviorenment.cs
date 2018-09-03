using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coord.UnitTest
{
    [TestClass]
   public  class Enviorenment
    {
    
        [AssemblyInitialize]
        public static void BeforeClass(TestContext tc)
        {
          TollsClient.Key= "Your_API_KEY";

        }

    }
}
