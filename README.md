Módulos E-commerce – Epics – Features
1: Módulo Compras (descrição - busca de mercado)
Classes:
1.   	Orcamentos (Quotation)
ATRIBUTOS
idOrcamento: int
idUsuario: int
idFornecedor: int
nomeProduto: string
precoProduto: double
quantidadeProduto: int
listaProdutos: bool
delete: string
 #region "Atributos"
 private int _idQuotation;  
 private int _idUser;          
 private int _idProvider;    
 private string _nameProduct;
 private double _priceProdut; 
 private int _quantityProduct; 
 private bool _listProduct;      
 private string _delete;         
 #endregion
MÉTODOS
novaEncomenda();
editarEncomenda();
eliminarEncomenda();
listarEncomendas();
procurarEncomenda();
calculaValorOrcamento();
 
2.   	NotasDeEncomenda (InputInvoice - notas de faturas recebidas dos fornecedores)
ATRIBUTOS
idNE: int;
idFornecedor : int;
numeroNE: string ;
dataEmissaoNE: dateTime;
idProduto: int;
nomeProduto: string;
qtdProduto: int;
valorProduto: double;
campanhaFornecedor: double;
idCondicaoPagamento: int;
#region "Atributos"
 private int _idII;  
 private int _idProvider;
 private string _numberII;
 private DateTime _dateII;
 private int _idProduct;     
 private string _nameProduct;
 private int _qtdProduct;         
 private double _priceProduct;
 private double _campaignProvider;
 private int _idMethodOfPayment;   
 #endregion
MÉTODOS
cadastrarNotaEntrada();
editarNotaEntrada();
detetarNotaEnrada();
listarNotaEntra();
buscarNotasEntrada();
 
3.   	PedidosDeCompra (PurchaseRequest - compras ao fornecedor para abastecer o estoque do ecommerce)
ATRIBUTOS
idOrcamento: int
idPedidoCompra: int
aprovado: boolean
idCondicaoPagamento: int
campanhaFornecedor: double
#region "Atributos"
private int _idQuotation;          
private int _idPurchaseRequest;
private bool _okay;               
private int _idMethodOfPayment;
private double _campaignProvider;
#endregion

MÉTODOS
calculaValorTotalEncomenda();
fornecedorcreditoEncomenda();
fornecedordebitoEncomenda();
clientecreditoEncomenda();
converterOrcamentoPedidoCompra();

4.   	Condição de Pagamento
ATRIBUTOS
idCondicaoPagamento: int
nomeCondicaoPagamento: string
condicaoPagamento: string
#region "Atributos"
private int _idMethodOfPayment;       
private string _nameMethodOfPayment; 
private int _MethodOfPayment;         
#endregion
MÉTODOS
novaCondicaoPagamento();
editarCondicaoPagamento();
eliminarCondicaoPagamento();
listarCondicaoPagamento();
 
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
#region "ATRIBUTOS PRODUCT"
private int _idProduct; 
	private string _nameProduct;
private string _descriptionProduct;
	private string _typeProduct;
	private string _categoryProduct;
	private double _weightProduct;
	private string _warehouseProduct;
	private double _pricePurchaseProduct;
	private double _priceSellProduct;
	private bool _discontinuedProduct;
	private string _delete;
	#endregion
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
#region "atributos"
private int _idProduct;             
private int _idWarehouse;           
private string _productDescription;
private string _nameInventory;
private int _newQuantity;
#endregion
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
 
5.   	TipoDeSaida
ATRIBUTOS
idProduto: int
idArmazem: int
tipoSaida: string
#region "atributos"
private int _idProduct;
private int _idStorage;
private TE _typeExit; 
#endregion
MÉTODOS
listarSaidaProdutos();
rastrearArmazemProdutos();
campanhaProduto();
alterarArmazemProduto();
 
6.   	Custos(SalesPrice)
ATRIBUTOS
idProduto: int
creditoClientes: double
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
7.   	Campanhas (IsOnSale)
 	ATRIBUTOS
idCampanha: int
idProduto: int
idArmazem: int
custoProduto: double
valorCampanha: double
#region "Atributos"
private int _idIsOnSale;         
private int _idProduct;           
private int _idWarehouse;         
private double _costProduct;      
private double _valueSalePercent; 
#endregion
	MÉTODOS
aplicarValorCampanha();
removerValorCampanha();

O que tenho armazenado?
Qual o valor do estoque armazenado?
Qual o custo do estoque armazenado?
Qual o preço de venda sugerido para o produto?
Onde está armazenado determinado item?
 
3: Módulo Faturação
Classes
1.   	Clientes
ATRIBUTOS
idCliente: int
idPessoa: int
delete: string
MÉTODOS
cadastrarCliente();
removerCliente();
editarCliente();
listarCliente();
 
2.   	Fornecedores
ATRIBUTOS
idFornecedor: int
idPessoa: int
creditoFornecedores: double
delete: string
MÉTODOS
cadastraFornecedor();
removerFornecedor();
editarFornecedor();
listarFornecedor();
 
3.   	Pedidos de Venda(InvoicesReceivable)
ATRIBUTOS
idPedidoVenda: int
idCliente: int
idProduto: int
idCarrinhoCompras : int
idCondicaoDePagamento: int
quantidadeProduto: int
precoProdutos: double
pesoProduto: double
delete: string
  #region "ATRIBUTOS INVOICESRECEIVABLE"
        int _idPedidoVenda;
        int _idCliente;
        int _idProduto;
        int _idCondicaoDePagamento;
        int _quantidadeProduto;
        double _precoProdutos;
        double _pesoProduto;
        string _delete;
        #endregion

MÉTODOS
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
ATRIBUTOS
idCarrinhoCompras : int
idCliente: int
idProduto: it
idCondicaoDePagamento: int
quantidadeProduto: int
precoProdutos: double
pesoProduto: double
delete: string
#region "Atributos"
private int _idShoppingCar;    
private int _idClient;        
private int _idProduct;     
private int _idMethodOfPayment;
private int _quantityProduct;   
private double _priceProduct; 
private double _weightProduct;
private string _delete;      
#endregion
MÉTODOS
listarProdutos();
salvarCarinho();
 
5.   	Envio Pedidos de Venda
ATRIBUTOS
idPedidoVenda: int
idEnvioPedido: int
MÉTODOS
calculaPesoProduto();
valorTotalPostagem();
 
6.   	Desbloquear Estoque
ATRIBUTOS
idProdudo : int;
idDesbloqueio: int
MÉTODOS
desbloquearSaldoEstoque();
 
7.   	Emitir Notas de fatura
ATRIBUTOS
idPedidoVenda: int
idNF: int
MÉTODOS
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
#region "atributos"
private int _idPeople;      
private int _idUser;         
private string _surname;    
private string _site;        
private string _NIF;        
private string _CC;         
private string _note;       
private string _address;   
private string _number;    
private string _district;    
private string _city;        
private string _country;  
private string _postalCode; 
private string _socialMidia; 
private string _cellPhone;   
#endregion
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
MÉTODOS
editarUsuario()
listarUsuarios()
novoUsuario()
 
5: Módulo Contabilidade 
Classes
1.   	Contas a pagar(InvoiceToPay)
ATRIBUTOS
idNE: int
status: boolean
#region "Atributos"
private int _idII;    
private bool _status; 
#endregion
MÉTODOS
buscarNotasEmAberto();
liquidarContas();
desfazerLiquidar();
 
2.   	Contas a receber
ATRIBUTOS
idPedidoVenda: int
idStatus: boolean
MÉTODOS
buscarEntradasDoDia();



 
 
 
 

