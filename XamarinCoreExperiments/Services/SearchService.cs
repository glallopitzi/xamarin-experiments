using System;

namespace XamarinCoreExperiments
{
	public class SearchService : ISearchService
	{
		public SearchService ()
		{
		}

		#region ISearchService implementation
		public System.Collections.Generic.List<Advert> search (string what, string where)
		{
			return fakeSearch (what, where);
		}

		System.Collections.Generic.List<Advert> fakeSearch (string what, string where)
		{
			System.Collections.Generic.List<Advert> result = new System.Collections.Generic.List<Advert> ();
			result.Add (new Advert());
			result.Add (new Advert());
			result.Add (new Advert());
			result.Add (new Advert());
			result.Add (new Advert());

			return result;
		}
		#endregion
	}
}

