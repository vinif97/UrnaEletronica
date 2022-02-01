<h1 style="font-weight: bold">Urna Eletrônica</h1>
<h3>O projeto foi desenvolvido utilizando .NET 5.0 (Back-End), Angular 13 (Front-End) e MySQL (Banco de dados).</h3>
<br>
<hr>
<h2 style="font-weight: bold">Back-End</h2>
A persistência dos dados foi realizada através do banco de dados MySQL, que encontra-se hospedado na plataforma de nuvem <a href="https://dashboard.heroku.com/apps">Heroku</a>. Por estar hospedado em um servidor nos Estados Unidos, haverá um intervalo de 1-3 segundos para a API processar requisições realizadas pelo front-end.
<br><br>
O Acesso da API é dado em <a http: href="http://localhost:5000">http://localhost:5000</a>(sem swagger) e <a href="http://localhost:5000/swagger/index.html"> http://localhost:5000/swagger/index.html</a>(com swagger).<br><br>
<p style="font-weight: bold">O front-end está ajustado para receber requisições rodando dessa porta, portanto o projeto não deve ser rodado usando o "IIS Express", mas sim o "UrnaEletronica" ou dotnet run (terminal do visual code studio)</p>

<br>
A API possui os seguintes endpoint, para a realização das requisições:
<ol>
    <li>api/candidate [POST]</li>
    Registra os candidatos no banco de dados, recebendo um arquivo JSON com as seguintes informações:<br>
    {<br>
        "fullName": "Nome Completo do Candidato",<br>
        "viceName": "Nome do Vice",<br>
        "label": Legenda<br>
    }
    <li>api/candidate [DELETE]</li>
    Delete os candidatos no banco de dados, recebendo um arquivo JSON com as seguintes informações: <br>
    {<br>
        "label": Legenda<br>
    }
    <li>api/vote [POST]</li>
    Registra os votos referentes a cada candidato no banco de dados, recebendo um arquivo JSON com as seguintes informalções: <br>
    {<br>
        "label": Legenda
    }
    <li>api/votes [GET]</li>
    Retorn um JSON com a lista de todos os candidatos e seus respectivos votos recebidos
</ol>
<br>
<h4 style="font-weight: bold">Os votos brancos e nulos estão registrados com legendas 100 e 101, respectivamente o endpoint api/candidate [DELETE] não permite a exclusão desses, é necessário esse registro para tratamento dos dados.</h4>
<hr>
<h2 style="font-weight: bold">Front-End</h2>
O front possui 3 telas, são elas:
<ol>
    <li style="font-weight: bold">Tela de votação</li>
    Aqui é possível inserir votos em branco, nulo (caso seja digitado qualquer valor o qual não exista um candidato no banco de dados referente a ele.) e para um candidato desejado.
    <li style="font-weight: bold">Tela de Candidatura</li>
    Aqui é possível inserir candidatos no banco de dados, que estarão concorrendo as eleições.
    <li style="font-weight: bold">Tela de Resultados</li>
    Aqui podemos ver os resultados da eleições em ordem decrescente, com os votos nulos e brancos contabilizados a direita.
</ol>

