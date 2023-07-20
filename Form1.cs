namespace Aula08Estoque
{
    public partial class Form1 : Form
    {

        //Variáveis globais
        List<string> produto_nome = new List<string>();
        List<int> produto_quantidade = new List<int>();
        
        utilidades utilidades = new utilidades();

        public Form1()
        {
            InitializeComponent();
        }

        // Minhas funções

        void adicionaProduto()
        {
           
            if(utilidades.textBoxEstaVazio(txtNome) == true )
            {

                MessageBox.Show(" O nome está vazio");
                return;
            }
           
            if (utilidades.textBoxEstaVazio(txtQuantidade) == true)
            {
                MessageBox.Show(" Não tem nada no espaço de estoque");
                return;

            }

               


            utilidades.textBoxEstaVazio( txtNome);
;            string nome = txtNome.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            produto_nome.Add(nome);
            produto_quantidade.Add(quantidade);


        }


        void atualizaInterface()
        {

            // Contabiliza a quantidade cadastrada 


            int quantidade_cadastrada = produto_nome.Count();
            lblCadastros.Text = quantidade_cadastrada.ToString();
         
            // contabiliza todos produtos em estoque
            // For: a variável controladora; condição; incrementação

            int estoque = 0;
            for( int i =0; i < produto_quantidade.Count; i++)
            {
                int quantidade = produto_quantidade[i];
                estoque += quantidade;

            }

            LblQuantidade.Text = estoque.ToString();

        }

        void LimpaCampos()
        {

            txtNome.Clear();
            txtQuantidade.Clear();
            txtNome.Focus();

        }

        void verProduto( bool primeiro)
        {


            if ( listaEstaVazia() == true)
            {

                MessageBox.Show("Você não pode ver a lista ainda...");
                return;
            }
       
            

            string nome;
            int quantidade;

            if ( primeiro == true)
            {

                nome = produto_nome[0];
                quantidade = produto_quantidade[0];

            }
            else
            {
                nome = produto_nome[produto_nome.Count - 1];
                quantidade = produto_quantidade[ produto_quantidade.Count() - 1];
            }

            MessageBox.Show($"Nome: {nome}, quantidade: {quantidade}");


        }

        void removerProduto()
        {

            if (listaEstaVazia() == true)
            {
                MessageBox.Show("Você não pode remover!");

            }

            else
            {
                produto_nome.RemoveAt(0);
                produto_quantidade.Remove(0);
                atualizaInterface();
            }


    
          

        }


        // ------------------------------------------------------------------------

        bool listaEstaVazia()
        {

            if ( produto_nome.Count > 0)
            {

                return false;

            }

            else
            {
                return true;

            }



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          adicionaProduto();
          atualizaInterface();
          LimpaCampos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnPrimeiroP_Click(object sender, EventArgs e)
        {
            verProduto( true );




        }

        private void btnUltimoP_Click(object sender, EventArgs e)
        {
            verProduto(false);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            removerProduto();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            utilidades utilidades = new utilidades();
            utilidades.mostramensagem();

            Console.WriteLine();


        }
    }
}