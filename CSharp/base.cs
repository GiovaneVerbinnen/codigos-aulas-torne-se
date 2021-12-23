<!DOCTYPE html>
<html lang="pt-BR">

<head>
  <meta charset="UTF-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
  <link rel="stylesheet" href="../highlight/styles/monokai-sublime.min.css" />
  <script src="../highlight/highlight.min.js"></script>
  <script>
    hljs.initHighlightingOnLoad();
  </script>

  <title>Forms</title>
</head>

<body>
  <section class="container">
    <div class="my-5">
      <!-- Aula Teórica -->

      <h2>Ruby on Rails - Forms</h2>
      <p>Recapitulando: Criamos um Controller que passa os dados para o Model, aprendemos como criar manualmente e com o
        <code>rails generate</code>, e retornava na View fazendo a rederização.
      </p>
      <p>O objetivo desta aula é criar um formulário onde possamos enviar dados até nossa aplicação e registrando em
        nossa base de dados.</p>
      <p>Material de apoio:
        <a href="https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status">Documentação de códigos HTTP (MDN Web
          Docs)</a>
      </p>
    </div>
    <!-- Aula Prática -->
    <div>
      <h3>Aula Prática</h3>
      <hr>
      <p>Hoje iremos incluir uma página de cadastros.</p>
      <p>Então dentro de <code>views/layouts/_header.html.erb</code> faça:</p>
      <pre class="m-0">
      <code class="language-html rounded">
      <a href="/produtos">Produtos</a>
      </code>
      </pre>
      <p>Agora em nosso menu temos um link para a rota <code>/produtos</code>, mas não temos ela criada ainda, então no
        arquivo <code>routes.rb</code> adicionamos:</p>
      <pre class="m-0">
      <code class="language-C# rounded">
      get "/produtos", to: "produtos#index"
      </code>
      </pre>
      <p>Ainda não criamos o controller de produtos, como já vimos anteriormente devemos criar um arquivo
        <code>produtos_controller.rb</code> na pasta de controllers, um arquivo em branco não vai retornar nada, então
        vamos copiar o conteúdo de <code>home_controller.rb</code> algo assim:
      </p>
      <pre class="m-0">
      <code class="language-C#  rounded">
      class ProdutosController < ApplicationController
        def index
        end
      end
      </code>
      </pre>
      <p>Pronto! Nossa rota chama um controller que tem um método index, e nós temos um médodo index no arquivo do
        controller, mas o Rails vai procurar um view com nome index e isso ainda não temos, por convenção o Rails
        procura pelo nome que colocamos no controller, neste caso produtos, então criremos um diretório produtos e dentro a view index, devemos criar como: <code>views\produtos\index.html.erb</code>.
      </p>
      <br>
      <!-- FIM -->
  </section>
  <script type="text/javascript">
    /* 
     * Script para "escapar" html dentro das tags code para não ser interpretado como HTML em si 
     */
    function formataCodigoHtml() {
      document.querySelectorAll("code.language-html").forEach(function(element) {
        element.innerHTML = element.innerHTML.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g,
          "&gt;").replace(/"/g, "&quot;").replace(/'/g, "&#039;");
      });
    }
    formataCodigoHtml();
  </script>
</body>

</html>