namespace DI.dotnet.Services
{
    public interface IScopeService
    {
        void Test(string text);
    }

    public class ScopeService : IScopeService
    {
        // public ScopeService()
        // {
        //     System.Console.WriteLine(nameof(ScopeService));
        // }
        readonly ITransientService _transientService;

        public ScopeService(ITransientService transientService)
        {
            this._transientService = transientService;
            System.Console.WriteLine(nameof(ScopeService));
        }

        public void Test(string text)
        {
            System.Console.WriteLine(text);
            _transientService.Test2("scope call transient");
        }
    }
}