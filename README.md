# Hello World Idempotente – C# / .NET

Este projeto é um **exemplo simples e conceitual** para demonstrar o **conceito de idempotência** usando **C#/.NET**.

A ideia é mostrar como uma operação pode ser executada várias vezes sem causar efeitos colaterais adicionais, garantindo que o resultado final seja sempre o mesmo.

---

## 📌 O que é Idempotência?

Idempotência é uma propriedade de uma operação que garante que:

> Executar a mesma ação uma ou mais vezes produz o mesmo resultado final.

Em sistemas distribuídos, APIs e processamento de mensagens, isso é essencial para evitar:
- Duplicação de dados
- Processamentos repetidos
- Efeitos colaterais indesejados

---

## 🎯 Objetivo do Projeto

Criar um **"Hello World" idempotente**, onde:

- Na **primeira execução**, a mensagem `Hello World` é exibida
- Nas **execuções seguintes**, a aplicação identifica que a ação já foi realizada e não repete o efeito

---

## 🧠 Conceito Aplicado

Este projeto utiliza:

- Uma **chave de idempotência** (`idempotencyKey`)
- Um **estado persistido em arquivo**
- Uma verificação antes de executar a ação principal

Fluxo simplificado:

1. Verifica se a ação já foi executada
2. Se **não foi**, executa o `Hello World`
3. Marca a ação como executada
4. Se **já foi**, não executa novamente

---

## 🛠️ Tecnologias Utilizadas

- .NET (Console Application)
- C#
- Sistema de arquivos para persistência simples

---

## ▶️ Como Executar

1. Clone o repositório
2. Execute o projeto via terminal ou IDE
3. Observe o comportamento:
   - Primeira execução → imprime `Hello World`
   - Próximas execuções → informa que já foi executado

---

## 📂 Estrutura do Projeto

```text
├── Program.cs
└── idempotency.txt  (criado automaticamente após a primeira execução)
```