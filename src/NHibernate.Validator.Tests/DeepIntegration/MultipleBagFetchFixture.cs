using System.Collections;
using System.Collections.Generic;
using NHibernate.Collection;
using NUnit.Framework;

namespace NHibernate.Validator.Tests.DeepIntegration
{
	[TestFixture]
	public class MultipleBagFetchFixture : AbstractMultipleCollectionFixture
	{
		protected override IList Mappings
		{
			get { return new string[] { "DeepIntegration.PersonBag.hbm.xml" }; }
		}

		protected override void AddToCollection(ICollection<Person> collection, Person person)
		{
			collection.Add(person);
		}

		protected override ICollection<Person> GCreateCollection()
		{
			return new List<Person>();
		}
	}
}