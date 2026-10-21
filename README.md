# BlazorPokeApi

Atividade da disciplina **Usabilidade, Desenvolvimento Web, Mobile e Jogos**, professor Daniel Henrique Matos de Paiva.

Projeto Blazor WebAssembly que consulta a [PokéAPI](https://pokeapi.co/) pelo nome de um Pokémon e exibe:
- Imagem oficial do Pokémon, obtida de `sprites.other["official-artwork"].front_default`;
- ID e nome;
- Altura em metros (API fornece decímetros);
- Peso em quilogramas (API fornece hectogramas).

## Como executar

1. Instale o SDK do .NET 10.
2. No terminal, dentro da pasta do projeto, execute `dotnet restore` e `dotnet run`.
3. Abra o endereço local indicado pelo terminal.
4. Pesquise por `pikachu` ou `ditto`.

O aplicativo precisa de acesso à internet para consultar a API e carregar as imagens.

**Repositório solicitado:** `blazor-pokeapi`.
