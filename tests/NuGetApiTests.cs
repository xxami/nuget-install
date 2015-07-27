
using System;
using NUnit.Framework;
using NuGetInstall;

namespace NuGetInstallTests
{
    [TestFixture]
    public class NuGetApiTest
    {

        [Test]
        public void TestConstructWithValidApiVersion()
        {
            try
            {
                var v1 = new NuGetApi((NuGetApi.Version) 1);
                var v2 = new NuGetApi((NuGetApi.Version) 2);
                var v3 = new NuGetApi((NuGetApi.Version) 3);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void TestConstructWithInvalidApiVersion()
        {
            var exceptionsThrown = 0;
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    var v = new NuGetApi((NuGetApi.Version) i);
                }
                catch (Exception)
                {
                    exceptionsThrown += 1;
                }
            }
            Assert.AreEqual(exceptionsThrown, 2);
        }

    }
}
