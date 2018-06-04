using Microsoft.VisualStudio.TestTools.UnitTesting;
using My.Models;
using My.Serializer;
using System;

namespace My.Serializer.Benchmark
{
    [TestClass]
    public class Benchmark
    {
        [TestMethod]
        public void BenchmarkJson()
        {
            DoBenchmark(new Json.Serializer());
        }

        [TestMethod]
        public void BenchmarkNewtonsoftJson()
        {
            DoBenchmark(new NewtonsoftJson.Serializer());
        }

        [TestMethod]
        public void BenchmarkProtoBuf()
        {
            DoBenchmark(new ProtoBuf.Serializer());
        }

        private void DoBenchmark(ISerializer serializer)
        {
            DoBenchmark(serializer, FamilyFactory());
        }

        private void DoBenchmark(ISerializer serializer, Family family)
        {
            const int Iterations = 10000;
            var workingObj = family;

            //int size;
            //var obj = serializer.Serialize(family);
            //if (obj is string strData)
            //    size = strData.Length;
            //else if (obj is byte[] binData)
            //    size = binData.Length;
            //else
            //    size = 0;

            for (int i = 0; i < Iterations; i++)
            {
                workingObj = serializer.Deserialize<Family>(serializer.Serialize(family));
                workingObj = serializer.Deserialize<Family>(serializer.Serialize(family));
                workingObj = serializer.Deserialize<Family>(serializer.Serialize(family));
                workingObj = serializer.Deserialize<Family>(serializer.Serialize(family));
            }
        }

        private Family FamilyFactory()
        {
            var userParent = new User()
            {
                Id = new Random().Next(),
                Gender = GenderType.Other,
                Name = "Parent user"
            };

            userParent.Phones.Add(new PhoneNumber()
            {
                Type = PhoneType.Work,
                Number = "+44 (0) 1234 567890"
            });

            var family = new Family
            {
                Parent = userParent
            };
            family.Children.AddRange(new User[]
            {
                new User()
                {
                    Id = new Random().Next(),
                    Gender = GenderType.Male,
                    Name = "Child 1"
                },

                new User()
                {
                    Id = new Random().Next(),
                    Gender = GenderType.Female,
                    Name = "Child 2"
                }
            });

            return family;
        }
    }
}
