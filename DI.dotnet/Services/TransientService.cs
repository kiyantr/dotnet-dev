namespace DI.dotnet.Services
{
    public interface ITransientService
    {
        void Test(string text);
        void Test2(string text);
    }

    public class TransientService : ITransientService
    {
        readonly IScopeService _scopeService;
        // public TransientService(IScopeService scopeService)
        // {
        //     this._scopeService = scopeService;
        //     System.Console.WriteLine(nameof(TransientService));
        // }
        public TransientService()
        {
            System.Console.WriteLine(nameof(TransientService));
        }

        public void Test(string text)
        {
            System.Console.WriteLine(text);
        }

        public void Test2(string text)
        {
            System.Console.WriteLine(text);
            this._scopeService?.Test("Transient 2 call scope");
        }
    }
}