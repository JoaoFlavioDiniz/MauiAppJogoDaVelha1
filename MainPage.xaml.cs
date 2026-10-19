namespace MauiAppJogoDaVelha1
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int jogadas = 0; // Contador de jogadas para detectar empate
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;
            jogadas++; // Soma +1 a cada botão clicado

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            /*LINHAS HORIZONTAIS*/
            /* Verificando se o X ganhou na 1ª linha */
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                 DisplayAlertAsync("Parabéns!", "O X ganhou na linha 1!", "OK");
                Zerar();
            }

            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O O ganhou na linha 1!", "OK");
                Zerar();
            }

            /* Verificando se o X ganhou na 2ª linha */
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou na linha 2!", "OK");
                Zerar();
            }

            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O O ganhou na linha 2!", "OK");
                Zerar();
            }

            /* Verificando se o X ganhou na 3ª linha */
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou na linha 3!", "OK");
                Zerar();
            }

            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O O ganhou na linha 3!", "OK");
                Zerar();
            }

            /*LINHAS DIAGONAIS*/
            /* Verificando se o X ganhou na 1ª linha diagonal */
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou na diagonal 1!", "OK");
                Zerar();
            }

            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O O ganhou na diagonal 1!", "OK");
                Zerar();
            }

            /* Verificando se o X ganhou na 1ª linha diagonal */
            if (btn30.Text == "X" && btn21.Text == "X" && btn12.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou na diagonal 2!", "OK");
                Zerar();
            }

            if (btn30.Text == "O" && btn21.Text == "O" && btn12.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O O ganhou na diagonal 2!", "OK");
                Zerar();
            }

            /*LINHAS VERTICAIS*/
            /* Verificando se o X ganhou na 1ª linha vertical */
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou na linha vertical 1!", "OK");
                Zerar();
            }

            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O O ganhou na linha vertical 1!", "OK");
                Zerar();
            }

            /* Verificando se o X ganhou na 2ª linha vertical */
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou na linha vertical 2!", "OK");
                Zerar();
            }

            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O O ganhou na linha vertical 2!", "OK");
                Zerar();
            }

            /* Verificando se o X ganhou na 3ª linha vertical */
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O X ganhou na linha vertical 3!", "OK");
                Zerar();
            }

            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O O ganhou na linha vertical 3!", "OK");
                Zerar();
            }

          /*VERIFICANDO SE DEU NEGA / EMPATE \*/ 
            if (jogadas == 9) { DisplayAlertAsync("Deu Nega!", "Nenhum jogador venceu esta partida.", "OK"); 
                Zerar(); }
        } // Fecha método

        void Zerar()
        {
            /*LINHAS HORIZONTAIS*/
            /* Zerando a 1ª linha */
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            /* Zerando a 2ª linha */
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            /* Zerando a 3ª linha */
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            
            /* Setar a 1ª linha com true */
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            /* Setar a 1ª linha com true */
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            /* Setar a 1ª linha com true */
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            // Reseta variáveis de controle
            vez = "X";
            jogadas = 0; // Zera o contador para a próxima partida
        }

    } // Fecha Classe
} // Fecha Namespace
