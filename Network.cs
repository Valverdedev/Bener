namespace Bener
{
    public class Network
    {

        private int qntElementos;
        private Dictionary<int, List<int>> conexoes;
        public Network(int qntElementos)
        {
            if (qntElementos <= 0) throw new ArgumentException("O número de elementos deve ser positivo.");

            this.qntElementos = qntElementos;
            this.conexoes = new Dictionary<int, List<int>>();
        }
        public void Connect(int elemento1, int elemento2)
        {
            Verificarlemento(elemento1);
            Verificarlemento(elemento2);

            if (!conexoes.ContainsKey(elemento1))
            {
                conexoes[elemento1] = new List<int>();
            }

            if (!conexoes.ContainsKey(elemento2))
            {
                conexoes[elemento2] = new List<int>();
            }

            conexoes[elemento1].Add(elemento2);
            conexoes[elemento2].Add(elemento1);
        }

        public bool Query(int elemento1, int elemento2)
        {
            Verificarlemento(elemento1);
            Verificarlemento(elemento2);

            if (!conexoes.ContainsKey(elemento1) || !conexoes.ContainsKey(elemento2))
            {
                return false;
            }

            List<int> visitados = new List<int>();            
         
            
            return VerificarConexao(elemento1, elemento2, visitados);
        }

        private bool VerificarConexao(int atual, int destino, List<int> visitados)
        {
            if (atual == destino)
            {
                return true;
            }

            visitados.Add(atual);

            foreach (int vizinho in conexoes[atual])
            {
                if (!visitados.Contains(vizinho))
                {
                    if (VerificarConexao(vizinho, destino, visitados))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void Verificarlemento(int elemento)
        {
            if (elemento < 1 || elemento > qntElementos) throw new ArgumentException("Elemento inválido.");           
        }
    }
}
