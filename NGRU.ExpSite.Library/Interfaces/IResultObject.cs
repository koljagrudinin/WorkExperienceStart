namespace NGRU.ExpSite.Library.Interfaces
{
	public interface IResultObject
	{
		bool IsSuccess { get;  }

		string[] Errors { get; }
		string GetErrorsText();
	}
}