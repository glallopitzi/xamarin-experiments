using Cirrious.MvvmCross.ViewModels;

namespace XamarinCoreExperiments.ViewModels
{
    public class SearchViewModel 
		: MvxViewModel
    {

		private ISearchService searchService;

		public SearchViewModel(ISearchService searchService){
			this.searchService = searchService;
		}

    }
}
