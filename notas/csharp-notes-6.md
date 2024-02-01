# POO de um jeito pratico

## null assertion

o operador `null!` ou usar `!` para evitar warnings(avisos) de nulo, nao garante que o conteudo nao vira nulo, apenas indica que voce esta se responsabilizando que o conteudo nao sera nulo.

```cs
public class User
{
   public int Id { get; set; }
   public string Email { get; set; } = null!;
   public string Username { get; set; }
   public string? Nickname {get; set;} = null;
   public string Password { get; set; }
}
```

## struct

Uma estrutura de dados que precede a criação a POO.

```cs
struct Pessoa {
   string Nome;
   int Idade;
   double Altura;
   string NumeroDeTelefone;
}

public class Program {
   public static void Main() {

      Pessoa pessoa;
   }
}
```

## Composição

usernamesOfUsers
emailsOfUsers
passwordsOfUsers

```js
const user = {
   email: "email@gmail.com",
   password: "password123",
   address: {
      street: "Rua X",
      city: "Cidade Y",
      number: "123a",
      country: "Brasil"
   },
   posts: [
      {
         content: "Treta renato cariani",
         likes: 400
      },
      {
         content: "BBB 2024",
         likes: 200
      }
   ]
}

user.posts.push({
   // meu post aqui
})
```

```ts
export interface Address {
   street: string
   city: string
   number: string
   country: string
}

export interface Post {
   id: number
   content: string
   likes: number
}

export interface User {
   email: string
   password: string
   level: 'basic' | 'blue' | 'gold' | 'emerald'
   address: Address
   posts: Post[]
}

export interface Report {
   category: 'spam' | 'fake news'
   postId: number
}

const myUser = {
   level: 
}
```

## Relacionamentos

### 1. Relacionamento tem-um

> O arqueiro possui um arco

```cs
public class Arco {
   public string Nome {get; set;}
   public int NumeroDeFlechas {get; set;}
   public double Forca {get; set;}

   public void Atirar() {
      NumeroDeFlechas--;
      Console.WriteLine("atirei");
   }
}

public class Arqueiro {
   public double Forca {get; set;}
   public Arco ArcoPrincipal {get; set;}
   public Arco ArcoSecundario {get; set;}
}

Arqueiro arq = new Arqueiro();

arq.ArcoPrincipal.Atirar();
```

## 2. Relacionamento tem-varios

```cs
public class Flecha() {
   public string Dano {get; set;}
   public string Efeito {get; set;}
}

public class Arco {
   public string Nome {get; set;}
   public double Forca {get; set;}
   public List<Flecha> Flechas {get; set;}
}

public class Arqueiro {
   public double Forca {get; set;}
   public Arco Arco {get; set;}
}
```

### 3. Consequencias

- um pra um = tem-um + tem-um
- um pra muitos ou muitos pra um = tem-um + tem-varios
- um pra muitos ou muitos pra um = tem-varios + tem-um
- muitos pra muitos = tem-varios + tem-varios

## Diagramas

### 1. Diagrama UML

Diagrama UML é usado normalmente para descrever relacionamentos(composições e heranças) em Orientação a Objetos

Normalmente:

- A classe vai no topo de cada caixa
- Os atributos vao no meio
- Os metodos vao no fim
- Nao colocamos construtores, ToString e metodos pre-prontos
- Se tiver em italico, é classe abstrata
- 0..1 = indica que pode ter nenhum ou um
- 0..* = indica que pode ter nenhum ou muitos
- 1..* = indica que pode ter 1 ou muitos

### 2. Diagrama ER - Entidade Relacional

Este diagrama é focado em descrever as tabelas do banco de dados e os relacionamentos entre elas (chaves estrageiras e tabelas de normalização)

### 3. Diagrama de Use-Case

Este diagrama foca na parte operacional da solução, isto é, descrever o inicio de um uso até o seu fim, incluindo todas as possibilidades do usuário durante este caminho.

Caso de uso:

> O usuário faz login e o sistema valida, depois o usuário acessa

Variante:

> Um usuário não cadastrado vai ao login, cria uma conta, o sistema registra, envia email, ele valida o email, a conta é ativada e depois o usuário acessa a conta.
