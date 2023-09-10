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


<p align="center">
<img align="center" src = "https://user-images.githubusercontent.com/99992149/230115916-9f3e7ad6-e2f1-47cd-84b8-25514d7d6a2a.png" width="100px" heigth="100px"/>
</p>


# Diagramas:

## DER
![MER](https://github.com/GustavoPisanello/API_SpreadBible/assets/101807287/0a6fbdce-9bdb-44f4-8998-de5db1dbb828)

## MER
![DER](https://github.com/GustavoPisanello/API_SpreadBible/assets/101807287/64af7c4d-ddb7-4668-aec3-587a6e21b016)

## Diagrama de Classe
![Diagrama de Classe (1)](https://github.com/GustavoPisanello/API_SpreadBible/assets/101807287/d0d69c1b-9eb6-46da-8f10-d5a5aecc9d47)







