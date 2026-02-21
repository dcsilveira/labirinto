#pragma warning disable CA1416 // Validate platform compatibility
using System.Drawing;

namespace Labirinto.RegraNegocio
{
    public class LabirintoSolver
    {
        public enum Direcao { Cima, Baixo, Direita, Esquerda, Nenhuma };

        private readonly bool resolucaoRapida;

        #region Propriedades

        /// <summary>
        /// Lista de Soluções no formato Bitmap junto com a quantidade de passos necessários pra se chegar a solução
        /// </summary>
        public Dictionary<Bitmap, int> Solucoes { get; set; }

        /// <summary>
        /// Defino se a função de resolução já acabou
        /// </summary>
        public bool Acabou { get; set; }

        /// <summary>
        /// Dimensão do mapa
        /// </summary>
        public int TamanhoMapa { get; set; }

        /// <summary>
        /// Mapa no formato matriz de caracteres
        /// </summary>
        public char[,] Mapa { get; set; }

        /// <summary>
        /// Mapa no formato Bitmap
        /// </summary>
        public Bitmap MapaBitmap
        {
            get
            {
                return MapaCaracteresParaBitmap();
            }
        }

        #endregion

        #region Contrutores

        public LabirintoSolver()
        {
            TamanhoMapa = 10;
            Mapa = new char[10, 10];
            Acabou = false;
            Solucoes = new Dictionary<Bitmap, int>();
        }

        public LabirintoSolver(int tamanhoMapa, string mapaTemplate, bool resolucaoRapida)
        {
            TamanhoMapa = tamanhoMapa;
            Mapa = new char[tamanhoMapa, tamanhoMapa];
            MontarMapa(mapaTemplate);
            Acabou = false;
            Solucoes = new Dictionary<Bitmap, int>();
            this.resolucaoRapida = resolucaoRapida;
        }

        #endregion

        #region Métodos Privados

        /// <summary>
        /// Transforma um template de mapa em formato string para uma matriz de caracteres
        /// </summary>
        /// <param name="template">Template do mapa</param>
        private void MontarMapa(string template)
        {
            string linha = "";

            for (int i = 0; i < TamanhoMapa; i++)
            {
                linha = template.Substring(i * TamanhoMapa, TamanhoMapa);

                for (int j = 0; j < linha.Length; j++)
                    Mapa[i, j] = linha[j];
            }

        }

        /// <summary>
        /// Função de imprimir no console
        /// </summary>
        private void ImprimeConsole()
        {
            string linha = "";

            for (int i = 0; i < TamanhoMapa; i++)
            {
                for (int j = 0; j < TamanhoMapa; j++)
                    linha += Mapa[i, j];

                Console.WriteLine(linha);
                linha = "";
            }

            Thread.Sleep(50);
        }

        /// <summary>
        /// Função que dá os passos dentro do mapa e verifica se foi encontrada uma solução ou não
        /// </summary>
        /// <param name="x">Posição no eixo X</param>
        /// <param name="y">Posição no eixo Y</param>
        /// <param name="direcao">De qual direção veio o passo anterior</param>
        /// <param name="passos">Quantidade de passos realizados até o momento</param>
        private void PassoConsole(int x, int y, Direcao direcao, int passos)
        {
            ImprimeConsole();
            Console.Clear();

            if (Mapa[x, y] == ' ')
                Mapa[x, y] = '.';

            if (Mapa[x, y] == 'F')
            {
                ImprimeConsole();
                Console.WriteLine(string.Format("\nEncontrou uma solucao em {0} passos!\n", passos));
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                if (Mapa[x, y] != 'X')
                {
                    if (direcao != Direcao.Cima && Mapa[x, y + 1] != '.')     PassoConsole(x, y + 1, Direcao.Baixo, passos + 1);
                    if (direcao != Direcao.Baixo && Mapa[x, y - 1] != '.')    PassoConsole(x, y - 1, Direcao.Cima, passos + 1);
                    if (direcao != Direcao.Direita && Mapa[x + 1, y] != '.')  PassoConsole(x + 1, y, Direcao.Esquerda, passos + 1);
                    if (direcao != Direcao.Esquerda && Mapa[x - 1, y] != '.') PassoConsole(x - 1, y, Direcao.Direita, passos + 1);

                    if(Mapa[x, y] != 'I')
                        Mapa[x, y] = ' ';
                }
            }
        }

        /// <summary>
        /// Função que dá os passos dentro do mapa e verifica se foi encontrada uma solução ou não
        /// </summary>
        /// <param name="x">Posição no eixo X</param>
        /// <param name="y">Posição no eixo Y</param>
        /// <param name="direcao">De qual direção veio o passo anterior</param>
        /// <param name="passos">Quantidade de passos realizados até o momento</param>
        private void Passo(int x, int y, Direcao direcao, int passos)
        {
            if (!Acabou)
            {
                if (Mapa[x, y] == ' ')
                    Mapa[x, y] = '.';

                if (Mapa[x, y] == 'F')
                {
                    Solucoes.Add(MapaBitmap, passos);

                    if(!resolucaoRapida)
                        Thread.Sleep(1000);
                }
                else
                {
                    if (Mapa[x, y] != 'X')
                    {
                        if (direcao != Direcao.Cima && Mapa[x, y + 1] != '.')     Passo(x, y + 1, Direcao.Baixo, passos + 1);
                        if (direcao != Direcao.Baixo && Mapa[x, y - 1] != '.')    Passo(x, y - 1, Direcao.Cima, passos + 1);
                        if (direcao != Direcao.Direita && Mapa[x + 1, y] != '.')  Passo(x + 1, y, Direcao.Esquerda, passos + 1);
                        if (direcao != Direcao.Esquerda && Mapa[x - 1, y] != '.') Passo(x - 1, y, Direcao.Direita, passos + 1);

                        if (Mapa[x, y] != 'I')
                            Mapa[x, y] = ' ';
                    }

                    if (!resolucaoRapida)
                        Thread.Sleep(50);
                }
            }
        }

        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Transforma um mapa em formato matriz de caracteres em uma imagem
        /// </summary>
        /// <returns>Imagem</returns>
        public Bitmap MapaCaracteresParaBitmap()
        {
            Bitmap imagem = new Bitmap(260, 260);
            Graphics g = Graphics.FromImage(imagem);

            int tamanhoPixel = 260 / TamanhoMapa;

            for (int x = 0; x < TamanhoMapa; x++)
            {
                for (int y = 0; y < TamanhoMapa; y++)
                {
                    switch (Mapa[y, x])
                    {
                        case 'X':
                            g.FillRectangle(Brushes.Black, x * tamanhoPixel, y * tamanhoPixel, tamanhoPixel, tamanhoPixel);
                            break;
                        case '.':
                            g.FillRectangle(Brushes.Blue, x * tamanhoPixel, y * tamanhoPixel, tamanhoPixel, tamanhoPixel);
                            break;
                        case 'I':
                            g.FillRectangle(Brushes.Green, x * tamanhoPixel, y * tamanhoPixel, tamanhoPixel, tamanhoPixel);
                            break;
                        case 'F':
                            g.FillRectangle(Brushes.Red, x * tamanhoPixel, y * tamanhoPixel, tamanhoPixel, tamanhoPixel);
                            break;
                        default:
                            g.FillRectangle(Brushes.White, x * tamanhoPixel, y * tamanhoPixel, tamanhoPixel, tamanhoPixel);
                            break;
                    }
                }
            }

            g.Dispose();

            return imagem;
        }

        /// <summary>
        /// Encontra as possíveis soluções de um labirinto
        /// </summary>
        public void ResolverConsole()
        {
            for (int i = 0; i < TamanhoMapa; i++)
                for (int j = 0; j < TamanhoMapa; j++)
                    if (Mapa[i, j] == 'I')
                        PassoConsole(i, j, Direcao.Nenhuma, 0);

            Acabou = true;
        }

        /// <summary>
        /// Encontra as possíveis soluções de um labirinto
        /// </summary>
        public void Resolver()
        {
            for (int i = 0; i < TamanhoMapa; i++)
                for (int j = 0; j < TamanhoMapa; j++)
                    if (Mapa[i, j] == 'I')
                        Passo(i, j, Direcao.Nenhuma, 0);

            Acabou = true;
        }

        #endregion
    }
}

#pragma warning restore CA1416 // Validate platform compatibility
