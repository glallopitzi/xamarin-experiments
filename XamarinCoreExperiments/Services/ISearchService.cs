using System;
using System.Collections.Generic;

namespace XamarinCoreExperiments
{
	public interface ISearchService
	{
		List<Advert> search (string what, string where);
	}
}

