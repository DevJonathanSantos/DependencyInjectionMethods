using DependencyInjectionMethods.Teste;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionMethods.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly ITesteSingleton _testeSingleton;
        private readonly ITesteScoped _testeScoped;
        private readonly ITesteTransient _testeTransient;
        public TesteController(ITesteSingleton testeSingleton, ITesteScoped testeScoped, ITesteTransient testeTransient)
        {
            _testeSingleton = testeSingleton;
            _testeScoped = testeScoped;
            _testeTransient = testeTransient;
        }

        [HttpGet]
        public string Get()
        {
            var idSingleton = _testeSingleton.RetornarId();
            var idScoped = _testeScoped.RetornarId();
            var idTransient = _testeTransient.RetornarId();
            var idSingleton2 = _testeSingleton.RetornarId();
            var idScoped2 = _testeScoped.RetornarId();
            var idTransient2 = _testeTransient.RetornarId();

            return $"idSingleton: {idSingleton}|idSingleton2: {idSingleton2} \n  idScoped: {idScoped}|idScoped2: {idScoped2} \n  idTransient: {idTransient}|idTransient2: {idTransient2}\n";
        }
    }
}
