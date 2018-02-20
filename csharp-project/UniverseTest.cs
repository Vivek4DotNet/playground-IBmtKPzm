﻿using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.IO;

namespace TechIo
{
    [TestClass]
    public class UniverseTest
    {
	[TestMethod]
	public void testSIMD_AVXonCSharp() 
	{
		UniverseStub.run_SIMD_AVX_on_CSharp();
	}
    }
}
