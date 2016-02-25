﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DLaB.Xrm.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using XrmUnitTest.Test;

namespace DLaB.Xrm.Test.Tests
{
    [TestClass]
    public class EntityDependencyTests
    {

        #region Add_MultipleDependencies_Should_CreateValidCreationOrder

        [TestMethod]
        public void EntityDependency_Add_MultipleDependencies_Should_CreateValidCreationOrder()
        {
            new Add_MultipleDependencies_Should_CreateValidCreationOrder().Test();
        }

        // ReSharper disable once InconsistentNaming
        private class Add_MultipleDependencies_Should_CreateValidCreationOrder : TestMethodClassBase
        {


            protected override void InitializeTestData(IOrganizationService service)
            {
                // No Data Required
            }

            protected override void Test(IOrganizationService service)
            {
                var constructorInfo = typeof(EntityDependency).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                var a = Account.EntityLogicalName;
                var b = Lead.EntityLogicalName;
                var c = Contact.EntityLogicalName;

                // Test in this manner:
                /*
                    a,b,c
                    a,c,b
                    b,a,c
                    b,c,a
                    c,a,b
                    c,b,a
                */

                TestAdditionOrder(constructorInfo, a, b, c);
                TestAdditionOrder(constructorInfo, a, c, b);
                TestAdditionOrder(constructorInfo, b, a, c);
                TestAdditionOrder(constructorInfo, b, c, a);
                TestAdditionOrder(constructorInfo, c, a, b);
                TestAdditionOrder(constructorInfo, c, b, a);

            }

            private static void TestAdditionOrder(ConstructorInfo constructorInfo, string first, string second, string third)
            {
                //
                // Arrange
                //
                var mapper = (EntityDependency) constructorInfo.Invoke(null);

                //
                // Act
                //
                mapper.Add(first);
                mapper.Add(second);
                mapper.Add(third);

                //
                // Assert
                //
                var order = mapper.EntityCreationOrder.ToArray();
                var accountDependencies = new List<string> {Account.Fields.ParentAccountId, Account.Fields.PrimaryContactId, Account.Fields.MasterId, Account.Fields.OriginatingLeadId};
                var contactDependencies = new List<string> {Contact.Fields.MasterId, Contact.Fields.OriginatingLeadId, Contact.Fields.ParentCustomerId};
                var leadDependencies = new List<string> {Lead.Fields.CustomerId, Lead.Fields.CustomerId, Lead.Fields.MasterId, Lead.Fields.ParentAccountId, Lead.Fields.ParentContactId};
                AssertDependencies(order[0], accountDependencies, contactDependencies, leadDependencies);
                AssertDependencies(order[1], accountDependencies, contactDependencies, leadDependencies);
                AssertDependencies(order[2], accountDependencies, contactDependencies, leadDependencies);
            }

            private static void AssertDependencies(EntityDependencyInfo entity, List<string> accountDependencies, List<string> contactDependencies, List<string> leadDependencies)
            {
                switch (entity.LogicalName)
                {
                    case Account.EntityLogicalName:
                        Assert.AreEqual(ConvertToString(entity.CyclicAttributes), ConvertToString(accountDependencies), "Account's Cyclic Dependencies didn't match expected.");
                        contactDependencies.Remove(Contact.Fields.AccountId);
                        leadDependencies.Remove(Lead.Fields.CustomerId);
                        leadDependencies.Remove(Lead.Fields.ParentAccountId);
                        break;

                    case Contact.EntityLogicalName:
                        Assert.AreEqual(ConvertToString(entity.CyclicAttributes), ConvertToString(contactDependencies), "Contacts's Cyclic Dependencies didn't match expected.");
                        accountDependencies.Remove(Account.Fields.PrimaryContactId);
                        leadDependencies.Remove(Lead.Fields.CustomerId);
                        leadDependencies.Remove(Lead.Fields.ParentContactId);
                        break;

                    case Lead.EntityLogicalName:
                        Assert.AreEqual(ConvertToString(entity.CyclicAttributes), ConvertToString(leadDependencies), "Lead's Cyclic Dependencies didn't match expected.");
                        accountDependencies.Remove(Account.Fields.OriginatingLeadId);
                        contactDependencies.Remove(Contact.Fields.OriginatingLeadId);
                        break;
                }
            }

            private static string ConvertToString(IEnumerable<string> value) { return string.Join(", ", value.Distinct().OrderBy(v =>v)); }
        }

        #endregion Add_MultipleDependencies_Should_CreateValidCreationOrder
    }
}
