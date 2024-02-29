# Introducao Backend

## Protocolo Http

## Principais verbos

- `GET`: pegar alguma recurso

exemplo: `GET www.api.imatech.com/alunos`

exemplo: `GET www.google.com/q="bolo+de+cenoura"`

- `POST`: cadastrar/enviar alguma recurso

exemplo:

`POST www.api.imatech.com/alunos/cadastrar`

body:

```json
{
  "nome": "Joao da Silva",
  "turma": "SharpCoders 2"
}
```

- `PUT`: atualizacao total

`PUT www.api.imatech.com/alunos/atualizar/2`

```json
{
  "nome": "Pedro da Silva",
  "turma": "SharpCoders 2"
}
```

- `DELETE`: delecao do recurso

`DELETE www.api.imatech.com/alunos/deletar/1`

### Http status code

## Arquiteturas de software

### MVC

Model: modelagem do dominio/assunto.
View: constroi um codigo HTML/CSS/JS para ser enviado.
Controller: gerenciador de requisicoes

## Nomes

Rest API: abstracao de um servico, recebo pedidos, envio respostas e nao crio vinculo com a maneira que estes dados serao utilizados.

Restful API: mesma coisa da Rest API seguindo boas praticas

Http protocol: protocolo principal que usaremos nas mensagens enviadas

Endpoint: endpoint é o nome de cada recurso oferecido pelo nosso backend
