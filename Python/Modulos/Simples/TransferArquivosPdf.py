import os
import shutil

Caminho1 = input("Cole aqui o caminho raiz")
Caminho2 = input("Cole aqui o caminho destino")

for root, dirs, files in os.walk(Caminho1):
    for file in files:
        if '.pdf' in file:
           OldPath = os.path.join(root, file)
           NewPath = os.path.join(Caminho2, file)
           shutil.move(OldPath, NewPath)