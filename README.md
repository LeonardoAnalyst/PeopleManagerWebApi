# PeopleManagerWebApi

# Um Api simples de gerenciamento de funcionários. Em qualquer ação(requisição, resposta) que o nosso cliente fizer, será retornado um objeto em formato Json.

# Segue o passo a passo de como manusear esta API:

# Primeiro iremos precisar de um cliente, neste sistema usamos o Postman da Google que é bem prático. Depois iremos abrir o projeto usando o Visual Studio da Microsoft:
# 1 - Execute a aplicação no botão superior (Start) em modo Debug utilizando o navegador de sua preferencia (usamos o Google Chrome)
# 2 - Abra o Postman (Client)

# Aqui iremos fazer ações  POST e GET pois esta aplicação é do tipo CRUD assim poderemos criar, Ler, atualizar e excluir dados da nossa API!

# Iremos começar Listando os produtos:
# 1 - Com aplicação rodando, abra o Postman, você ira notar na parte superior um botão que nos permitirá fazer várias ações. Para esta ação iremos fazer uma requisição, assim iremos colocar do tipo GET (Se for a primeira vez que você utiliza o Postman já deve esta como padrão)
# 2 - No parâmetro da URL iremos digitar da seguinte forma:
# Com a nossa aplicação rodando, o navegador estará aberto com um determinado endereço de URL, Examplo: http://localhost<Porta>
 # Copie esta Url e cole no parametro do tipo GET no Postman, em seguida acrescente /funcionarios/list, ficara assim:
 # http://localhost<Porta>/funcionarios/list
 # Dê um Enter e espere a reposta. Pronto! Note que no corpo da resposta será retornado uma lista de todos os objetos de registro existentes em formato Json object
  
  # Listando por ID
# Utilize a mesma url que esta no Postman, só iremos fazer as seguintes alterações:
 # Troque /funcionarios/list, para /funcionarios/show/(aqui você irá passar o id),  ficara assim:
 # http://localhost<Porta>/funcionarios/show/2
 # Dê um Enter e espere a reposta. Pronto! Note que no corpo da resposta será retornado baseado na pesquisa por id apenas um objeto formato Json object
  
   # Criando um novo registro
# Utilize a mesma url que esta no Post man, só iremos fazer as seguintes alterações:
# Troque a ação para o tipo POST e selecione Body logo abaixo
 # Troque /funcionarios/show, para /funcionarios/create,  ficara assim:
 # http://localhost<Porta>/funcionarios/create
 # Para facilitar a criação, copie um ojeto Json retornado pelo metodo list e cole no Body e altere todos os campos (id, nome, endereco, etc)
 # Dê um Enter e espere a reposta. Pronto! Note que no Header ou authorization a resposta irá nos retornar o novo registro em um objeto em formato Json object
  
  # Apagando por ID
# Utilize a mesma url que esta no Post man, só iremos fazer as seguintes alterações:
# Troque a ação para o tipo DELETE
 # Troque /funcionarios/create, para /funcionarios/delete/(aqui você irá passar o id),  ficara assim:
 # http://localhost<Porta>/funcionarios/delete/3
  # Dê um Enter e espere a reposta. Pronto! Note que no Header ou authorization a resposta irá nos retornar baseado na pesquisa por id  o registro que foi apagado em um objeto formato Json object
  
  
   # Atualizando por ID
# Utilize a mesma url que esta no Post man, só iremos fazer as seguintes alterações:
# Troque a ação para o tipo POST e selecione Body logo abaixo
# Troque /funcionarios/delete/, para /funcionarios/update/(aqui você irá passar o id),  ficara assim:
# http://localhost<Porta>/funcionarios/update/id
# Para facilitar a atualização, copie um ojeto Json retornado pelo metodo list e cole no Body e altere  os campos almejados (nome, endereco, etc)
 # Dê um Enter e espere a reposta. Pronto! Note que no Header ou authorization a resposta irá nos retornar baseado na pesquisa por id o registro que foi atualizado em um objeto formato Json object
  
  # Espero que tenham conseguido fazer o uso da aplicação e tenham se interagido bastante. Qualquer dúvida estou a disposição, segue  abaixo contatos:
  # Instagram: @leozeradev / Email: codezeraoficial@gmail.com
  
  
