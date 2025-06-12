document.querySelector('#formulario').addEventListener('submit', function(event) {
    // seleciona os campos de senha e confirmar senha
    const senha = document.querySelector('#senha').value;
    const confirmacaoSenha = document.querySelector('#confirmacaoSenha').value;

    if (senha !== confirmacaoSenha)
    {
        // impede o envio do formulário
        event.preventDefault();
        // exibe uma mensagem de erro
        alert('As senhas não coincidem. Por favor, tente novamente.');
    } 
    else {
                // exibe uma mensagem de sucesso
                alert('Formulário enviado com sucesso! :D');
    }
});
