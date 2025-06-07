class Contato {

    // Método Construtor
    constructor(){
        this.name = null;
        this.email = null;
        this.tel = null;
        this.message = null;
        this.dt_cad = null;
        this.age = null;
        this.tel_tip = null;
    }

    //Método específicio da classe Contato
    Enviar(event){
        event.preventDefault(); // impedir uso padrao do form
        this.name = document.getElementById('name').value;
        this.email = document.getElementById('email').value;
        this.tel = document.getElementById('tel').value;
        this.message = document.getElementById('message').value;
        this.dt_cad = document.getElementById('dt_cad').value;
        this.subj_tip = document.getElementById('subj_tip').value;
        let name = '';
        let email = '';
        let tel = '';
        let message = '';
        let dt_cad = '';
        let age = '';
        let tel_tip = '';

        if (user === year) {
            alert(this.name + 'Dado inválido!')
        }

        alert(alerted + ' de ' + this.name + ' em ' + year)

     // Verificar se o nome é um número
    if (/^\d+$/.test(this.name)) {
        erros += 'O nome não pode ser exclusivamente numérico. \n'
    }
    }
}

contato = new Contato();

// function Enviar(){

//     let user = 'Bernardo';
//     const alerted = 'Você está na página de contato'
//     let year = '2025';

//     if (user === year) {
//         alert(this.name + 'Dado inválido!')
//     }

//     alert(alerted + ' de ' + this.name + ' em ' + year)
// }