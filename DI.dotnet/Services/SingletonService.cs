namespace DI.dotnet.Services
{
    public interface ISingletonService
    {
        void Test(string text);
    }

    public class SingletonService : ISingletonService
    {
        // readonly ITransientService _transientService;
        // public SingletonService(ITransientService transientService)
        // {
        //     System.Console.WriteLine(nameof(SingletonService));
        //     this._transientService = transientService;
        // }
        public void Test(string text)
        {
            System.Console.WriteLine(text);
            // _transientService.Test("Single call transient");
            // _transientService.Test2("Single call transient 2");
        }
    }
}