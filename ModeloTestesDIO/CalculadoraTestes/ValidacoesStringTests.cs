using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange
            string texto = "Olá";

            // Act
            int resultado = _validacoes.ContarCaracteres(texto);

            // Assert
            Assert.Equal(3, resultado);
        }
    }
}