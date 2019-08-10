﻿using CodeRunner.Templates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Linq;

namespace Test.Core.Templates
{
    [TestClass]
    public class TVariable
    {
        [TestMethod]
        public void Basic()
        {
            Variable v = new Variable("v");
            Assert.IsTrue(v.Equals(new Variable("v") as object));
            Assert.ThrowsException<NullReferenceException>(() => v.GetDefault());
        }

        [TestMethod]
        public void Collection()
        {
            VariableCollection variables = new VariableCollection
            {
                new Variable("var"),
                new Variable("var"),
                new Variable("var2")
            };
            Assert.IsFalse(variables.IsReadOnly);
            Assert.AreEqual(2, variables.Count);
            {
                Variable[] arr = new Variable[variables.Count];
                variables.CopyTo(arr, 0);
                foreach (object v in ((IEnumerable)arr))
                {
                    Assert.IsTrue(arr.Contains(v));
                }
            }
            Assert.IsTrue(variables.Contains(new Variable("var2")));
            Assert.IsTrue(variables.Remove(new Variable("var2")));
            Assert.AreEqual(1, variables.Count);
            variables.Clear();
            StringTemplate st = new StringTemplate("abc", new[] { new Variable("A") });
            variables.Collect(new[] { st });
            Assert.IsTrue(variables.Contains(new Variable("A")));
        }

        [TestMethod]
        public void Readonly()
        {
            Variable v = new Variable("v").Required().NotRequired("v").ReadOnly();
            Assert.ThrowsException<Exception>(() => v.Required());
            Assert.ThrowsException<Exception>(() => v.NotRequired(null));
            Assert.ThrowsException<Exception>(() => v.IsReadOnly = false);
            Assert.ThrowsException<Exception>(() => v.IsRequired = false);
            Assert.ThrowsException<Exception>(() => v.Name = "n");
        }
    }
}