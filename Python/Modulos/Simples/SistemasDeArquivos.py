import os 
import sys

"""""
print(os.getcwd())

os.chdir('..')

print(os.getcwd())

os.chdir('Simples')

print(os.getcwd())

print(os.path.isabs('C:\\Users\\gabri\\OneDrive - ynzws\\Languages\\Python\\Simples'))

print(os.name)

print(sys.platform)
"""""
###################
"""""
caminho = os.getcwd()
cam = os.path.join('C:\\Users\\gabri\\OneDrive\\Documentos Gabriel')
length = list(os.scandir(cam))
for i in range(len(length)):
    print('Numero',i)
    print(length[i].name)
    print(length[i].path)
    print(length[i].inode())
    print(length[i].is_dir())
    print(length[i].is_file())
    print(length[i].is_symlink())
    print(length[i].stat())
"""""

print(os.path.exists('texto.txt'))

open('arquivo.txt', 'w').close()
open('arquivo2.txt', 'a').close()
with open('arquivo3.txt', 'w') as arquivo:
    pass

os.mkmod()