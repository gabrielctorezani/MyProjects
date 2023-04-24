from io import StringIO as IO

mensagem = 'Gabriel Correia Torezani freitas'
arquivo = IO(mensagem)
print(arquivo.read())