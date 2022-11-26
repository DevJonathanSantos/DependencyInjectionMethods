namespace DependencyInjectionMethods.Teste
{
    public class TesteSingleton : ITesteSingleton
    {
        private readonly Guid _id;
        public TesteSingleton()
        {
            _id = Guid.NewGuid();
        }

        public Guid RetornarId()
        {
            return _id;
        }
    }
}
