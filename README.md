# PeopleManagerWebApi

# Um Api simples de gerenciamento de funcionários. Em qualquer ação(requisição, resposta) que o nosso cliente fizer, será retornado um objeto em formato Json.

# Segue o passo a passo de como manusear esta API:

# Primeiro iremos precisar de um cliente, neste sistema usamos o Postman da Google que é bem prático. Depois iremos abrir o projeto usando o Visual Studio da Microsoft:
# 1 - Execute a aplicação no botão superior (Start) em modo Debug utilizando o navegador de sua preferencia (usamos o Google Chrome)
# 2 - Abra o Postman (Client)

# Aqui iremos fazer ações do tipo POST e GET pois esta aplicação é do tipo CRUD assim poderemos criar, Ler, atualizar e excluir dados da nossa API!

# Iremos começar Listando os produtos:
# 1 - Com aplicação rodando, abra o Postman você ira notar na parte superior um botão que nos permitirá fazer várias ações. Para esta ação iremos fazer uma requisição, assim iremos colocar do tipo GET (Se for a primeira vez que você utiliza o Postman já deve esta como padrão)
# 2 - No parâmetro da URL iremos digitar da seguinte forma:
Com a nossa aplicação rodando, o navegador estará aberto com um determinado endereço de URL, Examplo: http://localhost<Porta>
  Copie esta Url e cole no parametro do tipo GET no Postman, em seguida acrescente /funcionarios/list, ficara assim:
  http://localhost<Porta>/funcionarios/list
  Dê um Enter e espere a reposta. Pronto! Note que no corpo da resposta será retornado uma lista de objeto em formato Json object
  
  # Listando por ID
# 1 - No parâmetro da URL iremos digitar da seguinte forma:
Use a mesma url que esta no Post man, só iremos fazer o seguinte
 Troque /funcionarios/list, para /funcionarios/list/(aqui você irá passar o id),  ficara assim:
  http://localhost<Porta>/funcionarios/list/2
  Dê um Enter e espere a reposta. Pronto! Note que no corpo da resposta será retornado apenas um objeto formato Json object
