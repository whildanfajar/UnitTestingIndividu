using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    class TestCase
    {
        [TestCase]
        public void User()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual("WhildanFajar", mtk.User("Whildan"));
        }

        [TestCase]
        public void Tambah()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual(31, mtk.Tambah(20, 11));
        }

        [TestCase]
        public void Kurang()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual(9, mtk.Kurang(20, 11));
        }
    }
}
