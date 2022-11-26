namespace DependencyInjectionMethods.Teste
{
    public class TesteTransient : ITesteTransient
    {
        private readonly Guid _id;
        public TesteTransient()
        {
            _id = Guid.NewGuid();
        }

        public Guid RetornarId()
        {
            return _id;
        }
    }
}
