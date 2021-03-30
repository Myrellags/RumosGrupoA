Módulos E-commerce – Epics – Features
1: Módulo Compras (descrição - busca de mercado)
Classes:
1.   	Orcamentos 
ATRIBUTOS
idOrcamento: int
idUsuario: int
idFornecedor: int
nomeProduto: string
precoProduto: double
quantidadeProduto: int
listaProdutos: bool
delete: string
MÉTODOS
novaEncomenda();
editarEncomenda();
eliminarEncomenda();
listarEncomendas();
procurarEncomenda();
calculaValorOrcamento();
 
2.   	NotasDeEncomenda
ATRIBUTOS
idNE: int;
idFornecedor;
numeroNE: string ;
dataEmissaoNE: dateTime;
idProduto: int;
nomeProduto: string;
qtdProduto: int;
valorProduto: double;
campanhaFornecedor: double;
idCondicaoPagamento: int;
MÉTODOS
cadastrarNotaEntrada();
editarNotaEntrada();
detetarNotaEnrada();
listarNotaEntra();
buscarNotasEntrada();
 
3.   	PedidosDeCompra
ATRIBUTOS
idOrcamento: int
idPedidoCompra: int
aprovado: boolean
idCondicaoPagamento: int
campanhaFornecedor: double
MÉTODOS
calculaValorTotalEncomenda();
fornecedorcreditoEncomenda();
fornecedordebitoEncomenda();
clientecreditoEncomenda();
converterOrcamentoPedidoCompra();

4.   	Condição de Pagamento
ATRIBUTOS
idCondicaoPagamento: int
nomeCondicaoPagamento: 
descricaoCondicaoPagamento: string
MÉTODOS
novaCondicaoPagamento();
editarCondicaoPagamento();
eliminarCondicaoPagamento();
listarCondicaoPagamento();


o que está sendo comprado?
quem está comprando?
qual é a quantidade comprada?
quem é o fornecedor?
qual é o valor?
qual é a condição de pagamento?
 
2: Módulo Stock
Classes
1.   	Categorias de Produtos
ATRIBUTOS
idCategora: int
nomeCategoria: string
tipoCategoria: string
MÉTODOS
cadastraCategoria()
removeCategoria()
editarCategoria()
listarCategoria()
filtrarCategoria()
 
2.   	Produtos
ATRIBUTOS
idProduto: int
idCategoria: int
idArmazem: int
nomeProduto: string
descricaoProduto: string
tipoProduto: string
pesoProduto: double
delete: string
armazemProduto: string;
precoVenda: double
precoCompra: double
MÉTODOS
cadastraProduto()
removerProduto()
editarProduto()
listarProduto()
filtrarProduto()
 
3.   	Inventários
ATRIBUTOS
idProduto: int
idArmazem: int
descricaoProduto: string;
nomeInventario: string
novaQuantidade: int
MÉTODOS
lancarSaldoEmEstoque()
atualizarSaldoEmEstoque()
 
4.   	Armazem
ATRIBUTOS
idArmazem: int
descricaoArmazem: string;
MÉTODOS
cadastraArmazem()
removerArmazem()
editarArmazem()
listarArmazem()
 
5.   	Movimentação de produtos
ATRIBUTOS
MÉTODOS
listarSaidaProdutos();
rastrearArmazemProdutos();
campanhaProduto();
alterarArmazemProduto();
 
6.   	Custos
ATRIBUTOS
creditoFornecedores: double
crditoClientes: double
custosFornecedores: double
custoProduto: double
custosOutros: double
tipodecusto: string
MÉTODOS
alterarCusto();
inserirCusto();
listarCustos();
calculaPrecoVenda();
calculaTotalEstoque();
calculaTotalPorProduto();
 
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
1.   	People (Pessoa)
ATRIBUTOS
idPessoa: int
idUsuario: int
apelido: string
site: string
NIF: string
CC: string
observacao: string
logradouro: string
numero: string
bairro: string
cidade: string
pais: string
codigoPostal: string
redeSociais: string
telemovel: string
MÉTODOS
cadastraPessoa(); 	
removerPessoa();
editarPessoa();
listarPessoa();
2.   	User (Usuário)
ATRIBUTOS
idUser: int;
idPeople: int;
passUser: string;
emailUser: string;
MÉTODOS
editarUsuario()
listarUsuarios()
novoUsuario()

// ATRIBUTOS USER (já em inglês lol)

idUser: int
nameUser: string
passUser: string
surnameUser: string
nifUser: string
emailUser: string
cityUser: string
countryUser: string
contact1User: string
contact2User: string
​
//METODOS USER

editUser();
listUser();
newUser();

 
5: Módulo Contabilidade 
Classes
1.   	Contas a pagar;
buscarNotasEmAberto();
liquidarContas();
 
2.   	Contas a receber
buscarEntradasDoDia();
 
 
 
 

