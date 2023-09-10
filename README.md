API desenvolvida para o app SpreadBible. Por Gustavo Laur Pisanello e Alexandre Mezack de Lima

<h1>Funcionamento e explicações</h1> 

<h2>Manipulação das Igrejas</h1>

<h3>Método AddChurch()</h3>
- Testando método AddChurch() que adiciona uma igreja <br>

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/85b46aa1-cb49-469e-8783-984e26c09c81)

Resultado positivo (código 200)
![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/8a262bab-5726-4024-8f06-46a443c87f94)

<h3>Método GetAllChurches</h3>
-Testando método GetAllChurches() que retorna todas as igrejas cadastradas

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/af885d5a-52d4-41f1-a49f-b1f68b2e5eac)

<h3>Método GetChurch()</h3>
- Testando método GetChurch() que retorna uma igreja apenas, baseado no ID informado

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/1339b74d-458f-486a-b3c5-1aadaee3308e)

<h3>Método UdpateChurch()</h3>
- Testando método UpdateChurch() que atualiza uma igreja pré-existente, baseado no ID informado (Aqui, mudei a UF de "SP" para "RJ")

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/04a886b1-02b0-4f26-8086-b02cea60b564)

Resultado Positivo (código 200)
![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/7bd315c8-6753-41f7-8a18-fc3bdccc8b28)

<h3>Método DeleteChurch()</h3>
- Testando método DeleteChurch() que deleta uma igreja pré-existente, baseado no ID informado

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/4923de0b-c98e-4745-b30f-3478ace22f6a)



<h2>Manipulação dos Usuários</h2>

<h3>Método AddUser()</h3>
- Testando método AddUser() que adiciona um usuário<br>

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/18222d70-685e-4657-9678-6214fda8fcd0)


<h3>Método GetAllUsers</h3>
-Testando método GetAllUsers() que retorna todos os usuários cadastrados

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/daeab8d1-719d-4f11-8b1f-462b5d06a919)


<h3>Método GetUser()</h3>
- Testando método GetUser() que retorna um usuário apenas, baseado no ID informado

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/bbeaa0b2-ee62-413e-ae6a-a63c613552ec)


<h3>Método UdpateUser()</h3>
- Testando método UpdateUser() que atualiza um usuário pré-existente, baseado no ID informado (Aqui, mudei a senha de "1234567" para "senhaanonima123")

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/0303f328-37a5-4daa-87c7-a5f9fcfd2189)


Resultado Positivo (código 200)
![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/1bd7c677-126f-4de6-a44a-93b4a792e3d6)


<h3>Método DeleteUser()</h3>
- Testando método DeleteUser() que deleta uma usuário pré-existente, baseado no ID informado

![image](https://github.com/GustavoPisanello/API_SpreadBible/assets/99992149/0abcd556-30ab-42c5-8c0d-863fb0ad0cbd)

Dados da API escolhida:

<p align="center">
<img align="center" src = "https://user-images.githubusercontent.com/99992149/230115916-9f3e7ad6-e2f1-47cd-84b8-25514d7d6a2a.png" width="100px" heigth="100px"/>
</p>

O app deve buscar os versículos da bíblia usando a API externa e salvar igrejas favoritas usando a API interna.

-  URL da documentação: https://github.com/marciovsena/abibliadigital/blob/master/DOCUMENTATION.md
-  URL de Acesso a API: https://www.abibliadigital.com.br/api/

- Métodos disponíveis / (endpoints) / Foi utilizado ou não (0 = não foi usado, 1 = foi usado).  Todos os métodos abaixo não requisitam autenticação, mas, se não possuir uma, são limitadas a 20 requisições por hora. Além disso, TODOS retornam strings e ints. <br> <br>
```Get Books (retorna a lista de 66 livros da bíblia) / GET https://www.abibliadigital.com.br/api/books - 1 ```<br>
```Get Book (retorna detalhes de um livro específico da bíblia) / GET https://www.abibliadigital.com.br/api/books/:abbrev - 1``` <br>
```Get Chapter (retorna todos o versos e detalhes de um capítulo) / GET https://www.abibliadigital.com.br/api/verses/:version/:abbrev/:chapter - 1```<br>
```Get Verse (retorna um verso de um capítulo) / GET https://www.abibliadigital.com.br/api/verses/:version/:abbrev/:chapter/:number - 1``` <br>
```Get Random Verse (retorna um verso aleatório de um capítulo aleatório) / GET https://www.abibliadigital.com.br/api/verses/:version/random - 1```<br>
```Get Random Verse Book (retorna um verso aleatório de um livro específico) / GET https://www.abibliadigital.com.br/api/verses/:version/:abbrev/random - 1 ```<br>
```Search by word (retorna versos com a palavra digitada como parâmetro) / POST https://www.abibliadigital.com.br/api/verses/search - 1```<br>
```Get Versions (retorna todas as versões da bíblia e o número de versos) / GET https://www.abibliadigital.com.br/api/versions - 1``` 

      
Exemplo 
~~~javascript
abbrev: {
pt: "js",
en: "js"
},
author: "Josué",
chapters: 24,
group: "Históricos",
name: "Josué",
testament: "VT"
} 
~~~

      - Create Users (cria um novo usuário) / POST https://www.abibliadigital.com.br/api/users (Dados para a criação de usuário: Nome, Email e Senha) - NÃO Precisa de autenticação - 0
      - Get User (retorna um usuário) / GET https://www.abibliadigital.com.br/api/users/:email - Precisa de autenticação - 0
      - Get User Stats (retorna as estatísticas do usuário) / GET https://www.abibliadigital.com.br/api/users/stats - Precisa de autenticação - 0
      - Update Token (retorna um token) / PUT https://www.abibliadigital.com.br/api/users/token - NÃO Precisa de autenticação - 0
      - Delete User (remove um usuário) / DELETE https://www.abibliadigital.com.br/api/users - Precisa de autenticação - 0
      - Resend User Password (Manda um email com a senha do usuário) / POST https://www.abibliadigital.com.br/api/users/password/:email - NÃO Precisa de autenticação - 0
      
Todos os métodos ABAIXO necessitam obrigatoriamente uma autenticação 

      - Get Requests (retorna as requisições num período) / GET https://www.abibliadigital.com.br/api/requests/:range (mês, semana, dia) - 0
      - Get Number Requisitions (retorna o número de requisições num período / GET https://www.abibliadigital.com.br/api/requests/amount/:range (mês, semana, dia) - 0

Sumário de Parâmetros de busca desta API:
```      - abbrev: abreviação do livro {Gênesis = Gn / Êxodo = Ex / Levítico = Lv / Números = Nm / Deuteronômio = Dt / Josué = Js / Samuel = Sm / Ruth = Rt / Jó = job / Salmos = sl / Mateus = mt / Isaías = Is / Jeremias = Jr / Judas = Jd, etc }
      - chapter: capítulo da bíblia
      - search: variável digitada pelo usuário como índice de busca
      - verses: verso da bíblia
      - version: versão da bíblia
      - number: número do versículo
```      
Exemplo de retorno de busca: https://www.abibliadigital.com.br/api/verses/nvi/sl/23

~~~javascript
book: {
abbrev: "sl",
name: "Salmos",
author: "David, Moisés, Salomão",
group: "Poéticos",
version: "nvi"
},
chapter: {
number: 23,
verses: 6
},
verses: [
{
number: 1,
text: "O Senhor é o meu pastor; de nada terei falta."
},
{
number: 2,
text: "Em verdes pastagens me faz repousar e me conduz a águas tranqüilas;"
},
{
number: 3,
text: "restaura-me o vigor. Guia-me nas veredas da justiça por amor do seu nome."
},
{
number: 4,
text: "Mesmo quando eu andar por um vale de trevas e morte, não temerei perigo algum, pois tu estás comigo; a tua vara e o teu cajado me protegem."
},
{
number: 5,
text: "Preparas um banquete para mim à vista dos meus inimigos. Tu me honras, ungindo a minha cabeça com óleo e fazendo transbordar o meu cálice."
},
{
number: 6,
text: "Sei que a bondade e a fidelidade me acompanharão todos os dias da minha vida, e voltarei à casa do Senhor enquanto eu viver."
}
]
}
~~~

Link do Vídeo Demonstrativo: https://drive.google.com/drive/folders/1S1dORh9bCkoIEQ7c57vSM_qCg5IMysMR?usp=drive_link

# Diagramas:

## MER
![MER](https://github.com/GustavoPisanello/API_SpreadBible/assets/101807287/c869b3ed-9f9a-4843-bf36-a0b424692681)

## DER
![DER](https://github.com/GustavoPisanello/API_SpreadBible/assets/101807287/64af7c4d-ddb7-4668-aec3-587a6e21b016)

## Diagrama de Classe
![Diagrama de Classe (1)](https://github.com/GustavoPisanello/API_SpreadBible/assets/101807287/d0d69c1b-9eb6-46da-8f10-d5a5aecc9d47)







