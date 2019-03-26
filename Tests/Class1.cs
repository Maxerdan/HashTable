using System;
using System.Collections.Generic;
using System.Text;
using HashTable;
using NUnit.Framework;

namespace HashTable
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PutAndSearch3Elements()
        {
            var pair = new HashTable(3);
            for (int i = 0; i < 3; i++)
            {
                pair.PutPair(i.GetHashCode(), i);
            }
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(i, pair.GetValueByKey(i.GetHashCode()));
            }
        }

        [Test]
        public void TwoSimilarKey()
        {
            var pair = new HashTable(2);
            for (int i = 0; i < 2; i++)
            {
                pair.PutPair(1, i*42);
            }
            Assert.AreEqual(42, pair.GetValueByKey(1));
        }

        [Test]
        public void Put10000AndFind1()
        {
            var pair = new HashTable(10000);
            for (int i = 0; i < 10000; i++)
            {
                pair.PutPair(i, i * 42);
            }
            Assert.AreEqual(126, pair.GetValueByKey(3));
        }

        [Test]
        public void Put10000AndFind1000NotPutKey()
        {
            var pair = new HashTable(10000);
            for (int i = 0; i < 10000; i++)
            {
                pair.PutPair((i * 10000).ToString(), i);
            }
            for(int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(null, pair.GetValueByKey(i));
            }
        }
    }
}
