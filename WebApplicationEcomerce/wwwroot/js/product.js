
//Carregando combo categorias com dados da base
document.getElementById("opcaoCategoria").onselect = function () {
    fetch("/CategoryDAO/BuscaCategoria").then(respostaDoServidor => respostaDoServidor.json()).then(listaDeCategorias => mostrarCategorias(listaDeCategorias));
};

function mostrarCategorias(listaDeCategorias) {
    for (var i = 0; i < listaDeCategorias.length; i++) {
        document.getElementById("opcaoCategoria").innerHTML +=
            "<option>" + listaDeCategorias[i] + "</option>";
    }
}

function enviar() {
    if (
        parseInt(document.getElementById("pesoProduto").value) <= 0 ||
        parseInt(document.getElementById("pesoProduto").value) > 100
    ) {
        alert("Dados inválidos, verificar campos!");
        return false; 
    }
    else {
        alert("Guardando dados!");
        return true;
    }
}

