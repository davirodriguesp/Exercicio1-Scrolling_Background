# 🚀 Exercício 1: Scrolling Background (Unity 2D)

Um script simples e otimizado para criar o efeito de rolagem de cenário (scrolling background) em jogos 2D na Unity. Desenvolvido para um projeto de nave estilo Arcade com movimentação vertical.

## 🎮 Demonstração Visual

<!-- Substitua o link abaixo pelo link do seu GIF após fazer o upload -->
https://github.com/user-attachments/assets/70c3b14d-7605-4cf5-9f92-30cc18d86d90

## 🛠️ Tecnologias Utilizadas
* **Engine:** Unity 2D
* **Linguagem:** C# e integração com a API do Unity
* **IDE:** JetBrains Rider

## ⚙️ Como funciona
O script `ScrollBackground.cs` acessa o componente `SpriteRenderer` (ou `MeshRenderer`) do objeto e manipula o offset da textura do material (`mainTextureOffset`) em tempo real no eixo Y, utilizando `Time.deltaTime` para garantir fluidez independente do framerate. Isso cria a ilusão de que a nave está avançando pelo espaço.

## 🚀 Como testar no seu projeto
1. Adicione a sua imagem de background na Unity.
2. Nas configurações da imagem (Inspector), mude o **Wrap Mode** para **Repeat**.
3. Crie um Material novo utilizando um shader compatível (ex: `Unlit/Transparent`) e aplique a imagem a ele.
4. Anexe o script `ScrollBackground.cs` ao seu objeto de fundo.
5. Ajuste a variável `velocidade` no Inspector.
