import PySimpleGUI as sg
from cotacao import pegar_cotacoes

layout = [[sg.Text("Teste 1")],
          [sg.InputText(key="nome_cotacao")],
          [sg.Button("Pegar cotação"), sg.Button("Cancelar")],
          [sg.Text("", key="texto_cotacao")]]


janela = sg.Window("Titulo", layout)

while True:
    evento, valores = janela.read()
    if evento == sg.WIN_CLOSED:
        break
    if evento == "Pegar cotação":
        codigo_cotacao = valores["nome_cotacao"]
        cotacao = pegar_cotacoes(codigo_cotacao)
        janela["texto_cotacao"].update(f"{codigo_cotacao} = {cotacao}")

janela.close()