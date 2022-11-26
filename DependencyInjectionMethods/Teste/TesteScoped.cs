namespace DependencyInjectionMethods.Teste
{
    public class TesteScoped : ITesteScoped
    {
        private readonly Guid _id;
        public TesteScoped()
        {
            _id = Guid.NewGuid();
        }

        public Guid RetornarId()
        {
            return _id;
        }
    }
}
