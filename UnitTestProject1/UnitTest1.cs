using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using BakeryTemp;
using Assert = Xunit.Assert;
using System.Collections.Generic;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            TConv myconverter = new TConv(212);
            double result = myconverter.Degc;
            Assert.Equal(100.0, result, 0.5);
        }
        [Fact]
        public void TestMethod2()
        {
            TConv myconverter = new TConv(160);
            double result = myconverter.Degc;
            Assert.Equal((160 - 32) / 9.0 * 5.0, result, 0.5);
        }

        [Fact]
        public void TestMethod3()
        {
            TConv myconverter = new TConv(160.5);
            double result = myconverter.Degc;
            Assert.Equal((160.5 - 32) / 9.0 * 5.0, result, 0.5);
        }

        [Fact]

        public void TestMethod4()
        {
            List<TConv> templist = new List<TConv>{};
            double testtotal =0 ;
            for (int i = 0; i < 300; i+= 10)
            {
                templist.Add(new TConv(i));
                testtotal += i;
            }
            testtotal = testtotal / 30;
            TAvg Avg = new TAvg();
            TConv average = Avg.Average(templist);
            Assert.Equal(testtotal, average.Degf);

        }
    }
}

