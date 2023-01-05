
let teste1 = "teste";
let idAtiva = "";
let idEndereco = "";
let dataCreated = "";
let clienteEncontrado = false;
let searchbtn = document.querySelector("#search");
let searchPizza = document.querySelector(".head .search-bar");
searchbtn.onclick = () => {
  searchPizza.classList.toggle("active");
  menu.classList.remove('active');
};

let menu = document.querySelector(".head .navbar");
document.querySelector('#bars').onclick = () =>{
  menu.classList.toggle('active');
  searchPizza.classList.remove('active')
}
window.onscroll = () => {
    menu.classList.remove('active');
    searchPizza.classList.remove('active')
}

$(document).ready(() => {
    $('#editUser').hide();
    $('#deleteUser').hide();

    // Cancelar exclusao
    $('#salvar').click((e) => {
        e.preventDefault();
        executaSalvaEndereco('save');
        
    });
    $('#buscarCliente').click((e) => {
        e.preventDefault();
        $('#modal').modal('hide');
        executaBuscarCliente();
        
    });
    $('#editUser').click((e) => {
        e.preventDefault();
        executaSalvaEndereco('edit');
    });
    $('#deleteUser').click((e) => {
        e.preventDefault();
        $('#modalDelete').modal('show');
    })
    $('#ExcluirCliente').click((e) => {
        e.preventDefault();
        $('#modalDelete').modal('hide');
        //
        executaDeleteCliente(idAtiva, idEndereco);
    })
});


const executaSalvaEndereco = (status) => {
    //debugger
    var Cidade = $("#Cidade").val();
    var Bairro = $("#Bairro").val();
    var Logradouro = $("#Logradouro").val();
    var Numero = $("#Numero").val();
    var CEP = $("#CEP").val();
    var enderecoId = idEndereco;

    if (status == 'edit') {
        var url = `/Endereco/Editend`;
        var dados = { Id: enderecoId, Cidade: Cidade, Bairro: Bairro, Logradouro: Logradouro, Numero: Numero, CEP: CEP };
    } else {
        var url = `/Endereco/CriarEnderecoComCliente`;
        var dados = { Cidade: Cidade, Bairro: Bairro, Logradouro: Logradouro, Numero: Numero, CEP: CEP };
    }

    
    $.ajax({
        url: url,
        method: 'POST',
        data: dados,
        success: (response) => {
            
            executaSalvaCliente(response);
          
        }
    });
}

const executaSalvaCliente = (id) => {
    //debugger
    var Login = $("#Login").val();
    var Senha = $("#Senha").val();
    var Nome = $("#Nome").val();
    var Telefone = $("#Telefone").val();
    
    if (id == 'ok') {
        id = idAtiva;
        url = '/Clientes/Edit';
        dados = { Id: idAtiva, Login: Login, Senha: Senha, Nome: Nome, Telefone: Telefone, Created_Time: dataCreated, IdEndereco: idEndereco }
    } else {
        var diaN = new Date();
        var dia = String(diaN.getDate()).padStart(2, '0');
        var mes = String(diaN.getMonth() + 1).padStart(2, '0');
        var ano = diaN.getFullYear();
        var Created_Time = `${dia}/${mes}/${ano}`;

        url = '/Clientes/Create';
        dados = {Login: Login, Senha: Senha, Nome: Nome, Telefone: Telefone, Created_Time: Created_Time, IdEndereco: id }
    }
    
    
    $.ajax({
        url: url,
        method: 'POST',
        data: dados,
        success: (response) => {
            alert(response);
            window.close('/Clientes/Create');

        }
    });
}

const executaBuscarCliente = () => {
    let login = $('#loginEditar').val();
    let senha = $('#senhaEditar').val();
    
    if (login != "" || senha != "") {
        $.ajax({
            url: `/Clientes/Find`,
            method: 'get',
            data: {
                Login: login,
                Senha: senha
            },
            success: (obj) => {
                //debugger
               
                idAtiva = obj.id;
                dataCreated = obj.created_Time;
                idEndereco = obj.idEndereco;
                clienteEncontrado = true;
                $('#Login').val(`${obj.login}`);
                $('#Senha').val(`${obj.senha}`);
                $('#Nome').val(`${obj.nome}`);
                $('#Telefone').val(`${obj.telefone}`);
                
                executaBuscarEndereco(idEndereco, clienteEncontrado);
            }
        });
        
    }
    
}

const executaBuscarEndereco = (id, encontrado) => {
    //debugger
    if (encontrado == true) {
        $.ajax({
            url: `/Endereco/Details`,
            method: 'get',
            data: {
                Id: id,

            },
            success: (obj) => {
                //debugger
                $('#Cidade').val(`${obj.cidade}`);
                $('#Bairro').val(`${obj.bairro}`);
                $('#Logradouro').val(`${obj.logradouro}`);
                $('#Numero').val(`${obj.numero}`);
                $('#CEP').val(`${obj.cep}`);

            }
        });
    }
    $('#salvar').hide();
    $('#searchUser').hide();
    $('#editUser').show();
    $('#deleteUser').show();
   
}

const executaDeleteCliente = (idcliente, idendereco) => {
    //debugger
       $.ajax({
            url: '/Clientes/DeleteCliente',
            method: 'POST',
            data: {
                Id: idcliente
            },
            success: (response) => {
                retorno = response;
                executaDeleteEndereco(idendereco,retorno)
            }
        });
}

const executaDeleteEndereco = (idendereco, retorno) => {
    //debugger
    $.ajax({
        url: '/Endereco/DeleteEndereco',
        method: 'POST',
        data: {
            Id: idendereco
        },
        success: (response) => {
            retorno = response;
            alert(retorno);
            window.close('/Clientes/Create');
        }

    });
}