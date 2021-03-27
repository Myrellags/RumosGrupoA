Módulos E-commerce – Epics – Features
1: Módulo Compras
Classes:
1.   	Cotações / Encomendas 
novaCotacao(); / novaEncomenda();
editarCotacao(); / editarEncomenda();
deletarCotacao(); / eliminarEncomenda();
listarCotacoes(); / listarEncomendas();
buscarCotacoes(); / procurarEncomenda();
 
2.   	Entradas de Notas ???
cadastrarNotaEntrada();
editarNotaEntrada();
detetarNotaEnrada();
listarNotaEntra();
buscarNotasEntrada();
 
3.   	Pedidos de compra / 
converterEncomendaseEfectuadas();
adicionadoEncomenda();
numeroEncomenda();
fornecedorEncomenda();
precofornecedorEncomenda();
precoclienteEncomenda();
fornecedorcreditoEncomenda();
fornecedordebitoEncomenda();
clientecreditoEncomenda();
clientedebitoEncomenda

converterCotacoesPedidoCompra();  ??
 
o que está sendo comprado?
quem está comprando?
qual é a quantidade comprada?
quem é o fornecedor?
qual é o valor?
qual é a condição de pagamento?
 
2: Módulo Stock
Classes
1.   	Categorias de Produtos
cadastraCategoria()
removeCategoria()
editarCategoria()
listarCategoria()
filtrarCategoria()
 
2.   	Produtos
cadastraProduto()
removerProduto()
editarProduto()
listarProduto()
filtrarProduto()
 
3.   	Inventários
lancarSaldoEmEstoque()
atualizarSaldoEmEstoque()
 
4.   	Saldo Inicial
alterarSaldoProdutos()
 
5.   	Movimentação de produtos
listarSaidaProdutos();
rastrearArmazemProdutos();
campanhaProduto();
 
6.   	PrecoVenda
calculaPrecoVenda();
 
O que tenho armazenado?
Qual o valor do estoque armazenado?
Qual o custo do estoque armazenado?
Qual o preço de venda sugerido para o produto?
Onde está armazenado determinado item?
 
3: Módulo Faturação
Classes
1.   	Clientes
cadastrarCliente();
removerCliente();
editarCliente();
listarCliente();
 
2.   	Fornecedores
cadastraFornecedor();
removerFornecedor();
editarFornecedor();
listarFornecedor();
 
3.   	Pedidos de Venda
calculaTotalPedido();
adicionaProduto();
removeProduto();
atualizaValorProduto();
orcamentoPedido();
finalizaPedido();
calculaValorEnvio();
statusPagamento();
statusPedido();
 
4.   	Carrinho de compras
listarProdutos();
salvarCarinho();
 
5.   	Envio Pedidos de Venda
calculaPesoProduto();
valorTotalPostagem();
 
6.   	Desbloquear Estoque
desbloquearSaldoEstoque();
 
7.   	Emitir Notas de fatura
gerarNotaFaturaConsumidor();
 
4: Módulo Pessoal 
            Classes
1.   	Pessoa
cadastraPessoa();
removerPessoa();
editarPessoa();
listarPessoa();
 
5: Módulo Contabilidade 
Classes
1.   	Contas a pagar;
buscarNotasEmAberto();
 
2.   	Contas a receber
buscarEntradasDoDia();
 
 
 
 



If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)